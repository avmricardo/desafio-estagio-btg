INSERT INTO public.client(
	id_client, cpf, name, telephone, address)
	VALUES  (1, 111, 'Nome teste 1', '1','Rua 1'),
			(2, 222, 'Nome teste 2', '2','Rua 2'),
			(3, 333, 'Nome teste 3', '3','Rua 3'),
			(4, 444, 'Nome teste 4', '4','Rua 4'),
			(5, 555, 'Nome teste 5', '5','Rua 5'),
			(6, 666, 'Nome teste 6', '6','Rua 6'),
			(7, 777, 'Nome teste 7', '7','Rua 7'),
			(8, 888, 'Nome teste 8', '8','Rua 8'),
			(9, 999, 'Nome teste 9', '9','Rua 9'),
			(10, 101010, 'Nome teste 10', '10','Rua 10'),
			(11, 111111, 'Nome teste 11', '11','Rua 11'),
			(12, 121212, 'Nome teste 12', '12','Rua 12'),
			(13, 131313, 'Nome teste 13', '13','Rua 13'),
			(14, 141414, 'Nome teste 14', '14','Rua 14'),
			(15, 151515, 'Nome teste 15', '15','Rua 15'),
			(16, 161616, 'Nome teste 16', '16','Rua 16'),
			(17, 171717, 'Nome teste 17', '17','Rua 17'),
			(18, 181818, 'Nome teste 18', '18','Rua 18'),
			(19, 191919, 'Nome teste 19', '19','Rua 19'),
			(20, 202020, 'Nome teste 20', '20','Rua 20'),
			(21, 212121, 'Nome teste 21', '21','Rua 21'),
			(22, 222222, 'Nome teste 22', '22','Rua 22'),
			(23, 232323, 'Nome teste 23', '23','Rua 23'),
			(24, 242424, 'Nome teste 24', '24','Rua 24'),
			(25, 252525, 'Nome teste 25', '25','Rua 25'),
			(26, 262626, 'Nome teste 26', '26','Rua 26'),
			(27, 272727, 'Nome teste 27', '27','Rua 27'),
			(28, 282828, 'Nome teste 28', '28','Rua 28'),
			(29, 292929, 'Nome teste 29', '29','Rua 29'),
			(30, 303030, 'Nome teste 30', '30','Rua 30'),
			(31, 313131, 'Nome teste 31', '31','Rua 31'),
			(32, 323232, 'Nome teste 32', '32','Rua 32'),
			(33, 333333, 'Nome teste 33', '33','Rua 33'),
			(34, 343434, 'Nome teste 34', '34','Rua 34'),
			(35, 353535, 'Nome teste 35', '35','Rua 35'),
			(36, 363636, 'Nome teste 36', '36','Rua 36'),
			(37, 373737, 'Nome teste 37', '37','Rua 37'),
			(38, 383838, 'Nome teste 38', '38','Rua 38'),
			(39, 393939, 'Nome teste 39', '39','Rua 39'),
			(40, 404040, 'Nome teste 40', '40','Rua 40'),
			(41, 414141, 'Nome teste 41', '41','Rua 41'),
			(42, 424242, 'Nome teste 42', '42','Rua 42'),
			(43, 434343, 'Nome teste 43', '43','Rua 43'),
			(44, 444444, 'Nome teste 44', '44','Rua 44'),
			(45, 454545, 'Nome teste 45', '45','Rua 45'),
			(46, 464646, 'Nome teste 46', '46','Rua 46'),
			(47, 474747, 'Nome teste 47', '47','Rua 47'),
			(48, 484848, 'Nome teste 48', '48','Rua 48'),
			(49, 494949, 'Nome teste 49', '49','Rua 49'),
			(50, 505050, 'Nome teste 50', '50','Rua 50');


INSERT INTO public.account(
	id_account, id_client, "number", balance)
	VALUES  (1, 1, 10, 100),
			(2, 2, 20, 200),
			(3, 3, 30, 300),
			(4, 4, 40, 400),
			(5, 5, 50, 500),
			(6, 6, 60, 600),
			(7, 7, 70, 700),
			(8, 8, 80, 800),
			(9, 9, 90, 900),
			(10, 10, 100, 1000),
			(11, 11, 110, 1100),
			(12, 12, 120, 1200),
			(13, 13, 130, 1300),
			(14, 14, 140, 1400),
			(15, 15, 150, 1500),
			(16, 16, 160, 1600),
			(17, 17, 170, 1700),
			(18, 18, 180, 1800),
			(19, 19, 190, 1900),
			(20, 20, 200, 2000),
			(21, 21, 210, 2100),
			(22, 22, 220, 2200),
			(23, 23, 230, 2300),
			(24, 24, 240, 2400),
			(25, 25, 250, 2500),
			(26, 26, 260, 2600),
			(27, 27, 270, 2700),
			(28, 28, 280, 2800),
			(29, 29, 290, 2900),
			(30, 30, 300, 3000),
			(31, 31, 310, 3100),
			(32, 32, 320, 3200),
			(33, 33, 330, 3300),
			(34, 34, 340, 3400),
			(35, 35, 350, 3500),
			(36, 36, 360, 3600),
			(37, 37, 370, 3700),
			(38, 38, 380, 3800),
			(39, 39, 390, 3900),
			(40, 40, 400, 4000),
			(41, 41, 410, 4100),
			(42, 42, 420, 4200),
			(43, 43, 430, 4300),
			(44, 44, 440, 4400),
			(45, 45, 450, 4500),
			(46, 46, 460, 4600),
			(47, 47, 470, 4700),
			(48, 48, 480, 4800),
			(49, 49, 490, 4900),
			(50, 50, 500, 5000);


INSERT INTO public.transaction(
	id_transaction, value, id_account, date, type_transaction)
	VALUES  (1, 10, 1, '2023-08-04 13:52:57.521764', 2),
			(2, 20, 2, '2023-08-04 13:52:57.526310', 2),
			(3, 30, 3, '2023-08-04 13:52:57.526310', 2),
			(4, 40, 4, '2023-08-04 13:52:57.526310', 2),
			(5, 50, 5, '2023-08-04 13:52:57.526310', 2),
			(6, 60, 6, '2023-08-04 13:52:57.526310', 2),
			(7, 70, 7, '2023-08-04 13:52:57.526310', 2),
			(8, 80, 8, '2023-08-04 13:52:57.526310', 2),
			(9, 90, 9, '2023-08-04 13:52:57.526310', 2),
			(10, 100, 10, '2023-08-04 13:52:57.526310', 2),
			(11, 110, 11, '2023-08-04 13:52:57.526310', 2),
			(12, 120, 12, '2023-08-04 13:52:57.526310', 2),
			(13, 130, 13, '2023-08-04 13:52:57.526310', 2),
			(14, 140, 14, '2023-08-04 13:52:57.526310', 2),
			(15, 150, 15, '2023-08-04 13:52:57.526310', 2),
			(16, 160, 16, '2023-08-04 13:52:57.526310', 2),
			(17, 170, 17, '2023-08-04 13:52:57.526310', 2),
			(18, 180, 18, '2023-08-04 13:52:57.526310', 2),
			(19, 190, 19, '2023-08-04 13:52:57.526310', 2),
			(20, 200, 20, '2023-08-04 13:52:57.526310', 2),
			(21, 210, 21, '2023-08-04 13:52:57.526310', 2),
			(22, 220, 22, '2023-08-04 13:52:57.526310', 2),
			(23, 230, 23, '2023-08-04 13:52:57.526310', 2),
			(24, 240, 24, '2023-08-04 13:52:57.526310', 2),
			(25, 250, 25, '2023-08-04 13:52:57.526310', 2),
			(26, 260, 26, '2023-08-04 13:52:57.526310', 2),
			(27, 270, 27, '2023-08-04 13:52:57.526310', 2),
			(28, 280, 28, '2023-08-04 13:52:57.526310', 2),
			(29, 290, 29, '2023-08-04 13:52:57.526310', 2),
			(30, 300, 30, '2023-08-04 13:52:57.526310', 2),
			(31, 310, 31, '2023-08-04 13:52:57.526310', 2),
			(32, 320, 32, '2023-08-04 13:52:57.526310', 2),
			(33, 330, 33, '2023-08-04 13:52:57.526310', 2),
			(34, 340, 34, '2023-08-04 13:52:57.526310', 2),
			(35, 350, 35, '2023-08-04 13:52:57.526310', 2),
			(36, 360, 36, '2023-08-04 13:52:57.526310', 2),
			(37, 370, 37, '2023-08-04 13:52:57.526310', 2),
			(38, 380, 38, '2023-08-04 13:52:57.526310', 2),
			(39, 390, 39, '2023-08-04 13:52:57.526310', 2),
			(40, 400, 40, '2023-08-04 13:52:57.526310', 2),
			(41, 410, 41, '2023-08-04 13:52:57.526310', 2),
			(42, 420, 42, '2023-08-04 13:52:57.526310', 2),
			(43, 430, 43, '2023-08-04 13:52:57.526310', 2),
			(44, 440, 44, '2023-08-04 13:52:57.526310', 2),
			(45, 450, 45, '2023-08-04 13:52:57.526310', 2),
			(46, 460, 46, '2023-08-04 13:52:57.526310', 2),
			(47, 470, 47, '2023-08-04 13:52:57.526310', 2),
			(48, 480, 48, '2023-08-04 13:52:57.526310', 2),
			(49, 490, 49, '2023-08-04 13:52:57.526310', 2),
			(50, 500, 50, '2023-08-04 13:52:57.526310', 2);
