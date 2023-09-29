USE prueba_bbdd_conocimientos;

SELECT
	E.nombreEmpleado AS Empleado,
    DATE_FORMAT(N.FechaPago, '%M') AS Mes,
    N.Pagado AS Pagado
FROM Empleado AS E
INNER JOIN
    Nomina AS N ON E.idEmpleado = N.idEmpleado
WHERE
    YEAR(N.FechaPago) = 2021
    AND N.Pagado > 2000.00
ORDER BY
    E.nombreEmpleado ASC,
    Mes ASC,
    N.Pagado ASC;