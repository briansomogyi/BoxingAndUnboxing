namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            int i = 3;
            object obj1 = i;
            
            Console.WriteLine(i);
            Console.WriteLine(obj1);

            // Unboxing
            int smallNumber = 10;
            object obj2 = smallNumber;
            if (obj2 is int)
            {
                long j = (int)obj2;
                Console.WriteLine(obj2);
                Console.WriteLine(j);
            }
            object obj3 = new Person();
            if(obj3 is string obj3Content)
            {
                Console.WriteLine(obj3Content);
            }
            
            // Literals
            long a = 123;
            long b = -a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Operators
            string text = null;
            Console.WriteLine($"Length of text: {text?.Length}");
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}