#include <iostream>
using namespace std;

class Figure {
public:
    string type;
    char symbol;
    Figure(string type, char symbol) {
        this->type = type;
        this->symbol = symbol;
    }
};

char getRandomLetter() {
    return 'A' + rand() % 26;
}

int main() {
    srand(static_cast<unsigned int>(time(NULL)));

    Figure empty("Empty", ' ');

    Figure diagram[10][10];

    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 10; j++) {
            int random = rand() % 4; 
            if (random == 0) {
                diagram[i][j] = empty;
            }
            else {
                char randomLetter = getRandomLetter();
                diagram[i][j] = Figure("Letter", randomLetter);
            }
        }
    }

    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 10; j++) {
            cout << diagram[i][j].symbol << ' ';
        }
        cout << endl;
    }

    return 0;
}

