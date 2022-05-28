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
		internal static OleDbDataAdapter adapter = new OleDbDataAdapter();
		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=DB_UserAccess.accdb;Cache Authentication=True");
		internal static void Config()
		{

			string Insert_CommandText = "INSERT into UserTable(UserName,UserPassword,Access_Id) values(@UserName,@UserPassword,@Access_Id);";
			string Delete_CommandText = "DELETE FROM UserTable WHERE UserName = @UserName;";
			string Select_CommandText = "SELECT * from UserTable ORDER BY UserKey_Id;";
			string Update_CommandText = "UPDATE UserTable SET UserPassword = @UserPassword, Access_Id = @Access_Id WHERE UserName = @UserName;";

            OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
            OleDbCommand Delete_Command = new OleDbCommand(Delete_CommandText, connexion);
            OleDbCommand Select_Command = new OleDbCommand(Select_CommandText, connexion);
            OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);

            adapter.SelectCommand = Select_Command;
			adapter.InsertCommand = Insert_Command;
			adapter.DeleteCommand = Delete_Command;
			adapter.UpdateCommand = Update_Command;

			adapter.TableMappings.Add("UserTable", "Local_UserTable");
			adapter.TableMappings.Add("AccessTable", "Local_AccessTable");

			adapter.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
			adapter.InsertCommand.Parameters.Add("@UserPassword", OleDbType.VarChar, 40, "UserPassword");
			adapter.InsertCommand.Parameters.Add("@Access_Id", OleDbType.Numeric, 100, "Access_Id");
			adapter.DeleteCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
        }

		internal static void Insert(string Name)
		{
			/*Adapter.InsertCommand.Parameters[0].Value = Name;
			Adapter.InsertCommand.Parameters[1].Value = "test";
			Adapter.InsertCommand.Parameters[2].Value = 5;

			try
			{
				connexion.Open();

				int buffer = Adapter.InsertCommand.ExecuteNonQuery();

				if (buffer != 0) MessageBox.Show("User successfully inserted");
				else MessageBox.Show("User not inserted");
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
		internal static void Fill(DataSet dataset, String TableName, string DB_Table, DataGridView Grid)
		{
			dataset.Tables[TableName].Clear();

			adapter.SelectCommand = new OleDbCommand("SELECT * from " + DB_Table + ";", connexion);

			try
			{
				connexion.Open();

				adapter.Fill(dataset.Tables[TableName]);

				Grid.DataSource = dataset.Tables[TableName];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				connexion.Close();
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

