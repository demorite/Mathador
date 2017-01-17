using System;
using Mono.Data.Sqlite;

namespace Mathador
{

	public class Database
	{
		private string name_db = "Data Source=file:Mathador.db,version=3";

		//Constructor
		public Database()
		{
		}

		//Create the database of Mathador
		public void createDB()
		{



			using (SqliteConnection con = new SqliteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				using (SqliteCommand cmd = new SqliteCommand(con))
				{ 

					cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Users(pseudo VARCHAR(255), highscore INT, games_nb INT)";
					cmd.ExecuteNonQuery();
					Console.WriteLine("Database > Table Users created");

				}

				con.Close();
				Console.WriteLine("Database > DB closed !");
			}
		}

		public void insert(User user)
		{
			using (SqliteConnection con = new SqliteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "INSERT INTO Users (pseudo, highscore, games_nb) VALUES (?,?,?)";
				SqliteCommand insertSQL = new SqliteCommand(command, con);
				insertSQL.Parameters.Add(user.pseudo);
				insertSQL.Parameters.Add(user.highscore);
				insertSQL.Parameters.Add(user.games_nb);

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


		public void update(User user)
		{
			using (SqliteConnection con = new SqliteConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "UPDATE Users SET highscore = @hg, games_nb= @gn WHERE pseudo= @p";
				SqliteCommand updateSQL = new SqliteCommand(command, con);
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
