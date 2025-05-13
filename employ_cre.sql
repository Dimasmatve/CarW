CREATE TABLE [dbo].[employ] (
    [employee_id] INT            IDENTITY (1, 1) NOT NULL,
    [logen]       NVARCHAR (50)  NOT NULL,
    [passw]       NVARCHAR (MAX) NOT NULL,
    [full_name]   NVARCHAR (50)  NOT NULL,
    [roule]       NVARCHAR (20)  NULL,
    [salary]      NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([employee_id] ASC)
);

