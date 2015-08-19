using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Resources;
using System.Web;

namespace EchoWeb4
{
    public class Cookie
    {
        public Cookie(HttpCookie cookie)
        {
            NAME = cookie.Name;
            Domain = cookie.Domain;
            Expires = cookie.Expires;
            Secure = cookie.Secure;
            Value = cookie.Value;
            Values = cookie.Values.AllKeys.Aggregate(String.Empty,
                (key, str) => str + string.Format("{0}:{1}, ", key,cookie.Values[key] ));
        }

        public string NAME { get; set; }
        public string Domain { get; set; }
        public DateTime Expires { get; set; }
        public bool Secure { get; set; }

        public string Value { get; set; }
        public string Values { get; set; }

        public DataSet Select()
        {
            return null;
        }

    }
}