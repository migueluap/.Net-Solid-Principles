using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAutoFact.Model.Interface
{
    interface IClient
    {
        void SetName(string name);
        string GetName();
    }
}
