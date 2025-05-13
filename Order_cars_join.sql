SELECT 
    Cars.brand,
    Cars.model,
    Cars.body_type,
    [Order].DateAdded,
    [Order].[Status]
FROM 
    Cars
INNER JOIN 
    [Order] ON Cars.car_id = [Order].car_id
WHERE 
    [Order].[Status] = N'Готов к выполнению';