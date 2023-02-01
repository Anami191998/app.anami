// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Liczby Całkowite;
int myAge = 120;
int newMyAge = myAge + 5;
Console.WriteLine(newMyAge);
int myOldAge = myAge - 10;
Console.WriteLine(myOldAge);
uint myLola = uint.MaxValue;
long myLola2 = long.MaxValue;
//Liczby Zmiennoprzecinkowe;
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;
//Zmienne Tekstowe;
String name = "Anna";
String surname = "lach";
String result = name + surname + myAge;
Console.WriteLine(result);
//Zmienne char
var result2 = name.ToArray();

//Zmienna Logiczna
bool isActive = true;
bool isactive = false;
var isVaild = 5 > 6;
Console.WriteLine(isVaild);
//Warunki logoczne if
var number1 = 5;
var number2 = 10;
if (number1 > number2)
{
    Console.WriteLine("jestem tutaj w lini 30");
}
else
{
    Console.WriteLine("jestem tutaj linia 31");
}

// zmienne logiczne
var name1 = "Ania";
var age = 25;
if (name1 == "Ania" || age > 50)
{
    Console.WriteLine("jestem Anią lub mam mniej niż 50lat");
}
else
{
    Console.WriteLine("jestem kimś innym");
}
// && - i
//|| - lub
// ! -  czy mamy warunek (np. czy wiek nie jest wiekszy niż 50) jest to negacja

