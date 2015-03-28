using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Loteria.Entidades
{
    [DataContract]
    public class Premio
    {
        [DataMember]
        public int id { set; get;}

        [DataMember]
        public int premio { set; get; }

        [DataMember]
        public double monto { set; get; }

    }
}