using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
	public class BasculaService : IBascula
	{
		public float Pesar (Alimento alimento)
		{
			return alimento.Peso;
		}
	}
}
