CREATE TABLE Servic (
    ID INT IDENTITY (1, 1) NOT NULL,             -- Уникальный идентификатор услуги (автоинкремент)
    ServiceName NVARCHAR(255) NOT NULL,          -- Название услуги (не может быть пустым)
    Cost DECIMAL(10, 2) NOT NULL,               -- Стоимость услуги (десятичное число с 2 знаками после запятой)
    Descript  NVARCHAR(255),                    -- Описание услуги
    DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP -- Дата добавления (автоматически устанавливается при создании записи)
    PRIMARY KEY CLUSTERED ([ID] ASC),
);