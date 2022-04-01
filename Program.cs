
double num1, num2, total;
int p;
char oper;
string function, perc;

Console.WriteLine("\t\t\t\t\tSimple Calculator\n");

Console.WriteLine("What do you need: Simple Operations(so), Raise to the Power(rp), Percentage(per), Square Root(sr), Exponent(exp)?");
function = Convert.ToString(Console.ReadLine());

if (function == "so")
{
    Console.WriteLine("\nEnter first number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nEnter your operation( - + / * ): ");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("\nEnter second number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    if (oper == '-')
    {
        total = num1 - num2;
        Console.WriteLine("\nAnswer: " + total);

    }
    else if (oper == '+')
    {
        total = num1 + num2;
        Console.WriteLine("\nAnswer: " + total);

    }
    else if (oper == '/')
    {
        total = num1 / num2;
        Console.WriteLine("\nAnswer: " + total);

    }
    else if (oper == '*')
    {
        total = num1 * num2;
        Console.WriteLine("\nAnswer: " + total);

    }
    else
    {
        Console.WriteLine("\nWrong operator");
    }
}

else if (function == "per")
{
    Console.WriteLine("\nConvert percentage into number(c) or the operation with percentages(o)?");
    perc = Convert.ToString(Console.ReadLine());

    if (perc == "c")
    {
        Console.WriteLine("\nExample: 167% = 1,67");

        Console.WriteLine("\nEnter your number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        total = num1 / 100;
        Console.WriteLine("\nAnswer: " + total);

    }
    else if (perc == "o")
    {
        Console.WriteLine("\nExample: 247 - 90% = 24,7 or 86 * 12% = 10,32");

        Console.WriteLine("\nEnter your number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter your operator: ");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("\nEnter percentage (without '%'): ");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (oper == '-')
        {
            total = num1 - ((num2 * num1) / 100);
            Console.WriteLine("\nAnswer: " + total);

        }
        else if (oper == '+')
        {
            total = num1 + ((num2 * num1) / 100);
            Console.WriteLine("\nAnswer: " + total);
        }
        else if (oper == '/')
        {
            total = num1 / ((num2 * num1) / 100);
            Console.WriteLine("\nAnswer: " + total);
        }
        else if (oper == '*')
        {
            total = num1 * ((num2 * num1) / 100);
            Console.WriteLine("\nAnswer: " + total);
        }
        else
        {
            Console.WriteLine("\nWrong operator");
        }
    }
    else
    {
        Console.WriteLine("\nThere is no such function");
    }

}

else if (function == "rp")
{
    Console.WriteLine("\nEnter your number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nEnter your power: ");

    bool isInt = int.TryParse(Console.ReadLine(), out p);
    if (isInt == true)
    { 
        total = Math.Pow(num1, p);
        Console.WriteLine("\nAnswer: " + total);

    }
    else
    {
        Console.WriteLine("\nWrong number format");
    }

    
}

else if (function == "sr")
{
    Console.WriteLine("\nEnter number under sqrt: ");
    num1 = Convert.ToDouble((Console.ReadLine()));

    total = Math.Sqrt(num1);
    Console.WriteLine("\nAnswer: " + total);
}

else if (function == "exp")
{
    Console.WriteLine("\nEnter exponent's power: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    total = Math.Exp(num1);
    Console.WriteLine("\nAnswer: " + total);
}

else
{
    Console.WriteLine("\nThere is no such function");
}












