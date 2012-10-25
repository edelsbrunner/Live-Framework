using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace LivePsicologos.Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha atual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter ao menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova senha")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a nova senha")]
        [Compare("NewPassword", ErrorMessage = "A senha e a confirmação devem ser iguais.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembre-me")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Endereço de e-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter ao menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação devem ser iguais.")]
        public string ConfirmPassword { get; set; }
    }

    public class CadastroPsicologo
    {
        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Endereço de e-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter ao menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação devem ser iguais.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Instituição de ensino")]
        public string InstituicaoEnsino { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "N° Registro (CRP)")]
        public string RegistroCRP { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Consultório")]
        public string Consultorio { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Banco")]
        public string Banco { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Agência")]
        public string Agencia { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Conta")]
        public string Conta { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Tipo de conta")]
        public string TipoConta { get; set; }
    }
}
