using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
	public class Alimento
	{
		public float Peso { get; set; }
		public bool Calentado { get; set; }

		public Alimento ()
		{
			Peso = 0;
			Calentado = false;
		}

		public Alimento (float Peso, bool _Calentado)
		{
			Calentado = _Calentado; // La barra baja es para diferenciar a la variable local del metodo.
			this.Peso = Peso; //Éste es la otra forma, se llaman igual, pero la vlariable global se referencia con this.
		}
	}
}
