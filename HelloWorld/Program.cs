// // int age = 20;
// // double gpa = 4.5;
// // bool isStudent = true;
// // string name = "Иван";

// // Console.WriteLine(name);
// // Console.WriteLine(age);
// // Console.WriteLine(gpa);
// // Console.WriteLine(isStudent);
  
// // string myName = "Иван";
// // int myAge = 20;
// // string myGroup = "ИСП-234";

// // Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");
// // int x = 10;
// // int y = 3;

// // Console.WriteLine(x + y);  // 13
// // Console.WriteLine(x - y);  // 7
// // Console.WriteLine(x * y);  // 30
// // Console.WriteLine(x / y);  // 3 (целочисленное деление)
// // Console.WriteLine(x % y);  // 1 (остаток от деления)
// string firstName = "Александр";
// string lastName = "Глазков";
// string group = "ИСП-242";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = true;

// int currentYear = 2026;
// int age = currentYear - birthYear;

// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Стипендия: {hasScholarship}");

// Console.Write("\nВведите ваш любимый предмет: ");
// string subject = Console.ReadLine()!F;
// Console.WriteLine($"Отлично! {firstName} любит {subject}.");
int a = 15;
int b = 4;

Console.WriteLine($"Сумма: {a + b}");
Console.WriteLine($"Разность: {a - b}");
Console.WriteLine($"Произведение: {a * b}");
Console.WriteLine($"Частное (int): {a / b}");
Console.WriteLine($"Остаток: {a % b}");

double result = (double)a / b;
Console.WriteLine($"Частное (double): {result}");

Console.WriteLine(Math.Abs(-5));
Console.WriteLine(Math.Pow(2, 10));
Console.WriteLine(Math.Sqrt(144));
Console.WriteLine(Math.Max(10, 25));
Console.WriteLine(Math.Min(10, 25));
Console.WriteLine(Math.Round(3.567, 2));
Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма: {num1 + num2}");
Console.WriteLine($"Разность: {num1 - num2}");
Console.WriteLine($"Произведение: {num1 * num2}");
if (num2 != 0)
    Console.WriteLine($"Частное: {num1 / num2}");
else
    Console.WriteLine("Деление на ноль невозможно!");
