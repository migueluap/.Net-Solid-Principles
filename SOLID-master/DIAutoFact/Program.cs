using Autofac;
using DIAutoFact.Model.Entity;
using DIAutoFact.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAutoFact
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new ContainerBuilder();
            app.RegisterType<Client>().As<IClient>();
            var _builder = app.Build();
            var _c = _builder.Resolve<IClient>();
            _c.SetName("migue");

            Console.WriteLine(_c.GetName());
            Console.ReadKey();
        }
    }
}
