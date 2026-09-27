using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APP_avanzo.Server.data
{
    public class Calcular2
    {
        public int Id { get; set; }
          public string? Nombre { get; set; }

        [Required(ErrorMessage = "El promedio final es obligatorio / Matematicas")]
        [Range(6, 10, ErrorMessage = "La nota mínima debe ser 6 y la máxima 10")]
        public float Promedio_Inall_Mate { get; set; }=6;
       
        public float Promedio_Avanzo_Mate { get; set; }  
         public float Promedio_final_Mate { get; set; } 



        [Required(ErrorMessage = "El promedio final es obligatorio / Ciencias")]
        [Range(6, 10, ErrorMessage = "La nota mínima debe ser 6 y la máxima 10")]
        public float Promedio_Inall_Ciencias { get; set; }=6;
       
        public float Promedio_Avanzo_Ciencias { get; set; }  
        public float Promedio_final_Ciencias { get; set; }  



        [Required(ErrorMessage = "El promedio final es obligatorio / Sociales")]
        [Range(6, 10, ErrorMessage = "La nota mínima debe ser 6 y la máxima 10")]
        public float Promedio_Inall_Sociales { get; set; }=6;
       
        public float Promedio_Avanzo_Sociales { get; set; }  
         public float Promedio_final_Sociales { get; set; } 



        [Required(ErrorMessage = "El promedio final es obligatorio / Lenguaje")]
        [Range(6, 10, ErrorMessage = "La nota mínima debe ser 6 y la máxima 10")]
        public float Promedio_Inall_Lenguaje { get; set; }=6;
       
        public float Promedio_Avanzo_Lenguaje { get; set; }
         public float Promedio_final_Lenguaje { get; set; } 

        

        public float Promedio_Final { get; set; }  
        public bool Estado { get; set; }
    }

    
}