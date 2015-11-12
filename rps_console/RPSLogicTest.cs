using NUnit.Framework;

[TestFixture]
public class RPSTests
{

	RPS game;

	[SetUp]
	public void GetReady()
	{
		game = new RPS ();
	}

	[TestCase("Rock","Scissors","Player One Wins")]
	[TestCase("Rock","Rock","It's a draw")]
	[TestCase("Rock","Paper","Player Two Wins")]
	[TestCase("Paper","Rock","Player One Wins")]
	[TestCase("Paper","Paper","It's a draw")]
	[TestCase("Paper","Scissors","Player Two Wins")]
	[TestCase("Scissors","Paper","Player One Wins")]
	[TestCase("Scissors","Scissors","It's a draw")]
	[TestCase("Scissors","Rock","Player Two Wins")]
	public void TwoPlayer(string playerOneWeapon, string playerTwoWeapon, string expected)
	{
		string result = game.TwoPlayer (playerOneWeapon, playerTwoWeapon);
		Assert.That (result, Is.EqualTo (expected));
	}
}

