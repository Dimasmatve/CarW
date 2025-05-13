CREATE TABLE [dbo].[Cars] (
    [car_id] INT IDENTITY(1,1) PRIMARY KEY,
    [brand] NVARCHAR(50) NOT NULL,
    [model] NVARCHAR(50) NOT NULL,
    [body_type] NVARCHAR(20) NOT NULL,
    [client_id] INT NOT NULL,
    
    -- Внешний ключ на таблицу клиентов
    CONSTRAINT FK_Cars_Clients 
        FOREIGN KEY ([client_id]) 
        REFERENCES [dbo].[clients]([client_id])
);