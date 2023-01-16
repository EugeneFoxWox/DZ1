using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class ComponentDiagram : Diagram
    {
        Relation relation;
        public ComponentDiagram(Relation relation)
        {
            this.relation = relation;
        }
    }
}
