/*
 * Created by SharpDevelop.
 * User: Aula1
 * Date: 17/09/2013
 * Time: 06:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;


namespace Practica2
{
	
	 class Program
	{
		static void Main (string [] args){
			
		int opc;
		Console.WriteLine("Menu \n\n 1.Reloj \n 2.Cronometro");
		opc = int.Parse(Console.ReadLine());
		switch(opc){
			case 1: 
				Reloj r=new Reloj ();
				r.iniciar ();
				break;
			case 2: 
				Cronometro c=new Cronometro ();
				c.iniciar ();
					break;
		}
		/*for (int h=0; h<=24; h++){
			for(int m=0; m<=60; m++){
				for(int s=0; s<=60; s++){
				}
			}
				}
		Console.WriteLine(h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00"));
		System.Threading.Thread.Sleep(1000);
		Console.Clear();*/
		}
	}
}

