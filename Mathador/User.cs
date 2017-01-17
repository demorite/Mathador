using System;
namespace Mathador
{
	public class User
	{
		public string pseudo;
		public int highscore;
		public int games_nb;

		//Constructor
		public User()
		{
			this.pseudo = "test";
			this.highscore = 0;
			this.games_nb = 0;
		}

		public User(string p)
		{ 
			this.pseudo = p;
			this.highscore = 0;
			this.games_nb = 0;
		}
	}
}
