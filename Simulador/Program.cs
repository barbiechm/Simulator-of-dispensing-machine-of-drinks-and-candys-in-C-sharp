using System;

namespace Simulador
{         
  
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

                CandyCatalag muestraDulces = new CandyCatalag(); //candyCatalog
                
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


