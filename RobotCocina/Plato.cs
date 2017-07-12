using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
	public class Plato
	{
		private Alimento alimento1;
		private Alimento alimento2;
		//public String NombrePlato;

		public Plato(Alimento _alimento1, Alimento _alimento2)
		{
			alimento1 = _alimento1;
			alimento2 = _alimento2;

			//NombrePlato = "" + _alimento1 + _alimento2;
		}

		public override bool Equals(object obj)
		{
			if(obj == null)
			{
				return false;
			}

			if (!this.GetType().Equals(obj.GetType()))
			{
				return false;
			}

			if (this.alimento1 == null && ((Plato)obj).alimento1 != null)
			{
				return false;
			}

			if (this.alimento1 != null && this.alimento1.Equals( ((Plato)obj).alimento1 ))
			{
				return false;
			}

			if (this.alimento2 == null && ((Plato)obj).alimento2 != null)
			{
				return false;
			}

			if (this.alimento2 != null && this.alimento2.Equals(((Plato)obj).alimento2))
			{
				return false;
			}
			return base.Equals(obj);
		}
	}

}
