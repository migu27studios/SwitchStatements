using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		
		int number;
		switch (number) 
		{
		case 1:
			Console.Writeline ("Choose your weapons!");
			break;

		case 2:
			Console.WriteLine ("Choose your team!");
			break;

		case 3:
			Console.WriteLine ("Choose your players!");
			break;

		case 4:
			Console.WriteLine ("Choose your league!");
			break;

		case 5:
			Console.WriteLine ("Choose your color!");
			break;

		case 6: 
			Console.WriteLine ("Choose your allies!");
			break;

		case 7:
			Console.WriteLine ("Choose your location!");
			break;

		case 8:
			Console.WriteLine ("Choose your culture!");
			break;

		case 9: 
			Console.WreiteLine ("Choose your main weapon!");
			break;

		case 10:
			Console.WriteLine ("Choose your beacon!");
			break;

		}
	}
}
