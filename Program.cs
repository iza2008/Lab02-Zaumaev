Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte:  {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int:  {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long:  {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных чисел");
Console.WriteLine($"float:  {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double:  {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal:  {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");


Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '_';
int charAsNumber = firstLetter;
Console.WriteLine($"Символ: {firstLetter}, разделитель: {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция: \tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");


Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double:  0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20;
var gpa = 4.75;
var fullName = "Заумаев И.У";

Console.WriteLine($"{fullName}, Возраст {studentAge}, средний балл {gpa}");

// Console.WriteLine();
// Console.WriteLine("Ввод текста");

// Console.Write("Введите ваше имя ");
// string enteredName = Console.ReadLine();

// Console.Write("Введите название вашей группы: ");
// string enteredGroup = Console.ReadLine();

// Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

// Console.WriteLine();
// Console.WriteLine("Ввод чисел: Convert и Parse");

// Console.Write("Введите ваш год рождения: ");
// string birthYearInput = Console.ReadLine();

// int birthYearConvert = Convert.ToInt32(birthYearInput);
// int birthYearParse = int.Parse(birthYearInput);

// Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
// Console.WriteLine($"int.Parse:       {birthYearParse}");
// Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

// Console.WriteLine();
// Console.WriteLine("Калькулятор ИМТ");

// Console.Write("Введите рост в метрах, например 1,75: ");
// double bmiHeight = double.Parse(Console.ReadLine() ?? "");

// Console.Write("Введите вес в килограммах: ");
// double bmiWeight = double.Parse(Console.ReadLine() ?? "");

// double bmiResult = bmiWeight / (bmiHeight * bmiHeight);

// Console.WriteLine($"ИМТ: {bmiResult:F2}");

Console.WriteLine();
Console.WriteLine("Инициалы");

Console.Write("Введите фамилию: ");
string initialsSurname = Console.ReadLine() ?? "";

Console.Write("Введите имя: ");
string initialsName = Console.ReadLine() ?? "";

char initialsFirstLetter = initialsName[0];

Console.WriteLine($"{initialsSurname} {initialsFirstLetter}.");