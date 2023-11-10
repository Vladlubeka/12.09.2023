#include <iostream>

using namespace std;

class MorseCodeConverter {
private:
    static const char alphabet[];
    static const char* morseCode[];

public:
    string textToMorse(const string& text) const {
        string result;
        for (char c : text) {
            if (isupper(c)) {
                int index = c - 'A';
                result += morseCode[index];
                result += ' ';
            }
        }
        return result;
    }

    string morseToText(const string& morse) const {
        string result;
        size_t start = 0;
        size_t end = morse.find(' ');

        while (end != string::npos) {
            string currentMorse = morse.substr(start, end - start);
            for (int i = 0; i < 26; ++i) {
                if (currentMorse == morseCode[i]) {
                    result += alphabet[i];
                    break;
                }
            }
            start = end + 1;
            end = morse.find(' ', start);
        }

        return result;
    }
};

const char MorseCodeConverter::alphabet[] = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
const char* MorseCodeConverter::morseCode[] = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

