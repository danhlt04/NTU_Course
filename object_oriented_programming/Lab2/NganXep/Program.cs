namespace NganXep
{
    public class Stack
    {
        private int top;
        private int Max;
        private int[] stack;

        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        public int maxV
        {
            get { return Max; }
            set { Max = value; }
        }

        public int[] stacks
        {
            get { return stacks; }
            set { stacks = value; }
        }

        public Stack()
        {
            stack = new int[100000];
            top = -1;
        }

        public void Push(int x) { stack[++top] = x; }

        public void Pop() { --top; }

        public int Peek() { return stack[top]; }

        public bool IsEmpty() { return top == -1; }

        public void Print() { while(top != -1) Console.Write($"{stack[top--]} "); }

        public void PrintHex()
        {
            string hex = "0123456789ABCDEF";
            while (top != -1) Console.Write($"{hex[stack[top--]]} "); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            int n = 234223535;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        st.Push(i);
                        n /= i;
                    }
                }
            }
            if (n > 1) st.Push(n);
            st.Print();
            Console.WriteLine();

            Stack binst = new Stack();
            int x = 123;
            while (x != 0)
            {
                binst.Push(x & 1);
                x >>= 1;
            }
            binst.Print();
            Console.WriteLine();

            Stack hexst = new Stack();
            int y = 34234;
            while(y != 0)
            {
                hexst.Push(y % 16);
                y /= 16;
            }
            hexst.PrintHex();
        }
    }
}
