using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
// The result of an attack.
public enum ResultOfAttack
{
	// The player hit something
	Hit,

	// The player missed
	Miss,

	// The player destroyed a ship
	Destroyed,

	// That location was already shot.
	ShotAlready,

	// The player killed all of the opponents ships
	GameOver
}

