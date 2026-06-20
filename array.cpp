#include <iostream>
#include <vector>

using namespace std;

int main() {
    int n = 10;
    int arr[10] = {1, 23, 8, 32, 45, 11, 22, 55, 33, 44}; 
    
    int sum = 0; 
    int mi = arr[0];
    int ma = arr[0];

    for (int i = 0; i < n; i++) {
        if (arr[i] < mi) mi = arr[i];
        if (arr[i] > ma) ma = arr[i];
        sum += arr[i];
    }

    float avg = (float)sum / n;

    cout << "Min: " << mi << endl;
    cout << "Max: " << ma << endl;
    cout << "Average: " << avg << endl;

    return 0;
}
