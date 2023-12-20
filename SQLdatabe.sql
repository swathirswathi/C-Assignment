CREATE DATABASE TicketBookingSystem;

USE TicketBookingSystem;

CREATE TABLE Venu (
    venue_id INT PRIMARY KEY,
    venue_name VARCHAR(255),
    address VARCHAR(255)
);

CREATE TABLE Event (
    event_id INT PRIMARY KEY,
    event_name VARCHAR(255),
    event_date DATE,
    event_time TIME,
    venue_id INT,
    total_seats INT,
    available_seats INT,
    ticket_price DECIMAL,
    event_type VARCHAR(20),
    CHECK (event_type IN ('Movie', 'Sports', 'Concert')),
    booking_id INT
);


CREATE TABLE Customer (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(255),
    email VARCHAR(255),
    phone_number VARCHAR(15),
    booking_id INT
);

CREATE TABLE Booking (
    booking_id INT PRIMARY KEY,
    customer_id INT,
    event_id INT,
    num_tickets INT,
    total_cost DECIMAL,
    booking_date DATE,
    FOREIGN KEY (customer_id) REFERENCES Customer(customer_id),
    FOREIGN KEY (event_id) REFERENCES Event(event_id)
);



--Data Manipulation Language (DML):

--1. Write a SQL query to insert at least 10 sample records into each table.

-- Insert sample records into Venu table
INSERT INTO Venu VALUES
(1, 'Hall', 'Address A'),
(2, 'Amphere theatre', 'Address B'),
(3, 'Screen', 'Address C'),
(4, 'Venue D', 'Address D'),
(5, 'Venue E', 'Address E'),
(6, 'Venue F', 'Address F'),
(7, 'Venue G', 'Address G'),
(8, 'Venue H', 'Address H'),
(9, 'Venue I', 'Address I'),
(10,'Venue J', 'Address J');

-- Insert sample records into Event table
INSERT INTO Event VALUES
(1, 'Event A', '2023-01-01', '12:00:00', 1, 100, 50, 150.00, 'Concert', 1),
(2, 'Event B', '2023-02-02', '15:30:00', 2, 200, 150, 100.00, 'Sports', 2),
(3, 'Event C', '2023-03-03', '18:00:00', 3, 150, 100, 120.00, 'Movie', 3),
(4, 'Event D', '2023-04-04', '20:00:00', 4, 120, 80, 180.00, 'Concert', 4),
(5, 'Event E', '2023-05-05', '14:30:00', 5, 180, 120, 90.00, 'Sports', 5),
(6, 'Event F', '2023-06-06', '17:00:00', 6, 250, 200, 200.00, 'Concert', 6),
(7, 'Event G', '2023-07-07', '19:30:00', 7, 300, 250, 120.00, 'Movie', 7),
(8, 'Event H', '2023-08-08', '21:00:00', 8, 120, 90, 150.00, 'Concert', 8),
(9, 'Event I', '2023-09-09', '13:00:00', 9, 200, 150, 80.00, 'Sports', 9),
(10, 'Event J', '2023-10-10', '16:30:00', 10, 150, 100, 100.00, 'Movie', 10);

-- Insert sample records into Customer table
INSERT INTO Customer VALUES
(1, 'Customer A', 'customerA@example.com', '123-456-7890', 1),
(2, 'Customer B', 'customerB@example.com', '987-654-3210', 2),
(3, 'Customer C', 'customerC@example.com', '234-567-8901', 3),
(4, 'Customer D', 'customerD@example.com', '345-678-9012', 4),
(5, 'Customer E', 'customerE@example.com', '456-789-0123', 5),
(6, 'Customer F', 'customerF@example.com', '567-890-1234', 6),
(7, 'Customer G', 'customerG@example.com', '678-901-2345', 7),
(8, 'Customer H', 'customerH@example.com', '789-012-3456', 8),
(9, 'Customer I', 'customerI@example.com', '890-123-4567', 9),
(10, 'Customer J', 'customerJ@example.com', '901-234-5678', 10);

-- Insert sample records into Booking table
INSERT INTO Booking VALUES
(1, 1, 1, 2, 300.00, '2023-01-01'),
(2, 2, 2, 5, 500.00, '2023-02-02'),
(3, 3, 3, 3, 360.00, '2023-03-03'),
(4, 4, 4, 4, 720.00, '2023-04-04'),
(5, 5, 5, 2, 180.00, '2023-05-05'),
(6, 6, 6, 3, 600.00, '2023-06-06'),
(7, 7, 7, 1, 120.00, '2023-07-07'),
(8, 8, 8, 2, 300.00, '2023-08-08'),
(9, 9, 9, 4, 320.00, '2023-09-09'),
(10, 10, 10, 3, 300.00, '2023-10-10');

--2. Write a SQL query to list all Events.

SELECT * FROM Event;

--3. Write a SQL query to select events with available tickets.

SELECT * FROM Event WHERE available_seats > 0;

--4. Write a SQL query to select events name partial match with ‘cup’.

SELECT * FROM Event WHERE UPPER(event_name) LIKE '%CUP%';

--5. Write a SQL query to select events with ticket price range is between 1000 to 2500.

SELECT * FROM event
WHERE ticket_price >= 1000 AND ticket_price <= 2500;

--6. Write a SQL query to retrieve events with dates falling within a specific range.

SELECT * FROM Event WHERE event_date BETWEEN '2023-01-01' AND '2023-12-31';

--7. Write a SQL query to retrieve events with available tickets that also have "Concert" in their name.

SELECT * FROM Event WHERE available_seats > 0 AND event_type = 'Concert';

--8. Write a SQL query to retrieve users in batches of 5, starting from the 6th user.

SELECT * FROM Customer
ORDER BY customer_id
OFFSET 5 ROWS
FETCH NEXT 5 ROWS ONLY;

--9. Write a SQL query to retrieve bookings details contains booked no of ticket more than 4.

SELECT * FROM Booking WHERE num_tickets > 4;

--10. Write a SQL query to retrieve customer information whose phone number end with ‘000’

SELECT * FROM Customer WHERE phone_number LIKE '%000';

--11. Write a SQL query to retrieve the events in order whose seat capacity more than 15000.

SELECT * FROM Event WHERE total_seats > 15000 ORDER BY total_seats;

--12. Write a SQL query to select events name not start with ‘x’, ‘y’, ‘z’

SELECT * FROM Event WHERE event_name NOT LIKE 'x%' AND event_name NOT LIKE 'y%' AND event_name NOT LIKE 'z%';

--Aggregate functions, GroupBy and Joins:

--1 Write a SQL query to list Events and Their Average Ticket Prices:

SELECT event_name, AVG(ticket_price) AS avg_ticket_price FROM Event GROUP BY event_name;

--2 Write a SQL query to Calculate the Total Revenue Generated by Events:

SELECT SUM(ticket_price * num_tickets) AS total_revenue FROM Event INNER JOIN Booking ON Event.event_id = Booking.event_id;

--3 Write a SQL query to find the event with the highest ticket sales:

SELECT TOP 1 event_name, COUNT(Booking.booking_id) AS tickets_sold
FROM Event
INNER JOIN Booking ON Event.event_id = Booking.event_id
GROUP BY event_name
ORDER BY tickets_sold DESC;

--4 Write a SQL query to Calculate the Total Number of Tickets Sold for Each Event:

SELECT event_name, COUNT(Booking.booking_id) AS tickets_sold FROM Event INNER JOIN Booking ON Event.event_id = Booking.event_id GROUP BY event_name;

-- 5 Write a SQL query to Find Events with No Ticket Sales:

SELECT event_name FROM Event LEFT JOIN Booking ON Event.event_id = Booking.event_id WHERE Booking.booking_id IS NULL;

-- 6 Write a SQL query to Find the User Who Has Booked the Most Tickets:

SELECT TOP 1 customer_name, COUNT(Booking.booking_id) AS tickets_booked
FROM Customer
LEFT JOIN Booking ON Customer.customer_id = Booking.customer_id
GROUP BY customer_name
ORDER BY tickets_booked DESC;

--7 Write a SQL query to List Events and the total number of tickets sold for each month:

SELECT FORMAT(event_date, 'yyyy-MM') AS month, COUNT(Booking.booking_id) AS tickets_sold
FROM Event
LEFT JOIN Booking ON Event.event_id = Booking.event_id
GROUP BY FORMAT(event_date, 'yyyy-MM')
ORDER BY FORMAT(event_date, 'yyyy-MM');

--8. Write a SQL query to calculate the average Ticket Price for Events in Each Venue.

SELECT venue_id, AVG(ticket_price) AS avg_ticket_price FROM Event GROUP BY venue_id;

--9. Write a SQL query to calculate the total Number of Tickets Sold for Each Event Type.

SELECT event_type, COUNT(Booking.booking_id) AS tickets_sold FROM Event LEFT JOIN Booking ON Event.event_id = Booking.event_id GROUP BY event_type;

--10. Write a SQL query to calculate the total Revenue Generated by Events in Each Year.

SELECT YEAR(event_date) AS event_year, SUM(ticket_price * num_tickets) AS total_revenue
FROM Event
INNER JOIN Booking ON Event.event_id = Booking.event_id
GROUP BY YEAR(event_date)
ORDER BY event_year;

--11. Write a SQL query to list users who have booked tickets for multiple events.

SELECT customer_name, COUNT(DISTINCT Booking.event_id) AS events_booked
FROM Customer
INNER JOIN Booking ON Customer.customer_id = Booking.customer_id
GROUP BY customer_name
HAVING events_booked > 1;

--12. Write a SQL query to calculate the Total Revenue Generated by Events for Each User.

SELECT customer_name, SUM(ticket_price * num_tickets) AS total_revenue FROM Customer INNER JOIN Booking ON Customer.customer_id = Booking.customer_id INNER JOIN Event ON Booking.event_id = Event.event_id GROUP BY customer_name;

--13. Write a SQL query to calculate the Average Ticket Price for Events in Each Category and Venue.

SELECT event_type, venue_id, AVG(ticket_price) AS avg_ticket_price FROM Event GROUP BY event_type, venue_id;

--14. Write a SQL query to list Users and the Total Number of Tickets They've Purchased in the Last 30

SELECT customer_name, SUM(num_tickets) AS total_tickets_purchased
FROM Customer
INNER JOIN Booking ON Customer.customer_id = Booking.customer_id
WHERE booking_date >= DATEADD(DAY, -30, GETDATE())
GROUP BY customer_name;


-- Subqueries
--1. Calculate the Average Ticket Price for Events in Each Venue Using a Subquery.

SELECT venue_id, AVG(ticket_price) AS avg_ticket_price 
FROM Event GROUP BY venue_id;

--2. Find Events with More Than 50% of Tickets Sold using subquery.

SELECT * FROM Event 
WHERE (SELECT COUNT(*) FROM Booking WHERE Booking.event_id = Event.event_id) > 0.5 * total_seats;

--3. Calculate the Total Number of Tickets Sold for Each Event.

SELECT event_id, (SELECT SUM(num_tickets) FROM Booking 
WHERE Booking.event_id = Event.event_id) AS total_tickets_sold FROM Event;

--4. Find Users Who Have Not Booked Any Tickets Using a NOT EXISTS Subquery.

SELECT * FROM Customer 
WHERE NOT EXISTS (SELECT 1 FROM Booking WHERE Booking.customer_id = Customer.customer_id);

--5. List Events with No Ticket Sales Using a NOT IN Subquery.

SELECT * FROM Event
WHERE event_id NOT IN (SELECT DISTINCT event_id FROM Booking);

--6. Calculate the Total Number of Tickets Sold for Each Event Type Using a Subquery in the FROM Clause.

SELECT event_type, SUM(total_tickets) AS total_tickets_sold 
FROM (SELECT event_id, COUNT(*) AS total_tickets FROM Booking GROUP BY event_id) AS TicketCount INNER JOIN Event ON TicketCount.event_id = Event.event_id GROUP BY event_type;

--7. Find Events with Ticket Prices Higher Than the Average Ticket Price Using a Subquery in the WHERE Clause.

SELECT * FROM Event
WHERE ticket_price > (SELECT AVG(ticket_price) FROM Event);


--8. Calculate the Total Revenue Generated by Events for Each User Using a Correlated Subquery.

SELECT customer_name, (SELECT SUM(ticket_price * num_tickets) FROM Booking
WHERE Booking.customer_id = Customer.customer_id) AS total_revenue FROM Customer;

--9. List Users Who Have Booked Tickets for Events in a Given Venue Using a Subquery in the WHERE Clause.

SELECT * FROM Customer 
WHERE EXISTS (SELECT 1 FROM Booking INNER JOIN Event ON Booking.event_id = Event.event_id WHERE Event.venue_id = 1 AND Booking.customer_id = Customer.customer_id);

--10. Calculate the Total Number of Tickets Sold for Each Event Category Using a Subquery with GROUP BY.

SELECT event_type, SUM(total_tickets) AS total_tickets_sold
FROM (SELECT Event.event_type, COUNT(*) AS total_tickets FROM Booking INNER JOIN Event ON Booking.event_id = Event.event_id GROUP BY Event.event_type, Booking.event_id) AS TicketCount GROUP BY event_type;

--11. Find Users Who Have Booked Tickets for Events in a Given Month Using a Subquery with DATE_FORMAT.

SELECT * FROM Customer
WHERE EXISTS (SELECT 1 FROM Booking INNER JOIN Event ON Booking.event_id = Event.event_id
WHERE YEAR(Event.event_date) = 2023 AND MONTH(Event.event_date) = 12
AND Booking.customer_id = Customer.customer_id
);

--12. Calculate the Average Ticket Price for Events in Each Venue Using a Subquery

SELECT venue_id, AVG(ticket_price) AS avg_ticket_price 
FROM Event GROUP BY venue_id;