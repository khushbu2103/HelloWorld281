namespace HelloWorld281
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //object creation of human class 
            //className objectVarible=new ClassName 
            Human human = new Human();
            Console.WriteLine("please enter your name");
            human.name = Console.ReadLine();
            Console.WriteLine("please enter your height");
            string height = Console.ReadLine();
            Console.ReadLine();

        }
    }
}