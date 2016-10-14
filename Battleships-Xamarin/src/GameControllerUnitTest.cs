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

		[Test]
		public void EndDeploymentTest ()
		{
			GameController.StartGame ();
			GameController.EndDeployment ();
			Assert.IsNotNull (GameController.HumanPlayer);
		}

		[Test]
		public void SetDifficultyTest ()
		{
			GameController.EndCurrentState ();
			Assert.AreEqual (GameState.ViewingMainMenu, GameController.CurrentState);
		}

	}
}
