using NUnit.Framework;

namespace TDDCourse.DvdLibrary.Test
{
    public class DonateDvdTest
    {
        private Movie _movie;
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _movie = new Movie();
            _library = new Library();
            _library.Donate(_movie);
        }

        [Test]
        public void MovieAddedToLibrary()
        {
            Assert.True(_library.ContainsMovie(_movie));
        }

        [Test]
        public void RentalCopyAddedToMovie()
        {
            Assert.AreEqual(1, _movie.Copies);
        }
    }
}
