namespace MVC_DB_CSV.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnagraficaIcpDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anagrafica",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDCLIENTE = c.String(),
                        CF = c.String(),
                        PIVA = c.String(),
                        DENOMINAZIONE = c.String(),
                        MAIL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Icp",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndirizzoRes = c.String(),
                        Tipologia = c.String(),
                        Ubicazione = c.String(),
                        Descrizione = c.String(),
                        DataInizioValidita = c.String(),
                        DataFineValidita = c.String(),
                        Esposizione = c.String(),
                        OrdLum = c.String(),
                        Categoria = c.String(),
                        Suolo = c.String(),
                        UnitaDiMisura = c.String(),
                        Lunghezza = c.String(),
                        Larghezza = c.String(),
                        Qta = c.String(),
                        Elementi = c.String(),
                        Facce = c.String(),
                        QtaTass = c.String(),
                        DataVariazione = c.String(),
                        OraVariazione = c.String(),
                        Utente = c.String(),
                        Tributo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Icp");
            DropTable("dbo.Anagrafica");
        }
    }
}
