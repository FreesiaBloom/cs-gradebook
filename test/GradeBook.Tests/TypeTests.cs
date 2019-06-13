using System;
using Xunit;

namespace GradeBook.Tests
{

    public class TypeTests
    {

        [Fact]
        public void ValueTypesAlsoPasByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            Assert.Equal("Book 1", book1.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        [Fact]
        public void Strings() 
        {
            string name = "Agata";
            var upper = MakeUpperCase(name);

            Assert.Equal("Agata", name);
            Assert.Equal("AGATA", upper);
        }

        private string MakeUpperCase(string param)
        {
            return param.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        public void TwoVarsCanReferenceSameObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
    }
}
