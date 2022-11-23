using ProjectPT_Remaster.Class;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;

namespace ProjectPT_Remaster.Class
{
    internal class SQLiteControl
    {
        private SQLiteConnection conn = null;
        public List<Medicine> SQLiteSetup()
        {
            List<Medicine> medicines = new List<Medicine>();
            conn = new SQLiteConnection("Data Source=C:\\Users\\KRKimwoo\\source\\repos\\ProjectPT_Remaster\\MediData.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Medicine", conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                medicines.Add(new Medicine()
                {
                    itemSeq = reader.GetInt32(0),
                    itemName = reader["itemName"].ToString(),
                    entpName = reader["entpName"].ToString(),
                    efcyQesitm = reader["efcyQesitm"].ToString(),
                    useMethodQesitm = reader["useMethodQesitm"].ToString(),
                    atpnWarnQesitm = reader["atpnWarnQesitm"].ToString(),
                    atpnQesitm = reader["atpnQesitm"].ToString(),
                    intrcQesitm = reader["intrcQesitm"].ToString(),
                    seQesitm = reader["seQesitm"].ToString(),
                    depositMethodQesitm = reader["depositMethodQesitm"].ToString(),
                    openDe = reader["openDe"].ToString(),
                    updateDe = reader["updateDe"].ToString()
                });
            }
            reader.Close();
            conn.Close();
            return medicines;
        }
    }
}
