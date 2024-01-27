#include <iostream>
#include <string>
#pragma warning(disable : 4996)
using namespace std;


void Delete_Symbol(char A[], int index, int length) {
    for (int i = index; i < length - 1; i++) {
        A[i] = A[i + 1];
    }

    A[length - 1] = '\0';
    for (int i{}; i < length - 1; i++) {
        cout << A[i];
    }
}

void Delete_Entires(char A[], int length, char Entire) {
    int numRemoved = 0;
    for (int i = 0; i < length; i++) {
        if (A[i] == Entire) {
            numRemoved++;
        }
        else {
            A[i - numRemoved] = A[i];
        }
    }
    A[length - numRemoved] = '\0';
    for (int i{}; i < length; i++) {
        cout << A[i];
    }
}

void insertCharacter(char A[], char Insert, int pos) {
    int length = strlen(A);
    for (int i = length; i >= pos; i--) {
        A[i + 1] = A[i];
    }
    A[pos] = Insert;
    for (int i{}; i < length + 1; i++) {
        cout << A[i];
    }
}

void Switch_Symbols(char A[], int length) {
    for (int i{}; i < length; i++) {
        if (A[i] == '.') A[i] = '!';
    }
    for (int i{}; i < length; i++) {
        cout << A[i];
    }
}

void CountSymbol(char A[], int length) {
    char symbol;
    int count = 0;
    cin >> symbol;
    for (int i{}; i < length; i++) {
        if (A[i] == symbol) count++;
    }
    cout << "Symbol" << symbol << " meets in your string " << count << " times!" << endl;
}

void Counter(char A[], int length) {
    int letters = 0, digits = 0, others = 0;
    cin.getline(A, length);

    for (int i = 0; A[i] != '\0'; i++) {
        if (isalpha(A[i]))
            letters++;
        else if (isdigit(A[i]))
            digits++;
        else
            others++;
    }
    cout << "Letters: " << letters << endl;
    cout << "Digits: " << digits << endl;
    cout << "Others: " << others << endl;
}

int main() {

    //TASK 1
    const int length = 100;
    char str[length] = "New teacher is da best";
    Delete_Symbol(str, 2, length);

    //TASK 2
    //const int length = 100;
    //char str[length] = "New teacher is da best";
    //char Ent = 'e';
    //Delete_Entires(str, length, Ent);

    //TASK 3
    //const int length = 100;
    //char str[length] = "New teacher is da best";
    //insertCharacter(str, '!', 4);

    //TASK 4
    //const int length = 100;
    //char str[length] = "New. teacher. is. da. best";
    //Switch_Symbols(str, length);

    //TASK 5
    //const int length = 100;
    //char str[length] = "New. teacher. is. da. best";
    //CountSymbol(str, length);

    //TASK 6
    //const int length = 100;
    //char str[length] = "New. teacher. is. da. best";
    //Counter(str, length);

    return 0;
}