using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badetidssystemet;

namespace Badetidssystemet
{
    public class Kreds
    { // metoder 
        public string ID { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }
        public int antalDeltagere { get; set; }
        public string tlf { get; set; }


        public Kreds(string ID, string navn, string adresse, int antalDeltagere, string tlf) // metode + parameter
        {
            this.ID = ID;
            this.navn = navn;
            this.adresse = adresse;
            this.antalDeltagere = antalDeltagere;
            this.tlf = tlf;

        }

             public override string ToString() // override to ToString
        {
            return $"ID: {ID} navn: {navn} adresse: {adresse} antalDeltagere: {antalDeltagere} tlf: {tlf}";
        }
    }
}
