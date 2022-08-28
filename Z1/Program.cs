//dotnet run - Для старта
//dotnet new console - сщздать новый проект
//Console.WriteLine("текст"); - Для ввода текста в ковычках
//Console.Write("текст"); - Для ввода текста в одну строку
//string для текста string username = Console.ReadLine(); то что ввели
//int.Parse(Console.ReadLine()); Для ввода в терминале
//git config user.email "t12345556@gmail.com"
//git config user.name "Anatoly

//new Random().Next(min,max); рандомайзер

// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int i = 5;
int f = 6;
int g = 7;
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());
if(number == a)
Console.WriteLine($"номер {a}, понедельник не является выходным");
if(number == b)
Console.WriteLine($"номер {b}, вторник не является выходным");
if(number == c)
Console.WriteLine($"номер {c}, среда не является выходным");
if(number == d)
Console.WriteLine($"номер {d}, четвер не является выходным");
if(number == i)
Console.WriteLine($"номер {i}, пятница не является выходным");
if(number == f)
Console.WriteLine($"номер {f}, суббота является выходным");
if(number == g)
Console.WriteLine($"номер {g}, воскресенье является выходным");
