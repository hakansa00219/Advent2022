using System.Linq;
namespace Challenge05
{
    internal class Program
    {
        public static Stack<char>[] stacks = new Stack<char>[9];
        public static string input = "move 5 from 4 to 9\r\nmove 3 from 5 to 1\r\nmove 12 from 9 to 6\r\nmove 1 from 6 to 9\r\nmove 3 from 2 to 8\r\nmove 6 from 3 to 9\r\nmove 2 from 2 to 9\r\nmove 2 from 3 to 5\r\nmove 9 from 8 to 1\r\nmove 1 from 6 to 9\r\nmove 1 from 8 to 3\r\nmove 14 from 1 to 2\r\nmove 8 from 2 to 6\r\nmove 2 from 2 to 7\r\nmove 2 from 5 to 8\r\nmove 5 from 2 to 6\r\nmove 9 from 7 to 8\r\nmove 1 from 9 to 8\r\nmove 5 from 6 to 9\r\nmove 1 from 3 to 8\r\nmove 1 from 7 to 5\r\nmove 1 from 1 to 5\r\nmove 4 from 1 to 7\r\nmove 15 from 6 to 1\r\nmove 4 from 7 to 6\r\nmove 2 from 5 to 7\r\nmove 9 from 8 to 7\r\nmove 13 from 1 to 3\r\nmove 8 from 6 to 9\r\nmove 1 from 6 to 8\r\nmove 1 from 7 to 5\r\nmove 2 from 1 to 3\r\nmove 4 from 7 to 1\r\nmove 13 from 3 to 6\r\nmove 2 from 1 to 3\r\nmove 1 from 5 to 8\r\nmove 2 from 3 to 4\r\nmove 5 from 7 to 1\r\nmove 4 from 1 to 9\r\nmove 2 from 4 to 5\r\nmove 4 from 6 to 2\r\nmove 3 from 2 to 5\r\nmove 6 from 8 to 1\r\nmove 7 from 6 to 7\r\nmove 1 from 3 to 5\r\nmove 1 from 2 to 4\r\nmove 8 from 1 to 8\r\nmove 4 from 6 to 2\r\nmove 3 from 5 to 3\r\nmove 1 from 4 to 3\r\nmove 2 from 1 to 3\r\nmove 8 from 8 to 5\r\nmove 2 from 3 to 8\r\nmove 4 from 5 to 3\r\nmove 1 from 9 to 2\r\nmove 1 from 8 to 3\r\nmove 1 from 2 to 1\r\nmove 15 from 9 to 3\r\nmove 6 from 7 to 5\r\nmove 1 from 7 to 3\r\nmove 2 from 2 to 8\r\nmove 6 from 9 to 4\r\nmove 22 from 3 to 6\r\nmove 3 from 8 to 6\r\nmove 1 from 1 to 2\r\nmove 2 from 9 to 8\r\nmove 6 from 4 to 7\r\nmove 6 from 7 to 2\r\nmove 16 from 6 to 9\r\nmove 8 from 2 to 1\r\nmove 4 from 6 to 1\r\nmove 2 from 3 to 4\r\nmove 9 from 5 to 4\r\nmove 1 from 7 to 9\r\nmove 1 from 6 to 2\r\nmove 3 from 5 to 7\r\nmove 16 from 9 to 4\r\nmove 2 from 7 to 1\r\nmove 4 from 6 to 3\r\nmove 1 from 9 to 5\r\nmove 1 from 9 to 7\r\nmove 1 from 7 to 6\r\nmove 1 from 7 to 9\r\nmove 2 from 9 to 2\r\nmove 1 from 6 to 1\r\nmove 2 from 8 to 1\r\nmove 11 from 4 to 2\r\nmove 9 from 2 to 6\r\nmove 9 from 6 to 1\r\nmove 15 from 4 to 6\r\nmove 1 from 4 to 2\r\nmove 1 from 5 to 3\r\nmove 6 from 6 to 4\r\nmove 3 from 2 to 1\r\nmove 2 from 4 to 6\r\nmove 3 from 6 to 2\r\nmove 7 from 6 to 2\r\nmove 1 from 4 to 7\r\nmove 1 from 7 to 2\r\nmove 5 from 3 to 6\r\nmove 1 from 5 to 4\r\nmove 1 from 4 to 5\r\nmove 8 from 1 to 6\r\nmove 1 from 4 to 8\r\nmove 12 from 6 to 1\r\nmove 1 from 3 to 4\r\nmove 1 from 4 to 1\r\nmove 1 from 3 to 4\r\nmove 2 from 6 to 5\r\nmove 31 from 1 to 7\r\nmove 2 from 5 to 7\r\nmove 1 from 8 to 2\r\nmove 1 from 5 to 8\r\nmove 1 from 8 to 6\r\nmove 3 from 4 to 9\r\nmove 3 from 9 to 4\r\nmove 2 from 4 to 3\r\nmove 2 from 1 to 6\r\nmove 2 from 3 to 8\r\nmove 1 from 4 to 9\r\nmove 4 from 2 to 9\r\nmove 17 from 7 to 8\r\nmove 3 from 8 to 2\r\nmove 2 from 9 to 4\r\nmove 4 from 2 to 5\r\nmove 1 from 1 to 4\r\nmove 1 from 9 to 3\r\nmove 8 from 8 to 4\r\nmove 1 from 9 to 4\r\nmove 4 from 8 to 3\r\nmove 8 from 2 to 5\r\nmove 2 from 2 to 3\r\nmove 1 from 2 to 1\r\nmove 1 from 8 to 4\r\nmove 2 from 8 to 1\r\nmove 1 from 7 to 2\r\nmove 1 from 8 to 6\r\nmove 3 from 4 to 5\r\nmove 8 from 4 to 7\r\nmove 1 from 2 to 8\r\nmove 1 from 8 to 1\r\nmove 2 from 4 to 7\r\nmove 8 from 5 to 9\r\nmove 7 from 5 to 2\r\nmove 6 from 3 to 1\r\nmove 6 from 1 to 2\r\nmove 9 from 9 to 4\r\nmove 5 from 7 to 4\r\nmove 2 from 1 to 2\r\nmove 9 from 4 to 2\r\nmove 3 from 6 to 2\r\nmove 1 from 6 to 8\r\nmove 1 from 8 to 9\r\nmove 1 from 3 to 5\r\nmove 6 from 7 to 5\r\nmove 4 from 4 to 2\r\nmove 19 from 2 to 3\r\nmove 1 from 4 to 6\r\nmove 7 from 7 to 5\r\nmove 2 from 1 to 8\r\nmove 12 from 3 to 4\r\nmove 3 from 4 to 1\r\nmove 1 from 6 to 3\r\nmove 8 from 5 to 9\r\nmove 3 from 9 to 7\r\nmove 6 from 4 to 3\r\nmove 3 from 1 to 2\r\nmove 13 from 3 to 7\r\nmove 3 from 4 to 6\r\nmove 4 from 9 to 4\r\nmove 14 from 7 to 8\r\nmove 3 from 5 to 2\r\nmove 3 from 2 to 6\r\nmove 1 from 6 to 2\r\nmove 1 from 3 to 9\r\nmove 4 from 4 to 6\r\nmove 11 from 2 to 7\r\nmove 2 from 9 to 6\r\nmove 3 from 5 to 6\r\nmove 1 from 9 to 7\r\nmove 14 from 6 to 5\r\nmove 1 from 5 to 1\r\nmove 4 from 5 to 8\r\nmove 2 from 5 to 6\r\nmove 4 from 2 to 5\r\nmove 1 from 2 to 9\r\nmove 14 from 8 to 5\r\nmove 2 from 8 to 4\r\nmove 3 from 8 to 7\r\nmove 5 from 5 to 4\r\nmove 13 from 5 to 7\r\nmove 5 from 7 to 6\r\nmove 31 from 7 to 9\r\nmove 7 from 6 to 7\r\nmove 6 from 5 to 7\r\nmove 1 from 8 to 9\r\nmove 1 from 5 to 3\r\nmove 1 from 3 to 5\r\nmove 1 from 1 to 8\r\nmove 6 from 4 to 3\r\nmove 1 from 8 to 5\r\nmove 1 from 4 to 1\r\nmove 33 from 9 to 3\r\nmove 13 from 7 to 1\r\nmove 29 from 3 to 2\r\nmove 3 from 3 to 8\r\nmove 1 from 5 to 2\r\nmove 20 from 2 to 6\r\nmove 19 from 6 to 4\r\nmove 1 from 7 to 4\r\nmove 5 from 1 to 7\r\nmove 1 from 8 to 7\r\nmove 2 from 8 to 5\r\nmove 10 from 2 to 8\r\nmove 6 from 3 to 9\r\nmove 4 from 7 to 1\r\nmove 1 from 3 to 5\r\nmove 1 from 1 to 2\r\nmove 1 from 7 to 6\r\nmove 1 from 2 to 8\r\nmove 1 from 8 to 7\r\nmove 4 from 9 to 7\r\nmove 2 from 5 to 2\r\nmove 1 from 8 to 5\r\nmove 1 from 8 to 6\r\nmove 7 from 8 to 3\r\nmove 2 from 9 to 4\r\nmove 3 from 5 to 1\r\nmove 2 from 2 to 5\r\nmove 5 from 7 to 8\r\nmove 10 from 4 to 1\r\nmove 5 from 8 to 5\r\nmove 10 from 1 to 3\r\nmove 2 from 6 to 4\r\nmove 1 from 7 to 3\r\nmove 1 from 8 to 1\r\nmove 3 from 5 to 8\r\nmove 12 from 4 to 7\r\nmove 3 from 5 to 3\r\nmove 16 from 1 to 7\r\nmove 2 from 3 to 7\r\nmove 1 from 5 to 6\r\nmove 3 from 8 to 4\r\nmove 1 from 4 to 7\r\nmove 1 from 6 to 3\r\nmove 14 from 3 to 1\r\nmove 5 from 3 to 8\r\nmove 1 from 3 to 5\r\nmove 1 from 7 to 6\r\nmove 1 from 6 to 2\r\nmove 13 from 7 to 2\r\nmove 1 from 5 to 3\r\nmove 3 from 4 to 2\r\nmove 1 from 3 to 5\r\nmove 3 from 8 to 9\r\nmove 2 from 8 to 9\r\nmove 1 from 6 to 4\r\nmove 5 from 2 to 4\r\nmove 3 from 2 to 5\r\nmove 7 from 7 to 3\r\nmove 7 from 4 to 7\r\nmove 5 from 3 to 7\r\nmove 8 from 2 to 3\r\nmove 5 from 9 to 5\r\nmove 11 from 1 to 9\r\nmove 4 from 3 to 1\r\nmove 1 from 2 to 7\r\nmove 4 from 1 to 7\r\nmove 22 from 7 to 3\r\nmove 5 from 3 to 4\r\nmove 1 from 7 to 1\r\nmove 1 from 1 to 4\r\nmove 3 from 4 to 6\r\nmove 3 from 1 to 3\r\nmove 2 from 6 to 1\r\nmove 2 from 4 to 9\r\nmove 13 from 9 to 1\r\nmove 1 from 6 to 5\r\nmove 4 from 7 to 1\r\nmove 3 from 1 to 6\r\nmove 19 from 3 to 9\r\nmove 5 from 3 to 1\r\nmove 18 from 9 to 8\r\nmove 1 from 9 to 3\r\nmove 11 from 1 to 7\r\nmove 1 from 4 to 5\r\nmove 13 from 8 to 1\r\nmove 7 from 5 to 8\r\nmove 7 from 8 to 5\r\nmove 3 from 6 to 5\r\nmove 2 from 3 to 9\r\nmove 1 from 3 to 7\r\nmove 5 from 5 to 2\r\nmove 10 from 1 to 5\r\nmove 9 from 7 to 9\r\nmove 11 from 5 to 2\r\nmove 2 from 8 to 4\r\nmove 1 from 4 to 3\r\nmove 2 from 7 to 3\r\nmove 1 from 7 to 4\r\nmove 3 from 8 to 3\r\nmove 8 from 5 to 2\r\nmove 2 from 3 to 8\r\nmove 4 from 3 to 8\r\nmove 6 from 2 to 6\r\nmove 5 from 1 to 8\r\nmove 8 from 2 to 7\r\nmove 2 from 4 to 7\r\nmove 9 from 2 to 9\r\nmove 4 from 7 to 8\r\nmove 5 from 1 to 8\r\nmove 3 from 7 to 4\r\nmove 1 from 8 to 3\r\nmove 3 from 7 to 2\r\nmove 3 from 1 to 9\r\nmove 1 from 4 to 9\r\nmove 1 from 6 to 3\r\nmove 18 from 8 to 5\r\nmove 1 from 8 to 2\r\nmove 2 from 4 to 9\r\nmove 3 from 2 to 1\r\nmove 2 from 2 to 3\r\nmove 24 from 9 to 8\r\nmove 3 from 3 to 7\r\nmove 15 from 8 to 2\r\nmove 12 from 2 to 5\r\nmove 1 from 7 to 4\r\nmove 1 from 3 to 1\r\nmove 28 from 5 to 4\r\nmove 1 from 7 to 9\r\nmove 2 from 2 to 1\r\nmove 4 from 6 to 3\r\nmove 1 from 5 to 3\r\nmove 1 from 5 to 9\r\nmove 1 from 2 to 6\r\nmove 5 from 3 to 5\r\nmove 8 from 4 to 2\r\nmove 2 from 6 to 2\r\nmove 1 from 7 to 3\r\nmove 4 from 2 to 8\r\nmove 3 from 1 to 2\r\nmove 5 from 2 to 5\r\nmove 3 from 5 to 4\r\nmove 2 from 1 to 5\r\nmove 2 from 2 to 1\r\nmove 4 from 9 to 2\r\nmove 7 from 8 to 9\r\nmove 1 from 3 to 1\r\nmove 1 from 1 to 7\r\nmove 2 from 8 to 3\r\nmove 4 from 9 to 3\r\nmove 9 from 5 to 7\r\nmove 3 from 3 to 5\r\nmove 1 from 5 to 3\r\nmove 7 from 7 to 9\r\nmove 1 from 7 to 9\r\nmove 1 from 5 to 9\r\nmove 1 from 5 to 1\r\nmove 1 from 8 to 5\r\nmove 9 from 9 to 1\r\nmove 2 from 7 to 2\r\nmove 1 from 5 to 6\r\nmove 4 from 3 to 2\r\nmove 11 from 2 to 4\r\nmove 1 from 8 to 4\r\nmove 1 from 8 to 2\r\nmove 1 from 2 to 8\r\nmove 1 from 6 to 5\r\nmove 1 from 8 to 6\r\nmove 6 from 1 to 7\r\nmove 1 from 5 to 6\r\nmove 1 from 6 to 5\r\nmove 3 from 9 to 8\r\nmove 3 from 8 to 1\r\nmove 3 from 7 to 8\r\nmove 1 from 6 to 9\r\nmove 1 from 2 to 4\r\nmove 1 from 9 to 7\r\nmove 2 from 7 to 9\r\nmove 10 from 1 to 6\r\nmove 2 from 9 to 3\r\nmove 1 from 5 to 7\r\nmove 3 from 7 to 5\r\nmove 3 from 5 to 3\r\nmove 4 from 6 to 3\r\nmove 18 from 4 to 2\r\nmove 3 from 4 to 1\r\nmove 1 from 1 to 3\r\nmove 2 from 1 to 2\r\nmove 8 from 2 to 9\r\nmove 1 from 4 to 7\r\nmove 1 from 7 to 1\r\nmove 3 from 9 to 2\r\nmove 3 from 8 to 6\r\nmove 1 from 4 to 9\r\nmove 7 from 2 to 8\r\nmove 7 from 6 to 7\r\nmove 3 from 9 to 2\r\nmove 3 from 2 to 5\r\nmove 6 from 4 to 6\r\nmove 2 from 5 to 6\r\nmove 3 from 3 to 6\r\nmove 6 from 6 to 3\r\nmove 5 from 7 to 5\r\nmove 2 from 4 to 8\r\nmove 5 from 5 to 2\r\nmove 1 from 7 to 2\r\nmove 4 from 6 to 4\r\nmove 1 from 7 to 8\r\nmove 1 from 6 to 4\r\nmove 1 from 5 to 7\r\nmove 1 from 3 to 4\r\nmove 1 from 6 to 4\r\nmove 2 from 9 to 1\r\nmove 3 from 1 to 3\r\nmove 1 from 3 to 1\r\nmove 9 from 2 to 1\r\nmove 8 from 1 to 5\r\nmove 1 from 7 to 1\r\nmove 1 from 9 to 1\r\nmove 4 from 5 to 7\r\nmove 4 from 7 to 5\r\nmove 1 from 1 to 9\r\nmove 5 from 2 to 4\r\nmove 1 from 9 to 6\r\nmove 8 from 8 to 9\r\nmove 18 from 4 to 9\r\nmove 3 from 5 to 4\r\nmove 2 from 6 to 5\r\nmove 1 from 8 to 5\r\nmove 17 from 9 to 6\r\nmove 2 from 8 to 1\r\nmove 1 from 4 to 6\r\nmove 8 from 6 to 3\r\nmove 1 from 1 to 8\r\nmove 5 from 5 to 3\r\nmove 1 from 1 to 7\r\nmove 1 from 8 to 6\r\nmove 2 from 4 to 5\r\nmove 6 from 9 to 4\r\nmove 1 from 7 to 5\r\nmove 7 from 6 to 8\r\nmove 2 from 6 to 5\r\nmove 6 from 8 to 3\r\nmove 1 from 9 to 6\r\nmove 2 from 9 to 5\r\nmove 1 from 3 to 1\r\nmove 1 from 8 to 6\r\nmove 7 from 5 to 6\r\nmove 7 from 6 to 7\r\nmove 5 from 4 to 9\r\nmove 1 from 4 to 5\r\nmove 2 from 9 to 6\r\nmove 3 from 1 to 7\r\nmove 5 from 6 to 8\r\nmove 1 from 1 to 5\r\nmove 21 from 3 to 6\r\nmove 3 from 7 to 2\r\nmove 2 from 9 to 3\r\nmove 1 from 9 to 7\r\nmove 5 from 5 to 7\r\nmove 7 from 6 to 7\r\nmove 14 from 7 to 1\r\nmove 3 from 2 to 8\r\nmove 12 from 1 to 4\r\nmove 5 from 7 to 6\r\nmove 1 from 7 to 4\r\nmove 8 from 8 to 3\r\nmove 8 from 3 to 5\r\nmove 6 from 5 to 6\r\nmove 1 from 5 to 3\r\nmove 2 from 1 to 8\r\nmove 2 from 8 to 3\r\nmove 10 from 3 to 7\r\nmove 8 from 4 to 3\r\nmove 3 from 4 to 9\r\nmove 3 from 9 to 2\r\nmove 1 from 2 to 5\r\nmove 2 from 2 to 9\r\nmove 13 from 3 to 1\r\nmove 1 from 4 to 1\r\nmove 2 from 1 to 7\r\nmove 1 from 5 to 8\r\nmove 1 from 9 to 6\r\nmove 1 from 9 to 2\r\nmove 1 from 4 to 9\r\nmove 8 from 6 to 2\r\nmove 1 from 9 to 5\r\nmove 1 from 2 to 8\r\nmove 1 from 5 to 9\r\nmove 2 from 2 to 3\r\nmove 12 from 6 to 8\r\nmove 1 from 3 to 7\r\nmove 8 from 8 to 4\r\nmove 1 from 9 to 1\r\nmove 13 from 1 to 3\r\nmove 2 from 4 to 5\r\nmove 12 from 7 to 2\r\nmove 1 from 5 to 8\r\nmove 3 from 3 to 8\r\nmove 2 from 4 to 1\r\nmove 1 from 1 to 9";

        static void Main(string[] args)
        {
            StacksInit();
            string[] temp = input.Split("\r\n");

            Operation[] operations = new Operation[temp.Length];

            int idx = 0;
            //5.14.23
            Array.ForEach(temp, operation =>
            {
                string cleaned = operation.Replace(" ", "").Replace("move", "").Replace("from", ".").Replace("to", ".");
                string[] splitted = cleaned.Split('.');
                operations[idx++] = new Operation
                {
                    move = int.Parse(splitted[0]),
                    from = int.Parse(splitted[1]),
                    to = int.Parse(splitted[2])
                };
            });

            Array.ForEach(operations, operation => Do(operation));

            string solution = "";

            Array.ForEach(stacks, stack => solution += stack.Peek());

            Console.WriteLine(solution);

        }

        public static void StacksInit()
        {
            for (int i = 0; i < stacks.Length; i++)
            {
                stacks[i] = new Stack<char>();
            }
            string[] stackInputs = new string[]
            {
               "BPNQHDRT","WGBJTV","NRHDSVMQ","PZNMC","DZB","VCWZ","GZNCVQLS","LGJMDNV","TPMFZCG"
            };
            for (int i = 0; i < stacks.Length; i++)
            {
                StacksMultiplePush(stacks[i], stackInputs[i].ToCharArray());
            }
        }
        public static void StacksMultiplePush(Stack<char> stack, char[] value)
        {
            Array.ForEach(value, (c) => stack.Push(c));
        }

        public static void Do(Operation operation)
        {
            for (int i = 0; i < operation.move; i++)
            {
                char popped = stacks[operation.from - 1].Pop();
                operation.hand.Push(popped);
            }
            for (int i = 0; i < operation.move; i++)
            {
                char pushed = operation.hand.Pop();
                stacks[operation.to - 1].Push(pushed);
            }
            
        }

        public class Operation
        {
            public int move;
            public int from;
            public int to;

            public Stack<char> hand = new Stack<char>();
        }
    }
}