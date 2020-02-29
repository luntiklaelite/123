-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Фев 29 2020 г., 22:06
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `tovari`
--

-- --------------------------------------------------------

--
-- Структура таблицы `company`
--

CREATE TABLE IF NOT EXISTS `company` (
  `company_id` int(11) NOT NULL AUTO_INCREMENT,
  `company_name` varchar(50) NOT NULL,
  `company_type` tinyint(4) NOT NULL,
  PRIMARY KEY (`company_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `company`
--

INSERT INTO `company` (`company_id`, `company_name`, `company_type`) VALUES
(1, 'СтройМех', 0),
(2, 'ВашПром', 2),
(3, 'КузПром', 1),
(4, 'ИнСтрой', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE IF NOT EXISTS `products` (
  `products_id` int(11) NOT NULL AUTO_INCREMENT,
  `products_staff_id` int(11) NOT NULL,
  `products_price` int(11) NOT NULL,
  `products_company_id` int(11) NOT NULL,
  PRIMARY KEY (`products_id`),
  KEY `products_company_id` (`products_company_id`),
  KEY `products_staff_id` (`products_staff_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`products_id`, `products_staff_id`, `products_price`, `products_company_id`) VALUES
(3, 4, 1000, 2),
(4, 1, 300, 3),
(5, 4, 1500, 2),
(6, 4, 1000, 3),
(8, 4, 1300, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `sotr_company`
--

CREATE TABLE IF NOT EXISTS `sotr_company` (
  `sotr_id` int(11) NOT NULL AUTO_INCREMENT,
  `sotr_company_id` int(11) NOT NULL,
  `sotr_users_id` int(11) NOT NULL,
  PRIMARY KEY (`sotr_id`),
  KEY `sotr_company_id` (`sotr_company_id`),
  KEY `sotr_users_id` (`sotr_users_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `sotr_company`
--

INSERT INTO `sotr_company` (`sotr_id`, `sotr_company_id`, `sotr_users_id`) VALUES
(1, 2, 3),
(2, 1, 1),
(3, 3, 6);

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

CREATE TABLE IF NOT EXISTS `staff` (
  `staff_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_name` varchar(50) NOT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `staff`
--

INSERT INTO `staff` (`staff_id`, `staff_name`) VALUES
(1, 'Плитка'),
(3, 'Кирпич'),
(4, 'Ковролин');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `users_id` int(11) NOT NULL AUTO_INCREMENT,
  `users_fio` varchar(100) NOT NULL,
  `users_login` varchar(50) NOT NULL,
  `users_pass` varchar(50) NOT NULL,
  `users_role` tinyint(4) NOT NULL,
  PRIMARY KEY (`users_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=7 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`users_id`, `users_fio`, `users_login`, `users_pass`, `users_role`) VALUES
(1, 'Калинин Александр Владимирович', 'admin', 'admin', 0),
(2, 'Беспечный Рашид Васильевич', 'user', 'user', 1),
(3, 'Тугарин Змий Остапович', 'tugarin', 'tugarin', 2),
(4, 'Тупачок Василий Борисович', 'vasya123', '123123', 2),
(5, 'Кусок Рузай Никонович', 'kusok123', '123123', 1),
(6, 'Ступаков Валерий Дмитриевич', 'stupakov123', '123123', 0);

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`products_company_id`) REFERENCES `company` (`company_id`),
  ADD CONSTRAINT `products_ibfk_2` FOREIGN KEY (`products_staff_id`) REFERENCES `staff` (`staff_id`);

--
-- Ограничения внешнего ключа таблицы `sotr_company`
--
ALTER TABLE `sotr_company`
  ADD CONSTRAINT `sotr_company_ibfk_1` FOREIGN KEY (`sotr_company_id`) REFERENCES `company` (`company_id`),
  ADD CONSTRAINT `sotr_company_ibfk_2` FOREIGN KEY (`sotr_users_id`) REFERENCES `users` (`users_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
