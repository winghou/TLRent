using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Data.Entity;

namespace SPYDF.Core.BaseService.Impl
{
    public class BaseCore
    {
        [Import]
        public DbContext DbEntity { set; get; }

        public BaseCore()
        {
            //因为这里有Import，所以需要装配MEF
            regisgter().ComposeParts(this);
        }

        public CompositionContainer regisgter()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            return container;
        }
    }
}
