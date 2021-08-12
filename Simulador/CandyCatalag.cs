using System;

namespace Simulador
{
    class CandyCatalag
    {

        string doritos = "Doritos: esta elección, junto a una coca cola, the best!",
        cheetos = "Cheetos: es lo mejor que puedes ordenar, tenemos de queso",
        paleta = "Paleta: genial, te endulza la vida",
        platanitos = "Platanitos: Nutritivo y light",
        barritaNutritiva = "Barrita de proteina: Es deliciosa y te llena de energia para todo el día :D",
        chocolate = "Chocolate: dulce y empalagoso, pero para gustos los colores";

        public void ShowCandys()
        {
            Console.WriteLine("\nDulces y chucherias x 0,50$ \n\n 7-.Doritos \n 8-.Cheetos \n 9.-Paleta 10-.Platanitos \n 11-.Barrita Nutritiva \n 12-.Chocolate");

        }

        public void ComprobarDulces(int entradaDulces)
        {
            switch (entradaDulces)
            {
                case 7:
                    Console.WriteLine(doritos);
                    break;
                case 8:
                    Console.WriteLine(cheetos);
                    break;
                case 9:
                    Console.WriteLine(paleta);
                    break;
                case 10:
                    Console.WriteLine(platanitos);
                    break;
                case 11:
                    Console.WriteLine(barritaNutritiva);
                    break;
                case 12:
                    Console.WriteLine(chocolate);
                    break;
                default:
                    Console.WriteLine("Por ahora solo poseemos estos productos");
                    break;
            }
        }
    }
}
