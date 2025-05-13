SELECT 
    o.order_id,
    c.client_full_name AS "Клиент",
    ca.brand AS "Марка авто",
    ca.model AS "Модель авто",
    s.ServiceName AS "Услуга",
    s.Cost AS "Стоимость",
    o.DateAdded AS "Дата заказа"
FROM 
    [Order] o
INNER JOIN 
    Clients c ON o.client_id = c.client_id
INNER JOIN 
    Cars ca ON o.car_id = ca.car_id
INNER JOIN 
    Servic s ON o.servic_id = s.ID;