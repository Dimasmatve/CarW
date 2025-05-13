CREATE TABLE Clients (
    client_id INT IDENTITY(1,1) PRIMARY KEY, -- ID с автоинкрементом
    client_full_name NVARCHAR(255) NOT NULL, -- ФИО клиента
    phone_number VARCHAR(20) NOT NULL,       -- Телефон
    created_at DATETIME DEFAULT GETDATE()    -- Дата создания записи
);