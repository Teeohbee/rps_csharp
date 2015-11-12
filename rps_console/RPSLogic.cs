using System;

public class RPS
{
	static Random rnd = new Random ();

	string CPUWeapon()
	{
		string[] weapons = { "Rock", "Paper", "Scissors" };
		return weapons [rnd.Next (2)];
	}

	public string TwoPlayer(string playerOneWeapon = "", string playerTwoWeapon = "")
	{
		if (playerOneWeapon == String.Empty) 
		{
			playerOneWeapon = CPUWeapon ();
		}
		if (playerTwoWeapon == String.Empty) 
		{
			playerTwoWeapon = CPUWeapon ();
		}
		return Play (playerOneWeapon, playerTwoWeapon);
	}

	string Play (string playerOneWeapon, string playerTwoWeapon)
	{
		if (playerOneWeapon == playerTwoWeapon) {
			return "It's a draw";
		}
		else
			if (playerOneWeapon == "Rock") 
			{
				return PlayerOneRock (playerTwoWeapon);
			}
			else if (playerOneWeapon == "Paper") 
			{
				return PlayerOnePaper (playerTwoWeapon);
			}
			else 
			{
				return PlayerOneScissors (playerTwoWeapon);
			}
	}

	string PlayerOneRock (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Scissors") ? "Player One Wins" : "Player Two Wins";
	}

	string PlayerOnePaper (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Rock") ? "Player One Wins" : "Player Two Wins";
	}

	string PlayerOneScissors (string playerTwoWeapon)
	{
		return (playerTwoWeapon == "Paper") ? "Player One Wins" : "Player Two Wins";
	}
}
