CREATE TABLE [dbo].[Clienti] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [ragione_sociale] VARCHAR (50) NOT NULL,
    [partita_iva]     VARCHAR (11) NOT NULL,
    [codice_fiscale]  VARCHAR (16) NOT NULL,
    CONSTRAINT [PK_Clienti] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [UN_PI_Clienti] UNIQUE NONCLUSTERED ([partita_iva] ASC),
    CONSTRAINT [UN_CF_Clienti] UNIQUE NONCLUSTERED ([codice_fiscale] ASC)
);

CREATE TABLE [dbo].[Fornitori] (
    [id]              INT          IDENTITY (1, 1) NOT NULL,
    [ragione_sociale] VARCHAR (50) NOT NULL,
    [partita_iva]     VARCHAR (11) NOT NULL,
    [codice_fiscale]  VARCHAR (16) NOT NULL,
    CONSTRAINT [PK_Fornitori] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [UN_CF_Fornitori] UNIQUE NONCLUSTERED ([codice_fiscale] ASC),
    CONSTRAINT [UN_PI_Fornitori] UNIQUE NONCLUSTERED ([partita_iva] ASC)
);

CREATE TABLE [dbo].[Prodotti] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [codice]      VARCHAR (20) NOT NULL,
    [descrizione] TEXT         NULL,
    [misura]      VARCHAR (10) NOT NULL,
    [giacenza]    INT          NOT NULL,
    CONSTRAINT [PK_Prodotti] PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Pagamenti] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [tipologia] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Pagamenti] PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Destinazioni] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [cliente]   INT          NULL,
    [fornitore] INT          NULL,
    [stato]     VARCHAR (20) NULL,
    [indirizzo] VARCHAR (50) NOT NULL,
    [città]     VARCHAR (50) NOT NULL,
    [provincia] VARCHAR (2)  NOT NULL,
    [cap]       VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Destinazioni] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Destinazioni_Fornitori] FOREIGN KEY ([fornitore]) REFERENCES [dbo].[Fornitori] ([id]),
    CONSTRAINT [FK_Destinazioni_Clienti] FOREIGN KEY ([cliente]) REFERENCES [dbo].[Clienti] ([id])
);

CREATE TABLE [dbo].[Ddt] (
    [id]           INT          IDENTITY (1, 1) NOT NULL,
    [numero]       INT          NOT NULL,
    [data]         DATE         NOT NULL,
    [cliente]      INT          NOT NULL,
    [porto]        VARCHAR (20) NOT NULL,
    [destinazione] INT          NOT NULL,
    CONSTRAINT [PK_Ddt] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [UN_NU_Ddt] UNIQUE NONCLUSTERED ([numero] ASC),
    CONSTRAINT [FK_Ddt_Clienti] FOREIGN KEY ([cliente]) REFERENCES [dbo].[Clienti] ([id])
);

CREATE TABLE [dbo].[Fatture] (
    [id]           INT          IDENTITY (1, 1) NOT NULL,
    [numero]       INT          NOT NULL,
    [data]         DATE         NOT NULL,
    [cliente]      INT          NOT NULL,
    [porto]        VARCHAR (20) NOT NULL,
    [destinazione] INT          NULL,
    CONSTRAINT [PK_Fatture] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [UN_NU_Fatture] UNIQUE NONCLUSTERED ([numero] ASC),
    CONSTRAINT [FK_Fatture_Clienti] FOREIGN KEY ([cliente]) REFERENCES [dbo].[Clienti] ([id])
);

CREATE TABLE [dbo].[Ddt_fatturati] (
    [ddt]     INT NOT NULL,
    [fattura] INT NOT NULL,
    CONSTRAINT [PK_Ddt_fatturati] PRIMARY KEY CLUSTERED ([ddt] ASC, [fattura] ASC),
    CONSTRAINT [FK_Ddt_fatturati_Ddt] FOREIGN KEY ([ddt]) REFERENCES [dbo].[Ddt] ([id]),
    CONSTRAINT [FK_Ddt_fatturati_Fatture] FOREIGN KEY ([fattura]) REFERENCES [dbo].[Fatture] ([id])
);

CREATE TABLE [dbo].[Operazioni_merci] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [prodotto]   INT          NOT NULL,
    [operazione] VARCHAR (20) NOT NULL,
    [quantità]   INT          NOT NULL,
    [cliente]    INT          NULL,
    [fornitore]  INT          NULL,
    [ddt]        INT          NULL,
    [fattura]    INT          NULL,
    CONSTRAINT [PK_Operazioni_merci] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Operazioni_merci_Fornitore] FOREIGN KEY ([fornitore]) REFERENCES [dbo].[Fornitori] ([id]),
    CONSTRAINT [FK_Operazioni_merci_Clienti] FOREIGN KEY ([cliente]) REFERENCES [dbo].[Clienti] ([id]),
    CONSTRAINT [FK_Operazioni_merci_Fatture] FOREIGN KEY ([fattura]) REFERENCES [dbo].[Fatture] ([id]),
    CONSTRAINT [FK_Operazioni_merci_Ddt] FOREIGN KEY ([ddt]) REFERENCES [dbo].[Ddt] ([id]),
    CONSTRAINT [FK_Operazioni_merci_Prodotti] FOREIGN KEY ([prodotto]) REFERENCES [dbo].[Prodotti] ([id])
);
