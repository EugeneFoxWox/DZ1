using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class UseCaseDiagram : Diagram
    {
        Relation relation;
        UseCase usecase;
        Actor actor;
        public UseCaseDiagram(Relation relation, UseCase usecase, Actor actor)
        {
            this.relation = relation;
            this.usecase = usecase;
            this.actor = actor;
        }

    }
}
