using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

// The GameController is responsible for controlling the game,
// managing user input, and displaying the current state of the
// game.
public static class GameController
{
    


    private static BattleShipsGame _theGame;
	private static Player _human;
	private static AIPlayer _ai;
	private static Stack<GameState> _state = new Stack<GameState>();
	private static AIOption _aiSetting;
	private static bool isHuman = false;

    //create a list to store attacked spot
    private static IList<Point> attackedPoints = new List<Point>();

    //create a point class
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    //create an isAttacked function
    private static bool isAttacked(int row, int col)
    {
        foreach (var p in attackedPoints)
        {
            if (p.X == row && p.Y == col)
            {
                return true;
            }
        }

        return false;
    }

    // Gets the player to attack the indicated row and column.
    // Checks the attack result once the attack is complete
    public static void Attack(int row, int col)
    {
        //if (isAttacked(row, col))
        //{
        //    return false;
        //}

        attackedPoints.Add(new Point(row, col));
        AttackResult result = default(AttackResult);
        result = _theGame.Shoot(row, col);
        CheckAttackResult(result);
    }

    // Returns the current state of the game, indicating which screen is
    // currently being used

    public static GameState CurrentState {
		get { return _state.Peek(); }
	}

	public static bool IsHuman {
		get { return isHuman; }
	}

	// Returns the human player.
	public static Player HumanPlayer {
		get { return _human; }
	}

	// Returns the computer player.
	public static Player ComputerPlayer {
		get { return _ai; }
	}

	static GameController()
	{
		// bottom state will be quitting, if player exits main menu then the game is over
		_state.Push(GameState.Quitting);

		// at the start the player is viewing the main menu
		_state.Push(GameState.ViewingMainMenu);
	}

	// Starts a new game.
	// Creates an AI player based upon the _aiSetting.
	public static void StartGame()
	{
		if (_theGame != null)
			EndGame();

		// Create the game
		_theGame = new BattleShipsGame();

		// create the players
		switch (_aiSetting) {
		case AIOption.Easy:
			_ai = new AIEasyPlayer(_theGame);
			break;
		case AIOption.Medium:
			_ai = new AIMediumPlayer(_theGame);
			break;
		case AIOption.Hard:
			_ai = new AIHardPlayer(_theGame);
			break;
		default:
			_ai = new AIHardPlayer(_theGame);
			break;
		}

		_human = new Player(_theGame);

		_human.PlayerGrid.Changed += GridChanged;
		_ai.PlayerGrid.Changed += GridChanged;
		_theGame.AttackCompleted += AttackCompleted;

		AddNewState(GameState.Deploying);
	}

	// Stops listening to the old game once a new game is started
	private static void EndGame()
	{
		_human.PlayerGrid.Changed -= GridChanged;
		_ai.PlayerGrid.Changed -= GridChanged;
		_theGame.AttackCompleted -= AttackCompleted;
	}

	// Listens to the game grids for any changes and redraws the screen
	// when the grids change
	private static void GridChanged(object sender, EventArgs args)
	{
		DrawScreen();
		SwinGame.RefreshScreen();
	}

	private static void PlayHitSequence(int row, int column, bool showAnimation)
	{
		if (showAnimation) {
			UtilityFunctions.AddExplosion(row, column);
		}

		Audio.PlaySoundEffect(GameResources.GameSound("Hit"));

		UtilityFunctions.DrawAnimationSequence();
	}

	private static void PlayMissSequence(int row, int column, bool showAnimation)
	{
		if (showAnimation) {
			UtilityFunctions.AddSplash(row, column);
		}

		Audio.PlaySoundEffect(GameResources.GameSound("Miss"));

		UtilityFunctions.DrawAnimationSequence();
	}

	// Listens for attacks to be completed.
	// Displays a message, plays sound and redraws the screen
	private static void AttackCompleted(object sender, AttackResult result)
	{
		isHuman = object.ReferenceEquals(_theGame.Player, HumanPlayer);

		if (isHuman) {
			UtilityFunctions.Message = "You " + result.ToString();
		} else {
			UtilityFunctions.Message = "The AI " + result.ToString();
		}

		switch (result.Value) {
		case ResultOfAttack.Destroyed:
			PlayHitSequence(result.Row, result.Column, isHuman);
			Audio.PlaySoundEffect(GameResources.GameSound("Sink"));

			break;
		case ResultOfAttack.GameOver:
			PlayHitSequence(result.Row, result.Column, isHuman);
			Audio.PlaySoundEffect(GameResources.GameSound("Sink"));

			while (Audio.SoundEffectPlaying(GameResources.GameSound("Sink"))) {
				SwinGame.Delay(10);
				SwinGame.RefreshScreen();
			}

			if (HumanPlayer.IsDestroyed) {
				Audio.PlaySoundEffect(GameResources.GameSound("Lose"));
			} else {
				Audio.PlaySoundEffect(GameResources.GameSound("Winner"));
			}

			break;
		case ResultOfAttack.Hit:
			PlayHitSequence(result.Row, result.Column, isHuman);
			break;
		case ResultOfAttack.Miss:
			PlayMissSequence(result.Row, result.Column, isHuman);
			break;
		case ResultOfAttack.ShotAlready:
			Audio.PlaySoundEffect(GameResources.GameSound("Error"));
			break;
		}
	}

	// Completes the deployment phase of the game and
	// switches to the battle mode (Discovering state)
	// This adds the players to the game before switching
	// state.
	public static void EndDeployment()
	{
		// deploy the players
		_theGame.AddDeployedPlayer(_human);
		_theGame.AddDeployedPlayer(_ai);

		SwitchState(GameState.Discovering);
	}



    

	// Gets the AI to attack.
	// Checks the attack result once the attack is complete.
	private static void AIAttack()
	{
		AttackResult result = default(AttackResult);
		result = _theGame.Player.Attack();
		CheckAttackResult(result);
	}

	// Checks the results of the attack and switches to
	// Ending the Game if the result was game over.
	// attack
	// Gets the AI to attack if the result switched
	// to the AI player.
	private static void CheckAttackResult(AttackResult result)
	{
		switch (result.Value) {
		case ResultOfAttack.Miss:
			if (object.ReferenceEquals(_theGame.Player, ComputerPlayer))
				AIAttack();
			break;
		case ResultOfAttack.GameOver:
			SwitchState(GameState.EndingGame);
			break;
		}
	}

	// Handles the user SwinGame.
	// Reads key and mouse input and converts these into
	// actions for the game to perform. The actions
	// performed depend upon the state of the game.
	public static void HandleUserInput()
	{
		// Read incoming input events
		SwinGame.ProcessEvents();

		switch (CurrentState) {
		case GameState.ViewingMainMenu:
			MenuController.HandleMainMenuInput();
			break;
		case GameState.ViewingGameMenu:
			MenuController.HandleGameMenuInput();
			break;
		case GameState.AlteringSettings:
			MenuController.HandleSetupMenuInput();
			break;
		case GameState.Deploying:
			DeploymentController.HandleDeploymentInput();
			break;
		case GameState.Discovering:
			DiscoveryController.HandleDiscoveryInput();
			break;
		case GameState.EndingGame:
			EndingGameController.HandleEndOfGameInput();
			break;
		case GameState.ViewingHighScores:
			HighScoreController.HandleHighScoreInput();
			break;
		}

		UtilityFunctions.UpdateAnimations();
	}

	// Draws the current state of the game to the screen.
	// What is drawn depends upon the state of the game.
	public static void DrawScreen()
	{
		UtilityFunctions.DrawBackground();

		switch (CurrentState) {
		case GameState.ViewingMainMenu:
			MenuController.DrawMainMenu();
			break;
		case GameState.ViewingGameMenu:
			MenuController.DrawGameMenu();
			break;
		case GameState.AlteringSettings:
			MenuController.DrawSettings();
			break;
		case GameState.Deploying:
			DeploymentController.DrawDeployment();
			break;
		case GameState.Discovering:
			DiscoveryController.DrawDiscovery();
			break;
		case GameState.EndingGame:
			EndingGameController.DrawEndOfGame();
			break;
		case GameState.ViewingHighScores:
			HighScoreController.DrawHighScores();
			break;
		}

		UtilityFunctions.DrawAnimations();

		SwinGame.RefreshScreen();
	}

	// Move the game to a new state. The current state is maintained
	// so that it can be returned to.
	public static void AddNewState(GameState state)
	{
		_state.Push(state);
		UtilityFunctions.Message = "";
	}

	// End the current state and add in the new state.
	public static void SwitchState(GameState newState)
	{
		EndCurrentState();
		AddNewState(newState);
	}

	// Ends the current state, returning to the prior state
	public static void EndCurrentState()
	{
		_state.Pop();
	}

	// Sets the difficulty for the next level of the game.
	public static void SetDifficulty(AIOption setting)
	{
		_aiSetting = setting;
	}

}

