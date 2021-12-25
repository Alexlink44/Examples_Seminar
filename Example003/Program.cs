// По заданному номеру дня недели вывести его название.

string[] weekdays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Вескресенье"};

Console.Write("Введите день недели: ");
int numDay = int.Parse(Console.ReadLine());
Console.Write($"{weekdays[numDay - 1]}");