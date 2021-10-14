namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Push(4);
            B.Push(5);
            B.Push(6);
            B.Pop();
            B.Pop();
            B.View();



            /*Queue A = new Queue();
            A.Push(1);
            A.Push(2);
            A.Push(3);
            A.Push(4);
            A.Push(5);
            A.Push(6);
            A.Pop();
            A.Push(1);
            A.View();*/
        }
    }
}
