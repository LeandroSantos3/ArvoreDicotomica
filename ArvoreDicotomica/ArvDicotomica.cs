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
	[Serializable]
	
	class ArvoreDicotomica
{
		
		/// <summary>
		/// Arvore Dicotómica de aprendizado - jogando e aprendendo....
		/// </summary>
		/// <returns></returns>
		/// <param name="nodoRaiz">Nodo raiz da arvore criada</param>
		/// <param name="nodoRaiz.esq">nodo à esquerda - representa o sim</param>
		/// <param name="nodoRaiz.dir">Nodo à direita - representa o não</param>	
		/// <param name="nodoAux">Nodo auxiliar que percorreria a sequencia de nodos</param>
		/// <param name="lst">lista ligada simple que guarda os valores da árvore</param>
		
    public ListaLigadaSimples Play()	
    {
    	
    	ListaLigadaSimples lst = new ListaLigadaSimples();  // lista ligada que guardará os valores 	
    	
    	
    	//Esse troço de código só será executado na primeira vez, para termos uma mini-arvore de modo a que possa iniciar o jogo e assim poder me orientar
     	// a atribuição de nodos
    	
    	Console.WriteLine("Pense num tema (sala de aulas) e num objecto...");
    	Console.WriteLine("Me faça uma pergunta e responda com (s)im ou (n)ao ; Que vou aprendendo ao longo do jogo ;)");
    	String perguntaRaiz = Console.ReadLine(); // a pergunta que daria inicio ao tema
    	
    	Nodo nodoRaiz = new Nodo(perguntaRaiz); // a raiz do nodo terá a perguntaRaiz - assim seria de um tema de inteeresse do user - tornando-o mais intuitivo
    	Console.WriteLine("Qual seria o objecto se a resposta fosse (s)im?");
    	String obj = Console.ReadLine();   	
    		
    	nodoRaiz.esq =  new Nodo(obj); //novo valor adicionado no nodo.esq
		lst.Adicionar(nodoRaiz.esq.raiz); // adiciona o obj aprendido na lista Ligada
    	
    	Console.WriteLine("Qual seria o objecto se a resposta fosse (n)ao?");
    	String obj1 = Console.ReadLine();
    		
    	nodoRaiz.dir = new Nodo(obj1);  // novo valor adicionado no nodo.dir
		lst.Adicionar(nodoRaiz.dir.raiz); //adiciona o obj aprendido na lista ligada
    		
        Nodo nodoAux = nodoRaiz; //seria o mesmo raciocinio em aulas para termos um nodoAux para percorrer a arvore
        
        while(true) // repete sempre - loop infinito
        {
        	//Esse metodo irá percorrer sempre os nodos.raizes, pois se o mesmo tiver filhos é prq é uam pergunta
        	// senão continua a ser uma pergunta, então vamos de forma sucessiva percorrer todas as perguntas
        	
        	while(nodoAux.dir!=null || nodoAux.esq != null) // aqui ele procura sempre até encontrar um nodo folha(filho) que não teria novos filhos ainda
        													// caso a encontre passaria para a linha 78
        	{        			
        			Console.WriteLine(nodoAux.raiz); // sempre faria a pergunta, até encontrar o nodo filho, caso não seja um filho passaria pra próxima
        			String respostasSucessivas = Console.ReadLine(); 
        			
        			if(respostasSucessivas.ToLower()=="s" || respostasSucessivas.ToLower()=="sim" )
        			{
        				
        				nodoAux = nodoAux.esq; // se for sim, ele passa para o proximo nnodo, que será a pergunta que irá deferenciar os dois filhos de baixo
        			}
        			else
        			{
        				nodoAux = nodoAux.dir; // caso contrário
        			}        			
    		}        	
        	
    	Console.WriteLine("a resposta seria : --- " + nodoAux.raiz + " --- (s)im/(n)ão  ?"); //testa a primeira solução - que estaria na raiz no nodo
    	String resposta = Console.ReadLine();													 // caso não seja essa passaria para a linha 86 - para aprender o valor
			
        	if(resposta.ToLower()=="s" || resposta.ToLower()=="sim")
        	{        		
        		Console.WriteLine("Acertei.... :)");        
        	}        	
			// Aqui que começa o processo de aprendizagem
        	else
        	{    			
    			Console.WriteLine("Qual seria o objecto então?"); // isso tornaria o nodo filho - esq.raiz
  				String diffObj = Console.ReadLine(); 
  				
  				Console.WriteLine("A pergunta que as diferencie"); // isso tornaria o nodo pergunta -  nodo.raiz
        		String diff = Console.ReadLine();  
        		
        		Nodo aux = new Nodo(diffObj); //criar um nodo aux para passarmos o novo valor, senão a perderiamos
        		lst.Adicionar(diffObj); // adiciona o novo obj aprendido
        		nodoAux.esq = aux; // igualando o valor
        		nodoAux.dir = new Nodo(nodoAux.raiz); //criei um novo nodo que seria o da dir, mas teria como valor o valor que antes estava na esq
        		nodoAux.raiz = diff; // tenho que resetar a raiz, de modo a que tenha a pergunta que diferencie os dois valores
				
        		
        		Console.WriteLine("Aprendi... um novo valor e o adicionei à listagem:)" );	        		
    			}   			
        		
    			Console.WriteLine("Queres jogar de novo? (s)im/(n)ão)");
    			String again = Console.ReadLine(); 
	        		if(again == "n" || again == "nao" || again == "não")
	        		{    				
    					Console.WriteLine("Adeus...mas antes vamos guardar os dados aprendidos na listagem");
    					break;//para sair do while
        			}
	        		
        		Console.Clear(); // simplementee para tornar o ambienta mais agradevél
        		Console.WriteLine("Já estou aprendendo...só apaguei o menu anterior para ver se lembras do valor ou se eu lembro ;)");
        		Thread.Sleep(1000);
				nodoAux=nodoRaiz; // isso seria o mais importante - pois teria que resetar o nodo, de modo a que quando voltasse no loop ele possa começar com a
								 // perguntaRaiz - senão ele apresentaria a ultima pergunta que fiz e não a sequencia de nodos para chegar aos resultados
	        }
        ListaLigadaSimples.GravarDados(lst,"objectos.arv"); // guarda no ficheiro usando a serialização binária
        return lst; // retorna a lista que será usada para posterior consulta no Program
    	}
	}   
}

