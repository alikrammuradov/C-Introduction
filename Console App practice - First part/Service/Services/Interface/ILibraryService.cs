using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    internal interface ILibraryService
    {
        Library Create (Library library);
        Library Update(Library library);
        Library Get(Predicate<Library> predicate);
        List<Library> GetAll(Predicate<Library> predicate);
        void Delete(int id);
    }
}
