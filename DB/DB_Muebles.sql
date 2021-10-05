-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 26-09-2021 a las 16:32:28
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `administrador`
--

CREATE TABLE `administrador` (
  `id_a` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `tel_admi` int(11) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `estado`	tinyint(1)	NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `administrador`
--

INSERT INTO `administrador` (`id_a`, `nombre`, `tel_admi`, `correo`, `clave`, `estado`) VALUES
(1, 'carlos', 4988, 'car@hotmail.com', '45',1),
(1012, 'admin', 4988, 'admin@gmail.com', '123',1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulo`
--

CREATE TABLE `articulo` (
  `id` int(11) NOT NULL,
  `nit_fk` int(11) NOT NULL,
  `precio` double NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `nombre` varchar(50) NOT NULL,
  `estado`	tinyint(1)	NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `articulo`
--

INSERT INTO `articulo` (`id`, `nit_fk`, `precio`, `descripcion`, `nombre`, `estado`) VALUES
(1, 88, 10000, 'silla abc', '', 1),
(3, 88, 10200, 'marrano', '', 0),
(5, 88, 10100, 'computador', '', 1),
(6, 3, 52000, 'articulo para el baño', 'lavamanos', 1),
(7, 5, 45000, 'categoria mesas', 'mesa escritorio', 1),
(25, 1, 1500000, 'mueble para sala', 'sofa', 1),
(74, 10, 150000, 'categoria alcoba', 'silla escritorio', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulo_pedido`
--

CREATE TABLE `articulo_pedido` (
  `id_art_fk` int(11) NOT NULL,
  `id_ped_fk` int(11) NOT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `valor_total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `estado`	tinyint(1)	NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id`, `nombre`, `correo`, `clave`, `estado`) VALUES
(45, 'Paola', 'pao@gmail.com', '12', 1),
(123, 'jairo', 'client@gmail.com', '123', 1),
(458, 'Pedro', 'cliente@gmail.com', '123', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `dir_cliente`
--

CREATE TABLE `dir_cliente` (
  `direccion` varchar(90) NOT NULL,
  `id_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `id_p` int(11) NOT NULL,
  `id_cliente_fk` int(11) NOT NULL,
  `valor_total` double NOT NULL,
  `fecha_pago` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`id_p`, `id_cliente_fk`, `valor_total`, `fecha_pago`) VALUES
(1, 123, 10500, '0000-00-00 00:00:00'),
(5, 123, 10500, '0000-00-00 00:00:00'),
(6, 123, 20500, '0000-00-00 00:00:00'),
(7, 123, 10500, '0000-00-00 00:00:00');


--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE compra(
	id_compra int AUTO_INCREMENT PRIMARY KEY,
	id_cliente_fk int not null,
	id_art_fk int not null,
	valor_total int not null,
	fecha_pago datetime not null,
	cantidad double not null,
    FOREIGN KEY(id_cliente_fk) REFERENCES cliente(id),
    FOREIGN KEY(id_art_fk) REFERENCES articulo(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `compra` (`id_cliente_fk`, `id_art_fk`, `valor_total`, `fecha_pago`, `cantidad`) VALUES
(45, 1, 10500, '0000-00-00 00:00:00', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `nit` int(11) NOT NULL,
  `contacto` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `clave` varchar(50) NOT NULL,
  `estado`	tinyint(1)	NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`nit`, `contacto`, `direccion`, `nombre`, `correo`, `clave`, `estado`) VALUES
(88, '3165345', 'calle 5#28-05', 'Brandon', 'bo@gmail.com', '123', 1);
INSERT INTO `proveedor` (`nit`, `contacto`, `direccion`, `nombre`, `correo`, `clave`, `estado`) VALUES
(89, '3441223', 'calle 5#24-05', 'prove', 'prove@gmail.com', '123', 1);
INSERT INTO `proveedor` (`nit`, `contacto`, `direccion`, `nombre`, `correo`, `clave`, `estado`) VALUES
(84, '3441262', 'calle 5#24-05', 'proveunactive', 'proveunactive@gmail.com', '123', 0);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tel_cliente`
--

CREATE TABLE `tel_cliente` (
  `telefono` int(11) NOT NULL,
  `id_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tel_prov`
--

CREATE TABLE `tel_prov` (
  `telefono` varchar(90) NOT NULL,
  `nit_fk` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `administrador`
--
ALTER TABLE `administrador`
  ADD PRIMARY KEY (`id_a`);

--
-- Indices de la tabla `articulo`
--
ALTER TABLE `articulo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `articulo_pedido`
--
ALTER TABLE `articulo_pedido`
  ADD PRIMARY KEY (`id_art_fk`,`id_ped_fk`),
  ADD KEY `id_ped_fk` (`id_ped_fk`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `dir_cliente`
--
ALTER TABLE `dir_cliente`
  ADD KEY `id_fk` (`id_fk`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_p`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`nit`);

--
-- Indices de la tabla `tel_cliente`
--
ALTER TABLE `tel_cliente`
  ADD PRIMARY KEY (`telefono`,`id_fk`),
  ADD KEY `id_fk` (`id_fk`);

--
-- Indices de la tabla `tel_prov`
--
ALTER TABLE `tel_prov`
  ADD PRIMARY KEY (`telefono`,`nit_fk`),
  ADD KEY `nit_fk` (`nit_fk`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `articulo_pedido`
--
ALTER TABLE `articulo_pedido`
  ADD CONSTRAINT `articulo_pedido_ibfk_1` FOREIGN KEY (`id_art_fk`) REFERENCES `articulo` (`id`),
  ADD CONSTRAINT `articulo_pedido_ibfk_2` FOREIGN KEY (`id_ped_fk`) REFERENCES `pedido` (`id_p`);

--
-- Filtros para la tabla `dir_cliente`
--
ALTER TABLE `dir_cliente`
  ADD CONSTRAINT `dir_cliente_ibfk_1` FOREIGN KEY (`id_fk`) REFERENCES `cliente` (`id`);

--
-- Filtros para la tabla `tel_cliente`
--
ALTER TABLE `tel_cliente`
  ADD CONSTRAINT `tel_cliente_ibfk_1` FOREIGN KEY (`id_fk`) REFERENCES `cliente` (`id`);

--
-- Filtros para la tabla `tel_prov`
--
ALTER TABLE `tel_prov`
  ADD CONSTRAINT `tel_prov_ibfk_1` FOREIGN KEY (`nit_fk`) REFERENCES `proveedor` (`nit`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
