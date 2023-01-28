/*
 * Created by SharpDevelop.
 * User: leand
 * Date: 16/01/2023
 * Time: 21:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.IO;

namespace ArvoreDicotomica
{
	class Program
{
		static void Main(String[] args)    
		{
			ArvoreDicotomica arv = new ArvoreDicotomica();
			ListaLigadaSimples lst = new ListaLigadaSimples();
			
	
        while (true)
        {
        	Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Iniciar Novo Jogo - já guardando na listagem");
            Console.WriteLine("2 - Mostrar o nome de todos os objetos possíveis de identificar até então - guardados na listagem");
            Console.WriteLine("0- Sair");

            String choice = Console.ReadLine();
				
            switch (choice)
            {            		
            		
                case "0":
            		Console.WriteLine("Obrigado pelo tempo... :) ");
            		Thread.Sleep(1000);
            		Console.WriteLine("Saindo ...");
            		Thread.Sleep(3000);
                    return;
                case "1":  
                                        
                    lst = arv.Play();
					Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey(); 
                    break;
                    
                   case "2":
                    Console.WriteLine("Os objectos identificados até ao momento:");
                    lst.Exibir();
                    Console.WriteLine("Digite algo para continuar...");
                    Console.ReadKey(); 
                	break;
             	}
    		}
		}
	}
}