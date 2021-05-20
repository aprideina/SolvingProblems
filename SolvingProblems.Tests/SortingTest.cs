using Moq;
using NUnit.Framework;
using SolvingProblems.Sorting;

namespace SolvingProblems.Tests
{   
    public class SortingTest
    {
        private const int Timeout = 9000;

        [Test]
        public void Test_Case1()
        {
            var badVersionServiceMock = new Mock<IBadVersionService>();
            badVersionServiceMock
                .Setup(service => service.IsBadVersion(It.IsInRange(4, 5, Range.Inclusive)))
                .Returns(() => true);

            var sut = new SortingService(badVersionServiceMock.Object);

            var result = sut.FirstBadVersion(5);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test_Case2()
        {
            var badVersionServiceMock = new Mock<IBadVersionService>();

            badVersionServiceMock
                .Setup(service => service.IsBadVersion(It.Is<int>(i => i == 1)))
                .Returns(() => true);

            var sut = new SortingService(badVersionServiceMock.Object);

            var result = sut.FirstBadVersion(1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_Case3()
        {
            var badVersionServiceMock = new Mock<IBadVersionService>();

            badVersionServiceMock
                .Setup(service => service.IsBadVersion(It.IsInRange(10, 10, Range.Inclusive)))
                .Returns(() => true);

            var sut = new SortingService(badVersionServiceMock.Object);

            var result = sut.FirstBadVersion(10);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Test_Case4()
        {
            var badVersionServiceMock = new Mock<IBadVersionService>();

            badVersionServiceMock
                .Setup(service => service.IsBadVersion(It.IsInRange(1, 3, Range.Inclusive)))
                .Returns(() => true);

            var sut = new SortingService(badVersionServiceMock.Object);

            var result = sut.FirstBadVersion(3);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
