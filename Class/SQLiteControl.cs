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
        /*public void SQLiteClose(List<Medicine> gameInfos)
        {
            conn = new SQLiteConnection("Data Source=C:\\Users\\KRKimwoo\\source\\repos\\ProjectPT\\MediData.db;Version=3;");
            conn.Open();
            foreach (var gameInfo in gameInfos)
            {
                SQLiteCommand valuecmd = new SQLiteCommand("SELECT * FROM GameInfo WHERE GameType = '" + gameInfo.GameType + "'", conn);
                SQLiteDataReader reader = valuecmd.ExecuteReader();
                int count = 0;
                while (reader.Read())
                    count += 1;
                if (count == 0)
                {
                    reader.Close();
                    SQLiteCommand insertcmd = new SQLiteCommand("INSERT INTO GameInfo (BoardId, GameType, ThreadId, title, readCount, likeCount, userName, createTime, modifyTime) " +
                        "values (" + gameInfo.BoardId + ", '" + gameInfo.GameType + "'," + gameInfo.ThreadId + ", '" + gameInfo.title + "', " + gameInfo.readCount + ", " + gameInfo.likeCount + ", " + gameInfo.userName + ", " + gameInfo.createTime + ", " + gameInfo.modifyTime, conn);
                }
                else
                {
                    SQLiteCommand updatecmd = new SQLiteCommand("UPDATE GameInfo SET ThreadId = " + gameInfo.ThreadId + ", title = '" + gameInfo.title + "', readCount = " + gameInfo.readCount + ", likeCount = " + gameInfo.likeCount + ", userName = '" + gameInfo.userName + "', createTime = " + gameInfo.createTime + ", modifyTime = " + gameInfo.modifyTime + " WHERE BoardId = " + gameInfo.BoardId, conn);
                    updatecmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }*/

        public void SQLiteDelete(string GameType)
        {
            conn = new SQLiteConnection("Data Source=C:\\Users\\KRKimwoo\\source\\repos\\UI Design\\database.db;Version=3;");
            conn.Open();
            SQLiteCommand deletecmd = new SQLiteCommand("DELETE FROM GameInfo WHERE GameType = " + GameType, conn);
            deletecmd.ExecuteNonQuery();
        }
    }
}
