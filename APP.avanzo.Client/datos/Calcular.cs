using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace APP.avanzo.Client.datos
{
    public class Calcular
    {
     
        public string? Materia { get; set; }

        [Required(ErrorMessage = "El promedio final es obligatorio")]
        [Range(6, 10, ErrorMessage = "La nota mínima debe ser 6 y la máxima 10")]
        public float Promedio_Inall_Final { get; set; }=6;
       
        public float Promedio_Avanzo_Requerido { get; set; }  

    }
}