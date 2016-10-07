using NUnit.Framework;
using System;

namespace MyGame
{
	[TestFixture()]
	public class GameStatusTest
	{
		[Test ()]
		public void StateTest()
		{
			Assert.IsNotNull (GameState.AlteringSettings);
		}
	}
}

