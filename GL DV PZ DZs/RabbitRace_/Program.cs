namespace RabbitRace_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RabbitRace r = new RabbitRace(("50 150 7 11 303").Split(' '));
            Console.WriteLine(r.Run());
        }
    }
}
