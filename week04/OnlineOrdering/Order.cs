using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float CalculateTotal()
    {
        float total = 0;
        int shippingFee;
        float actualTotal;
        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }
        if (_customer.IsInUSA())
        {
            shippingFee = 5;
        }
        else
        {
            shippingFee = 35;
        }
        actualTotal = total + shippingFee;
        return actualTotal;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        string products;
        foreach (Product product in _products)
        {
            products = product.ProductInfo();
            packingLabel = packingLabel + products + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shipping = "";
        shipping += _customer.Info() + _customer.Location();

        return shipping;
    }
}