namespace Kalkulator_typy_generyczne
{
    static class Kalkulator<T>
    {
        static T x;
        static T y;
        public static void start()
        {
        ponowny_wybor:
            Console.WriteLine("Kalkulator\nWpisz pierwszą liczbę: ");
            string x_str = Console.ReadLine();
            Console.WriteLine("\nWpisz drugą liczbę: ");
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

            catch (Exception ex) { Console.WriteLine("\nBląd w konwersji!\n"); goto ponowny_wybor; }

            Console.WriteLine("x + y = " + (x_dynamic + y_dynamic) + "\n");
            Console.WriteLine("x - y = " + (x_dynamic - y_dynamic) + "\n");
            Console.WriteLine("x * y = " + (x_dynamic * y_dynamic) + "\n");
            if (y_dynamic != 0)
            {
                Console.WriteLine("x / y = " + (x_dynamic / y_dynamic) + "\n");
                Console.WriteLine("x % y = " + (x_dynamic % y_dynamic) + "\n");
            }
            else
            {
                Console.WriteLine("x / y nie ma wartości, gdyż y wynosi 0!\n");
                Console.WriteLine("x % y nie ma wartości, gdyż y wynosi 0!\n");
            }
            goto ponowny_wybor;

        }
    }
}
