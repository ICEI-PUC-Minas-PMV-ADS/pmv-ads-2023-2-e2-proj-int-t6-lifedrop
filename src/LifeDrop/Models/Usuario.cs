﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LifeDrop.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o senha")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatario informar o perfil")]
        [Display(Name = "Selecione o perfil")]
        public Origem Origem { get; set; } 
    }
    public enum Origem
    {
        Doador = 0,
        BancoDeSangue = 1
    }
}

