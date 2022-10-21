using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Aranda.Models
{
    public class Variables // datos de conexón
    {
        public String username { get; set; }
        public String password { get; set; }
        public int consoleid { get; set; }
        public int languageid { set; get; }
        public Boolean IsAnonymous { get; set; }
        public String authtype { get; set; }
        public int serverId { get; set; }
        

    }
}