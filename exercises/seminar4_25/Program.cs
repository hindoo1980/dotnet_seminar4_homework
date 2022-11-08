//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int  checkedVar1;
int  checkedVar2;
bool isInt;
int  a;
int  b;
string msg;
string fleeMsg;
string mercyStr;

msg = "сопротивление бесполезно";
fleeMsg = "то-то же!";
mercyStr = "пощади";

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
else 
{
    double result = a;

    for (int i=1; i < b; i++)
{
    result = result*a;
}

return result;

}

}


Console.WriteLine("введите основание для возведения в степень или просите пощады: ");

while (isInt == false )
{

   string tmp1 = Console.ReadLine();

     if  (tmp1 != mercyStr)
     {
        CheckInput (tmp1, out isInt, out checkedVar1); 
        if (isInt)
        {
            a = Convert.ToInt32(checkedVar1); 
        }
        else
        {
            Console.WriteLine(msg); 
        }
        
     }
        else
     {
        Console.WriteLine(fleeMsg);
        return;
     }
   
}

isInt = false;

Console.WriteLine("введите натуральный показатель степени или просите пощады: ");

while (isInt == false)
{

   string tmp2 = Console.ReadLine();

     if  (tmp2 != mercyStr)
     {
        CheckInput (tmp2, out isInt, out checkedVar2); 
        if (isInt)
        {
             b = Convert.ToInt32(checkedVar2); 
             if (b > 0)
             {
                Console.WriteLine($"{a} в степени {b} равно {expAB (a, b)}");
             } 
             else
             {
                 Console.WriteLine($"{b} не натуральное число");
             }   
             
        }
        else
        {
            Console.WriteLine(msg); 
        }
        
     }
        else
     {
        Console.WriteLine(fleeMsg);
        return;
     }
   
}