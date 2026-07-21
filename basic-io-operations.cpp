#include <iostream>
#include <string>
using namespace std;

int main() {
    string name;
    int age;

    cout << "Enter your full name: ";
    getline(cin, name); // <-- เก็บรวบหมดทั้งชื่อ-นามสกุล แม้จะมีเว้นวรรค

    cout << "Enter your age: ";
    cin >> age;

    cout << "\nHello " << name << "! You are " << age << " years old.";
    return 0;
}