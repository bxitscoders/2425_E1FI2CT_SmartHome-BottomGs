using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UniversalServer.Model
{
    public class DBAccess
    {
        private SQLiteConnection _myConnection; //Feld

        public DBAccess()
        {
            // 
            _myConnection =
                     new SQLiteConnection(
                         "Data Source=smarthome;" +
                         "Version=3;" +
                         "New = True;" +
                         "Compress=True;");

        }

        public void OpenConnectionToDBServer()
        {
            try
            {
                _myConnection.Open();
            }
            catch (Exception ex)
            {
                Exception ex2 = new Exception($"Open zur DB hat nicht geklappt!!! Läuft die DB???"+ Environment.NewLine + ex.Message);
                throw ex2;
            }
        }

        public void InsertData(TempValue tv, HumidValue hv, PressureValue pv, DateTime dt, string ip)
        {
            var sqlCmd = _myConnection.CreateCommand();

            int? sens_id = null;

            // Select sensor id if exists
            sqlCmd.CommandText = @"
                SELECT id
                FROM tbl_sensors
                WHERE ip = @ip;
            ";
            sqlCmd.Parameters.AddWithValue("@ip", ip);

            object result = sqlCmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                sens_id = Convert.ToInt32(result);
            }
            else
            {
                // Insert new sensor
                sqlCmd.CommandText = @"
                    INSERT INTO tbl_sensors (
                        room,
                        ip,
                        code
                    ) VALUES (
                        @room,
                        @ip,
                        @code
                    );
                ";

                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@room", "Placeholder Room");
                sqlCmd.Parameters.AddWithValue("@ip", ip);
                sqlCmd.Parameters.AddWithValue("@code", "print(\"Django unchained!\")");

                sqlCmd.ExecuteNonQuery();

                // Get last inserted id
                sqlCmd.CommandText = "SELECT last_insert_rowid();";
                sqlCmd.Parameters.Clear();

                sens_id = Convert.ToInt32(sqlCmd.ExecuteScalar());
                Console.WriteLine(sens_id);
            }

            // Insert values
            sqlCmd.CommandText = @"
                INSERT INTO tbl_values (
                    temperature,
                    humidity,
                    pressure,
                    date,
                    sens_id
                ) VALUES (
                    @temperature,
                    @humidity,
                    @pressure,
                    @date,
                    @sens_id
                );
            ";

            sqlCmd.Parameters.Clear();
            sqlCmd.Parameters.AddWithValue("@temperature", tv.Value);
            sqlCmd.Parameters.AddWithValue("@humidity", hv.Value);
            sqlCmd.Parameters.AddWithValue("@pressure", pv.Value);
            sqlCmd.Parameters.AddWithValue("@date", dt);
            sqlCmd.Parameters.AddWithValue("@sens_id", sens_id);

            sqlCmd.ExecuteNonQuery();
        }
    }
}