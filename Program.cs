using System;

public class RandomNumber
{
    // Atributtes
    private int min,
                max,
                number;

    // Constructors
    public RandomNumber()
    {
        this.min = 0;
        this.max = 100;
        generateRandom();
    }

    public RandomNumber(int min, int max)
    {
        this.min = min;
        this.max = max;
    }

    // Properties
    public int Min
    {
        get { return this.min; }
        set { this.min = value; }
    }

    public int Max
    {
        get { return this.max; }
        set { this.max = value; }
    }

    // Methods
    public int generateRandom()
    {
        Random r = new Random();
        this.number = r.Next(min, max);

        return this.number;
    }

    public int getHunch()
    {
        Console.Write("Guess a number between " + this.min + " and " + this.max + ": ");
        int hunch = Convert.ToInt32(Console.ReadLine());
        return hunch;

    }

    public bool checkHunch(int num)
    {
        return (num == this.number) ? true : false;
    }

    public int classifyHunch(int hunch)
    {
        if (hunch > number)
        {
            Console.WriteLine("To high! Guess lower...");
        }
        else
        {
            Console.WriteLine("To low! Guess higher...");
        }
        
        return getHunch();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        RandomNumber random = new RandomNumber();
        int hunch = 0,
            number = 0;

        number = random.generateRandom();
        //Console.WriteLine("Number: " + number);

        hunch = random.getHunch();
        while(!random.checkHunch(hunch))
        {
            hunch = random.classifyHunch(hunch);
        }

        Console.WriteLine("\nYOU WON!\nPress [ENTER] to exit...");

        Console.ReadLine();
    }
}