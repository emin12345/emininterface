using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    public class Book : IEntity
    {

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public int PageCount {  get; set; }

        public bool IsDeleted { get; set; } = false;

        private int _id;
        public int Id {  get; }

        public Book(string name, string authorName, int pageCount)
        {
            Name= name;
            AuthorName= authorName;
            PageCount= pageCount;

            Id = _id;
            _id++;
            
        }

        public string ShowInfo()
        {

            return $"Name: {Name} AuthorName: {AuthorName} PageCount: {PageCount} ";

        }

        public static bool operator >(Book.PageCount, Book.PageCount b)
        {
            return Book1.PageCount > Book2.PageCount;
                

        }

        public static bool operator <(Book a, Book b)
        {
            return;

        }
    }
}
