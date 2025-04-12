using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager_DBFirst.Globals
{
    public delegate void Notify(string actionType, string message, DateTime eventTime);
    
    public delegate void TactionHandler(Taction taction);
    public delegate void TactionUpdateHandler(Taction newTaction, Taction oldTaction);
    public delegate void ItemHandler(Item item);
    public delegate void ItemSubTypeHandler(ItemSubType itemSubType);
    public delegate void ItemGroupHandler(ItemGroup itemGroup);
    public delegate void ItemTopGroupHandler(ItemTopGroup itemTopGroup);
    public delegate void ShopHandler(Shop shop);
    public delegate void ShopGroupHandler(ShopGroup shopGroup);
    public delegate void ShopTypeHandler(ShopType shopType);

    public delegate void LoginHandler(UserProfile userProfile, UserLoginDetails loginDetails);
}
