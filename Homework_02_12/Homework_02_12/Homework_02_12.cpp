#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;
//TASK 1
vector<string> read_file(string filename) {
    ifstream file(filename);
    if (!file.is_open()) {
        cout << "Error opening file " << filename << endl;
        return {};
    }
    vector<string> lines;
    string line;
    while (getline(file, line)) {
        lines.push_back(line);
    }
    return lines;
}
bool compare_files(string file1, string file2) {
    vector<string> lines1 = read_file(file1);
    vector<string> lines2 = read_file(file2);
    if (lines1.empty() && lines2.empty()) {
        cout << "Both files are empty" << endl;
        return true;
    }
    if (lines1.empty() || lines2.empty()) {
        cout << "One file is empty" << endl;
        return false;
    }
    if (lines1 == lines2) {
        return true;
    }
    cout << "Files do not match" << endl;
    for (size_t i = 0; i < lines1.size() && i < lines2.size(); ++i) {
        if (lines1[i] != lines2[i]) {
            cout << "Non-matching line " << (i + 1) << ": " << lines1[i] << " vs " << lines2[i] << endl;
        }
    }
    return false;
}

//TASK 2
void print_stats(ostream& out, string filename) {
    ifstream file(filename, ios::app);
    if (!file.is_open()) {
        cout << "Error opening file " << filename << endl;
        return;
    }
    int chars = 0, lines = 0, vowels = 0, consonants = 0, digits = 0;
    string line;
    while (getline(file, line)) {
        chars += line.length();
        lines++;
        for (char c : line) {
            switch (tolower(c)) {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'y':
                vowels++;
                break;
            case 'b':
            case 'c':
            case 'd':
            case 'f':
            case 'g':
            case 'h':
            case 'j':
            case 'k':
            case 'l':
            case 'm':
            case 'n':
            case 'p':
            case 'q':
            case 'r':
            case 's':
            case 't':
            case 'v':
            case 'w':
            case 'x':
            case 'z':
                consonants++;
                break;
            }
            if (isdigit(c))digits++;
        }
    }
    out << "File: " << filename << "\n";
    out << "Characters: " << chars-1 << "\n";
    out << "Lines: " << lines << "\n";
    out << "Vowels: " << vowels << "\n";
    out << "Consonants: " << consonants << "\n";
    out << "Digits: " << digits << "\n";
    out << "======================" << "\n";
}

void caesar_encrypt(ostream& out, istream& in, int shift) {
    char c;
    while (in.get(c)) {
        if (isalpha(c)) {
            if (islower(c)) {
                c = 'a' + (c - 'a' + shift) % 26;
            }
            else {
                c = 'A' + (c - 'A' + shift) % 26;
            }
        }
        out.put(c);
    }
}

int main() {
    //TASK 1
    //string file1 = "file1.txt";
    //string file2 = "file2.txt";
    //if (compare_files(file1, file2)) {
    //    cout << "Files are identical or have common content" << endl;
    //}
    //else {
    //    cout << "Files are different" << endl;
    //}

    //TASK 2
    //string filename = "file1.txt";
    //ofstream outfile("stats.txt");
    //if (!outfile.is_open()) {
    //    cerr << "Error opening file stats.txt" << endl;
    //    return 1;
    //}
    //print_stats(outfile, filename);

    //TASK 3
    string input_filename = "input.txt";
    string output_filename = "output.txt";
    ifstream infile(input_filename);
    if (!infile.is_open()) {
        cout << "Error opening file " << input_filename << endl;
        return 1;
    }
    ofstream outfile(output_filename);
    if (!outfile.is_open()) {
        cout << "Error opening file " << output_filename << endl;
        return 1;
    }
    int shift = 3; 
    caesar_encrypt(outfile, infile, shift);

    return 0;
}