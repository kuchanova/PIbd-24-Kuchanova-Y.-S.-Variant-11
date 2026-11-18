using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Library.Data.Interfaces;
using Library.Data.Stubs;

namespace LibraryApp
{
    public static class ContainerConfig
    {
        public static IUnityContainer Configure()
        {
            var container = new UnityContainer();

            container.RegisterType<IThemeRepository, ThemeRepositoryStub>();
            container.RegisterType<ILibrarianRepository, LibrarianRepositoryStub>();
            container.RegisterType<IPublicationRepository, PublicationRepositoryStub>();
            container.RegisterType<IReaderRepository, ReaderRepositoryStub>();
            container.RegisterType<ILibraryCardRepository, LibraryCardRepositoryStub>();
            container.RegisterType<ILoanRepository, LoanRepositoryStub>();
            container.RegisterType<ILibrarianThemeRepository, LibrarianThemeRepositoryStub>();

            return container;
        }
    }
}
