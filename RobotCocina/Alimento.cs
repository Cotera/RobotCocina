using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
	public class Alimento
	{
		public string Nombre { get; set; }
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
				// Normalmente se usan ambos: this.Peso = _Peso
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if ( !this.GetType().Equals(obj.GetType()) )
			{
				return false;
			}

			if( ((Alimento)obj).Nombre == null )
			{
				if (this.Nombre != null)
				{
					return false;
				}
			} else
			{
				if (!((Alimento)obj).Nombre.Equals(this.Nombre))
				{
					return false;
				}
			}

			return ((Alimento)obj).Calentado == this.Calentado && ((Alimento)obj).Peso == this.Peso ;
			
		}
	}
}
