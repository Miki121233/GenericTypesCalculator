namespace GenericTypesCalculator
{
    static class Menu
    {

        public static void writeMenu()
        {
        menu:
            Console.WriteLine("Calculator\nChoose type:\n1. int\n2. double\n3. float");
            int input = 0;
            try { input = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex)
            {
                Console.WriteLine("\nWrong key, coming back to choose!\n"); System.Threading.Thread.Sleep(1000);
                goto menu;
            }
            switch (input)
            {
                case 1: //int
                    Calculator<int>.start();
                    break;
                case 2: //double
                    Calculator<double>.start();
                    break;
                case 3: //float
                    Calculator<float>.start();
                    break;


                default:
                    Console.WriteLine("\nWrong key, coming back to choose!\n");
                    System.Threading.Thread.Sleep(1000);
                    goto menu;
                    break;
            }

        }
    }
}
