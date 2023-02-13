namespace Kalkulator_typy_generyczne
{
    static class Menu
    {

        public static void wypisz_menu()
        {
        menu:
            Console.WriteLine("Kalkulator\nWybierz typ danych:\n1. int\n2. double\n3. float");
            int input = 0;
            try { input = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex)
            {
                Console.WriteLine("\nBłędny klawisz, powrót do wyboru!\n"); System.Threading.Thread.Sleep(1000);
                goto menu;
            }
            switch (input)
            {
                case 1: //int
                    Kalkulator<int>.start();
                    break;
                case 2: //double
                    Kalkulator<double>.start();
                    break;
                case 3: //float
                    Kalkulator<float>.start();
                    break;


                default:
                    Console.WriteLine("\nBłędny klawisz, powrót do wyboru!\n");
                    System.Threading.Thread.Sleep(1000);
                    goto menu;
                    break;
            }

        }
    }
}
