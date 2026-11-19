// class car 
// {
//     string color = "red";
//     string model = "Toyota";

//     static void Main(string[] args)
//     {
//         int a = 10;
//         int b = 5;
//         int sum = a + b;
//         Console.WriteLine($"Sum: {sum}");
//         car myCar = new car();
//         Console.WriteLine($"My car is a {myCar.color} {myCar.model}.");
//     }
// }

// class fruit
// {
//     string name = "Apple";
//     string color = "Red";

//     static void Main(string[] args)
//     {
//         fruit myFruit = new fruit();
//         Console.WriteLine($"My fruit is a {myFruit.color} {myFruit.name}.");
//     }
// }

// class Car
// {
//   public string color = "red";
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myObj1 = new Car();
//     Car myObj2 = new Car();
//     Console.WriteLine(myObj1.color);
//     Console.WriteLine(myObj2.color);
//   }
// }


// 
// 
class vehicle
{
    public string model = "Mustang";
    public void honk()
    {
        Console.WriteLine("Beep, beep!");
    }
}

class Car : vehicle
{
    public string modelName = "Mustang";
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.model + " " + myCar.modelName);
    }
}