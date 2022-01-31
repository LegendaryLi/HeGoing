Console.WriteLine("Начало работы программы");
int a = int.Parse(EntrA());
int b = int.Parse(EntrB());
Console.WriteLine("Выберите действие: (1 - sum, 2 - sub, 3 - mult, 4 - div) ");
string temp = Console.ReadLine();
if (temp == "1")
{
    sum();
}
else if (temp == "2")
{
    sub();
}
else if (temp == "3")
{
    mult();
}
else if (temp == "4")
{
    div();
}
string EntrA()
{
    Console.WriteLine("Введите а");
    return Console.ReadLine();
}
string EntrB()
{
    Console.WriteLine("Введите B");
    return Console.ReadLine();
}
void sum()
{
    Console.WriteLine(a + b);
}
void sub()
{
    Console.WriteLine(a - b);
}
void mult()
{
    Console.WriteLine(a * b);
}
void div()
{
    Console.WriteLine(a / b);
}
