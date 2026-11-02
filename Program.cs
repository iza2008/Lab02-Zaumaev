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

Console.WriteLine();
Console.WriteLine("Преобразование через TryParse");

Console.Write("Введите количество прочитанных книг за семестр ");
string booksInput = Console.ReadLine()??"";

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразовать: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");

Console.WriteLine();
Console.WriteLine("Анкета студента");

Console.Write("Введите имя и фамилию ");
string surveyFullName = Console.ReadLine()??"";

Console.Write("Введите название группы ");
string GroupName = Console.ReadLine()??"";

Console.Write("Введите ваш год рождения ");
string surveyBirthYear = Console.ReadLine()??"";

int surveyBirthYearParse = int.Parse(surveyBirthYear);

Console.Write("Введите средний балл за прошлый семестр: ");
double surveyAverageGrade = double.Parse(Console.ReadLine() ?? "");

Console.Write("Введите любимую букву: ");
string surveyLetterText = Console.ReadLine() ?? "";
char surveyFavoriteLetter = surveyLetterText[0];

Console.WriteLine("Сколько лет исполнится студенту в 2030 году.?");

int surveyAgeIn2030 = 2030 - surveyBirthYearParse;
Console.WriteLine($"В 2030 году студенту будет: {surveyAgeIn2030}");

bool surveyGoodGrade = surveyAverageGrade >= 4.0;


Console.WriteLine();
Console.WriteLine("СВОДКА");
Console.WriteLine($"Имя и фамилия: {surveyFullName}");
Console.WriteLine($"Группа: {GroupName}");
Console.WriteLine($"Год рождения: {surveyBirthYearParse}");
Console.WriteLine($"Средний балл: {surveyAverageGrade}");
Console.WriteLine($"Любимая буква: {surveyFavoriteLetter}");
Console.WriteLine($"В 2030 году исполнится лет: {surveyAgeIn2030}");
Console.WriteLine($"Средний балл не ниже 4.0: {surveyGoodGrade}");