CREATE TABLE [dbo].[State] (
    [state_id]    INT           IDENTITY (1, 1) NOT NULL,
    [title]     NVARCHAR (50) NOT NULL,
    [Description]     NVARCHAR (100),
    [DateAdded] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([state_id] ASC),
);

