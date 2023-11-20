using interfaceTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    public class Library : IEntity
    {
        private int _id;
        public int Id { get; }

        public int BookLimit;

        private Book[] Books;

        public Library()
        {
            Id = _id;
            _id++;

        }

        public Book GetBookById(int? id)
        {
            if (id.HasValue)
            {
                foreach (var book in Books)
                {
                    if (book.Id == id)
                    {
                        return book;
                    }
                }
                throw new NotFoundException("NOooo");

            }
        }

    }

}


