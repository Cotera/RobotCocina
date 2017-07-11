using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotCocina;

namespace RobotCocinaTest
{
	[TestClass]
	public class CocinaServiceTest
	{
		public void TestCalentar()
		{
			ICocina sut = new CocinaService();

			Alimento alimento1 = new Alimento();
			Alimento alimento2 = new Alimento();

			sut.Calentar(alimento1, alimento2);

			Assert.IsTrue(alimento1.Calentado);
			Assert.IsTrue(alimento2.Calentado);
		}
	}
}
