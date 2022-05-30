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
		internal static OleDbDataAdapter AdapterDataFromSensorTable = new OleDbDataAdapter();
		internal static OleDbDataAdapter AdapterUserTable = new OleDbDataAdapter();
		internal static OleDbConnection connexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"
																		+ @"Data Source=DB_UserAccess.accdb;Cache Authentication=True");
		internal static void ConfigUserTable()
		{
			string Insert_CommandText = "INSERT into UserTable(UserPassword,UserName,AccountType) values(@UserPassword,@UserName,@AccountType);";
			string Delete_CommandText = "DELETE FROM UserTable WHERE UserName = @UserName;";
			string Select_CommandText = "SELECT * from UserTable ORDER BY Id;";
			string Update_CommandText = "UPDATE UserTable SET UserPassword = @UserPassword, AccountType = @AccountType WHERE UserName = @UserName;";

			OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
			OleDbCommand Delete_Command = new OleDbCommand(Delete_CommandText, connexion);
			OleDbCommand Select_Command = new OleDbCommand(Select_CommandText, connexion);
			OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);

			AdapterUserTable.SelectCommand = Select_Command;
			AdapterUserTable.InsertCommand = Insert_Command;
			AdapterUserTable.DeleteCommand = Delete_Command;
			AdapterUserTable.UpdateCommand = Update_Command;

			//Adapter.TableMappings.Add("UserTable", "Local_UserTable");
			//Adapter.TableMappings.Add("AccessTable", "Local_AccessTable");

			AdapterUserTable.InsertCommand.Parameters.Add("@UserPassword", OleDbType.VarChar, 40, "UserPassword");
			AdapterUserTable.InsertCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
			AdapterUserTable.InsertCommand.Parameters.Add("@AccountType", OleDbType.Numeric, 100, "AccountType");

			//Adapter.DeleteCommand.Parameters.Add("@UserName", OleDbType.VarChar, 40, "UserName");
		}

		internal static void ConfigDataFromSensorTable()
		{
			string Insert_CommandText = "INSERT into DataFromSensorTable(SensorNumber,DataType,DataValue,FromLocal,SendedAt) values(@SensorNumber,@DataType,@DataValue,@FromLocal,@SendedAt);";
			string Update_CommandText = "UPDATE DataFromSensorTable SET type = @type, value = @value, sendedAt=@sendedAt WHERE Id = @Id;";

			OleDbCommand Insert_Command = new OleDbCommand(Insert_CommandText, connexion);
			OleDbCommand Update_Command = new OleDbCommand(Update_CommandText, connexion);

			AdapterDataFromSensorTable.InsertCommand = Insert_Command;
			AdapterDataFromSensorTable.UpdateCommand = Update_Command;

			AdapterDataFromSensorTable.InsertCommand.Parameters.Add("@SensorNumber", OleDbType.VarChar, 40, "SensorNumber");
			AdapterDataFromSensorTable.InsertCommand.Parameters.Add("@DataType", OleDbType.VarChar, 100, "DataType");
			AdapterDataFromSensorTable.InsertCommand.Parameters.Add("@DataValue", OleDbType.Numeric, 100000, "DataValue");
			AdapterDataFromSensorTable.InsertCommand.Parameters.Add("@FromLocal", OleDbType.VarChar, 40, "FromLocal");
			AdapterDataFromSensorTable.InsertCommand.Parameters.Add("@SendedAt", OleDbType.VarChar, 40, "SendedAt");

		}
	}
}
