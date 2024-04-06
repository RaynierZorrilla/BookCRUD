//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class books
    {
        [Display(Name = "#")]
        public int id { get; set; }
        [Display(Name = "Nombre del libro")]
        public string namebook { get; set; }
        [Display(Name = "Autor del libro")]
        public string author { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public System.DateTime date { get; set; }
    }
}