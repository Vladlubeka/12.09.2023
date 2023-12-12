// ConsoleApplication9.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <algorithm>
#include <iostream>
#include <cmath>
#include <vector>
#include <Windows.h>

using namespace std;

class Person {
private:
    string name;
    int age;

public:
    Person(string n, int a) : name(move(n)), age(a) {}
    string getName() const { return name; }
    int getAge() const { return age; }
};

class Town {
private:
    int floor;
    int apartments;
    int firstFloor;

public:
    Town(int f, int a) : floor(f), apartments(a), firstFloor(rand() % 2) {}

    int getFloor() const { return floor; }
    int getApartments() const { return apartments; }
    int getFirstFloor() const { return firstFloor; }
};

vector<int> sortFloors(const vector<Town>& towns) {
    vector<int> floorApartments(towns.size());

    auto comparator = [](const Town& a, const Town& b) {
        return a.getApartments() < b.getApartments();
    };

    vector<Town> sortedTowns = towns;
    sort(sortedTowns.begin(), sortedTowns.end(), comparator);

    for (size_t i = 0; i < sortedTowns.size(); ++i) {
        floorApartments[i] = sortedTowns[i].getFloor();
    }

    return floorApartments;
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    vector<Town> towns = {
        Town(5, 10),
        Town(10, 5),
        Town(7, 8),
    };

    cout << "Исходный порядок этажей:" << endl;
    for (const auto& town : towns) {
        cout << town.getFloor() << " этажей, " << town.getApartments() << " квартир на первом этаже" << endl;
    }

    vector<int> sortedFloors = sortFloors(towns);

    cout << "\nОтсортированный порядок этажей:" << endl;
    for (const auto& floor : sortedFloors) {
        cout << floor << " этажей" << endl;
    }

    return 0;
}


