// ConsoleApplication119.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <ctime>

using namespace std;

class RandomDateTime {
public:
    RandomDateTime() {
        int months_ = { "January", "February", "March", "April", "May", "June",
                   "July", "August", "September", "October", "November", "December" };
    }

    void generateAndPrint() {
        cout << "Enter an integer: ";
        cin >> number_;

        if (number_ % 2 == 0) {
            time_t now;
            time(&now);
            tm* ltm = localtime(&now);

            int randomDay = rand() % 31 + 1;
            int randomMonth = rand() % 12;
            int randomHour = rand() % 24;
            int randomMinute = rand() % 60;

            cout << "Random Date and Time: ";
            cout << randomDay << " " << months_[randomMonth] << " " << ltm->tm_year + 1900 << " "
                << (randomHour < 10 ? "0" : "") << randomHour << ":"
                << (randomMinute < 10 ? "0" : "") << randomMinute << endl;
        }
        else {
            cout << "You entered an odd number." << endl;
        }
    }

private:
    int number_;
    const char* months_[12];
};

int main() {
    srand(static_cast<unsigned>(time(0)));
    RandomDateTime randomDateTime;
    randomDateTime.generateAndPrint();

    return 0;
}

