/*
 * Created by SharpDevelop.
 * User: leand
 * Date: 16/01/2023
 * Time: 22:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;


namespace ArvoreDicotomica
{
	class ArvoreDicotomica
{
		
	
    public void Play()	
    {
    	Console.WriteLine("Pense num tema (sala de aulas) e um objecto...");
    	Console.WriteLine("Me faça uma pergunta e responda com (s)im ou (n)ao que vou aprendendo ;)");
    	String perguntaRaiz = Console.ReadLine();
    	
    	Nodo nodoRaiz = new Nodo(perguntaRaiz); // a raiz do nodo
    	Console.WriteLine("Qual seria o objecto se (s)im?");
    	String obj = Console.ReadLine();  //aprende o obj, por ser primeira vez  	
    		nodoRaiz.esq =  new Nodo(obj);
    	
    	Console.WriteLine("Qual seria o objecto se (n)ao?");
    	String obj1 = Console.ReadLine();
	    	nodoRaiz.dir = new Nodo(obj1);  
    		
        Nodo nodoAux = nodoRaiz;
        
        bool repeat = true;
        while(repeat)
        {
        	//Esse metodo irá percorrer sempre os nodos.raizes, pois se o mesmo tiver filhos é prq é uam pergunta
        	// senão continua a ser uma pergunta, então vamos de forma sucessiva percorrer todas as perguntas
        	
        	while(nodoAux.dir!=null || nodoAux.esq != null){
        			
        			Console.WriteLine(nodoAux.raiz);
        			String respostasSucessivas = Console.ReadLine(); 
        			
        			if(respostasSucessivas.ToLower()=="s" || respostasSucessivas.ToLower()=="sim" ){
        				
        				nodoAux = nodoAux.esq; // se for sim, ele passa para o proximo nnodo, que será a pergunta que irá deferenciar os dois filhos de baixo
        			}
        			else{
        				nodoAux = nodoAux.dir; // caso contrário
        			}
        			
        		}        	
        	
        	//Console.WriteLine("\n\nVamos jogar agora e mostrar o que aprendi .....");
        	Console.WriteLine("a resposta seria : --- " + nodoAux.raiz + " --- S/N  ?");
        	String resposta = Console.ReadLine();
			
        	if(resposta.ToLower()=="s" || resposta.ToLower()=="sim"){
        		
        		Console.WriteLine("Acertei.... :)");        
        	}
        	
    			// Aqui que começa o processo de aprendizagem
        	else{
    			
    			Console.WriteLine("Qual seria o objecto então?");
  				String diffObj = Console.ReadLine(); 
  				
  				Console.WriteLine("o que o torna diferente?");
        		String diff = Console.ReadLine();  
        		
        		Nodo novo = new Nodo(diffObj);
        		nodoAux.esq = novo;
        		nodoAux.dir = new Nodo(nodoAux.raiz);
        		nodoAux.raiz = diff;
//        		nodoAux.raiz = diff;				
//				nodoAux.esq = new Nodo(diffObj);
//				nodoAux.dir = new Nodo(nodoAux.raiz);
				
        		Console.WriteLine("Aprendi... um novo valor:)" );	
    			}
    			
        		
    			Console.WriteLine("Queres jogar de novo? [(S)/(N)ao)");
    			String again = Console.ReadLine(); 
	        		if(again == "n"){
    				
    				Console.WriteLine("Adeus...");
        			break; //para sair od while	            			
        			}    			
    				nodoAux=nodoRaiz;
	        }
		}
	}
}

