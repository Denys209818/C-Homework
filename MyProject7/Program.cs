using MyProject7.cargo;
using System;

namespace MyProject7
{
//    Задание 2.
//Разработать архитектуру классов иерархии товаров
//при разработке системы управления потоками товаров для
//дистрибьюторской компании.Прописать члены классов.
//Создать диаграммы взаимоотношений классов.
//Должны быть предусмотрены разные типы товаров,
//в том числе:
//• бытовая химия;
//• продукты питания.
//Предусмотреть классы управления потоком товаров
//(пришло, реализовано, списано, передано).
    class Program
    {
        static void Main()
        {
            Store store = new Store();
            Cart cart = new Cart();
            Fruits f = new Fruits("Apple", 1, (int)Prices.Fruits);
            Fish fish = new Fish("Fugu", 1, (int)Prices.Fish);

            Powder p = new Powder("Gala", (int)Prices.Powder);
            Detergent d = new Detergent("Ariel", (int)Prices.Detergent, 1);

            cart.AddToCartChemie(p);
            cart.AddToCartChemie(d);

            cart.AddToCartFood(f);
            cart.AddToCartFood(fish);


            store.AddToCart(cart);


            store.ShowAllCarts();
        }
    }
}
