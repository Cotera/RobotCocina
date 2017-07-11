using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCocina
{
    public class TurboMix
    {
		// Se coloca así para poder colocar cualquier implementación de IBascula e ICocina desde fuera.
		// Se puede hacer por Getters/setters o por Constructor. En Java es típico el GET/SET y en .Net
			// es típico el constructor. En éste caso, implementamos ambos al tiempo como ejemplo.
		public IBascula Bascula { get; set; }
		public ICocina Cocina { get; set; }

		public TurboMix(IBascula _Bascula, ICocina _Cocina)
		{
			this.Bascula = _Bascula;
			this.Cocina = _Cocina;
		}

		public Plato PesarYCocinar(Alimento ingrediente1, Alimento ingrediente2)
		{
			float Peso1 = Bascula.Pesar(ingrediente1);
			float Peso2 = Bascula.Pesar(ingrediente2);
			
			Cocina.Calentar(ingrediente1, ingrediente2);

			return new Plato(ingrediente1, ingrediente2);
		}
    }
}
