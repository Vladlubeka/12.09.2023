﻿
#include <iostream>
#include <algorithm>

using namespace std;

class Student {
public:
    string name;
    int age;
    void sayHi() {
        cout << "Hello, my name is " << name << ", and I am " << age << " years old." << endl;
    }
};

bool compareStudents(const Student& s1, const Student& s2) {
    return s1.age < s2.age;
}

int main() {
    Student newList[3]{
        {"Vlad", 18},
        {"Maxim", 16},
        {"Oleg", 20}
    };

    sort(newList, newList + 3, compareStudents);

    cout << "Sorted list of students by age:" << endl;
    for (int i = 0; i < 3; i++) {
        newList[i].sayHi();
    }

    return 0;
}
