using BioscoopCasus.Entities;

namespace BioscoopTests
{
    public class OrderTests
    {
<<<<<<< Updated upstream
=======
        // Path 1-2
        [Fact]
        public void Calculate_Price_Of_0_Tickets()
        {
            // Arrange
            Order order = new(1, false);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(0, result);
        }


        // path 1-3-4-7-8
        [Fact]
        public void Calculate_Price_Of_Two_Non_Premium_Seats_Non_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 2, 4), 10.0m);
            MovieTicket ticket1 = new(1, 1, false, screening);
            MovieTicket ticket2 = new(1, 1, false, screening);
            movie.AddScreening(screening);
            Order order = new(1, false);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(10.0m, result);
        }

        // path 1-3-4-7-9
        [Fact]
        public void Calculate_Price_Of_Six_Non_Premium_Seats_Non_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 2, 4), 10.0m);
            MovieTicket ticket1 = new(1, 1, false, screening);
            MovieTicket ticket2 = new(1, 1, false, screening);
            MovieTicket ticket3 = new(1, 1, false, screening);
            MovieTicket ticket4 = new(1, 1, false, screening);
            MovieTicket ticket5 = new(1, 1, false, screening);
            MovieTicket ticket6 = new(1, 1, false, screening);
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
            Assert.Equal(27.0m, result);
        }




        // path 1-3-4-6-8
        [Fact]
        public void Calculate_Price_Of_Two_Non_Premium_Seat_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 4, 2), 10.0m);
            MovieTicket ticket1 = new(1, 1, false, screening);
            MovieTicket ticket2 = new(1, 2, false, screening);
            movie.AddScreening(screening);
            Order order = new(1, true);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);

            // Act
            decimal result = order.CalculatePrice();
            
            // Assert
            Assert.Equal(10.0m, result);
        }


        // path 1-3-4-6-9
>>>>>>> Stashed changes
        [Fact]
        public void Calculate_Price_Of_Six_Non_Premium_Seat_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 4, 2), 10.0m);
            MovieTicket ticket1 = new(1, 1, false, screening);
            MovieTicket ticket2 = new(1, 2, false, screening);
            MovieTicket ticket3 = new(1, 3, false, screening);
            MovieTicket ticket4 = new(1, 4, false, screening);
            MovieTicket ticket5 = new(1, 5, false, screening);
            MovieTicket ticket6 = new(1, 6, false, screening);
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
            Assert.Equal(30.0m, result);
        }

        // path 1-3-5-6-9
        [Fact]
        public void Calculate_Price_Of_Six_Premium_Seat_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 4, 2), 10.0m);
            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 2, true, screening);
            MovieTicket ticket3 = new(1, 3, true, screening);
            MovieTicket ticket4 = new(1, 4, true, screening);
            MovieTicket ticket5 = new(1, 5, true, screening);
            MovieTicket ticket6 = new(1, 6, true, screening);
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
            Assert.Equal(36.0m, result);
        }

        // path 1-3-5-7-8
        [Fact]
        public void Calculate_Price_Of_Two_Premium_Seats_Non_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 2, 4), 10.0m);
            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 1, true, screening);
            movie.AddScreening(screening);
            Order order = new(1, false);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(13.0m, result);
        }

        // path 1-3-5-7-9
        [Fact]
        public void Calculate_Price_Of_Six_Premium_Seats_Non_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
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
            Assert.Equal(35.10m, result);
        }

        // path 1-3-5-6-8
        [Fact]
        public void Calculate_Price_Of_Two_Premium_Seat_Student_On_Weekend()
        {
            // Arrange
            Movie movie = new("The Matrix");
            MovieScreening screening = new(new DateTime(2023, 4, 2), 10.0m);
            MovieTicket ticket1 = new(1, 1, true, screening);
            MovieTicket ticket2 = new(1, 2, true, screening);
            movie.AddScreening(screening);
            Order order = new(1, true);
            order.AddSeatReservation(ticket1);
            order.AddSeatReservation(ticket2);

            // Act
            decimal result = order.CalculatePrice();

            // Assert
            Assert.Equal(12.0m, result);
        }
    }
}