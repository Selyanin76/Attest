﻿/*
Программа вычисления функции Аккермана

*/

int Acker(int m, int n)
{
    if(m==0)
    {
        return n+1;
    }
    else
    {
        if(n==0)
        {
            return Acker(m-1,1);    
        }
        else
        {
            return Acker(m-1, Acker(m, n-1));
        }
    }
    
}
Console.WriteLine(Acker(4,0));