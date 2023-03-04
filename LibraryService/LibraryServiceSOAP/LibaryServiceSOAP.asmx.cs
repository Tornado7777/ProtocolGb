using LibraryServiceSOAP.Models;
using LibraryServiceSOAP.Services;
using LibraryServiceSOAP.Services.Impls;
using System.Linq;
using System.Web.Services;

namespace LibraryServiceSOAP
{
    /// <summary>
    /// Сводное описание для LibaryServiceSOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class LibaryServiceSOAP : System.Web.Services.WebService
    {

        private readonly ILibraryRepositoryService _libraryRepositoryService;

        public LibaryServiceSOAP()
        {
            _libraryRepositoryService = new LibraryRepository(new LibraryDatabaseContext());
        }

        [WebMethod]
        public Book[] GetBooksByTitle(string title)
        {
            return _libraryRepositoryService.GetByTitle(title).ToArray();
        }

        [WebMethod]
        public Book[] GetBooksByAuthor(string author)
        {
            return _libraryRepositoryService.GetByAuthor(author).ToArray();
        }


        [WebMethod]
        public Book[] GetBooksByCategory(string category)
        {
            return _libraryRepositoryService.GetByCategory(category).ToArray();
        }
    }
}
