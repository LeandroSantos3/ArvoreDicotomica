/*
 * Created by SharpDevelop.
 * User: leand
 * Date: 16/01/2023
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArvoreDicotomica
{
	class Nodo 
	{
	    public String raiz{ get; set; } // nodo que guardará a info do nodo
	    public Nodo esq { get; set; }
	    public Nodo dir { get; set; }
	  	    
	    public Nodo(String raiz)
	    {
	        this.raiz = raiz;
	        this.esq = null;
	        this.dir = null;
	       
	    }
	}
}

