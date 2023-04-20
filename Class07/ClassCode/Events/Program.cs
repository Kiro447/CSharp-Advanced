using Events;

User user = new User()
{
    Name = "Kiril",
    FavoriteProductType = ProductType.Cosmetics
};

Market market = new Market()
{
    Name = "Stokomak",
    ProductOnPromotion = ProductType.Fruit,
};

market.Subscribe(user.ReactOnPromotion);
market.SendPromotionInfo();
