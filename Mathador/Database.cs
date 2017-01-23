using System;
using System.Data;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Mathador
{

	public class Database
	{
        
        private string name_db = @"Data Source=file:Mathador.db";

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



			using ( SqlConnection con = new SqlConnection(name_db) )
			{
			    if (con.State == ConnectionState.Closed)
			    {
                    con.Open();
                }

				Console.WriteLine("Database > DB opened !");

				using (SqlCommand cmd = new SqlCommand())
				{ 
					cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Users(pseudo VARCHAR(255), highscore INT, games_nb INT)";
					cmd.ExecuteNonQuery();
					Console.WriteLine("Database > Table Users created");

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
			using (SqlConnection con = new SqlConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "INSERT INTO Users (pseudo, highscore, games_nb) VALUES (@p, @hg, @gn)";
				SqlCommand insertSQL = new SqlCommand(command, con);
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
			using (SqlConnection con = new SqlConnection(name_db))
			{
				con.Open();
				Console.WriteLine("Database > DB opened !");

				string command = "UPDATE Users SET highscore = @hg, games_nb= @gn WHERE pseudo= @p";
				SqlCommand updateSQL = new SqlCommand(command, con);
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
