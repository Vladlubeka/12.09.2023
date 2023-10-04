﻿// ConsoleApplication56.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

class Figure {
public:
    string name;
    int square;
    int lineThickness;
    string lineColor;
    string fillColor;
};

class Rectangle : public Figure {
public:
    int width;
    int height;

    Rectangle(string n, int w, int h, int lt, string lc, string fc) {
        name = n;
        width = w;
        height = h;
        lineThickness = lt;
        lineColor = lc;
        fillColor = fc;
        square = width * height;
    }
};

class Circle : public Figure {
public:
    int radius;

    Circle(string n, int r, int lt, string lc, string fc) {
        name = n;
        radius = r;
        lineThickness = lt;
        lineColor = lc;
        fillColor = fc;
        square = static_cast<int>(3.14159 * radius * radius);
    }
};

class Triangle : public Figure {
public:
    int base;
    int height;

    Triangle(string n, int b, int h, int lt, string lc, string fc) {
        name = n;
        base = b;
        height = h;
        lineThickness = lt;
        lineColor = lc;
        fillColor = fc;
        square = (base * height) / 2;
    }
};

class Square : public Figure {
public:
    int side;

    Square(string n, int s, int lt, string lc, string fc) {
        name = n;
        side = s;
        lineThickness = lt;
        lineColor = lc;
        fillColor = fc;
        square = side * side;
    }
};

class Rhombus : public Figure {
public:
    int diagonal1;
    int diagonal2;

    Rhombus(string n, int d1, int d2, int lt, string lc, string fc) {
        name = n;
        diagonal1 = d1;
        diagonal2 = d2;
        lineThickness = lt;
        lineColor = lc;
        fillColor = fc;
        square = (diagonal1 * diagonal2) / 2;
    }
};

int main() {
    setlocale(LC_ALL, "Russian");
    Rectangle rect("Прямоугольник", 5, 10, 2, "Черный", "Синий");
    Circle circle("Круг", 7, 1, "Красный", "Зеленый");
    Triangle triangle("Треугольник", 8, 6, 3, "Синий", "Желтый");
    Square square("Квадрат", 6, 2, "Зеленый", "Красный");
    Rhombus rhombus("Ромб", 6, 8, 1, "Желтый", "Серый");

    cout << "Информация о фигурах:" << endl;
    cout << rect.name << " - Площадь: " << rect.square << ", Толщина линии: " << rect.lineThickness << ", Цвет линии: " << rect.lineColor << ", Цвет заливки: " << rect.fillColor << endl;
    cout << circle.name << " - Площадь: " << circle.square << ", Толщина линии: " << circle.lineThickness << ", Цвет линии: " << circle.lineColor << ", Цвет заливки: " << circle.fillColor << endl;
    cout << triangle.name << " - Площадь: " << triangle.square << ", Толщина линии: " << triangle.lineThickness << ", Цвет линии: " << triangle.lineColor << ", Цвет заливки: " << triangle.fillColor << endl;
    cout << square.name << " - Площадь: " << square.square << ", Толщина линии: " << square.lineThickness << ", Цвет линии: " << square.lineColor << ", Цвет заливки: " << square.fillColor << endl;
    cout << rhombus.name << " - Площадь: " << rhombus.square << ", Толщина линии: " << rhombus.lineThickness << ", Цвет линии: " << rhombus.lineColor << ", Цвет заливки: " << rhombus.fillColor << endl;

    return 0;
}

