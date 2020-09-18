using MyProject7.cargo;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject7
{
    public enum Status { New = 1, Ready, Del }

    public enum Prices { Fruits = 100, Fish = 200, Detergent = 50, Powder = 75 }
    class Store
    {
       private List<Cart> carts = new List<Cart>();

        public void AddToCart(Cart cart) 
        {
            carts.Add(cart);
        }

        public void RemoveFromCart(Cart cart)
        {
            carts.Remove(cart);
        }

        public void ShowAllCarts()
        {
          
            foreach (var item in carts)
            {
                if (item.status == 1)
                {
                    
                    Console.WriteLine("Cart:");
                    foreach (var itChemie in item.chemies)
                    {
                        Console.WriteLine(itChemie.title);
                      
                    }

                    foreach (var itFood in item.food)
                    {
                        Console.WriteLine(itFood.title);
                      
                    }
                    int num = 0;
                    Console.WriteLine("Enter status(2 - Ready, 3 - Delete):");
                    Console.Write("Status - ");
                    bool c = false;
                    while (!c)
                    {
                        try
                        {
                            while (num != 2 && num != 3)
                            {
                                num = int.Parse(Console.ReadLine());
                            }
                            c = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }

                    switch (num)
                    {
                        case 2:
                            {
                                item.status = 2;
                                break;
                            }
                        case 3:
                            {
                                item.status = 3;
                                break;
                            }
                    }

                }
            }

            foreach (var item in carts)
            {
                if (item.status == 2 || item.status == 3) 
                {
                    if (item.status == 2) 
                    {
                        int sum = 0;
                        foreach(var itChemie in item.chemies) 
                        {
                            sum += itChemie.GetPrice();
                        }
                        foreach (var itFood in item.food)
                        {
                            sum += itFood.GetPrice();
                        }
                        Console.WriteLine($"The order is fulfilled! Sum: {sum}");
                    }
                   
                }
            }

        }
    }
}
