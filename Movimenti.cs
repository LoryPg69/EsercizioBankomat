//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankomatSimulator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movimenti
    {
        public long Id { get; set; }
        public string NomeBanca { get; set; }
        public string NomeUtente { get; set; }
        public string Funzionalita { get; set; }
        public int Quantita { get; set; }
        public System.DateTime DataOperazione { get; set; }
    }
}
