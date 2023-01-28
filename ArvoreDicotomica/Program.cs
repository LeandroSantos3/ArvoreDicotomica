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

namespace ArvoreDicotomica
{
	class Program
{
		static void Main(String[] args)    
		{
			ArvoreDicotomica arv = new ArvoreDicotomica();
			
	
        while (true)
        {
        	Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Iniciar Novo Jogo");
            Console.WriteLine("2 - Mostrar o nome de todos os objetos possíveis de identificar até então");
//          Console.WriteLine("3 - Testar Nodo");
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
                    arv.Play();                    
                    break;
                    
                   case "2":
                   	
                	break;
                	
                	
//                	case "3":
////                	Nodo nodo1 = new Nodo("sou o nodo 1");
////                	Nodo nodo2 = new Nodo("sou o nodo 2");
////                	Nodo nodo3 = new Nodo("sou o nodo 3");
////                	nodo1.esq = nodo2;
////                	nodo1.dir = nodo3;
////                	//nodo1.dir= "dir";
////                	
////                	Console.WriteLine(nodo1.esq.raiz);
////                	Thread.Sleep(5000);
//                	break;
            	}
    		}
		}
	}
}
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
//                    
//                    Console.WriteLine("Escolha um objeto");
//                    String obj = Console.ReadLine().ToLower();
//                    Console.WriteLine("Que pergunta o retorna como sim?");
//                    String pergunta = Console.ReadLine();
//                    tree.Learn(obj,pergunta,"true");
//                    nodo.esq.pergunta = obj;
//                    Console.WriteLine("Que pergunta o retorna como não?");
//                    String pergunta2 = Console.ReadLine();
//                    nodo.dir.pergunta = pergunta2;
//                    Console.WriteLine("não - qual resposta?");
//                    String obj2 = Console.ReadLine().ToLower();
//                    nodo.dir.pergunta = obj2;                   
//            		                  
//                    Console.ReadKey();
//	                
//                    break;                   
//                    
//                    
//                case "2":
//                   
//                    break;
//                case "3":
//                    //TODO: add code to display tree
//                    
//            }
//        }
//		}}
//}
//	
//
//
