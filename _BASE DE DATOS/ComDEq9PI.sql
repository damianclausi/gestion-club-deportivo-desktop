-- -------------------------------------------------------------------------------------
-- CREACION DE BASE DE DATOS
-- -------------------------------------------------------------------------------------
drop database if exists ComDEq9PI;
create database ComDEq9PI;
use ComDEq9PI;

CREATE TABLE clientes (
  Id_Cliente INT NOT NULL AUTO_INCREMENT,
  Nombre VARCHAR(255) NOT NULL,
  DNI INT NOT NULL,
  Direccion VARCHAR(255) NOT NULL,      
  Fecha_Nacimiento DATE NOT NULL,  
  Fecha_Alta DATE NOT NULL,
  Ficha_Medica BOOLEAN NOT NULL, -- Nuevo atributo agregado  
  PRIMARY KEY (Id_Cliente)
);

CREATE TABLE no_socios (
  Id_NoSocio INT NOT NULL AUTO_INCREMENT,
  Id_Cliente INT NOT NULL,
  PRIMARY KEY (Id_NoSocio),
  FOREIGN KEY (Id_Cliente) REFERENCES clientes (Id_Cliente)
);

CREATE TABLE socios (
  Id_Socio INT NOT NULL AUTO_INCREMENT,
  Id_Cliente INT NOT NULL,
  Id_Carnet INT DEFAULT 0, -- Id_Carnet debe ser generado automáticamente o tener un valor predeterminado
  PRIMARY KEY (Id_Socio),
  FOREIGN KEY (Id_Cliente) REFERENCES clientes (Id_Cliente)
);

CREATE TABLE cuotas (
  Id_Cuota INT NOT NULL AUTO_INCREMENT,
  Descripcion VARCHAR(255) NOT NULL,      
  Monto FLOAT NOT NULL,  
  Fecha_Pago DATE NOT NULL,  
  Fecha_Vencimiento DATE NOT NULL, 
  Id_Socio INT,
  Id_NoSocio INT,
  PRIMARY KEY (Id_Cuota),
  FOREIGN KEY (Id_NoSocio) REFERENCES no_socios (Id_NoSocio),
  FOREIGN KEY (Id_Socio) REFERENCES socios (Id_Socio)  
);


CREATE TABLE actividades (
  Id_Actividad INT NOT NULL AUTO_INCREMENT,  
  Nombre VARCHAR(100) NOT NULL,
  Disponibilidad TINYINT,
  capacidadActividad INT,
  capacidadOcupada INT,
  Costo FLOAT NOT NULL,  
  PRIMARY KEY (Id_Actividad)  
);

CREATE TABLE no_socios_actividades (
    Id_Actividad INT,
    Id_NoSocio INT,
    CONSTRAINT PK_no_socios_actividades PRIMARY KEY(Id_Actividad,Id_NoSocio),
    CONSTRAINT FK_Id_Actividad FOREIGN KEY(Id_Actividad) REFERENCES actividades(Id_Actividad),
    CONSTRAINT FK_Id_NoSocio FOREIGN KEY(Id_NoSocio) REFERENCES no_socios(Id_NoSocio)
);

CREATE TABLE roles (
  RolUsu INT,
  NomRol VARCHAR(30),
  PRIMARY KEY (RolUsu)
);

CREATE TABLE usuario (
  CodUsu INT AUTO_INCREMENT,
  NombreUsu VARCHAR(20),
  PassUsu VARCHAR(15),
  RolUsu INT,
  Activo BOOLEAN DEFAULT TRUE,
  PRIMARY KEY (CodUsu),
  FOREIGN KEY (RolUsu) REFERENCES roles (RolUsu)
);

-- -------------------------------------------------------------------------------------
-- FIN CREACION BASE DE DATOS ----------------------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INICIO PROCEDURE IngresoLogin---------------------------------------------------------
-- -------------------------------------------------------------------------------------

DELIMITER //
CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  SELECT NomRol
  FROM usuario u 
  INNER JOIN roles r ON u.RolUsu = r.RolUsu
  WHERE NombreUsu = Usu AND PassUsu = Pass /* se compara con los parametros */
    AND Activo = 1; /* el usuario debe estar activo */
END //
DELIMITER ;

-- -------------------------------------------------------------------------------------
-- FIN PROCEDURE IngresoLogin-----------------------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INICIO PROCEDURE CrearNuevoClienteSocio ---------------------------------------------
-- -------------------------------------------------------------------------------------
DELIMITER //
CREATE PROCEDURE CrearNuevoClienteSocio (
    IN p_Nombre VARCHAR(255),
    IN p_DNI INT,
    IN p_Direccion VARCHAR(255),
    IN p_FechaNacimiento DATE,
    IN p_FechaAlta DATE,
    IN p_FichaMedica BOOLEAN,
    OUT p_Resultado INT
)
BEGIN
    DECLARE cliente_existente INT DEFAULT 0;
    DECLARE id_cliente_nuevo INT;

    -- Verificar si el cliente ya existe en la base de datos
    SELECT COUNT(*) INTO cliente_existente FROM clientes WHERE DNI = p_DNI;

    IF cliente_existente > 0 THEN
        -- El cliente ya existe, asignar -1
        SET p_Resultado = -1;
    ELSE
        -- El cliente no existe, procedemos a insertarlo
        -- Insertar el nuevo cliente, el ID_Cliente se autoincrementará automáticamente
        INSERT INTO clientes (Nombre, DNI, Direccion, Fecha_Nacimiento, Fecha_Alta, Ficha_Medica)
        VALUES (p_Nombre, p_DNI, p_Direccion, p_FechaNacimiento, p_FechaAlta, p_FichaMedica);

        -- Obtener el ID del cliente recién insertado
        SET id_cliente_nuevo = LAST_INSERT_ID();

        -- Obtener el último carnet generado
        SELECT COALESCE(MAX(Id_Carnet), 0) INTO @v_UltimoCarnet FROM socios;
        -- Incrementar el último carnet generado en 1
        SET @v_NuevoCarnet = @v_UltimoCarnet + 1;
        -- Insertar el nuevo socio con el ID del cliente y el carnet generado
        INSERT INTO socios (Id_Cliente, Id_Carnet) VALUES (id_cliente_nuevo, @v_NuevoCarnet);

        -- Indicar éxito y asignar el ID del cliente como resultado
        SET p_Resultado = id_cliente_nuevo;
    END IF;
END //
DELIMITER ;

-- -------------------------------------------------------------------------------------
-- FIN PROCEDURE CrearNuevoClienteSocio------------------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INICIO PROCEDURE CrearNuevoClienteNoSocio -------------------------------------------
-- -------------------------------------------------------------------------------------
DELIMITER //
CREATE PROCEDURE CrearNuevoClienteNoSocio (
    IN p_Nombre VARCHAR(255),
    IN p_DNI INT,
    IN p_Direccion VARCHAR(255),
    IN p_FechaNacimiento DATE,
    IN p_FechaAlta DATE,
    IN p_FichaMedica BOOLEAN,
    OUT p_Resultado INT
)
BEGIN
    DECLARE cliente_existente INT DEFAULT 0;
    DECLARE id_cliente_nuevo INT;

    -- Verificar si el cliente ya existe en la base de datos
    SELECT COUNT(*) INTO cliente_existente FROM clientes WHERE DNI = p_DNI;

    IF cliente_existente > 0 THEN
        -- El cliente ya existe, asignar -1
        SET p_Resultado = -1;
    ELSE
        -- El cliente no existe, procedemos a insertarlo
        -- Insertar el nuevo cliente, el ID_Cliente se autoincrementará automáticamente
        INSERT INTO clientes (Nombre, DNI, Direccion, Fecha_Nacimiento, Fecha_Alta, Ficha_Medica)
        VALUES (p_Nombre, p_DNI, p_Direccion, p_FechaNacimiento, p_FechaAlta, p_FichaMedica);

        -- Obtener el ID del cliente recién insertado
        SET id_cliente_nuevo = LAST_INSERT_ID();

        -- Insertar en la tabla de no socios
        INSERT INTO no_socios (Id_Cliente) VALUES (id_cliente_nuevo);

        -- Indicar éxito y asignar el ID del cliente como resultado
        SET p_Resultado = id_cliente_nuevo;
    END IF;
END //
DELIMITER ;

-- -------------------------------------------------------------------------------------
-- FIN PROCEDURE CrearNuevoClienteNoSocio-----------------------------------------------
-- -------------------------------------------------------------------------------------




-- -------------------------------------------------------------------------------------
-- INICIO PROCEDURE IncrementarCapacidadOcupada -------------------------------------------
-- -------------------------------------------------------------------------------------
DELIMITER //

CREATE PROCEDURE IncrementarCapacidadOcupada (
    IN p_NombreActividad VARCHAR(100),
    OUT p_Resultado INT
)
BEGIN
    DECLARE idActividad INT;
    
    -- Manejo de error: Establecer el resultado en -1 indicando fallo
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        SET p_Resultado = -1;
    END;

    -- Obtener el ID de la actividad
    SELECT Id_Actividad INTO idActividad
    FROM actividades
    WHERE Nombre = p_NombreActividad;
    
    IF idActividad IS NOT NULL THEN
        -- Incrementar la capacidad ocupada en 1
        UPDATE actividades
        SET capacidadOcupada = capacidadOcupada + 1
        WHERE Id_Actividad = idActividad;
        
        -- Chequear si la capacidad ocupada es igual a la capacidad total
        IF (SELECT capacidadOcupada FROM actividades WHERE Id_Actividad = idActividad) =
           (SELECT capacidadActividad FROM actividades WHERE Id_Actividad = idActividad) THEN
            -- Actualizar la disponibilidad a false
            UPDATE actividades
            SET disponibilidad = FALSE
            WHERE Id_Actividad = idActividad;
        END IF;
        
        -- Indicar éxito
        SET p_Resultado = 1;
    ELSE
        -- Indicar fallo
        SET p_Resultado = -1;
    END IF;
END //

DELIMITER ;


-- -------------------------------------------------------------------------------------
-- FIN PROCEDURE IncrementarCapacidadOcupada -------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INICIO InsertarNoSocioActividad IncrementarCapacidadOcupada -------------------------------------------
-- -------------------------------------------------------------------------------------
DELIMITER //

CREATE PROCEDURE InsertarNoSocioActividad (
    IN p_IdCliente INT,
    IN p_DescripcionActividad VARCHAR(100),
    OUT p_Resultado INT
)
BEGIN
    -- Variable para almacenar el ID del no socio
    DECLARE idNoSocio INT;

    -- Variable para almacenar el ID de la actividad
    DECLARE idActividad INT;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        -- Manejo de error: establecer el resultado en -1 indicando fallo
        SET p_Resultado = -1;
    END;

    -- Buscar el ID del no socio por el ID del cliente
    SELECT Id_NoSocio INTO idNoSocio
    FROM no_socios
    WHERE Id_Cliente = p_IdCliente;

    -- Buscar el ID de la actividad por la descripción
    SELECT Id_Actividad INTO idActividad
    FROM actividades
    WHERE Nombre = p_DescripcionActividad;

    -- Verificar si se encontró el ID del no socio y el ID de la actividad
    IF idNoSocio IS NOT NULL AND idActividad IS NOT NULL THEN
        -- Insertar la relación en la tabla no_socios_actividades
        INSERT INTO no_socios_actividades (Id_Actividad, Id_NoSocio)
        VALUES (idActividad, idNoSocio);

        -- Establecer el resultado como 1 para indicar éxito
        SET p_Resultado = 1;
    ELSE
        -- Si no se encontró el ID del no socio o el ID de la actividad, establecer el resultado en -1
        SET p_Resultado = -1;
    END IF;
END //

DELIMITER ;


-- -------------------------------------------------------------------------------------
-- FIN InsertarNoSocioActividad IncrementarCapacidadOcupada -------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INICIO CrearNuevaCuota  -------------------------------------------
-- -------------------------------------------------------------------------------------
DELIMITER //

CREATE PROCEDURE CrearNuevaCuota (
    IN p_Descripcion VARCHAR(255),
    IN p_Monto FLOAT,
    IN p_Fecha_Pago DATE,
    IN p_Fecha_vencimiento DATE,
    IN p_Id_Cliente INT,
    OUT p_Resultado INT
)
BEGIN
    -- Variable para almacenar el ID de la cuota insertada
    DECLARE nuevo_id INT;
    -- Variables para almacenar los IDs de socio y no socio correspondientes
    DECLARE v_id_socio INT DEFAULT NULL;
    DECLARE v_id_no_socio INT DEFAULT NULL;
    -- Variable para almacenar la última fecha de pago
    DECLARE ultima_fecha_pago DATE;

    -- Manejo de errores
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        SET p_Resultado = -1;
    END;

    -- Verificar si el cliente es socio y obtener su ID
    SELECT Id_Socio INTO v_id_socio FROM socios WHERE Id_Cliente = p_Id_Cliente LIMIT 1;

    -- Verificar si el cliente es no socio y obtener su ID
    SELECT Id_NoSocio INTO v_id_no_socio FROM no_socios WHERE Id_Cliente = p_Id_Cliente LIMIT 1;

    -- Si el cliente es socio, verificar la última fecha de pago de cuotas para este cliente
    IF v_id_socio IS NOT NULL THEN
        SELECT MAX(Fecha_Pago) INTO ultima_fecha_pago 
        FROM cuotas 
        WHERE Id_Socio = v_id_socio;

        -- Comparar la fecha de pago proporcionada con la última fecha de pago
        IF ultima_fecha_pago IS NULL OR p_Fecha_Pago > ultima_fecha_pago THEN
            -- Inserción en la tabla cuotas
            INSERT INTO cuotas (Descripcion, Monto, Fecha_Pago, Fecha_Vencimiento, Id_Socio)
            VALUES (p_Descripcion, p_Monto, p_Fecha_Pago, p_Fecha_vencimiento, v_id_socio);

            -- Obtener el ID de la cuota recién insertada
            SELECT LAST_INSERT_ID() INTO nuevo_id;

            -- Establecer el resultado como el ID de la cuota nueva
            SET p_Resultado = nuevo_id;
        ELSE
            -- Establecer el resultado como -2 si la fecha de pago no es válida
            SET p_Resultado = -2;
        END IF;
    ELSE
        -- Si el cliente no es socio, insertar la cuota sin validar la fecha de pago
        INSERT INTO cuotas (Descripcion, Monto, Fecha_Pago, Fecha_Vencimiento, Id_NoSocio)
        VALUES (p_Descripcion, p_Monto, p_Fecha_Pago, p_Fecha_vencimiento, v_id_no_socio);

        -- Obtener el ID de la cuota recién insertada
        SELECT LAST_INSERT_ID() INTO nuevo_id;

        -- Establecer el resultado como el ID de la cuota nueva
        SET p_Resultado = nuevo_id;
    END IF;
END //

DELIMITER ;



-- -------------------------------------------------------------------------------------
-- FIN CrearNuevaCuota  -------------------------------------------
-- -------------------------------------------------------------------------------------

-- -------------------------------------------------------------------------------------
-- INGRESO DE USUARIOS------------------------------------------------------------------
-- -------------------------------------------------------------------------------------
INSERT INTO roles VALUES
(120,'Administrador'),
(121,'Empleado');

INSERT INTO usuario (CodUsu,NombreUsu,PassUsu,RolUsu) VALUES
(29,'prueba','123456',121),
(30,'cristian1','123456',121),
(31,'cristian2','123456',121),
(32,'antonio','123456',121),
(33,'daniel','123456',121),
(34,'damian','123456',121),
(26,'admin','admin',120);

-- -------------------------------------------------------------------------------------
-- FIN DE USUARIOS----------------------------------------------------------------------
-- -------------------------------------------------------------------------------------

-- Insertar clientes intercalados (socios y no socios) con fechas de alta aleatorias en el año 2020
INSERT INTO clientes (Nombre, DNI, Direccion, Fecha_Nacimiento, Fecha_Alta, Ficha_Medica)
VALUES
('Juan Perez', 12345678, 'Avellaneda 223. CABA', '1980-05-10', '2020-01-01', 1),
('Roberto González', 19876540, 'Patagones 532, Lanús', '1979-05-10', '2020-01-02', 1),
('María Rodriguez', 18765432, 'Mitre 12343, Quilmes', '1985-07-15', '2020-01-03', 0),
('Isabel Vazquez', 21234567, 'Rivadavia 2322, Haedo', '1984-07-15', '2020-01-04', 0),
('Luis Martínez', 25678914, 'San Antonio 2323, CABA', '1978-02-20', '2021-01-05', 1),
('Eduardo Ramirez', 14142134, 'Belgrano 2323, Moreno', '1977-02-20', '2021-01-06', 1),
('Ana García', 36812345, 'Mansilla 4333. Ituzaingó', '1990-09-25', '2021-01-07', 0),
('Silvia Castro', 24567891, 'Latorre 3343, La Plata', '1993-09-25', '2021-01-08', 0),
('Carlos López', 32165498, 'Montevideo 2323, CABA', '1983-11-30', '2021-01-09', 1),
('Alberto Suarez', 16549872, 'Gounot 2232, Loma Hermmosa', '1981-11-30', '2022-01-10', 1),
('Laura Diaz', 25498731, 'Alma Fuerte 22323, Castelar', '1989-03-05', '2022-01-11', 0),
('Laura Molina', 36543217, 'Av. de Mayo 2322, Ramos Mejia', '1986-03-05', '2022-01-12', 0),
('Pedro Sanchez', 15926347, 'Formosa 2323, CABA', '1975-04-15', '2023-01-13', 1),
('David Ortiz', 37539518, 'Rio de Janeniro 2232, CABA', '1980-04-15', '2023-01-14', 1),
('Sofía Romero', 17495148, 'Sullivan 23233, Padua', '1992-08-20', '2023-01-15', 0),
('Ana Navarro', 11592634, 'Pavon 2323, Moron', '1995-08-20', '2023-01-16', 0),
('Daniel Torres', 36985214, 'Santa Fe 2323, Paso del Rey', '1987-10-25', '2023-01-17', 1),
('Javier Medina', 18527419, 'Zarate 2323, CABA', '1973-10-25', '2024-01-18', 1);

-- Insertar clientes socios en la tabla socios y asignar IDs de carnet consecutivos
INSERT INTO socios (Id_Cliente, Id_Carnet)
SELECT Id_Cliente, ROW_NUMBER() OVER (ORDER BY Id_Cliente) AS Id_Carnet FROM clientes WHERE Nombre IN ('Juan Perez', 'María Rodriguez', 'Luis Martínez', 'Ana García', 'Carlos López', 'Laura Diaz', 'Pedro Sanchez', 'Sofía Romero', 'Daniel Torres');

-- Insertar clientes no socios en la tabla no_socios
INSERT INTO no_socios (Id_Cliente)
SELECT Id_Cliente FROM clientes WHERE Nombre IN ('Roberto González', 'Isabel Vazquez', 'Eduardo Ramirez', 'Silvia Castro', 'Alberto Suarez', 'Laura Molina', 'David Ortiz', 'Ana Navarro', 'Javier Medina');

INSERT INTO actividades (Nombre, Disponibilidad, Costo, capacidadActividad, capacidadOcupada)
VALUES ('Fútbol', 1, 500.00, 5, 2);

INSERT INTO actividades (Nombre, Disponibilidad, Costo, capacidadActividad, capacidadOcupada)
VALUES ('Natación', 1, 1000.00, 4, 2);

INSERT INTO actividades (Nombre, Disponibilidad, Costo, capacidadActividad, capacidadOcupada)
VALUES ('Yoga', 1, 300.00, 5, 2);

INSERT INTO actividades (Nombre, Disponibilidad, Costo, capacidadActividad, capacidadOcupada)
VALUES ('Tennis', 1, 600.00, 3, 1);

INSERT INTO actividades (Nombre, Disponibilidad, Costo, capacidadActividad, capacidadOcupada)
VALUES ('Basket', 1, 450.00, 4, 2);


INSERT INTO cuotas (Descripcion, Monto, Fecha_Pago, Fecha_Vencimiento, Id_Socio, Id_NoSocio) 
VALUES 
('Actividad: Fútbol - Costo: $500 - Forma de pago: Tarjeta (1 cuota)', 500, '2024-05-30', '2024-05-30', null, 1),
('Actividad: Fútbol - Costo: $500 - Forma de pago: Tarjeta (3 cuotas)', 500, '2024-06-01', '2024-06-01', null, 2),
('Actividad: Natación - Costo: $1000 - Forma de pago: Tarjeta (6 cuotas)', 1000, '2024-06-02', '2024-06-02', null, 3),
('Actividad: Natación - Costo: $1000 - Forma de pago: Efectivo', 1000, '2024-06-03', '2024-06-03', null, 4),
('Actividad: Yoga - Costo: $300 - Forma de pago: Tarjeta (1 cuota)', 300, '2024-06-04', '2024-06-04', null, 5),
('Actividad: Yoga - Costo: $300 - Forma de pago: Efectivo', 300, '2024-06-05', '2024-06-05', null, 6),
('Actividad: Tennis - Costo: $600 - Forma de pago: Efectivo', 600, '2024-06-06', '2024-06-06', null, 7),
('Actividad: Basket - Costo: $450.50 - Forma de pago: Tarjeta (3 cuotas)', 450.50, '2024-06-07', '2024-06-07', null, 8),
('Actividad: Basket - Costo: $450.50 - Forma de pago: Tarjeta (6 cuotas)', 450.50, '2024-06-08', '2024-06-08', null, 9),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Tarjeta (1 cuota)', 25000, '2024-06-08', '2024-07-08', 1, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Tarjeta (3 cuotas)', 25000, '2024-06-02', '2024-07-02', 2, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Efectivo', 25000, '2024-06-01', '2024-07-01', 3, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Tarjeta (1 cuota)', 25000, '2024-06-03', '2024-07-03', 4, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Tarjeta (3 cuotas)', 25000, '2024-01-08', '2024-02-08', 5, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Efectivo', 25000, '2024-02-08', '2024-03-08', 6, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Efectivo', 25000, '2021-04-08', '2021-05-08', 7, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Tarjeta (6 cuotas)', 25000, '2024-06-08', '2024-07-08', 8, null),
('Actividad: FULL ACCESS - Costo: $25000 - Forma de pago: Efectivo', 25000, '2024-06-08', '2024-07-08', 9, null);


INSERT INTO no_socios_actividades (id_actividad, id_nosocio) VALUES
(1, 1),
(1, 2),
(2, 3),
(2, 4),
(3, 5),
(3, 6),
(4, 7),
(5, 8),
(5, 9);


