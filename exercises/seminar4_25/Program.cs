//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int  checkedVar;
bool isInt;
int  a;
int  b;
string msg;

msg = "сопротивление бесполезно";
isInt = false;
a=0;
b=0;

void CheckInput (string a, out bool isInt, out int checkedVar)
{
     isInt = int.TryParse(a, out checkedVar); 
}

double expAB (int a, int b) //цикл возведения в степень
{

if (b == 0)
{
    return 1;
}
else if(b > 0) 
{
double result = a;

for (int i=1; i < b; i++)
{
    result = result*a;
}
return result;
}
else 
{
    double result = a;

for (int i=1; i < Math.Abs(b); i++)
{
    result = result*a;
}
return 1/result;
}
}


Console.WriteLine("введите основание для возведения в степень или просите пощады: ");

while (isInt == false )
{

   string tmp1 = Console.ReadLine();

     if  (tmp1 != "пощади")
     {
        CheckInput (tmp1, out isInt, out checkedVar); 
        if (isInt)
        {
            a = Convert.ToInt32(tmp1); 
        }
        else
        {
            Console.WriteLine(msg); 
        }
        
     }
        else
     {
        Console.WriteLine("то-то же!");
        return;
     }
   
}

isInt = false;

Console.WriteLine("введите показатель степени или просите пощады: ");

while (isInt == false )
{

   string tmp2 = Console.ReadLine();

     if  (tmp2 != "пощади")
     {
        CheckInput (tmp2, out isInt, out checkedVar); 
        if (isInt)
        {
             b = Convert.ToInt32(tmp2); 
        }
        else
        {
            Console.WriteLine(msg); 
        }
        
     }
        else
     {
        Console.WriteLine("то-то же!");
        return;
     }
   
}

Console.WriteLine($"{a} в степени {b} равно {expAB (a, b)}");

