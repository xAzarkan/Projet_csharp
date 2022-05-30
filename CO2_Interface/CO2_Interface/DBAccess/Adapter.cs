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
		internal static void InsertUserTable(string username, string password, string accountType)
		{
			int passwordColumn = 0;
			int usernameColumn = 1;
			int accountTypeColumn = 2;

			Tools.AdapterUserTable.InsertCommand.Parameters[passwordColumn].Value = password;
			Tools.AdapterUserTable.InsertCommand.Parameters[usernameColumn].Value = username;
			Tools.AdapterUserTable.InsertCommand.Parameters[accountTypeColumn].Value = accountType;

			try
			{
				Tools.connexion.Open();

				int buffer = Tools.AdapterUserTable.InsertCommand.ExecuteNonQuery();

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

		internal static void InsertDataFromSensorTable(string sensorNumber, string dataType, string value, string local, string sendedAt)
		{
			int sensorNumberColumn = 0;
			int dataTypeColumn = 1;
			int valueColumn = 2;
			int localColumn = 3;
			int sendedAtColumn = 4;

			Tools.AdapterDataFromSensorTable.InsertCommand.Parameters[sensorNumberColumn].Value = sensorNumber;
			Tools.AdapterDataFromSensorTable.InsertCommand.Parameters[dataTypeColumn].Value = dataType;
			Tools.AdapterDataFromSensorTable.InsertCommand.Parameters[valueColumn].Value = value;
			Tools.AdapterDataFromSensorTable.InsertCommand.Parameters[localColumn].Value = local;
			Tools.AdapterDataFromSensorTable.InsertCommand.Parameters[sendedAtColumn].Value = sendedAt;

			try
			{
				Tools.connexion.Open();
				int buffer = Tools.AdapterDataFromSensorTable.InsertCommand.ExecuteNonQuery();

				if (buffer != 0) Console.WriteLine("Data successfully inserted");
				else Console.WriteLine("Data not inserted");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Tools.connexion.Close();
			}
		}

	}
}

