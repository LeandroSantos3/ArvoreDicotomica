/*
 * Created by SharpDevelop.
 * User: leand
 * Date: 28/01/2023
 * Time: 20:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArvoreDicotomica
{
	[Serializable]
	/// <summary>
	/// Lista Ligada Simples usada em aulas e agora adaptada no trabalho
	/// </summary>
	public class ListaLigadaSimples
	{
		Nodo primeiro; 
		
		public ListaLigadaSimples()
		{
			primeiro = null;
		}

		/// <summary>
		/// A lista seria preenchida passando o primeiro valor para o fim da lista
		/// Pois quero sempre testar se o ultimo valor foi ou  nao colocado
		/// </summary>
		/// <param name="val"></param>
	    public void Adicionar(String val)
	    {
	        Nodo novo = new Nodo(val + "/ ->");
	        novo.proximo = primeiro;
	        primeiro = novo;
	    }
		
	    /// <summary>
	    /// Metodo que irá permitir que eu chame a lista e o apresente no Program
	    /// </summary>
	    public void Exibir()
	    {
	        Nodo atual = primeiro;
	        while (atual != null)
	        {
	            Console.Write(atual.raiz + " -> ");
	            atual = atual.proximo;
	        }
	        Console.WriteLine("null");
	    }
	    
	    /// <summary>
	    /// Usada em aulas e adaptada nesse trabalho
	    /// </summary>
	    /// <param name="lst">lista que vai ser criada</param>
	    /// <param name="nomeficheiro">o nome com o qual vai ser criada o txt pedido</param>
	  	public static void GravarDados(ListaLigadaSimples lst, String nomeficheiro)
		{
		  	 BinaryFormatter formatador = new BinaryFormatter();
		  	 FileStream ficheiro = new FileStream(nomeficheiro, FileMode.Create);
		  	 formatador.Serialize(ficheiro,lst);
		  	 ficheiro.Close();	  		
	    }

	 	/// <summary>
	    /// Usada em aulas e adaptada nesse trabalho
	    /// </summary>
	    /// <param name="nomeficheiro">o nome do ficheiro que vai ser carregada</param>
	  	
      	public static ListaLigadaSimples LerDados(String nomeficheiro)
		{
	      	ListaLigadaSimples lst = new ListaLigadaSimples();
		  	BinaryFormatter formatador = new BinaryFormatter();
		    FileStream ficheiro = new FileStream(nomeficheiro, FileMode.Open);
		    lst = (ListaLigadaSimples)formatador.Deserialize(ficheiro);
		    ficheiro.Close();
		    return lst;
		}
	    
	}			
}

