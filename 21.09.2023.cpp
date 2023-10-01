// ConsoleApplication49.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
#include <iostream>
#include <string>
#include <Windows.h>

using namespace std;

class BankAccount {
private:
    string ownerName;
    int accountNumber;
    double balance;

public:
    BankAccount(const string& name, int number, double initialBalance)
        : ownerName(name), accountNumber(number), balance(initialBalance) {}

    void Deposit(double amount) {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        if (amount > 0) {
            balance += amount;
            cout << "Внесено " << amount << " грн на рахунок." << endl;
        }
        else {
            cout << "Некоректна сума для внесення на рахунок." << endl;
        }
    }

    void Withdraw(double amount) {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            cout << "Знято " << amount << " грн з рахунку." << endl;
        }
        else {
            cout << "Некоректна сума для зняття з рахунку або недостатньо коштів." << endl;
        }
    }

    double GetBalance() const {
        return balance;
    }

    void DisplayInfo() const {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Ім'я власника рахунку: " << ownerName << endl;
        cout << "Номер рахунку: " << accountNumber << endl;
        cout << "Поточний баланс: " << balance << " грн" << endl;
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    BankAccount account1("Александр Усик", 1001, 1500.0);
    BankAccount account2("Магистр Йода", 1002, 2000.0);

    account1.DisplayInfo();
    account2.DisplayInfo();

    account1.Deposit(500.0);
    account1.Withdraw(200.0);

    account2.Deposit(1000.0);
    account2.Withdraw(500.0);

    cout << "Поточний баланс рахунку 1: " << account1.GetBalance() << " грн" << endl;
    cout << "Поточний баланс рахунку 2: " << account2.GetBalance() << " грн" << endl;

    return 0;
}