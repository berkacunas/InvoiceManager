from datetime import datetime, date
from collections import namedtuple
import pymssql
from io import StringIO
import pandas as pd
import numpy as np

SQLSERVER_NAME = "PC-WINDOWS10"
SQL_SOURCE_SERVER_DB = "BankFunds"
SQLSERVER_DB = "Invoices"

HtmlSource = namedtuple('HtmlSource', ['id', 'Html', 'Dt'])

rename_columns_dict = {
    'Fon Kodu Fon Adı': 'Code Dt Title', 
    'Para Birimi': 'Currency', 
    'Birim Pay Fiyatı': 'UnitSharePrice', 
    'Risk Seviyesi': 'RiskLevel',
    'Günlük Getiri': 'DailyReturn', 
    'Aylık Getiri': 'MonthlyReturn', 
    '3 Aylık Getiri': 'ThreeMonthReturn', 
    'Yılbaşından': 'FromNewYear' 
}

def is_fundtype_exists(title: str) -> bool:
    
    conn = None
    is_exists = False
    try:    
        conn = pymssql.connect(server=SQLSERVER_NAME, database=SQLSERVER_DB)
        cursor = conn.cursor()
        
        sql = "SELECT COUNT(id) FROM BankFundType WHERE Title = %s"
        
        cursor.execute(sql, (title, ))
        row = cursor.fetchone()
        if row and row[0]:
            is_exists = int(row[0]) > 0
            
        conn.commit()
        cursor.close()
        
        return is_exists
    
    except Exception as error:
        raise Exception(f"{type(error)}: {error}")
    
    finally:
        if conn:
            conn.close()


def select_bankentitytype_id(title):
    
    conn = None
    id = -1
    
    try:    
        conn = pymssql.connect(server=SQLSERVER_NAME, database=SQLSERVER_DB)
        cursor = conn.cursor()
        
        sql = "SELECT id FROM BankEntityType WHERE Title = %s;"
        cursor.execute(sql, (title, ))
        row = cursor.fetchone()
    
        if row and row[0]:
            id = int(row[0])
            
        cursor.close()
        
        return id
    
    except Exception as error:
        raise Exception(f"{type(error)}: {error}")
    
    finally:
        if conn:
            conn.close()
            

def insert_bankfundtypes(fund_types_frame):

    bankfundtype_id = select_bankentitytype_id(u"Yatırım Fonu")
    
    conn = None
    try:    
        conn = pymssql.connect(server=SQLSERVER_NAME, database=SQLSERVER_DB)
        cursor = conn.cursor()
        
        sql = "INSERT INTO BankFundType(Title, EntityTypeId, Count) VALUES(%s, %s, %s)"
        
        for index, row in fund_types_frame.iterrows():
            cursor.execute(sql, (row.Code, bankfundtype_id, row.Count, ))
            print(f"BankFundType: {row.Code} added.")
                
        conn.commit()
        cursor.close()
    
    except Exception as error:
        raise Exception(f"{type(error)}: {error}")
    
    finally:
        if conn:
            conn.close()
            

def select_html_source_count() -> int:
    
    conn = None
    count = -1
    
    try:    
        conn = pymssql.connect(server=SQLSERVER_NAME, database=SQL_SOURCE_SERVER_DB)
        cursor = conn.cursor()
        
        sql = "SELECT COUNT(id) FROM HtmlSource"
        cursor.execute(sql)
        row = cursor.fetchone()
    
        if row and row[0]:
            count = int(row[0])
            
        cursor.close()
        
        return count
    
    except Exception as error:
        raise Exception(f"{type(error)}: {error}")
    
    finally:
        if conn:
            conn.close()

def select_html_sources(dt : date) -> list:
    ''' date format must be YYYY/MM/DD '''
    
    conn = None
    html_sources = None
    
    try:    
        conn = pymssql.connect(server=SQLSERVER_NAME, database=SQL_SOURCE_SERVER_DB)
        cursor = conn.cursor()
        
        sql = "SELECT id, Html, Dt FROM HtmlSource WHERE (SELECT CAST(Dt AS Date)) = %s"
        cursor.execute(sql, (dt, ))
        rows = cursor.fetchall()
    
        if rows:
            html_sources = []
            for row in rows:
                html_source = HtmlSource(row[0], clear_html(row[1]), row[2])
                html_sources.append(html_source)
            
        cursor.close()
        
        return html_sources
    
    except Exception as error:
        raise Exception(f"{type(error)}: {error}")
    
    finally:
        if conn:
            conn.close()
            

def clear_html(html: str) -> str:
    
    html = remove_unwanted_texts(html)
    html = replace_decimal_separator(html)
    
    return html

def remove_unwanted_texts(html: str) -> str:
    
    replace_substrings = ["<p>Yurt dışı piyasaların kapalı olduğu günlerde açıklanan fon fiyatı, piyasaların açık olduğu son gün hesaplanan değerleme fiyatıdır.</p>",
                          "<p>Günlük fiyat açıklamamakta olup, web sitesinde yer alan fiyatlar alım-satım günlerinde alım-satıma konu olan resmi fiyatlar, diğer günlerde ise referans fiyatlardır.</p>"
                         ]
    
    for replace_substring in replace_substrings: 
        pos = html.find(replace_substring)
        if pos != -1:
            html = html.replace(replace_substring, "")
            
    return html


def replace_decimal_separator(html) -> str:
    
    return html.replace(",", ".")

def rename_frame(frame: pd.DataFrame, rename_dict: dict, inplace=False):
    
    return frame.rename(columns=rename_dict, inplace=inplace)

def mask_frame(frame, condition, inplace=False):
    
    return frame.mask(condition, inplace=inplace)

def split_Code_Dt_Title_column(frame: pd.DataFrame, dt):
    
    temp_frame = frame["Code Dt Title"].str.split(" ", n=4, expand=True)
    frame["Code"] = temp_frame[0]
    frame["Dt"] = dt
    frame["Title"] = temp_frame[4]
    frame.drop(columns=["Code Dt Title"], inplace=True)
    
    return frame

def realign_frame(frame: pd.DataFrame):
    
    return frame.loc[:, ['Code', 'Dt', 'Title', 'Currency', 'UnitSharePrice', 'RiskLevel', 'DailyReturn', 'MonthlyReturn', 'ThreeMonthReturn', 'FromNewYear']]

def get_empty_row_indexes(frame: pd.DataFrame) -> list:
                
    np_idx_empty_rows = np.where(frame.loc[:, 'Title'].isnull())[0]
    indexes = list(np_idx_empty_rows.tolist())
    indexes.pop(0)
    
    return indexes

def create_framedict(frame, series, indexes) -> dict:

    frame_dict = {}
    start_index = 1
    for index in indexes:
        sub_frame = frame.iloc[start_index:index]
        key = series.iloc[len(frame_dict)].strip()
        frame_dict[key] = sub_frame
        start_index = index + 1
    
    sub_frame = frame.iloc[start_index:len(frame)]
    key = series.iloc[len(frame_dict)].strip()
    frame_dict[key] = sub_frame
    
    return frame_dict

def get_fund_types_frame(frame: pd.DataFrame) -> pd.DataFrame:
    
    temp_fund_types_frame = pd.DataFrame()
    fund_types_frame = frame.query("Title.isnull()", engine='python')
    temp_fund_types_frame["Code Count"] = fund_types_frame["Currency"]
    temp_fund_types_frame["Code"] = temp_fund_types_frame["Code Count"].str.split("(").str[0].astype(str)
    temp_fund_types_frame["Count"] = temp_fund_types_frame["Code Count"].str.split("(").str[1].str.split(")").str[0].astype(int)
    temp_fund_types_frame.drop(columns=["Code Count"], inplace=True)
    temp_fund_types_frame.reset_index(drop=True, inplace=True)
    
    return temp_fund_types_frame

def main():
    
        html_sources = select_html_sources(date.today())
        if not html_sources:
            return
        
        html_source = html_sources[0]

        m_frame = pd.read_html(StringIO(html_source.Html))[0]
        rename_frame(m_frame, rename_columns_dict, True)
        mask_frame(m_frame, m_frame == '', inplace=True)
        m_frame.dropna(axis=1, how='any', inplace=True)
        m_frame = split_Code_Dt_Title_column(m_frame, html_source.Dt)
        m_frame = realign_frame(m_frame)
                 
        indexes = get_empty_row_indexes(m_frame)
        fund_types_frame = get_fund_types_frame(m_frame)
        frame_dict = create_framedict(m_frame, fund_types_frame["Code"], indexes)
            
        try:
            insert_bankfundtypes(fund_types_frame)
            
        except Exception as error:
            print(error)
            


if __name__ == '__main__':
    main()