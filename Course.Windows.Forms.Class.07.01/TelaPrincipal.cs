using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.;
namespace Course.Windows.Forms.Class._07._01 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            dvgTabelaFucnionario.DataSource = Banco
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            InitializeComponent();       
        }
    }
}
