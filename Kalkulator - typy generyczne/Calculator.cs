namespace GenericTypesCalculator
{
    static class Calculator<T>
    {
        static T x;
        static T y;
        public static void start()
        {
        choise:
            Console.WriteLine("\nInput first number: ");
            string x_str = Console.ReadLine();
            Console.WriteLine("\nInput second number: ");
            string y_str = Console.ReadLine();
            dynamic x_dynamic;
            dynamic y_dynamic;

            try
            {
                x = (T)Convert.ChangeType(x_str, typeof(T));
                //x = (T)Convert.ChangeType(x_str, x.GetType());
                y = (T)Convert.ChangeType(y_str, typeof(T));

                x_dynamic = x;
                y_dynamic = y;
            }

            catch (Exception ex) { Console.WriteLine("\nConversion error!\n"); goto choise; }

            Console.WriteLine("\nx + y = " + (x_dynamic + y_dynamic) + "\n");
            Console.WriteLine("x - y = " + (x_dynamic - y_dynamic) + "\n");
            Console.WriteLine("x * y = " + (x_dynamic * y_dynamic) + "\n");
            if (y_dynamic != 0)
            {
                Console.WriteLine("x / y = " + (x_dynamic / y_dynamic) + "\n");
                Console.WriteLine("x % y = " + (x_dynamic % y_dynamic) + "\n");
            }
            else
            {
                Console.WriteLine("x / y has no value, because y equals 0!\n");
                Console.WriteLine("x % y has no value, because y equals 0!\n");
            }
            goto choise;

        }
    }
}
