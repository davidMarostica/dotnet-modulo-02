using System;
using System.Collections.Generic;
using System.Linq;



bool? desejaReceberEmnail = true;
if (desejaReceberEmnail.HasValue)
{
    if (desejaReceberEmnail.Value && desejaReceberEmnail.Value == true)
    {
        Console.WriteLine("O usuário deseja receber email.");
    }
    else
    {
        Console.WriteLine("O usuário não deseja receber email.");
    }
}
else
{
    Console.WriteLine("O usuário não respondeu sobre receber email.");
}