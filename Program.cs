﻿// Калинин Павел 03.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 2. Массивы и функции в программировании
// Домашняя работа

int intN = 0, intN1 = 0, intN2 = 0; 
double doubleN = 0, doubleN1 = 0, doubleN2 = 0, doubleN3 = 0;
bool isRepeat = true; 
string s = "";
string taskName = "";

if(false) { // выборочно отключить для отладки

taskName = "Задание  №1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите номер дня недели (1 ... 7): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if(intN1 == 6 || intN1 == 7) Console.WriteLine("День недели "+intN1+" - выходной день.");
    else                         Console.WriteLine("День недели "+intN1+" - НЕ выходной день.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №2. По двум заданным числам проверять является ли одно квадратом другого.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите первое целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите второе целое число: ");
    intN2 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if(intN1>=0 && intN1*intN1 == intN2) 
        Console.WriteLine("Число "+intN1+" является квадратом числа "+intN2);
    else if(intN2>=0 && intN2*intN2 == intN1) 
        Console.WriteLine("Число "+intN2+" является квадратом числа "+intN1);
    else {
        Console.WriteLine("Число "+intN1+" НЕ является квадратом числа "+intN2);
        Console.WriteLine("Число "+intN2+" НЕ является квадратом числа "+intN1);
    }    
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    

taskName = "Задание  №3. Задать номер четверти, показать диапазоны для возможных координат.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите номер четверти (1 ... 4): ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    s = "Координатной четверти с номером "+intN1+" не существует.";
    switch (intN1) {
        case 1: s = "I   четверти соотв. множество точек огран. неравенствами у>0 х>0"; break;
        case 2: s = "II  четверти соотв. множество точек огран. неравенствами у>0 х<0"; break;
        case 3: s = "III четверти соотв. множество точек огран. неравенствами у<0 х<0"; break;
        case 4: s = "IV  четверти соотв. множество точек огран. неравенствами у<0 х>0"; break;
    }
    Console.WriteLine(s);
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    

} // выборочно отключить для отладки


taskName = "Задание  №4. Программа проверяет пятизначное число на палиндромом.";
bool isPalindrome(string aStrNumber) {
    bool result = true;
    int len = aStrNumber.Length;
    for(int i=0; i<len/2;i++) {
        if(aStrNumber[i] != aStrNumber[len-1-i]) {
            result = false;
            break;
        } //else Console.WriteLine(aStrNumber[i]+" = "+aStrNumber[len-1-i]);
    }
    return result;
}
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите целое десятичное число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    s = Convert.ToString(intN1,10);
    if(s.Length>1 && isPalindrome(s)) 
        Console.WriteLine("\""+s+"\" является числом-палиндромом в десятичной системе счисления.");
    else                
        Console.WriteLine("\""+s+"\" НЕ является числом-палиндромом в десятичной системе счисления.");
    s = Convert.ToString(intN1,2);
    if(s.Length>1 && isPalindrome(s)) 
        Console.WriteLine("\""+s+"\" является числом-палиндромом в двоичной системе счисления.");
    else                
        Console.WriteLine("\""+s+"\" НЕ является числом-палиндромом в двоичной системе счисления.");
    s = Convert.ToString(intN1,16);
    if(s.Length>1 && isPalindrome(s)) 
        Console.WriteLine("\""+s+"\" является числом-палиндромом в шестнадцатеричной системе счисления.");
    else                
        Console.WriteLine("\""+s+"\" НЕ является числом-палиндромом в шестнадцатеричной системе счисления.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    int n = int.Parse(Console.ReadLine() ?? "0");
    isRepeat = n != 0;
}    


taskName = "Задание  №5. Найти расстояние между точками в пространстве 2D/3D";



