CREATE TABLE [dbo].[Order] (
    [order_id]    INT           IDENTITY (1, 1) NOT NULL,
    [car_id]     INT NOT NULL,
    [servic_id]     INT NOT NULL,
    [client_id] INT           NOT NULL,
    [DateAdded]   DATETIME        DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([order_id] ASC),
);