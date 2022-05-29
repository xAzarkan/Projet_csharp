using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.DBAccess
{
	internal class Adapter
	{
		internal static void Insert(string username, string password, string accountType)
		{
			int passwordColumn = 0;
			int usernameColumn = 1;
			int accountTypeColumn = 2;

			Tools.Adapter.InsertCommand.Parameters[passwordColumn].Value = password;
			Tools.Adapter.InsertCommand.Parameters[usernameColumn].Value = username;
			Tools.Adapter.InsertCommand.Parameters[accountTypeColumn].Value = accountType;

			try
			{
				Tools.connexion.Open();

				int buffer = Tools.Adapter.InsertCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully inserted");
				else MessageBox.Show("User not inserted");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Delete(String Name)
		{
			/*Adapter.DeleteCommand.Parameters[0].Value = Name;

			try
			{
				connexion.Open();

				int buffer = Adapter.DeleteCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully deleted");
				else MessageBox.Show("User not found");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				connexion.Close();
			}*/
		}
		internal static void Fill(DataSet dataset, string TableName, string DB_Table, DataGridView Grid)
		{
			dataset.Tables[TableName].Clear();

			Tools.Adapter.SelectCommand = new OleDbCommand("SELECT * FROM " + DB_Table + ";", Tools.connexion);

			try
			{
				Tools.connexion.Open();

				Tools.Adapter.Fill(dataset.Tables[TableName]);

				Grid.DataSource = dataset.Tables[TableName];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}
		internal static void Update(DataTable Table)
		{
			/*try
			{
				connexion.Open();

				Adapter.Update(Table);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				connexion.Close();
			}*/
		}
	}
}

