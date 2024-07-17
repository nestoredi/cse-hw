using System.Data.Common;
using System.Net.Mail;

public class Product
{
    private string _nameProd;
    private int _id;
    private double _price;
    private int _qty;
    private int _delivery;
    public Product(string nameProd,int id, double price,int qty,int delivery)
    {
         _nameProd = nameProd;
         _id = id;
         _price = price;
         _qty = qty;
         _delivery= delivery;

    }

    public string GetProd()
    {
        
        return $"{_nameProd} ..{_price}..{_qty}..subTotal $ {_price*_qty}...delivery ${_delivery} ";
    }
    public double getTotal()
    {
        double total = 0;
         total = total + _price * _qty +_delivery*_qty;
        return total;
    }
   

}