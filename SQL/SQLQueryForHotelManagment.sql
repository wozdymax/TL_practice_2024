IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Rooms')
	CREATE TABLE dbo.Rooms (
		room_id	INT IDENTITY(1, 1) NOT NULL,
		room_number INT NOT NULL,
		room_type NVARCHAR(50) NOT NULL,
		price_per_night MONEY NOT NULL,
		availability BIT NOT NULL,

		CONSTRAINT PK_Rooms_room_id PRIMARY KEY (room_id)
	)

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers')
	CREATE TABLE dbo.Customers (
		customer_id INT IDENTITY(1,1) NOT NULL,
		first_name NVARCHAR(50) NOT NULL,
		last_name NVARCHAR(50) NOT NULL,
		email NVARCHAR(100) NOT NULL,
		phone_number NVARCHAR(16) NOT NULL,

		CONSTRAINT PK_Customers_customer_id PRIMARY KEY (customer_id)
	)

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Bookings')
	CREATE TABLE dbo.Bookings (
		booking_id INT IDENTITY(1,1) NOT NULL,
		customer_id INT NOT NULL,
		room_id INT NOT NULL,
		check_in_date DATE NOT NULL,
		check_out_date DATE NOT NULL,

		CONSTRAINT PK_Bookings_booking_id PRIMARY KEY (booking_id),

		CONSTRAINT FK_Bookings_customer_id
			FOREIGN KEY (customer_id) REFERENCES dbo.Customers (customer_id),

		CONSTRAINT FK_Bookings_room_id
			FOREIGN KEY (room_id) REFERENCES dbo.Rooms (room_id),
	)

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Facilities')
	CREATE TABLE dbo.Facilities (
		facility_id INT IDENTITY(1,1) NOT NULL,
		facility_name NVARCHAR(50) NOT NULL,

		CONSTRAINT PK_Facilities_facility_id PRIMARY KEY (facility_id)
	)

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='RoomsToFacilities')
	CREATE TABLE dbo.RoomsToFacilities (
		room_id INT NOT NULL,
		facility_id INT NOT NULL,

		CONSTRAINT PK_rooms_to_facilities_id PRIMARY KEY (room_id),

		CONSTRAINT FK_RoomsToFacilities_room_id
			FOREIGN KEY (room_id) REFERENCES dbo.Rooms (room_id),

		CONSTRAINT FK_RoomsToFacilities_facilities_id
			FOREIGN KEY (facility_id) REFERENCES dbo.Facilities (facility_id),
	)

INSERT INTO dbo.Rooms (room_number, room_type, price_per_night, availability)
VALUES
	(101, 'double', 2200.0, 0),
	(102, 'double', 2200.0, 1),
	(103, 'single', 1400.0, 0),
	(104, 'triple', 3300.0, 1),
	(201, 'double', 2300.0, 0),
	(202, 'single', 1600.0, 0),
	(203, 'double', 2400.0, 1),
	(204, 'triple', 3500.0, 1);

INSERT INTO dbo.Customers (first_name, last_name, email, phone_number)
VALUES
	('Tom', 'Walker', 'twalker@gmail.com', '409688460'),
	('Alice', 'Felton', 'afelton@gmail.com', '334310442'),
	('Lisa', 'Berns', 'lberns@gmail.com', '287642167'),
	('John', 'Doe', 'jdoe@gmail.com', '732225641'),
	('Fiona', 'Galaher', 'fgalaher@gmail.com', '166264366'),
	('Mike', 'Brown', 'mbrown@gmail.com', '576988789'),
	('Alex', 'Simons', 'afoden@gmail.com', '861392178'),
	('Deby', 'Fletcher', 'dfletcher@gmail.com', '183340439');

INSERT INTO dbo.Bookings (customer_id, room_id, check_in_date, check_out_date)
VALUES
	(1, 3, '2024-10-12', '2024-11-19'),
	(2, 1, '2024-06-11', '2024-09-26'),
	(3, 4, '2024-09-01', '2024-10-18'),
	(4, 7, '2024-10-30', '2024-12-01'),
	(5, 6, '2024-07-12', '2024-08-03'),
	(6, 1, '2024-05-11', '2024-12-26'),
	(7, 2, '2024-12-09', '2024-12-31'),
	(8, 5, '2024-04-01', '2024-11-25');

INSERT INTO dbo.Facilities (facility_name)
VALUES
	('Wi-Fi'),
	('Conditioner'),
	('Minibar'),
	('TV'),
	('Balcony'),
	('Treats'),
	('Safe Box');

INSERT INTO dbo.RoomsToFacilities (room_id, facility_id)
VALUES
	(1, 1),
	(2, 4),
	(3, 3),
	(4, 1),
	(5, 5),
	(6, 2),
	(7, 6),
	(8, 3);

--¬се доступные номера дл€ бронировани€ сегодн€
SELECT * FROM dbo.Rooms
WHERE availability = 1 AND room_id NOT IN(
	SELECT room_id FROM dbo.Bookings 
	WHERE GETDATE() BETWEEN check_in_date AND check_out_date);

--¬се клиенты с фамилией на S
SELECT * FROM dbo.Customers
WHERE last_name LIKE 'S%';

--¬се бронировани€ клиента по электронному адресу
SELECT * FROM dbo.Bookings JOIN dbo.Customers
	ON dbo.Bookings.customer_id = dbo.Customers.customer_id
	WHERE dbo.Customers.email = 'jdoe@gmail.com';

--¬се бронировани€ дл€ определенного номера
SELECT * FROM dbo.Bookings JOIN dbo.Rooms
	ON dbo.Bookings.room_id = dbo.Rooms.room_id
	WHERE dbo.Rooms.room_number = 101;

--¬се номера, не забронированные на определенную дату
SELECT * FROM  dbo.Rooms WHERE availability = 1 AND room_id IN (
	SELECT room_id FROM  dbo.Bookings 
	WHERE '2024-10-10' NOT BETWEEN check_in_date AND check_out_date );

