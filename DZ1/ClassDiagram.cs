using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class ClassDiagram : Diagram
    {
        Relation relation;
        Class classs;
        Interface interfac;
        public ClassDiagram(Relation relation, Class classs, Interface interfac)
        {
            this.relation = relation;
            this.classs = classs;
            this.interfac = interfac;
        }

        /*
        public string ClassCount { get; set; }
        public string RelationsCount { get; set; }
        public string InterfacesCount { get; set; } 
        
        IDictionary<int, string> classes = new Dictionary<int, string>();
        IDictionary<int, string> relations = new Dictionary<int, string>();
        IDictionary<int, string> interfaces = new Dictionary<int, string>();

        */
        
    }
}
