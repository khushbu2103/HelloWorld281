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
            human.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter your phoneNum");
            human.phoneNum = Convert.ToInt64(Console.ReadLine());
            human.Talk();
            human.HumanDetails();
            Console.ReadLine();

        }
    }
}