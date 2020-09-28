using System;
using System.Threading;

namespace MiniProyecto.Opcion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "1-Pedir menu", "2-Pedir hamburguesa", "3-Pedir bebida", "4-Salir" };

            ShowMenu(menu);

            int opcionElegido = Convert.ToInt32(Console.ReadLine());

            while(opcionElegido > 4)
            {
                Console.WriteLine("Esa opción no está disponible");
                Console.WriteLine("introduzca otra opcion: ");
                opcionElegido = Convert.ToInt32(Console.ReadLine());
            }

            if (opcionElegido <= 4)
            {
                string test = "test";
                Console.WriteLine("Has elegido {0} {1}", menu[opcionElegido - 1].Split("-")[1] , test);

                switch (opcionElegido)
                {
                    case 1:
                        string[] valores = { "Grand Big Boot", "Big Boot", "BootPollo", "Cuarto de libra", "BootRoyal Deluxe"};
                        ChooseHamburConPatatas(valores);
                        ChooseDrinks();
                        break;
                    case 2:
                        string[] hamburgesas = {"Grand Big Boot","Big Boot","BootPollo","Cuarto de libra","BootRoyal Deluxe"};
                        ChooseHamburConPatatas(hamburgesas);
                        ChooseDrinks();
                        break;
                    case 3:
                        string[] bebidas = { "CocaCola", "Fanta", "Agua", "Cerveza" };
                        ChooseDrinks(bebidas);
                        break;
                    case 4:
                        Salir();
                        break;
                }
            }

        }

        static void ShowMenu(string[] menu)
        {
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
        }

        static void ShowValoresDeMenu(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + arr[i]);
            }
        }

        static void ChooseHamburConPatatas(string[] valores)
        {
            ShowValoresDeMenu(valores);
            Console.WriteLine("Elige uno:");
            int res = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quiere Patata? (S / N)");

            bool patatas = YesOrNo(Console.ReadLine());
            if (patatas)
            {
                Console.WriteLine("Aqui tienes tu hamburgusa: " + valores[res - 1] + " con patatas");
            }
            else
            {
                Console.WriteLine("Aqui tienes tu hamburgusa: " + valores[res - 1]);
            }

        }

        static bool YesOrNo(string response)
        {
            if (response.ToLower() == "s")
                return true;
            else
                return false;
        }


        static void ChooseDrinks(string[] valores)
        {
            ShowValoresDeMenu(valores);
            Console.WriteLine("elija una: ");
            int res = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quiere que la bebida sea grande? (S / N)");
            if (YesOrNo(Console.ReadLine()))
                Console.WriteLine("Aquí tienes tu bebida " + valores[res - 1] + " grande");
            else
                Console.WriteLine("Aqui tienes tu bebida: " + valores[res - 1] + " mediana");
        }

        static void ChooseDrinks()
        {
            Console.WriteLine("Desea bebida? (S / N)");
            string resBebida = Console.ReadLine();
            if (resBebida.ToLower() == "s")
            {
                string[] drinks = { "CocaCola", "Fanta", "Agua", "Cerveza" };
                ShowValoresDeMenu(drinks);
                Console.WriteLine("elija una: ");
                int res = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quiere que la bebida sea grande? (S / N)");
                if (YesOrNo(Console.ReadLine()))
                    Console.WriteLine("Aquí tienes tu bebida " + drinks[res - 1] + " grande");
                else
                    Console.WriteLine("Aqui tienes tu bebida: " + drinks[res - 1] + " mediana");
            }
            else
            {
                Console.WriteLine("Su pedido prepara pronto...");
                Salir();
            }
        }

        static void Salir()
        {
            Console.WriteLine("Salidendo de la App...");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        //static void ChooseMenu(string[] valores)
        //{
        //    ShowValoresDeMenu(valores);
        //    Console.WriteLine("Elige uno:");
        //    int res = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Aqui tienes tu menu: " + valores[res - 1]);
        //}
    }
}
