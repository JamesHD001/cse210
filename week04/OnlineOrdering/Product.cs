using System;
public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public string ProductInfo()
    {
        string name = _name;
        string productId = _productId;
        float price = _price;
        int quantity = _quantity;
        string productInfo = $"{name}{productId}";
        return productInfo;
    }

        public float CalculateTotalCost()
    {
        float price = _price;
        int quantity = _quantity;
        float totalCost= price * quantity;
        return totalCost;
    }

}