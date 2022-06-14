using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Badetidssystemet;

namespace Badetidssystemet
{
    public class Badetidsperiode
    {

        public string _type;
        public DayOfWeek _UgeDag;
        public DateTime _Startidspunkt;
        public DateTime _Slutidspunkt;
        Dictionary<string, Kreds> _kreds; //dictionary

        public Badetidsperiode(string type, DayOfWeek UgeDag, DateTime Startidspunkt, DateTime Slutidspunkt)
        {
            _type = type;
            _UgeDag = UgeDag;
            _Startidspunkt = Startidspunkt;
            _Slutidspunkt = Slutidspunkt;
            _kreds = new Dictionary<string, Kreds>();

        }

        public override string ToString()
        {
            return $" type: {_type} DayOfWeek {_UgeDag} DateTime {_Startidspunkt.TimeOfDay} DateTime {_Slutidspunkt.TimeOfDay};";
        }

        public void AdderKreds(Kreds kreds) //Create
        {

        }

        public void SletKreds(string id) //Delete
        {

        }

        internal void AdderKreds(Badetidsperiode bade1)
        {
        
        }

        internal void SletKreds(Badetidsperiode bade2)
        {
            
        }
    }
}
