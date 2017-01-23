using System;
using System.Data.SQLite;

namespace Mathador
{

	public class Database
	{

        private string name_db = "URI=file:mathador.db";

        //Constructor
        public Database()
		{
		}


		/*
		 * Create the database of Mathador
		 * 
         * @function: createDB
         * @parameter: 
         * 
         */
		public void createDB()
		{

			using (SQLiteConnection con = new SQLiteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users(pseudo VARCHAR(255), highscore INT, games_nb INT)", con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Database > Table Users created");
                    }
				}
                catch
                {

                    Console.WriteLine("Database > Table Users not created");
                }
				con.Close();
				Console.WriteLine("Database > DB closed !");
			}
		}

		/*
		 * Insert the user in the DB
		 * 
         * @function: insert
         * @parameter: 
         * User user -> user object
         * 
         */

		public void insert(User user)
		{
			using (SQLiteConnection con = new SQLiteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "INSERT INTO Users (pseudo, highscore, games_nb) VALUES (@p, @hg, @gn)";
				SQLiteCommand insertSQL = new SQLiteCommand(command, con);
				insertSQL.Parameters.AddWithValue("@p", user.pseudo);
				insertSQL.Parameters.AddWithValue("@hg", user.highscore);
				insertSQL.Parameters.AddWithValue("@gn", user.games_nb);

				try
				{
					insertSQL.ExecuteNonQuery();
					Console.WriteLine("Database > User "+user.pseudo+" inserted !");
					con.Close();
					Console.WriteLine("Database > DB closed !");
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}


		/*
		 * Update the user in the DB
		 * 
         * @function: update
         * @parameter: 
         * User user -> user object
         * 
         */

		public void update(User user)
		{
			using (SQLiteConnection con = new SQLiteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "UPDATE Users SET highscore = @hg, games_nb= @gn WHERE pseudo= @p";
				SQLiteCommand updateSQL = new SQLiteCommand(command, con);
				updateSQL.Parameters.AddWithValue("@hg", user.highscore);
				updateSQL.Parameters.AddWithValue("@gn", user.games_nb);
				updateSQL.Parameters.AddWithValue("@p", user.pseudo);

				try
				{
					updateSQL.ExecuteNonQuery();
					Console.WriteLine("Database > User " + user.pseudo + " updated !");
					con.Close();
					Console.WriteLine("Database > DB closed !");
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		
		}

	}
}
