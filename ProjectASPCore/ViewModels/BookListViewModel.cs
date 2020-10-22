using ProjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
