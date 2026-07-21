#include <iostream>
using namespace std;

int main() {
    int score;
    cout << "Enter score: ";
    cin >> score;

    if (score >= 50) {
        cout << "Pass!" << endl;
    } else {
        cout << "Fail!" << endl;
    }

    return 0;
}
