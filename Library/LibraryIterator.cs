using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class LibraryIterator<Book> : IEnumerator<Book>
    {
        private List<Book> books;

        private int currentIndex;

        public LibraryIterator(List<Book> books)
        {
            Reset();
            this.books = books;
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            this.books = null;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
