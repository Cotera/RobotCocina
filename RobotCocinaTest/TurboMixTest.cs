using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCocina;

namespace RobotCocinaTest
{
	[TestClass]
	public class TurboMixTest
	{
		[TestMethod]
		public void PesarYCocinar()
		{
			TurboMix sut = new TurboMix(null, null);
			Alimento alimento1 = new Alimento();
			alimento1.Peso = 1.5F;

			Alimento alimento2 = new Alimento();
			alimento2.Peso = 5F;

			Plato resultado = sut.PesarYCocinar(alimento1, alimento2);
			Plato mPlato = new Plato(alimento1, alimento2);

			Assert.IsTrue(mPlato.Equals(resultado) );
		}
		
	}
}