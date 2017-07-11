using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
    public class TurboMix
    {
		public void Cocinar(Alimento ingrediente1, Alimento ingrediente2)
		{
			PesarAlimento(ingrediente1);
			PesarAlimento(ingrediente2);

			
		}

		public int PesarAlimento(Alimento alimento)
		{
			return alimento.peso;
		}

		public Plato Calentar(Alimento ingrediente1, Alimento ingrediente2)
		{
			Plato plato = new Plato();

			ingrediente1.calentado = true;
			ingrediente2.calentado = true;

			plato.ingrediente1 = ingrediente1;
			plato.ingrediente2 = ingrediente2;

			return plato;
		}
    }

	public class Alimento
	{
		public int peso { get; set; }
		public bool calentado { get; set; } = false;
	}

	public class Plato
	{
		public Alimento ingrediente1 { get; set; }
		public Alimento ingrediente2 { get; set; }
	}
}
