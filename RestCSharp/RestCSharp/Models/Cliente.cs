using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestCSharp.Models
{
    class Cliente
    {
        private int id;
        private string nome;
        private int senha;
        private int saldo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Senha { get => senha; set => senha = value; }
        public int Saldo { get => saldo; set => saldo = value; }
    }
}
