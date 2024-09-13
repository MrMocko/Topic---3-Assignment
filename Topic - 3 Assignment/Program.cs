namespace Topic___3_Assignment
{ 
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Andre
            int roomnumber = 29;
            double price = 2.99;
            string coursename = "Computer science";
            Console.BackgroundColor = ConsoleColor. Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("This room is #" + roomnumber);
            Thread.Sleep(1000);
            Console.WriteLine("The price is $" + price);
            Thread.Sleep(1000);
            Console.WriteLine("i am learning about " + coursename);
            Thread.Sleep(1000);
            Console.WriteLine();
            string name = "Andre Mocko";
            int gradYear = 2026; 
            Console.WriteLine(" my name is " + name + " and i'll graduate in " + gradYear);
            Console.WriteLine();
            Thread.Sleep(1000);
            int ra = 6;
            double area = Math.PI * Math.Pow(ra, 2);
            Console.WriteLine(" I have a circle that has a radius of " + ra + " cm. Let's find the area! " + Math.Round(area,1) + "cm\xB2");
            Console.ReadLine();


        }
    }
}
