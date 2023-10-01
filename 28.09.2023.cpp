#include <iostream>
#include <Windows.h>
using namespace std;

class Bird {
public:
    string color;
    float weight;
    float height;

    void PrintInfo() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Цвет: " << color << endl;
        cout << "Вес: " << weight << " кг" << endl;
        cout << "Высота: " << height << " м" << endl;
    }
};

class HomeParrot : public Bird {
public:
    string name;
    bool isSpeak;
    bool trained;

    void Say(string word) {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << word << endl;
    }

    void PrintInfo() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        Bird::PrintInfo();
        cout << "Имя: " << name << endl;
        cout << "Говорит: " << (isSpeak ? "Да" : "Нет") << endl;
        cout << "Приручен: " << (trained ? "Да" : "Нет") << endl;
    }
};

class Ostrich : public Bird {
public:
    Ostrich() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        color = "Серый";
        weight = 100.0f;
        height = 2.5f;
    }

    void RunFast() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Страус умеет быстро бегать" << endl;
    }
};

class Falcon : public Bird {
public:
    Falcon() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        color = "Коричневый";
        weight = 1.0f;
        height = 0.3f;
    }

    void Hunt() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Сокол способен охотиться" << endl;
    }
};

class Condor : public Bird {
public:
    Condor() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        color = "Черный";
        weight = 12.0f;
        height = 3.0f;
    }

    void SoarHigh() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Кондор способен подниматься на высокие высоты и долго парить в воздухе" << endl;
    }
};

class Pelican : public Bird {
public:
    Pelican() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        color = "Белый";
        weight = 8.0f;
        height = 1.5f;
    }

    void CatchFish() {
        SetConsoleCP(1251);
        SetConsoleOutputCP(1251);
        cout << "Пеликаны умеют ловить рыбу с помощью своего клюва" << endl;
    }
};
