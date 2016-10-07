using NUnit.Framework;
using System;

namespace MyGame
{
	[TestFixture ()]
	public class ShipUnitTest
	{
		[Test ()]
		public void ShipNameTest ()
		{
			Ship _tug;
			_tug = new Ship(ShipName.Tug);
			string expectationtug = "Tug";
			string actualtug = _tug.Name;
			Assert.AreEqual(expectationtug,actualtug);

			Ship _ac;
			_ac = new Ship(ShipName.AircraftCarrier);
			string expectationac = "Aircraft Carrier";
			string actualac = _ac.Name;
			Assert.AreEqual(expectationac,actualac);
		}

		[Test ()]
		public void ShipSizeTest ()
		{
			Ship _ship;
			_ship = new Ship(ShipName.Battleship);
			int expectation = 4;
			int actual = _ship.Size;
			Assert.AreEqual(expectation,actual);
		}

		[Test ()]
		public void ShipDestroyTest ()
		{
			bool expectation = true;

			Ship _ship;
			_ship = new Ship(ShipName.Destroyer);
			_ship.Hit ();
			_ship.Hit ();
			_ship.Hit ();
			bool actual = _ship.IsDestroyed;
			Assert.AreEqual(expectation,actual);
		}
	}
}

