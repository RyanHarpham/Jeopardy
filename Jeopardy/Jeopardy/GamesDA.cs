﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Jeopardy
{
    public class GamesDA
    {
        readonly static OleDbConnection conn = GamesConn.GetGamesConnection();

        public static List<Game> SelectAllGames()
        {
            List<Game> games = new List<Game>();

            string query = "SELECT * FROM games";
            OleDbCommand selectCommand = new OleDbCommand(query, conn);

            try
            {
                conn.Open();

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.GameName = Convert.ToString(reader["GameName"]);
                    game.QuestionTimeLimit = TimeSpan.FromTicks(Convert.ToInt32(reader["QuestionTimeLimit"]));

                    games.Add(game);
                }
                reader.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return games;
        }
    }
}
