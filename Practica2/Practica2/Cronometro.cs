/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 17/09/2013
 * Time: 06:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	
	public class Cronometro
	{
		public Cronometro()
		{
		}
		public void iniciar () {
		
		Console.Clear();

                    for (int h = 0; h < 60; h++) // Se inicializa Hora en 0
                    {
                      
                        for (int m = 0; m < 60; m++) // Minuto 0
                        {
                            for (int s = 0; s < 60; s++) // Segundo 0
                            {
                                    Console.WriteLine( "Cronometro \n\n\n0" + h + ":0" + m + ":0" + s) ;
                                    System.Threading.Thread.Sleep(1000); // Dividirlo entre 1000 milisegundos
                                    Console.Clear();
                                
	}
}
}
		}
	}
}
