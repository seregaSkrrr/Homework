using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public string Brand { get; set; }
    public float Price { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(string brand, float price, string model, int year, string color)
    {
        Brand = brand;
        Price = price;
        Model = model;
        Year = year;
        Color = color;
    }
}