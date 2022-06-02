using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models

{
    public class Producto{
        [Key]
        public int Id{get;set;}
        [Required]
        [Display(Name ="Nombre")]
        public string Nombre {get;set;}
        public int IdCategoria{get;set;}
        [ForeignKey("IdCategoria")]
        public Categoria Categoria {get;set;}
        [Required]
        //Cantidad en gramos o mililitros
        [Display(Name ="Cantidad")]
        public int Cantidad {get;set;}
        public string Descipcion {get;set;}



    }


}