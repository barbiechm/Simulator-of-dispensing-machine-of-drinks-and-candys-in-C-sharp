using System;

namespace Simulador
{ 
    
    //CLASE QUE ALMACENA LAS PROPIEDADES Y MÉTODOS PARA PODER PROVEER LAS BEBIDAS
    class BeverageCatalog
    {
        String cocaCola = "Cocacola: perfecta elección, aunque morirás pronto";
        String chinotto = "Chinotto, chinotto ¿Eres venezolano?";
        String café = "Café: Buena elección, delicioso";
        String fanta = "Fanta, es genial(wakala)";
        String colita = "Colita, eres venezolando ew";
        String té = "Té: Bien, es saludable de tu parte";



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
}

