using DIAutoFact.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAutoFact.Model.Entity
{
    class Client : IClient
    {
        private string fullName;
        public string GetName()
        {
            return fullName;
        }

        public void SetName(string name)
        {
            fullName = name;
        }
    }
}
