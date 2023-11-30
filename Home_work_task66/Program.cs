/*
Программа принимает два значения M и N и выдает все натуральные числа в промежутке от  N до M

*/

Console.Clear();

int Summ (int start, int max)
{
    
    if(start==max)
    {            
        return start;
    }    
    else
    {         
     return start+Summ(start+1,max);           
    }
   
}
//System.Console.WriteLine(Summ(1,9));
int result = Summ(1,9);
System.Console.WriteLine($"Сумма всех чисел в заданом диапазоне равна {result}");
