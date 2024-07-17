using System.Security.Cryptography.X509Certificates;
using System;
public class Order
{
    List<Product> products = new List<Product>();
    Product product1 =new Product("pc",1,458.25,1,5);
    Product product2 =new Product("printer",2,78.23,2,5);
    Product product3 =new Product("disk",3,98,4,5);
    

    public Order()
    {
      products = new List<Product>();
      products.Add(product1);  
      products.Add(product2);  
      products.Add(product3);  
    }
    public void GetListProd()
    {
        double total = 0;
        foreach (Product p in products)
        {
           
           total = total + p.getTotal();
           Console.WriteLine(p.GetProd()) ;
           Console.WriteLine($" Total :{total}");
        }
    }
    public void GetTotal()
    {
      double total = 0;
        foreach (Product p in products)
        {
           
           total = total + p.getTotal();
           
          

        }

    }
}