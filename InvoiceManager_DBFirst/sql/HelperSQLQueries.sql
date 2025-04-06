USE Invoices;

SELECT Taction.Dt, Item.Name, ItemSubType.Name FROM TactionDetails
JOIN Taction ON TactionDetails.TransactionId = Taction.id
JOIN Item ON TactionDetails.ItemId = Item.id
JOIN ItemSubTypeDetails ON TactionDetails.ItemId = ItemSubTypeDetails.ItemId
JOIN ItemSubType ON TactionDetails.ItemSubTypeId = ItemSubType.id
WHERE Item.Name = 'Hamidiye Kaynak Suyu' AND ItemSubType.Name = '5 litre' AND Taction.Dt BETWEEN '2025-03-01' AND '2025-04-06';
