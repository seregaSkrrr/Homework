using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("\n\n===============================================");
            Console.WriteLine("Enter the task:\n1 - 1\n2 - 2\n3 - 3\nOther keys - end program");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Queue<Spell> spellQueue = new Queue<Spell>();

                    spellQueue.Enqueue(new HealSpell("Anapneo", 5, 10));
                    spellQueue.Enqueue(new DamageSpell("Confringo", 15, 25));
                    spellQueue.Enqueue(new HealSpell("Episkei", 10, 25));
                    spellQueue.Enqueue(new DamageSpell("Sectumsempra", 40, 70));
                    spellQueue.Enqueue(new HealSpell("Vulnera sanentur", 40, 50));
                    spellQueue.Enqueue(new DamageSpell("Avada Kedavra", 100, 100));

                    while (spellQueue.Count > 0)
                    {
                        Spell spell = spellQueue.Dequeue();
                        spell.Cast();
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    string[] names = { "Хоббит", "И никого не стало", "Гарри Поттер и философский камень", "Маленький принц", "Властелин колец", "Повесть о двух городах", "Дон Кихот", "Цитаты председателя Мао Цзэдуна", "Коран", "Библия" };
                    string[] authors = { "Джон Рональд Руэл Толкин", "Агата Кристи", "Джоан Роулинг", "Антуан де Сент-Экзюпери", "Джон Рональд Руэл Толкин", "Чарльз Диккенс", "Мигель де Сервантес", "Мао Цзэдун", "Мир", "Мир" };
                    int[] years = { 1937, 1939, 1997, 1943, 1954, 1859, 1605, 1964, 610, 2 };
                    Stack<Book> bookStack = new Stack<Book>();

                    Random rand = new Random();
                    for (int i = 0; i < rand.Next(5, 11); i++)
                    {
                        bookStack.Push(new Book(names[i], authors[i], years[i]));
                    }

                    Console.WriteLine("First book in the stack:");
                    Book firstBook = bookStack.Pop();
                    Console.WriteLine($"Title: {firstBook.Title}, Author: {firstBook.Author}, Year: {firstBook.Year}");
                    break;
                case 3:
                    Random random = new Random();
                    Dictionary<string, List<Car>> carsByBrand = new Dictionary<string, List<Car>>();

                    string[] brands = { "Toyota", "Ford", "Honda" };
                    for (int i = 0; i < random.Next(5, 11); i++)
                    {
                        string brand = brands[random.Next(0, 3)];
                        Car car = new Car(brand, (float)random.Next(10000, 50000), $"Model {random.Next(1, 10)}", random.Next(2000, 2022), $"Color {random.Next(1, 10)}");

                        if (!carsByBrand.ContainsKey(brand))
                        {
                            carsByBrand.Add(brand, new List<Car>());
                        }
                        carsByBrand[brand].Add(car);
                    }

                    foreach (var brand in carsByBrand.Keys)
                    {
                        Console.WriteLine($"Cars of brand {brand}:");
                        foreach (var car in carsByBrand[brand])
                        {
                            Console.WriteLine($"  {car.Model} - {car.Price}$");
                        }
                    }

                    Console.Write("Enter brand: ");
                    string userBrand = Console.ReadLine();
                    if (carsByBrand.ContainsKey(userBrand))
                    {
                        Console.WriteLine($"Cars of brand {userBrand}: {carsByBrand[userBrand].Count}");
                        float totalprice = 0;
                        foreach (var car in carsByBrand[userBrand])
                        {
                            totalprice += car.Price;
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Total price: {totalprice}$");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("No cars of this brand");
                    }
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}