using System;

namespace Simulador
{          //CLASE QUE ALMACENA LAS PROPIEDADES Y MÉTODOS PARA PODER PROVEER LAS BEBIDAS
    class BeverageCatalog
    {
         const String cocaCola = "Cocacola: perfecta elección, aunque morirás pronto";
         const String chinotto = "Chinotto, chinotto ¿Eres venezolano?";
         const String café = "Café: Buena elección, delicioso";
         const String fanta = "Fanta, es genial(wakala)";
         const String colita = "Colita, eres venezolando ew";
         const String té = "Té: Bien, es saludable de tu parte";

  

        //Aca se muestra en pantalla las bebidas disponibles
        public void ShowBeverage()
        { 

         Console.WriteLine("Hola amiguito, esta es una máquina dispensadora comun y corriente ¿Qué te apetece?");
         Console.WriteLine("Tenemos bebidas, y chucherias.\n\n Bebidas x 0,50$: \n\n 1.-CocaCola \n 2.-chinotto \n 3.-café \n 4.-fanta \n 5.-colita \n 6.-té");

        }
       //en este método se comprobará mediante un bucle lo que el usuario decida
        public void ComprobarBebidas(int entradaBebidas) 
        {
       
                switch (entradaBebidas)
                {
                    case 1:
                        Console.WriteLine(cocaCola);
                        break;
                    case 2:
                        Console.WriteLine(chinotto);
                        break;
                    case 3:
                        Console.WriteLine(café);
                        break;
                    case 4:
                        Console.WriteLine(fanta);
                        break;
                    case 5:
                        Console.WriteLine(colita);
                        break;
                    case 6:
                        Console.WriteLine(té);
                        break;
                    default:
                        Console.WriteLine("Por ahora solo poseemos estos productos");
                        break;
                }
        }      
       
    }

    class candyCatalog
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

    class Program
    {
        static void Main(string[] args) //EN EL MÉTODO MAIN SE ENCUENTRAN AMBAS INTANCIAS: LA QUE MUESTRA LOS PRODUCTOS, Y LA QUE HACE QUE EL USUARIO LOS DECIDA
        {
            int opcion = 0, opcion2 = 0, contadorPrecio= 0;
            do //ESTE BUCLE SE ENCARGA DE REPETIR EL PROCESO EVALUANDO LOS MÉTODOS DENTRO DE LAS INSTANCIAS DE CLASE
            {
                Console.Clear();//LIMPIA PANTALLA

                BeverageCatalog mostraCatalogo = new BeverageCatalog(); //Beverage catalog

                mostraCatalogo.ShowBeverage();  //muestra catalogo
                mostraCatalogo.ComprobarBebidas(Convert.ToInt32(Console.ReadLine())); //evalua lo que elige el usuario

                candyCatalog muestraDulces = new candyCatalog(); //candyCatalog
                
                muestraDulces.ShowCandys(); //muestra las chucherias
                muestraDulces.ComprobarDulces(Convert.ToInt32(Console.ReadLine())); //ingresa y evalua lo que elige el usuario

                Console.WriteLine("Si quieres salir y recibir el total de tu compra presiona 2. Si quieres continuar, presiona 1");

                opcion = Convert.ToInt32(Console.ReadLine());

                contadorPrecio++; //suma los precios
            } while (opcion == 1 || opcion2 == 1);

            Console.WriteLine($"Total a pagar en $ = {contadorPrecio}");//entrega el total 
        }

    }

}


