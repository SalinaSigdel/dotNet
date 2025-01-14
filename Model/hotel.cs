using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
   
    public class hotel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; }  = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

         public bool IsDeleted { get; set; } = false; // Soft delete flag
        
    }
}