using System;
public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
{
    _name = name;
    _productId = productId;
    _price = price;
    _quantity = quantity;
}

    public string ProductInfo()
    {
        string name = _name;
        string productId = _productId;
        string productInfo = $"{name} ({productId})";
        return productInfo;
    }


        public float CalculateTotalCost()
    {
        float totalCost = _price * _quantity;
        return totalCost;
    }

}