namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;



            // act
            double actual = a + b;

            // assert
            Assert.Equal(expected, actual);
            
        }
    }
}