﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioData
{
    public class Funcionario
    {
        public Funcionario(
            string nome, double salario, Cargo cargo
            ) 
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }

    }
}
