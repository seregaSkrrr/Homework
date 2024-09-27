#pragma once
#include "Libraries.h"
struct Car {
    double Length;
    double Clearance;
    double Engine_Volume;
    double Engine_Power;
    double Wheel_Diameter;
    string Color;
    string Transmission_Type;
};

void setCar(Car& car, double length, double clearance, double engineVolume, double enginePower, double wheelDiameter, string color, string transmissionType) {
    car.Length = length;
    car.Clearance = clearance;
    car.Engine_Volume = engineVolume;
    car.Engine_Power = enginePower;
    car.Wheel_Diameter = wheelDiameter;
    car.Color = color;
    car.Transmission_Type = transmissionType;
}

void display(const Car& car) {
    cout << "Length: " << car.Length << " metres" << endl;
    cout << "Clearance: " << car.Clearance << " metres" << endl;
    cout << "Engine volume: " << car.Engine_Volume << " litres" << endl;
    cout << "Enguni power: " << car.Engine_Power << " h.p." << endl;
    cout << "Wheel Diametr: " << car.Wheel_Diameter << " inches" << endl;
    cout << "olor: " << car.Color << endl;
    cout << "Trasmitssion type: " << car.Transmission_Type << endl << endl;
    cout << "========================" << endl << endl;
}

void findCar(const Car cars[], int numCars, double minEnginePower, double minEngineVolume) {
    cout << "Cars, that fit your filters:" << endl;
    for (int i = 0; i < numCars; ++i) {
        if (cars[i].Engine_Power >= minEnginePower && cars[i].Engine_Volume >= minEngineVolume) {
            cout << "Car " << i + 1 << ":" << endl;
            display(cars[i]);
        }
    }
}