using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QM.Business.Repository.Interface;
using QM.Domain.Model;

namespace QM.Business.UnitTest
{
    [TestClass]
    public class DateRepsitoryUnitTest
    {
        protected Mock<IDateRepository> dateRepositoryMock;

        public DateRepsitoryUnitTest()
        {
            dateRepositoryMock = new Mock<IDateRepository>();
        }

        [TestMethod]
        public void GivenTwoDate_WillReturnTheDifferenceInDays()
        {
            // Arrange

            var dayFirst = 2;
            var monthFirst = 2;
            var yearFirst = 2020;
            var dateFirst = new Date(dayFirst, monthFirst, yearFirst);

            var daySecond = 20;
            var monthSecond = 2;
            var yearSecond = 2020;
            var dateSecond = new Date(daySecond, monthSecond, yearSecond);
            var days = 18;

            // Act

            dateRepositoryMock.Setup(x => x.GetDifference(dateFirst, dateSecond))
                                           .Returns(days);
            var result = dateRepositoryMock.Object.GetDifference(dateFirst, dateSecond);
            // Assert
            Assert.AreNotEqual(result, 0);
            Assert.AreEqual(result, 18);
        }
    }
}
