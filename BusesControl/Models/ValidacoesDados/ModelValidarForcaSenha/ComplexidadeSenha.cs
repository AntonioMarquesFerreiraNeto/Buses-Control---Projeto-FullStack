﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace BusesControl.Models.ValidacoesDados.ModelValidarForcaSenha {
    public class ComplexidadeSenha : ValidationAttribute {

        public int SenhaTamanhoMinimo { get; set; }
        public int SenhaTamanhoMaximo { get; set; }

        public Boolean SenhaForteRequerida { get; set; }
        public Boolean CaracterEspecialRequerido { get; set; }
        public ComplexidadeSenha() {
            this.SenhaTamanhoMinimo = 8;
            this.SenhaTamanhoMaximo = 14;
            this.SenhaForteRequerida = true;
            this.CaracterEspecialRequerido = true;
            this.ErrorMessage = "";
        }

        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext) {
            // Carrega mensagem personalizada de erro caso nao tenha sido declarada na chamada do atributo
            if (this.ErrorMessage == "") {
                this.ErrorMessage = getMensagemErro();
            }

            // Verifica se o Valor é nulo
            if (value == null) {
                value = "";
            }

            string newValue = value.ToString();

            // Verifica se senha não é maior que o tamanho maximo
            if (newValue.Length > this.SenhaTamanhoMaximo) {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }

            // Carrega expressao regular para validação da senha
            Regex regexSenha = new Regex(getRegex());

            // Valida a expressao regular 
            Match match = regexSenha.Match(value.ToString());

            // Se valida retorna com sucesso
            if (match.Success) {
                return ValidationResult.Success; ;
            }

            // Devolve o erro padrao se a expressao nao for valida.
            return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
        }

        // Diretivas para validação do lado do Cliente, implementa com jquery.validate
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata,
            ControllerContext context) {
            // Carrega mensagem personalizada de erro caso nao tenha sido declarada na chamada do atributo
            if (this.ErrorMessage == "") {
                this.ErrorMessage = getMensagemErro();
            }

            var Rule = new ModelClientValidationRule {
                ValidationType = "senhabrasil",
                ErrorMessage = this.FormatErrorMessage(metadata.PropertyName)
            };

            // Carrega parametros para JQuery
            string[] array = new string[] { getRegex(), this.SenhaTamanhoMaximo.ToString() };

            Rule.ValidationParameters["params"] = string.Join(";", Array.ConvertAll(array, x => x.ToString()));

            yield return Rule;
        }

        /// <summary>
        /// Retorna expressao regular de acordo com parametros informados no atributo
        /// </summary>
        private string getRegex() {
            string regex = "^.*(?=.{" + this.SenhaTamanhoMinimo.ToString() + "," + this.SenhaTamanhoMaximo.ToString() + "})";


            if (SenhaForteRequerida) {
                regex += "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])";
                if (this.CaracterEspecialRequerido) {
                    regex += "(?=.*[@#$%^&+=])";
                }
            }
            else {
                regex += "(?=.*[a-zA-Z0-9@#$%^&+=])";
            }

            regex += ".*$";

            return regex;
        }

        /// <summary>
        /// Retorna mensagem de erro de acordo com parametros informados no atributo
        /// </summary>
        private string getMensagemErro() {
            string mErro = "Senha " + this.SenhaTamanhoMinimo.ToString();

            if (this.SenhaTamanhoMaximo != this.SenhaTamanhoMinimo) {
                mErro += " a " + this.SenhaTamanhoMaximo.ToString();
            }

            mErro += " caracteres";

            if (this.SenhaForteRequerida) {
                mErro += ", Conter Letras maiusculas, minusculas";

                if (CaracterEspecialRequerido) {
                    mErro += ", caracteres especiais";
                }

                mErro += " e números";
            }

            mErro += ".";

            return mErro;
        }
    }
}