#include <iostream>
#include <string.h>
#include <map>
using namespace std;

string findAndReplace(string text, string wordToFind, string wordToReplace) {
    size_t pos = text.find(wordToFind);
    while (pos != string::npos) {
        text.replace(pos, wordToFind.length(), wordToReplace);
        pos = text.find(wordToFind, pos + wordToReplace.length());
    }
    return text;
}

string capitalizeSentences(string text) {
    for (size_t i = 0; i < text.length(); i++) {
        if (i == 0) {
            text[i] = toupper(text[i]);
        }
        if (i > 1) {
            if (text[i - 2] == '.') {
                text[i] = toupper(text[i]);
            }
        }
    }
    return text;
}
//Добавил map для сохранения букв, поскольку с вектором не получилось реальзовать (по функционалу одно и тоже) 
map<char, int> countLetters(const string& text) {
    map<char, int> letterCount;
    for (char c : text) {
        if (isalpha(c)) {
            letterCount[tolower(c)]++;
        }
    }
    return letterCount;
}

int countDigits(string text) {
    int count = 0;
    for (char c : text) {
        if (isdigit(c)) {
            count++;
        }
    }
    return count;
}

int main() {
    //TASK 1
    string text = "This is a sample text. This text contains some words.";
    string newText = findAndReplace(text, "text", "new text");
    cout << text << endl;
    cout << newText << endl;
    
    //TASK 2
    //string text = "this is a sample text. this text contains some words.";
    //string newText = capitalizeSentences(text);
    //cout << text << endl;
    //cout << newText << endl;

    //TASK 3
    //string text = "This is a sample text. It contains 3 digits.";
    //map<char, int> letterCount = countLetters(text);
    //cout << text << endl;
    //for (auto i : letterCount) {
    //    cout << i.first << ": " << i.second << endl;
    //}

    //TASK 4
    //string text = "This is a sample text. It contains 3 digits.";
    //int count = countDigits(text);
    //cout << "Your text: " << text << endl;
    //cout << "Number of digits: " << count << endl;

    return 0;
}