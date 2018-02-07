using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo_Validacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome  { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "Preencha a observação")]
        public string Observacao { get; set; }

        [Range(18, 50, ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage = "Informe a idades.")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-,]\w+)*", ErrorMessage = "O email informado não é válido.")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Login deve possuir somente letras e deve ter de 5 a 15 caracteres.")]
        [Required(ErrorMessage = "O Logind deve ser preenchido.")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Esse login já existe.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage = "As senha não conferem.")]
        public string ConfirmaSenha { get; set; }
    }
}