using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Address ad1 = new Address("245 main st, Colorado", "Usa");
        Order order = new Order();
        Console.WriteLine(ad1.getAddress());
        order.GetListProd();
        
        
        
        
    }
}