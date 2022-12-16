using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jproect
{
    internal class Calculator
    {
       
      public void Calculation(int number,int number2)
        {
            int sum;
            sum = number + number2;
            int cixma;
            cixma = number - number2;
            int vurma;
            vurma = number * number2;
            float bolme;
            bolme = number / number2;
            Console.WriteLine(bolme);
            Console.WriteLine(vurma);
            Console.WriteLine(cixma);
            Console.WriteLine(sum);
        }
    }
}






