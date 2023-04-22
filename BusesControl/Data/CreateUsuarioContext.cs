using BusesControl.Helper;
using BusesControl.Models;
using BusesControl.Models.Enums;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace BusesControl.Data {
    public class CreateUsuarioContext {
        private readonly BancoContext _bancoContext;
        
        public CreateUsuarioContext(BancoContext bancoContext) {
            _bancoContext = bancoContext;
            CreateUserAdmin();
            CreateUserAssistente();
        }

        public void CreateUserAdmin() {
            Funcionario funcionario = new Funcionario {
                Id = 14,
                Name = "Pedro Augusto Nunes",
                Cpf = "15528498139",
                DataNascimento = DateTime.Parse("1994-04-04").Date,
                Email = "pedroaugusto@gmail.com",
                Telefone = "985701475",
                Cep = "29132654",
                ComplementoResidencial = "até 552/553",
                NumeroResidencial = "971",
                Logradouro = "Rua Mário Ribeiro Grijó",
                Bairro = "Bom Pastor",
                Cidade = "Viana",
                Estado = "EP",
                Ddd = "27",
                Apelido = "Admin teste",
                StatusUsuario = UsuarioStatus.Ativado,
                Status = StatuFuncionario.Habilitado,
                Cargos = CargoFuncionario.Administrador,
                Senha = "admin-root@25".GerarHash()
            };
            if (!_bancoContext.Funcionario.Any(x => x.Id == funcionario.Id)) {
                _bancoContext.Funcionario.Add(funcionario);
                _bancoContext.SaveChanges();
            }
        }

        public void CreateUserAssistente() {
            Funcionario funcionario = new Funcionario {
                Id = 15,
                Name = "Flávia Augusta Nunes",
                Cpf = "05150754005",
                DataNascimento = DateTime.Parse("1998-05-05").Date,
                Email = "flaviaugusta@gmail.com",
                Telefone = "945701475",
                Cep = "29132654",
                ComplementoResidencial = "até 552/553",
                NumeroResidencial = "971",
                Logradouro = "Rua Mário Ribeiro Grijó",
                Bairro = "Bom Pastor",
                Cidade = "Viana",
                Estado = "EP",
                Ddd = "27",
                Apelido = "Assistente teste",
                StatusUsuario = UsuarioStatus.Ativado,
                Status = StatuFuncionario.Habilitado,
                Cargos = CargoFuncionario.Assistente,
                Senha = "assistente-root@25".GerarHash()
            };
            if (!_bancoContext.Funcionario.Any(x => x.Id == funcionario.Id)) {
                _bancoContext.Funcionario.Add(funcionario);
                _bancoContext.SaveChanges();
            }
        }
    }
}
