// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
  
    int TmpNumber;
  
    int number = 0;

    void arrCreate (int size)
    {
        
        int[] nums = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < size -1 ; i++ )
        {
            nums[i] = rnd.Next(0, 100);    
        }
        
        foreach (int i in nums)
        {
            Console.Write($"{i} ");  
        }
    }


    Console.WriteLine("введите целое число элементов массива: ");
        
        string tmp = Console.ReadLine();

        bool CheckInput = Int32.TryParse(tmp, out TmpNumber);
        
        if(CheckInput)
        {
        number = Math.Abs(TmpNumber);
        arrCreate (number );   
        }
        else
        {
         Console.WriteLine("Это не целое число");
         Environment.Exit(0);
        }
      

