using Domain.Models;
using Repository.Repositories;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private LibraryRepository _libraryRepository;
        public int count;
        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }

        public Library Create(Library library)
        {
            library.Id = count;
            _libraryRepository.Create(library);
            count++;
            return library;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Library Get(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public Library Update(Library library)
        {
            throw new NotImplementedException();
        }
    }
}
