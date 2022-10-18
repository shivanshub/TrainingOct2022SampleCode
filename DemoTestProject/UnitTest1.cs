using FluentAssertions;
using Moq;
using TestableCodeDemo;
using Xunit;

namespace DemoTestProject
{
    public class UnitTest1
    {

        private readonly Mock<IDataAccessLayer> _mockDataAccessLayer;

        public UnitTest1()
        {
            _mockDataAccessLayer = new Mock<IDataAccessLayer>();
        }



        [Fact]
        public void TestableClass()
        {
            //Arrange
            var expectedResult = "TestData";
            _mockDataAccessLayer.Setup(x => x.GetData()).Returns("TestData");


            // Act
            var actual = new TestableBusinessClass(_mockDataAccessLayer.Object).GetData();

            // Assert

            actual.Should().Be(expectedResult);
        }


        [Fact]
        public void NonTestableClass()
        {
            //Arrange
            var expectedResult = "TestData";

            //Mock DAL
            _mockDataAccessLayer.Setup(x => x.GetData()).Returns("TestData");


            // Act

            // No ways to inject Mock object 
            var actual = new NonTestableBusinessClass().GetData();

            // Assert

            actual.Should().Be(expectedResult);
        }





        [Fact]
        public void Template()
        {
            //Arrange

            // Act


            // Assert

        }



    }
}