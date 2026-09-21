// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Иван";

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
  
// string myName = "Иван";
// int myAge = 20;
// string myGroup = "ИСП-234";

// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");
// int x = 10;
// int y = 3;

// Console.WriteLine(x + y);  // 13
// Console.WriteLine(x - y);  // 7
// Console.WriteLine(x * y);  // 30
// Console.WriteLine(x / y);  // 3 (целочисленное деление)
// Console.WriteLine(x % y);  // 1 (остаток от деления)
string firstName = "Александр";
string lastName = "Глазков";
string group = "ИСП-242";
int birthYear = 2008;
double gpa = 4.5;
bool hasScholarship = true;

int currentYear = 2026;
int age = currentYear - birthYear;

Console.WriteLine("Студенческое удостоверение");
Console.WriteLine($"Имя: {firstName} {lastName}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Стипендия: {hasScholarship}");

Console.Write("\nВведите ваш любимый предмет: ");
string subject = Console.ReadLine()!;
Console.WriteLine($"Отлично! {firstName} любит {subject}.");
