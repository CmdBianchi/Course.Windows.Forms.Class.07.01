using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace Banco {
    class ionarioDataAccess {
        public static DataTable PegarFuncionarios() {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\marcu\source\repos\Course.Windows.Forms.Class.07.01\Course.Windows.Forms.Class.07.01\_Banco\Banco03.db");
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Fucnioanrio", con);
            DataSet ds = new DataSet();

            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
