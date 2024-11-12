int foodname = 1;
switch (foodname)
{
    case 1:
        Console.WriteLine("pizza");
        if (foodname == 1)
            Console.WriteLine("suggest our drinks");
        else if (foodname != 1)
            Console.WriteLine("refer customer to next foods");

        break;
    case 2:
        Console.WriteLine("lazana");
        if (foodname == 2)
            Console.WriteLine("suggest our salad");
        else if (foodname != 2)
            Console.WriteLine("refer customer to next foods");
        break;
    case 3:
        Console.WriteLine("Pastais is not availavble");
        if (foodname == 3)
            Console.WriteLine("suggest our dessert");
        else if (foodname != 3)
            Console.WriteLine("refer customer to next foods");
        break;
    case 4:
        Console.WriteLine("traditional foods are prepared");
        if (foodname == 4)
            Console.WriteLine("suggest our appetizers");
        else if (foodname != 4)
            Console.WriteLine("refer customer to next foods");
        break;
}

