/*
 * Created by SharpDevelop.
 * User: leand
 * Date: 16/01/2023
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ArvoreDicotomica
{
	[Serializable]
	class Nodo 
	{
	    public String raiz{ get; set; } // string que guardará os valores
	    public Nodo esq { get; set; }	//apontador para a esq
	    public Nodo dir { get; set; }	//apontador para a dir
	    public Nodo proximo {get;set;} // nodo usado na lista ligada para saber o proximo
	       
	    public Nodo(String raiz)
	    {
	        this.raiz = raiz;
	        this.esq = null;
	        this.dir = null;
	        this.proximo = null;
	       
	    }
	}
}

