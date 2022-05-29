using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CO2_Interface.DBAccess
{
	class Tools
	{
		internal static OleDbDataAdapter Adapter = new OleDbDataAdapter();
		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
																		+ @"Data Source=DB_UserAccess.accdb;Cache Authentication=True");
		internal static void Config()
		{
			string Insert_CommandText = "INSERT into UserTable(UserPassword,UserName,AccountType) values(@UserPassword,@UserName,@AccountType);";
			string Delete_CommandText = "DELETE FROM UserTable WHERE UserName = @UserName;";
			string Select_CommandText = "SELECT * from UserTable ORDER BY Id;";
			string Update_CommandText = "UPDATE UserTable SET UserPassword = @UserPassword, AccountType = @AccountType WHERE UserName = @UserName;";

			OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
			OleDbCommand Delete_Command = new OleDbCommand(Delete_CommandText, connexion);
			OleDbCommand Select_Command = new OleDbCommand(Select_CommandText, connexion);
			OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);

			Adapter.SelectCommand = Select_Command;
			Adapter.InsertCommand = Insert_Command;
			Adapter.DeleteCommand = Delete_Command;
			Adapter.UpdateCommand = Update_Command;

			//Adapter.TableMappings.Add("UserTable", "Local_UserTable");
			//Adapter.TableMappings.Add("AccessTable", "Local_AccessTable");

			Adapter.InsertCommand.Parameters.Add("@UserPassword", OleDbType.VarChar, 40, "UserPassword");
			Adapter.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
			Adapter.InsertCommand.Parameters.Add("@AccountType", OleDbType.Numeric, 100, "AccountType");

			//Adapter.DeleteCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
		}
	}
}
