// See https://aka.ms/new-console-template for more information
using System;
      
struct arr_id
{
      public int digit;
      public bool isIndividible;
}

class work 
{
static void Main() 

{
    Console.WriteLine("введите границу поиска простых чисел: ");

    int border = Convert.ToInt32(Console.ReadLine());

    arr_id[] massiv = new arr_id[border];       //создание массива 
    arr_id element = new arr_id();          // элемент типа созданной структуры
    
    for (int i = 0; i < massiv.Length - 1 ; i++)
    
    {
        element.digit = i;
        
        element.isIndividible = true;
         
        massiv[i] = element;  // добавление в массив элемента созданной структуры
    }
    
    for (int i = 2; i < massiv.Length -1 ; i++)
    {

        if (massiv[i].isIndividible == true)
        {
            for (int j = 2*i; j < massiv.Length - 1  ; j = j + i)
            {
                massiv[j].isIndividible = false;
            }

        }
    }


    int k = 0;
    for (int i = 1; i < massiv.Length -1 ; i++)
    {
        if (massiv[i].isIndividible == true)
        {
            Console.Write(massiv[i].digit+" ");
            k++;
            if(k % 20 == 0)
            {
            Console.WriteLine ("");
            }
        }
    }
}
}