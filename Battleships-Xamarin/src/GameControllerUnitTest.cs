using NUnit.Framework;
namespace MyGame
{
	[TestFixture]
	public class GameControllerUnitTest
	{
		[Test]
		public void StartGameTest () 
		{
			GameController.StartGame ();
			Assert.IsNotNull (GameController.HumanPlayer);
		}
		 
	}
}
