class DivisionToTwoThreeAndFour
{
    public static void Main (string[]args)
    {
        int n = int.Parse(Console.ReadLine());

        int divideBy2 = 0;
        int divideBy3 = 0;
        int divideBy4 = 0;
        
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                divideBy2++;

            if (number % 3 == 0)
                divideBy3++;
            if (number % 4 == 0)
                divideBy4++;
        }

        double percentBy2 = (double) divideBy2 / n * 100;
        double percentBy3 = (double) divideBy3 / n * 100;
        double percentBy4 = (double) divideBy4 / n * 100;

        Console.WriteLine($"{percentBy2:F2}%");
        Console.WriteLine($"{percentBy3:F2}%");
        Console.WriteLine($"{percentBy4:F2}%");
        



    }
    }
