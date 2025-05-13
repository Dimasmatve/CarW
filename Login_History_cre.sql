CREATE TABLE [dbo].[Login_History] (
    [His_id]  INT      IDENTITY (1, 1) NOT NULL,
    [employ_ID]    INT      NOT NULL,
    [DateAdded] DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([His_id] ASC),
);

