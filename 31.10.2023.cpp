// ConsoleApplication69.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <math.h>
#include <Windows.h>

using namespace std;

class Progression {
private:
    unsigned long first;
    unsigned long second;

public:
    Progression(unsigned long first, unsigned long second) {
        this->first = first;
        this->second = second;
    }

    unsigned long getNumberByOrdinal(unsigned int ordinal = 1) {
        if (ordinal == 1)
            return first;
        if (ordinal == 2)
            return second;
        return 0;
    }

    unsigned long getNextNumber() {
        unsigned long next = first + second;
        first = second;
        second = next;
        return next;
    }

    void printFirstNNumbers(unsigned int n) {
        for (unsigned int i = 1; i <= n; i++) {
            cout << getNumberByOrdinal(i) << " ";
        }
        cout << endl;
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    Progression progression1 = { 1, 1 };

    cout << "Первые 10 чисел в прогрессии:  ";
    progression1.printFirstNNumbers(10);

    cout << "Следующий номер в прогрессии: " << progression1.getNextNumber() << endl;

    return 0;
}
