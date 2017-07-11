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

		public Plato(Alimento _alimento1, Alimento _alimento2)
		{
			alimento1 = _alimento1;
			alimento2 = _alimento2;
		}
	}
}
