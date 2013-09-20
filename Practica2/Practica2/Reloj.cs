
using System;

namespace Practica2
{
	
	public class Reloj
	{
		public  Reloj()
		{
		}
		public void iniciar (){
			 for (; ; ) //Permite hacer un ciclo infinito e irse actualizando cada segundo
                    {
                        Console.Clear();
                        Console.WriteLine("Reloj \n");
                        Console.WriteLine(DateTime.Now); //Imprime la fecha y hora actual del sistema
                        System.Threading.Thread.Sleep(1000);//Genera una pausa en el programa de 1 segundo(1000 milisegundos)

                	Console.ReadKey ();
	}
}
}
}	

