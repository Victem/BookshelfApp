using BookshelfApp.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Reflection;

namespace BookshelfApp.Test
{
    [TestClass]
    public class PageSizeAttribueTest
    {
        [TestMethod]
        public void Test_Measurable_Item_With_PageSizeAttribute()
        {
            // Arrange
            var album = new Album() { Pages = 100 };
            var pageSizeAttribute = typeof(Album).GetCustomAttribute<PageSizeAttribute>();
            
            var expectedWidth = 150;

            // Act
            var width = album.GetWidth();
            var pageClaculationResult = album.Measurer.Calculate(album);


            // Assert
            Assert.AreEqual(expectedWidth, width);
            Assert.AreEqual(pageClaculationResult, width);
            Assert.AreEqual(1.5, pageSizeAttribute.PageSize);
            Assert.IsInstanceOfType(pageSizeAttribute, typeof(PageSizeAttribute));
        }
    }
}
