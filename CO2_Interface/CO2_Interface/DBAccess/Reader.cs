using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace CO2_Interface.DBAccess
{
	class Reader
	{
		internal static void Read(DataGridView Grid, string DB_Table)
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
		}
	}
}
