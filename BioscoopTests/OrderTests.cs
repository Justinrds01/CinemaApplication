using BioscoopCasus.Entities;

namespace BioscoopTests
{
    public class OrderTests
    {
        [Fact]
        public void Calculate_Price_Of_Single_Premium_Seat_Non_Student_On_Week_Day()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 2, 2), 10.0m);
            MovieTicket ticket1 = new(1, 1, true, screening);
            movie.AddScreening(screening);
            Order order = new(1, false);
            order.AddSeatReservation(ticket1);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(13.0m, result);
        }

        [Fact]
        public void Calculate_Price_Of_Two_Premium_Seat_Non_Student_On_Week_Day()
        {
            // Arrange
            Movie movie = new("The Matrix");
            
            // Date is Wednesday
            MovieScreening screening = new(new DateTime(2023, 2, 1), 10.0m);
            
            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 1, true, screening);
            
            movie.AddScreening(screening);
            
            Order order = new(1, false);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);
            
            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(26.0m, result);
        }

        [Fact]
        public void Calculate_Price_Of_Two_Premium_Seat_Student_On_Week_Day()
        {
            // Arrange
            Movie movie = new("The Matrix");

            // Date is Thursday
            MovieScreening screening = new(new DateTime(2023, 2, 2), 10.0m);

            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 1, true, screening);

            movie.AddScreening(screening);

            Order order = new(1, true);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(12.0m, result);
        }

        [Fact]
        public void Calculate_Price_Of_Six_Premium_Seat_Non_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            
            // Date is Saturday
            MovieScreening screening = new(new DateTime(2023, 2, 4), 10.0m);

            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 1, true, screening);
            MovieTicket ticket3 = new(1, 1, true, screening);
            MovieTicket ticket4 = new(1, 1, true, screening);
            MovieTicket ticket5 = new(1, 1, true, screening);
            MovieTicket ticket6 = new(1, 1, true, screening);
            

            movie.AddScreening(screening);

            Order order = new(1, false);
            
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);
            order.AddSeatReservation(ticket3);
            order.AddSeatReservation(ticket4);
            order.AddSeatReservation(ticket5);
            order.AddSeatReservation(ticket6);


            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(35.1m, result);
        }

        [Fact]
        public void Calculate_Price_Of_Six_Premium_Seat_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");

            // Date is Saturday
            MovieScreening screening = new(new DateTime(2023, 2, 4), 10.0m);

            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 1, true, screening);
            MovieTicket ticket3 = new(1, 1, true, screening);
            MovieTicket ticket4 = new(1, 1, true, screening);
            MovieTicket ticket5 = new(1, 1, true, screening);
            MovieTicket ticket6 = new(1, 1, true, screening);


            movie.AddScreening(screening);

            Order order = new(1, true);

            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);
            order.AddSeatReservation(ticket3);
            order.AddSeatReservation(ticket4);
            order.AddSeatReservation(ticket5);
            order.AddSeatReservation(ticket6);


            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(36m, result);
        }
    }
}