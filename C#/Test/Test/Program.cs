namespace Test
{
    internal class Program
    {
        static int CountMeets(int[] hedgehogs, int color)
        {
            switch (color)
            {
                case 0:
                    return hedgehogs[1] == hedgehogs[2] ? hedgehogs[1] : -1;
                case 1:
                    return hedgehogs[0] == hedgehogs[2] ? hedgehogs[0] : -1;
                case 2:
                    return hedgehogs[0] == hedgehogs[1] ? hedgehogs[0] : -1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] hedgehogs = { 8, 10, 7 };
            Console.WriteLine(CountMeets(hedgehogs, 2));
        }
    }
}