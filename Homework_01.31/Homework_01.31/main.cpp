#include "Libraries.h"
#include "Complex.h"
#include "Car.h"

int main() {
    setlocale(LC_ALL, "");

    //TASK 1
    Complex num1 = { 3, 1 };
    Complex num2 = { 52, 45 };
    Complex sum = Summary(num1, num2);
    Complex difference = Subtract(num1, num2);
    Complex product = Multiply(num1, num2);
    Complex quotient = Divide(num1, num2);
    cout << "Summary: " << sum.real << " + " << sum.imaginary << "i" << endl;
    cout << "Substract: " << difference.real << " + " << difference.imaginary << "i" << endl;
    cout << "Multiply: " << product.real << " + " << product.imaginary << "i" << endl;
    cout << "Divide: " << quotient.real << " + " << quotient.imaginary << "i" << endl;

    //TASK 3
    //const int NUmberOfCars = 3;
    //Car cars[NUmberOfCars];
    //setCar(cars[0], 5.3, 0.05, 5, 480, 12, "Purple", "Automatic");
    //setCar(cars[1], 4, 0.3, 1.8, 160, 17, "Green", "Mechanic");
    //setCar(cars[2], 4.3, 0.17, 3.3, 320, 23, "Yellow", "Automatic");
    //cout << "All cars info:" << endl << endl;
    //cout << "========================" << endl << endl;
    //for (int i = 0; i < NUmberOfCars; ++i) {
    //    cout << "Car " << i + 1 << ":" << endl;
    //    display(cars[i]);
    //}
    //double minPower = 200;
    //double minVolume = 2.0;
    //findCar(cars, NUmberOfCars, minPower, minVolume);

    return 0;
}