using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    interface IVisitor
    {
        void VisitPersonAcc(Person acc);
        void VisitCompanyAc(Company acc);
    }
}
