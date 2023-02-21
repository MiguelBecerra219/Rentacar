using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USUARIO MODEL***/
  [Table("usuario")]
 public partial class Usuario : IMicron
 {
        [Primary]
        public Int32 idusuario {get; set;}
        public String nombre {get; set;}
        public String email {get; set;}
        public String password {get; set;}
 }
}
