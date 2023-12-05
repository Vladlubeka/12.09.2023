// ConsoleApplication8.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <ctime>
#include <Windows.h>

using namespace std;

class Weapon {
protected:
    int damage;
    int weight;
    int ammoInMagazine;
    int magazineCount;
    float accuracy;
    float fireRate;

public:
    Weapon() {}

    virtual ~Weapon() {}

    int getDamage() const { return damage; }

    int getWeight() const { return weight; }

    float getAccuracy() const { return accuracy; }

    virtual void displayInfo() const = 0;

    virtual void generateRandomStats() {
        damage = rand() % 50 + 1; 
        weight = rand() % 10 + 1; 
        ammoInMagazine = rand() % 30 + 1; 
        magazineCount = rand() % 5 + 1;
        accuracy = static_cast<float>(rand()) / RAND_MAX;
        fireRate = static_cast<float>(rand()) / RAND_MAX; 
    }
};

class Empty : public Weapon {
public:
    Empty() {}

    void displayInfo() const override {
        cout << "Нет оружия.\n";
    }
};

class Glock : public Weapon {
public:
    Glock() {
        generateRandomStats();
    }

    void displayInfo() const override {
        cout << "Оружие: Glock\n";
        cout << "Урон: " << getDamage() << "\n";
        cout << "Вес: " << getWeight() << "\n";
        cout << "Точность: " << getAccuracy() << "\n";
    }
};

class AK47 : public Weapon {
public:
    AK47() {
        generateRandomStats();
    }

    void displayInfo() const override {
        cout << "Оружие: AK47\n";
        cout << "Урон: " << getDamage() << "\n";
        cout << "Вес: " << getWeight() << "\n";
        cout << "Точность: " << getAccuracy() << "\n";
    }
};

class M4A1 : public Weapon {
public:
    M4A1() {
        generateRandomStats();
    }

    void displayInfo() const override {
        cout << "Оружие: M4A1\n";
        cout << "Урон: " << getDamage() << "\n";
        cout << "Вес: " << getWeight() << "\n";
        cout << "Точность: " << getAccuracy() << "\n";
    }
};

class ShotGun : public Weapon {
public:
    ShotGun() {
        generateRandomStats();
    }

    void displayInfo() const override {
        cout << "Оружие: ShotGun\n";
        cout << "Урон: " << getDamage() << "\n";
        cout << "Вес: " << getWeight() << "\n";
        cout << "Точность: " << getAccuracy() << "\n";
    }
};

class Player {
protected:
    string name;
    int health;
    Weapon* weapon;

public:
    Player(const string& playerName) : name(playerName), health(100), weapon(nullptr) {
        getWeapon();
    }

    virtual ~Player() {
        delete weapon;
    }

    void getWeapon() {
        int weaponType = rand() % 4 + 1; 

        switch (weaponType) {
        case 1:
            weapon = new Glock();
            break;
        case 2:
            weapon = new AK47();
            break;
        case 3:
            weapon = new M4A1();
            break;
        case 4:
            weapon = new ShotGun();
            break;
        default:
            break;
        }
    }

    virtual void openFire(Player& target) {
        float hitChance = static_cast<float>(rand()) / RAND_MAX;
        if (hitChance < weapon->getAccuracy()) {
            int damage = static_cast<int>(weapon->getDamage() * hitChance);
            target.receiveDamage(damage);
            cout << name << " попал в " << target.name << " на " << damage << " урона!\n";
        }
        else {
            cout << name << " промахнулся!\n";
        }
    }

    virtual void receiveDamage(int damage) {
        health -= damage;
        cout << name << " получил " << damage << " урона. Текущее здоровье: " << health << "\n";
    }

    void displayInfo() const {
        cout << "Игрок: " << name << "\n";
        cout << "Здоровье: " << health << "\n";
        weapon->displayInfo();
    }
};

class Bot : public Player {
public:
    Bot() : Player("Бот") {}

    void receiveDamage(int damage) override {
        Player::receiveDamage(damage);
        cout << "Текущее здоровье бота: " << health << "\n";
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    srand(static_cast<unsigned>(time(0)));

    Player player1("Игрок 1");
    Player player2("Игрок 2");
    Bot bot;

    player1.displayInfo();
    player2.displayInfo();
    bot.displayInfo();

    for (int i = 0; i < 5; ++i) {
        cout << "\n--- Итерация " << i + 1 << " ---\n";
        player1.openFire(player2);
        player2.openFire(player1);
        player1.openFire(bot);
        bot.openFire(player1);
        player2.openFire(bot);
        bot.openFire(player2);
    }

    cout << "\n--- Финальная информация ---\n";
    player1.displayInfo();
    player2.displayInfo();
    bot.displayInfo();

    return 0;
}

