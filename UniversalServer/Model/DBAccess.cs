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
            

        }
    }
}