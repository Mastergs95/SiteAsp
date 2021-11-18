using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace db_ado_ex.Models
{
    [Table("Categorias")]
    public class Categoria 
    {
        
    
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 3)]
            public string Nome { get; set; }

           
        }
    }

