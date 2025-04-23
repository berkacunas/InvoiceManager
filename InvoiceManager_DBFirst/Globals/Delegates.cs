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
    public delegate void ItemUpdateHandler(Item newitem, Item oldItem);
    public delegate void ItemSubTypeHandler(ItemSubType itemSubType);
    public delegate void ItemSubTypeUpdateHandler(ItemSubType newSubType, ItemSubType oldSubType);
    public delegate void ItemGroupHandler(ItemGroup itemGroup);
    public delegate void ItemGroupUpdateHandler(ItemGroup newItemGroup, ItemGroup oldItemGroup);
    public delegate void ItemTopGroupHandler(ItemTopGroup itemTopGroup);
    public delegate void ItemTopGroupUpdateHandler(ItemTopGroup newTopGroup, ItemTopGroup oldTopGroup);

    public delegate void ShopHandler(Shop shop);
    public delegate void ShopUpdateHandler(Shop newShop, Shop oldShop);

    public delegate void ShopGroupHandler(ShopGroup shopGroup);
    public delegate void ShopGroupUpdateHandler(ShopGroup newShopGroup, ShopGroup oldShopGroup);

    public delegate void ShopTypeHandler(ShopType shopType);
    public delegate void ShopTypeUpdateHandler(ShopType newShopType, ShopType oldShopType);

    public delegate void PaymentMethodHandler(PaymentMethod paymentMethod);
    public delegate void PaymentMethodUpdateHandler(PaymentMethod newPaymentMethod, PaymentMethod oldPaymentMethod);

    public delegate void BankCardHandler(BankCard bankCard);
    public delegate void BankCardUpdateHandler(BankCard newBankCard, BankCard oldBankCard);

    public delegate void UserHandler(User user);
    public delegate void UserUpdateHandler(User newUser, User oldUser);

    public delegate void SellerHandler(Seller seller);
    public delegate void SellerUpdateHandler(Seller newSeller, Seller oldSeller);


    public delegate void LoginHandler(UserProfile userProfile, UserLoginDetails loginDetails);
}
