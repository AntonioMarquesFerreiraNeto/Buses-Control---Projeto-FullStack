﻿using BusesControl.Helper;
using BusesControl.Models.Enums;
using BusesControl.Models.ModelValidarCPF;
using BusesControl.Models.ValidacoesCliente.ModelValidarDate;
using BusesControl.Models.ValidacoesDados.ModelValidarEmail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusesControl.Models {
    public class Funcionario {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5, ErrorMessage = "Campo inválido.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [CpfValidation(ErrorMessage = "Campo inválido!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DataType(DataType.Date, ErrorMessage = "Campo inválido!")]
        [ValidarDataFuncionario(ErrorMessage = "Data de nascimento inválida!")]
        [Display(Name = "Data de nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidarEmail(ErrorMessage = "Campo inválido!")]
        [MinLength(5, ErrorMessage = "Campo inválido!")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Campo inválido!")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(8, ErrorMessage = "Campo inválido!")]
        [MaxLength(9, ErrorMessage = "Campo inválido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(8, ErrorMessage = "Campo inválido!")]
        [MaxLength(8, ErrorMessage = "Campo inválido!")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NumeroResidencial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "Campo inválido!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(2, ErrorMessage = "Campo inválido!")]
        public string ComplementoResidencial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(2, ErrorMessage = "Campo inválido!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "Campo inválido!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(2, ErrorMessage = "Campo inválido!")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(2, ErrorMessage = "Campo inválido!")]
        public string Ddd { get; set; }

        public string Apelido { get; set; }
        public string Senha { get; set; }
        public StatuFuncionario Status { get; set; }
        public CargoFuncionario Cargos { get; set; }
        public UsuarioStatus StatusUsuario { get; set; }

        public virtual List<Contrato> Contratos { get; set; }

        public bool ValidarSenha(string senha) {
            if (senha.GerarHash() == Senha) {
                return true;
            }
            else {
                return false;
            }
        }

        public bool ValidarDuplicataSenha(string newSenha) {
            bool result = (Senha == newSenha) ? true : false;
            return result;
        }

        public string GerarSenha() {

            Random random = new Random();

            int rdn = random.Next(2);
            int tamanhoSenha = (rdn == 0) ? 8 : 10;

            string caixaCaracteres = "ABCDEFGHIJKLNOPQIWYZK" + "ABCDEFGHIJKLNOPQIWYZK".ToLower() + "@#$%&*!" + "123456789";
            StringBuilder senhaUser = new StringBuilder();

            for (int cont = 0; cont < tamanhoSenha; cont++) {
                int indiceCaracter = random.Next(0, caixaCaracteres.Length - 1);
                senhaUser.Append(caixaCaracteres[indiceCaracter]);
            }
            return Convert.ToString(senhaUser);
        }

        public void setPasswordHash() {
            Senha = Senha.GerarHash();
        }

        public string ReturnTelefoneFuncionario() {
            return $"{long.Parse(Telefone).ToString(@"00000-0000")}";
        }
        public string ReturnCpfFuncionario() {
            return $"{Convert.ToUInt64(Cpf):000\\.000\\.000\\-00}";
        }

    }
}
