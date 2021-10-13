INSERT INTO db_bank.dbo.customers (customertName,contactLasttName,contactFirstName,phone,addressLine1,addressLine2,city,state,postalCode,country,salesRepEmployeeNumber,creditLimit) VALUES
	 (N'Muhadjir',N'Muhadjir',N'Muchamad',N'089621807942',N'Jl. Pucangan 4/32-A',N'Jl. Pucangan 4/32-A',N'Surabaya',N'East Java',N'60282',N'Indonesia',3,20000000.00),
	 (N'Chris',N'Chris',N'Martin',N'089621807942',N'Jl. Pucangan 4/32-A',N'Jl. Pucangan 4/32-A',N'Bali',N'Bali',N'60282',N'Indonesia',2,15000000.00),
	 (N'Joni',N'Joni',N'Abu',N'089621807942',N'Jl. Pucangan 4/32-A',N'Jl. Pucangan 4/32-A',N'Jogja',N'DIY',N'60282',N'Indonesia',4,30000000.00),
	 (N'Deni',N'Ahmad',N'Deni',N'089621807942',N'Jl. Pucangan 4/32-A',N'Jl. Pucangan 4/32-A',N'Jakarta',N'DKI Jakarta',N'60282',N'Indonesia',5,10000000.00),
	 (N'Mario',N'Mario',N'Mucha',N'089621807942',N'Jl. Pucangan 4/32-A',N'Jl. Pucangan 4/32-A',N'Bandung',N'West Java',N'60282',N'Indonesia',6,25000000.00);INSERT INTO db_bank.dbo.employees (firstName,lasttName,extension,email,officeCode,reportsTo,jobTitle) VALUES
	 (N'Muchamad',N'Muhadjir',N'5 years',N'mmtkj0206@gmail.com',5,NULL,N'Manager'),
	 (N'Bagos',N'Eko',N'1 years',N'bagosep@gmail.com',1,1,N'Sales'),
	 (N'Muh',N'Yusuf',N'2 years',N'myusuf@gmail.com',2,1,N'Sales'),
	 (N'Firdaus',N'Alan',N'1 years',N'alan@gmail.com',3,1,N'Sales'),
	 (N'Muh',N'Widad',N'3 years',N'widad@gmail.com',5,1,N'Sales'),
	 (N'Eka',N'Pratama',N'1 years',N'ekap@gmail.com',4,1,N'Sales');INSERT INTO db_bank.dbo.offices (city,phone,addressLine1,addressLine2,state,country,postalCode,territory) VALUES
	 (N'Bandung',N'+623187645',N'Jl Bandung Raya No.1',N'Jl Mau Ke Bandung',N'West Java',N'Indonesia',N'90832',N'EAST'),
	 (N'Jakarta',N'+623565745',N'Jl Jakarta Raya No.1',N'Jl Mau Ke Jakarta',N'DKI Jakarta',N'Indonesia',N'94432',N'NORTH WEST'),
	 (N'Yogyakarta',N'+623674245',N'Jl Ngayogyakarta Raya No.1',N'Jl Mau Ke Yogyakarta',N'Yogyakarta',N'Indonesia',N'90122',N'NORTH'),
	 (N'Semarang',N'+623135545',N'Jl Semarang Raya No.1',N'Jl Mau Ke Semarang',N'Central Java',N'Indonesia',N'90562',N'NORTH EAST'),
	 (N'Surabaya',N'+631566645',N'Jl HR Muhammad No.1',N'Jl Mau Ke Surabaya',N'East Java',N'Indonesia',N'56832',N'WEST');INSERT INTO db_bank.dbo.orderdetails (orderNumber,productCode,quantityOrdered,priceEach) VALUES
	 (1,1,6,480000.00),
	 (2,6,4,340000.00),
	 (3,1,2,160000.00),
	 (4,3,3,240000.00),
	 (5,3,1,80000.00);INSERT INTO db_bank.dbo.orders (orderDate,requiredDate,shippedDate,status,comments,customerNumber) VALUES
	 ('2020-10-10','2020-10-11','2020-10-12',N'1',N'Dikirim Secepatnya',6),
	 ('2020-10-12','2020-10-13','2020-10-14',N'1',N'Dikirim Nih',7),
	 ('2020-10-13','2020-10-14','2020-10-15',N'1',N'Dikirim BOs',8),
	 ('2020-11-11','2020-11-11','2020-11-12',N'1',N'Dikirim Ya',9),
	 ('2020-12-10','2020-12-11','2020-12-12',N'1',N'Dikirim lah',10);INSERT INTO db_bank.dbo.payments (customerNumber,paymentDate,amount) VALUES
	 (6,'2022-12-12',10000000.00),
	 (7,'2024-12-12',10000000.00),
	 (8,'2023-12-12',1500000.00),
	 (9,'2021-12-12',10000000.00),
	 (10,'2025-12-12',20000000.00);INSERT INTO db_bank.dbo.productlines (textDescription,htmlDescription,[image]) VALUES
	 (N'Susu Bubuk',N'www.susububuk.com',N'E:\\susububuk.jpeg'),
	 (N'Susu Cair Botol',N'www.susucairbotol.com',N'E:\\susubotol.jpeg'),
	 (N'Susu Cair Kotak',N'www.susucairkotak.com',N'E:\\susukotak.jpeg'),
	 (N'Susu Kental Manis',N'www.skm.com',N'E:\\susukentalmanis.jpeg'),
	 (N'Susu Mini',N'www.susumini.com',N'E:\\susumini.jpeg');INSERT INTO db_bank.dbo.products (productLine,productName,productScale,productVendor,productDescription,quantityInStock,buyPrice,MSRP) VALUES
	 (1,N'Anlene',N'Lansia',N'Fonterra',N'Susu pencegah keretakan tulang untuk lansia',67,80000.00,85000.00),
	 (4,N'FrisianFlag',N'Remaja',N'FFGroup',N'Susu bendera nasional',216,1000.00,1500.00),
	 (3,N'IndoMilk',N'Remaja',N'IMGroup',N'Susu paling nikmat',140,80000.00,85000.00),
	 (2,N'MILKU',N'Anak-Anak',N'Fonterra',N'Susu kekinian',96,2500.00,3000.00),
	 (4,N'IndoMilk',N'Remaja',N'IMGroup',N'Susu paling nikmat',116,1000.00,1500.00),
	 (1,N'Dancow',N'Remaja',N'BBCA',N'Susu bikin kenyang',181,85000.00,92000.00),
	 (5,N'Ultra',N'Anak-Anak',N'UJ',N'Susu full cream sedappp',121,3000.00,3500.00),
	 (5,N'MILO',N'Anak-Anak',N'ICBP',N'Susu peninggi badan',111,2500.00,3000.00);