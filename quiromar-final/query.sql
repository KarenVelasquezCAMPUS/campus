-- 1. Listar todas las ventas que se realizaron en el mes de julio de 2023
SELECT id,fecha FROM venta 
WHERE fecha BETWEEN '2023-07-01' AND '2023-07-31';
/* BETWEEN consulta entre rangos*/

-- 2.  Seleccionar todos los empleados con sus respectivos cargos y municipios
SELECT e.nombre AS NombreEmpleado, c.descipcion AS Cargo, m.nombre AS Municipio
FROM empleado AS e 
JOIN cargo AS c ON e.IdCargoFK = c.Id 
JOIN municipio AS m ON e.IdMunicipioDk = m.Id;
/*e es un alias, cuando se define un alias se debe de colocar un AS (buena practica:)*/

-- 3. Obtener la lista de todas las ventas con la información de los clientes y la forma de pago
SELECT v.Id, v.Fecha, cl.nombre AS NombreCliente, fp.descripcion AS FormaPago
FROM venta v  
JOIN cliente cl ON v.IdClienteFk = cl.Id 
JOIN forma_pago fp ON v.Id.FormaPagoFk = fp.Id;

-- 4. Mostrar los detalles de todas las órdenes junto con los nombres de los empleados y clientes asociados
SELECT  o.Id, o.fecha, e.nombre AS NombreEmpleado, cl.nombre AS NombreCliente
FROM orden AS o 
JOIN empleado e ON o.IdEmpleadoFk = e.Id 
JOIN cliente cl ON o.IdClienteFk = cl.Id;

-- 5. Listar los productos disponibles en el inventario junto con su talla y color
SELECT inv.CodInv, p.Nombre AS NombrePrenda, t.descripcion AS Talla, col.Descripcion AS color
FROM inventario inv
JOIN prenda p ON inv.IdPrendaFk = p.Id 
JOIN inventario_talla it ON inv.Id = it.IdInvFk
JOIN talla t ON it.IdTallaFk = t.Id 
JOIN detalle_orden do ON p.Id = do.PrendaId
JOIN color col ON do.IdColorFk = col.Id;
/*la tabla principal siempre esta por encima de la otra*/

-- 6. Mostrar todos los proveedores junto con la lista de insumos que suminis
SELECT pr.Nombre AS NombreProveedor, i.nombre AS Insumo
FROM proveedor AS pr
JOIN insumo_proveedor ip ON pr.Id = ip.IdProveedorFK
JOIN insumo i ON ip.IdInsumoFk = i.Id;

-- 7. Encontrar la cantidad de ventas realizadas por cada empleado
SELECT e.nombre AS NombreEmpleado, COUNT(v.Id) AS CsntidadVentas
FROM empleado AS e 
JOIN venta v ON e.Id = v.IdEmpleadoFk 
GROUP BY e.nombre;

-- 8. Mostrar la lista de órdenes en proceso junto con los nombres de los clientes y empleados asociados
SELECT o.Id, o.fecha, e.nombre AS NombreEmpleado, cl.nombre AS NombreCliente
FROM orden AS o
JOIN empleado e ON o.IdEmpleadoFk = e.Id 
JOIN cliente cl ON o.IdClienteFk = cl.Id 
WHERE o.IdEstadoFk = (SELECT Id FROM tipo_estado WHERE Id = 2); 
/*El () de WHERE ultima linea es una subconsulta*/

-- 9. Obtener el nombre de la empresa y su respectivo representante legal junto con el nombre del municipio al que pertenecen
SELECT em.razon_social AS NombreEmpresa, em.representante_legal AS RepresentanteLegal, m.nombre AS NombreMunicipio
FROM empresa AS em
JOIN municipio m ON em.IdMunicipioFK = m.Id;

-- 10. Mostrar la lista de prendas y su respectivo stock disponible
SELECT p.Nombre AS NombrePrenda, SUM(dv.cantidad) AS StockDisponible
FROM detalle_venta AS dv
JOIN inventario i ON dv.IdProductoFk = i.Id
JOIN prenda p ON i.IdPrendaFk = p.Id 
GROUP BY p.Nombre;
/*SUM sumatoria lo que hay en la columna de la tabla*/

-- 11. Encontrar el nombre de los clientes que realizaron compras en una fecha específica junto con la cantidad de artículos comprados
SELECT c.nombre AS NombreCliente, COUNT(dv.Id) AS CantidadArticulosComprados
FROM cliente AS c
JOIN venta v ON c.Id = v.IdClienteFk
JOIN detalle_venta dv ON v.Id = dv.IdVentaFk
WHERE v.Fecha = '2023-08-10'
GROUP BY p.Nombre;

-- 12. Mostrar la lista de empleados y la duración de su empleo en años
SELECT nombre AS NombreEmpleado, DATEDIFF(CURRENT_DATE, fecha_ingreso)/365 AS DuracionEmpleadoAnos
FROM empleado;

    -- Antiguos y nuevos
    SELECT nombre AS NombreEmpleado, IF((DATEDIFF(CURRENT_DATE, fecha_ingreso)/365)>1, 'Antiguo', 'Nuevo') AS DuracionEmpleadoAnos
    FROM empleado;

-- 13. Obtener el nombre de las prendas junto con el valor total de ventas en dólares para cada una
SELECT p.Nombre AS NombrePrenda, SUM(dv.cantidad * dv.valor_unit) AS TotalVentasUSD
FROM detalle_venta AS dv
JOIN inventario i ON dv
/*falta terminar*/

-- 14. Obtener el nombre de las prendas junto con la cantidad mínima y máxima de insumos necesarios para su fabricación
SELECT p.Nombre AS NombrePrenda, MIN(ip.Cantidad) AS CantidadMinimaInsumos, MAX(ip.Cantidad) AS CantidadMaximaInsumos
FROM prenda AS p 
JOIN insumo_prendas ip ON p.Id = ip.IdPrendaFk
GROUP BY p.Nombre;

-- 15. Obtener la lista de empleados y su información de contacto, incluyendo el nombre, el cargo y el municipio 


-- 16. Mostrar la lista de ventas realizadas en un rango de fechas específico junto con el nombre del cliente y la forma de pago


-- 17. Obtener el nombre de las prendas y su valor unitario en dólares junto con el estado de disponibilidad


-- 18. Mostrar la lista de clientes y la cantidad de compras que han realizado


-- 19. Obtener la lista de órdenes junto con el estado actual y la fecha en que se crearon


-- 20. Obtener el nombre y la descripción de los cargos con un sueldo base superior a 2.000.000


-- 21. Mostrar la lista de clientes con sus respectivos municipios y países


-- 22 Obtener el nombre y la descripción de los tipos de protección y el número de prendas asociadas a cada tipo