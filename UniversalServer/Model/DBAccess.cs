using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalServer.Model
{
    public class DBAccess
    {
        private MySqlConnection _myConnection;

        public DBAccess()
        {
            // 
            _myConnection =
                     new MySqlConnection(
                         "SERVER=localhost;" +
                         "DATABASE=smarthome;" +
                         "UID = root;" +
                         "PASSWORD=;");

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
            

        }
    }
}