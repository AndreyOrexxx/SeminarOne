// Задача 4
// Напишите программу, которая принимает на ввод три числа и выдает максимальное из них.

// Я понимаю задачу так :
// Числа целые, генерируются автоматом из диапазона (10, 20)
// Результат выводится в терминал, как показанно в примере.

int x = new Random().Next(10, 20);
int y = new Random().Next(10, 20);
int z = new Random().Next(10, 20);
int max = x;

if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
    Console.WriteLine(max);

