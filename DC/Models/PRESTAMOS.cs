//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRESTAMOS
    {
        public string ID_PRESTAMO { get; set; }
        public Nullable<decimal> NUMERO_BOLETA { get; set; }
        public string MOTIVO { get; set; }
        public Nullable<System.DateTime> FECHA_SOLICITUD { get; set; }
        public Nullable<System.DateTime> FECHA_RETIRO { get; set; }
        public Nullable<decimal> PERIODO_USO { get; set; }
        public string SOFTWARE_REQUERIDO { get; set; }
        public string OBSERVACIONES_SOLICITANTE { get; set; }
        public string OBSERVACIONES_APROBADO { get; set; }
        public string OBSERVACIONES_RECIBIDO { get; set; }
        public Nullable<decimal> CEDULA_USUARIO { get; set; }
        public string SIGLA_CURSO { get; set; }
    }
}
