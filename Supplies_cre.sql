CREATE TABLE [dbo].[Supplies] (
    [supli_id]    INT           IDENTITY (1, 1) NOT NULL,
    [Product Name]     NVARCHAR(50) NOT NULL,
    [Descript]  NVARCHAR(255),
    [Quantity] INT NOT NULL,
    [Status] NVARCHAR(20) NOT NULL,
    [DateAdded]   DATETIME        DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([supli_id] ASC),
);