using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Course.Windows.Forms.Class._07._01.Modelo {
    class Funcionario {
        public int Id { get; set; }
        public string MyProperty { get; set; }
        public string Email { get; set; }
        public decimal Salario { get; set; }
        public string Sexo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DateAtualizacao { get; set; }
    }
}
