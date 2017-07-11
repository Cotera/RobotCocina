using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCocina;

namespace RobotCocinaTest
{
	[TestClass]
	public class TurboMixTest
	{
		Alimento al1;
		Alimento al2;

		Plato plato;

		TurboMix turboMix;

		[TestInitialize]
		public void IncializarTest()
		{
			al1 = new Alimento();
				al1.peso = 3;
			al2 = new Alimento();
				al2.peso = 12;

			turboMix = new TurboMix();
		}

		[TestMethod]
		public void TestCocinar()
		{
			
			al1.calentado = true;
			
			al2.calentado = true;
		}

		[TestMethod]
		public void TestPesarAlimento()
		{
			Assert.AreEqual( turboMix.PesarAlimento(al1), al1.peso );

			Assert.AreEqual( turboMix.PesarAlimento(al2), al2.peso );
		}

		[TestMethod]
		public void TestCalentar()
		{
			Assert.IsFalse( al1.calentado );
			Assert.IsFalse( al2.calentado );

			Plato plato = turboMix.Calentar(al1,al2);

			Assert.IsTrue(al1.calentado);
			Assert.IsTrue(al2.calentado);

			Assert.AreSame(plato.ingrediente1, al1);
			Assert.AreSame(plato.ingrediente2, al2);
		}
	}
}