using System;

namespace rps_console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StartGame ();
		}

		public static void StartGame ()
		{
			Console.WriteLine ("Welcome to Rock, Paper, Scissors!");
			Console.WriteLine ("Player One, choose your weapon");
			string PlayerOneWeapon = Console.ReadLine();
			Console.WriteLine ("Player Two, choose your weapon");
			string PlayerTwoWeapon = Console.ReadLine();

			var game = new RPS ();
			Console.WriteLine (game.TwoPlayer (PlayerOneWeapon, PlayerTwoWeapon));
			StartGame ();
		}
	}
}
