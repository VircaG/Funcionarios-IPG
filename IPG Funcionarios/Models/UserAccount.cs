﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IPG_Funcionarios.Models
{
    public class UserAccount
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Por favor, insira o seu nome")]
        [StringLength(50)]
        [Display(Name = "Nome:")]
        public string PrimeiroNome { get; set; }
        [Required(ErrorMessage = "Por favor, insira o seu apelido")]
        [StringLength(75)]
        [Display(Name = "Sobrenome:")]
        public string UltimoNome { get; set; }
        [EmailAddress(ErrorMessage = "Por favor, insira um email válido.")]
        [StringLength(200)]

        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Insira uma senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool IsValid { get; set; }
    }
}
