using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CasaDeShow.Models;
using Microsoft.AspNetCore.Identity;

namespace CasaDeShow.DTO {
    public class VendaDTO {
        [Required]
        public int Id { get; set; }

        
        public string User { get; set; }

        public string Nome { get; set; }

        public int QuantidadeDeIngressos { get; set; }

        public DateTime Data { get; set; }

        public double Preco { get; set; }

        public int CasaShowID { get; set; }


        public int CategoriaID { get; set; }

        public string Img { get; set; }
        public bool Status { get; set; }

        public int EventoID { get; set; }
        
        public int QuantidadeComprada{ get; set; }
    }
}