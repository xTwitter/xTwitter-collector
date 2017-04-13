using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xTwitter_collector
{
    public class KwixDatabase
    {
        public Kwix db;

        public KwixDatabase()
        {

        }

        public void Connect(string password)
        {
            // 비밀번호 없이 연결 못한다
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password need to connect to server database");
            }

            // 생성된 kwix 객체가 이미 있다면
            if (db != null)
            {
                // 연결을 끊는다
                db.Database.Connection.Close();
                // dispose한다
                db.Dispose();
            }

            // 새로 생성한다
            db = new Kwix();

            // Connection String에 비밀번호를 넣는다
            db.Database.Connection.ConnectionString = $"data source=kwix.ckcks12.com;initial catalog=KWIX;user id=sa;password={password};MultipleActiveResultSets=True;App=EntityFramework";
            // 연결한다
            db.Database.Connection.Open();
            db.Database.Initialize(false);
        }
    }
}
