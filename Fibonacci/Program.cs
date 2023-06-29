//Here you can chceck the result of the fucntions!


Console.WriteLine(CalcFibonacciIterationalWay(8)); //should be 21
Console.WriteLine(CalcFibonacciWithRecursion(8)); //should be 21

int CalcFibonacciIterationalWay(int position)
{
    int value1 = 1;
    int value2 = 1;
    for(int i = 2; i < position; i++)
    {
        value1 += value2;
        value2 = value1 - value2;
    }
    return value1;
}
int CalcFibonacciWithRecursion(int position)
{
    if(position ==1 || position == 2)
    {
        return 1;
    }
    return CalcFibonacciWithRecursion(position - 1) + CalcFibonacciWithRecursion(position -2);
}