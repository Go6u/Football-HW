public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public abstract class FootballPlayer
{
    public string Name { get; set; }
    public int Number { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }

}

public class Goalkeeper : FootballPlayer
{
    public Goalkeeper(string name, int number, int age, double height)
    {
        this.Name = name;
        this.Number = number;
        this.Age = age;
        this.Height = height;
    }
}

public class Defender : FootballPlayer
{
    public Defender(string name, int number, int age, double height)
    {
        this.Name = name;
        this.Number = number;
        this.Age = age;
        this.Height = height;
    }
}

public class Midfield : FootballPlayer
{
    public Midfield(string name, int number, int age, double height)
    {
        this.Name = name;
        this.Number = number;
        this.Age = age;
        this.Height = height;
    }
}

public class Atacker : FootballPlayer
{
    public Atacker(string name, int number, int age, double height)
    {
        this.Name = name;
        this.Number = number;
        this.Age = age;
        this.Height = height;
    }
}

public class Coach : Person
{
    public Coach(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

public class Referee : Person
{
    public Referee(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

public class Program
{
    static void Main(string[] args)
    {
    }
}