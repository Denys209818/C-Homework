using MyProject6.Figures;
using System;

namespace MyProject6
{
    class Program
    {
//        Задание 1.
//Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
//Разработать классы-наследники: Треугольник, Квадрат,
//Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг,
//Эллипс.Реализовать конструкторы, которые однозначно
//определяют объекты данных классов.
//Реализовать класс «Составная Фигура», который
//может состоять из любого количества «Геометрических
//Фигур». Для данного класса определить метод нахождения
//площади фигуры.Создать диаграмму взаимоотношений
//классов.
        static void Main()
        {
            SostavnaFigura sf = new SostavnaFigura();
            Elips el1 = new Elips(3,5);
            Krug el2 = new Krug(3);
            Trapecia el3 = new Trapecia(3, 5, 2,2, 3);
            Priamokutnyk el4 = new Priamokutnyk(3, 5);
            Romb el5 = new Romb(3, 5);
            Kvadrat el6 = new Kvadrat(3);
            Trykutnyk el7 = new Trykutnyk(3, 5, 7);

            sf.AddFigura(el1);
            sf.AddFigura(el2);
            sf.AddFigura(el3);
            sf.AddFigura(el4);
            sf.AddFigura(el5);
            sf.AddFigura(el6);
            sf.AddFigura(el7);


            Console.WriteLine( sf.GetS());



        }
    }
}
