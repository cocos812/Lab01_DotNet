// Console.WriteLine("Добро пожаловать в анкету!");

Console.Write("Введите ваше имя: ");
string name = Console.ReadLine() ?? string.Empty;

Console.Write("Введите вашу фамилию: ");
string surname = Console.ReadLine() ?? string.Empty;

Console.Write("Введите вашу группу: ");
string group = Console.ReadLine() ?? string.Empty;

Console.Write("Введите ваш год рождения: ");
int.TryParse(Console.ReadLine(), out int birthYear);

Console.Write("Введите ваш средний балл (например, 4.5): ");
double.TryParse(Console.ReadLine(), out double gpa);

int currentYear = 2026;
int age = currentYear - birthYear;
bool isExcellent = gpa >= 4.5;

string status = isExcellent ? "Отличник" : "Хорошист";

Console.WriteLine("nВаша анкета");
Console.WriteLine($"Имя: {name} {surname}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Средний балл: {gpa}");
Console.WriteLine($"Статус: {status}");
Console.WriteLine($"Лет до 30: {30 - age}");

Console.WriteLine("\nНажмите Enter для выхода...");
Console.ReadLine();
