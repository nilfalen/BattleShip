using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
// The different AI levels.
public enum AIOption
{
	// Easy, total random shooting
	Easy,

	// Medium, marks squares around hits
	Medium,

	// As medium, but removes shots once it misses
	Hard
}