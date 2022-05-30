using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace CO2_Interface.DBAccess
{
	class Reader
	{
		internal static void ReadUserTable(DataGridView Grid, string DB_Table)
		{
			Data.Tables.UserTable.Clear();

			OleDbCommand SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			int idColumn = 0;
			int usernameColumn = 2;
			int passwordColumn = 1;
			int accountTypeColumn = 3;

			try
			{
				Tools.connexion.Open();

				OleDbDataReader DBReader = SelectCommand.ExecuteReader();

				if (DBReader.HasRows)
				{
					while (DBReader.Read())
					{
						Data.Tables.UserTable.Rows.Add(new object[] { DBReader[idColumn], DBReader[usernameColumn], DBReader[passwordColumn], DBReader[accountTypeColumn] });
					}
				}

				DBReader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}

			Grid.DataSource = Data.Tables.UserTable;
			Grid.ClearSelection();
		}

		internal static void ReadAccountTable(DataGridView Grid , string DB_Table)
		{
			Data.Tables.AccessTable.Clear();

			OleDbCommand SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", Tools.connexion);

			int idColumn = 0;
			int accessNameColumn = 1;
			int allowCreateIdColumn = 2;
			int allowDestroyIdColumn = 3;
			int allowConfigAlarmColumn = 4;
			int userCreationColumn = 5;

			try
			{
				Tools.connexion.Open();

				OleDbDataReader DBReader = SelectCommand.ExecuteReader();

				if (DBReader.HasRows)
				{
					while (DBReader.Read())
					{
						Data.Tables.AccessTable.Rows.Add(new object[] { DBReader[idColumn], DBReader[accessNameColumn], DBReader[allowCreateIdColumn], DBReader[allowDestroyIdColumn], DBReader[allowConfigAlarmColumn], DBReader[userCreationColumn]}); ;
					}
				}

				DBReader.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}

			Grid.DataSource = Data.Tables.AccessTable;
			Grid.ClearSelection();
		}
	}
}
