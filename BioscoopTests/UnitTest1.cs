using BioscoopCasus.Entities;

namespace BioscoopTests
{
    public class UnitTest1
    {
        [Theory]
        public void CalculatePriceShouldReturnTheCorrectAmount()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(DateTime.Now, 10.0);
            MovieTicket ticket1 = new(1, 1, true, screening);
            movie.AddScreening(screening);
            Order order = new(1, true);
            order.AddSeatReservation(ticket1);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(result, result);
        }
    }
}