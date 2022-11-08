// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
   
        
    int TmpNumber;

    void DigSumCalc (int number )

    {

        int division = number;
        int DigitCounter = 0;
                
        while (division >= 1 )
        {
            division = division / 10 ;
            DigitCounter++ ;
        }
        
        int exp = 10;
        
        int SummDigit = 0;
        
        for (int i = 1; i <= DigitCounter; i++)
        
        {
            SummDigit = SummDigit + (number % (exp))/(exp/10); 
            exp = exp*10;
        }
        
        Console.WriteLine("");
        
        Console.WriteLine($"сумма цифр числа {number} равна {SummDigit}");
    }



        Console.WriteLine("введите целое число: ");
        
        string tmp = Console.ReadLine();

        bool CheckInput = Int32.TryParse(tmp, out TmpNumber);
        
        if(CheckInput)
        {
            DigSumCalc (TmpNumber);    
        }
        else
        {
            Console.WriteLine("Это не целое число");   
        }