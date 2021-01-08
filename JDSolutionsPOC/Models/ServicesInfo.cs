using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDSolutionsPOC.Models
{
    public class ServicesInfo
    {
        public List<Service> Services { get; set; }
    }
    public class Service 
    {
        public string id { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public string groupid { get; set; }
        public string icon { get; set; }
        public string preview { get; set; }
        public string fullname { get; set; }
        public List<string> fulltext { get; set; }
        public List<string> jdlist { get; set; }
        public string highlightedtext { get; set; }
        public string bottomtext { get; set; }
        public List<Icon> iconlist { get; set; }
    }
    public class Icon 
    {
        public string icon { get; set; }
        public string title { get; set; }
        public string text { get; set; }
    }
}
