/*
Программа выводит все натуральные числа от N до 1

*/ 

Console.Clear();

void DigitDiapas(int max, int start = 1)
{
    //System.Console.WriteLine();
    if(start>max)
    {
        return ;
    }
    else
    {
        System.Console.Write($"{max}, " );
        DigitDiapas(max-1, start);

    }

}
DigitDiapas(8);
