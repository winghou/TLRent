using SPYDF.Core.SecurityService;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPYDF.Composition
{
    public class CreateNewInstance
    {
        private CompositionContainer _compositionContainer;
        public CreateNewInstance()
        {
            ComposeParts();
        }

        private void ComposeParts()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            _compositionContainer = new CompositionContainer(catalog);
            _compositionContainer.SatisfyImportsOnce(this);
        }
       [Import]
        private static ExportFactory<IUserTokenService> _exportFactory;

        public static IUserTokenService CreateByExportFactory()
        {
            return _exportFactory.CreateExport().Value;
        }
    }
}
