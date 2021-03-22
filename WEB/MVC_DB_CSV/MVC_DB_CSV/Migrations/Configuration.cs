namespace MVC_DB_CSV.Migrations
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using MVC_DB_CSV.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_DB_CSV.DAL.AnagraficaIcpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_DB_CSV.DAL.AnagraficaIcpContext context)
        {
            /*try
            {
                string fileIcp = @"C:\Users\kemgang\Desktop\Basis_C#\C-\WEB\MVC_DB_CSV\File\icp.csv";
                string fileAnagrafica = @"C:\Users\kemgang\Desktop\Basis_C#\C-\WEB\MVC_DB_CSV\File\anagrafica.csv";


                using (var reader = new StreamReader(fileIcp))
                {
                    CsvConfiguration config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";"
                    };

                    using (var readerCsv = new CsvHelper.CsvReader(reader, config))
                    {
                        var L = readerCsv.GetRecords<Icp>();
                        foreach (var item in L)
                        {
                            Icp modelIcp = new Icp();
                            modelIcp.IndirizzoRes = item.IndirizzoRes;
                            modelIcp.Tipologia = item.Tipologia;
                            modelIcp.Ubicazione = item.Ubicazione;
                            modelIcp.Descrizione = item.Descrizione;
                            modelIcp.DataInizioValidita = item.DataInizioValidita;
                            modelIcp.DataFineValidita = item.DataFineValidita;
                            modelIcp.Esposizione = item.Esposizione;
                            modelIcp.OrdLum = item.OrdLum;
                            modelIcp.Categoria = item.Categoria;
                            modelIcp.Suolo = item.Suolo;
                            modelIcp.UnitaDiMisura = item.UnitaDiMisura;
                            modelIcp.Lunghezza = item.Lunghezza;
                            modelIcp.Larghezza = item.Larghezza;
                            modelIcp.Qta = item.Qta;
                            modelIcp.Elementi = item.Elementi;
                            modelIcp.Facce = item.Facce;
                            modelIcp.QtaTass = item.QtaTass;
                            modelIcp.DataVariazione = item.DataVariazione;
                            modelIcp.OraVariazione = item.OraVariazione;
                            modelIcp.Utente = item.Utente;
                            modelIcp.Tributo = item.Tributo;

                            context.icp.Add(modelIcp);
                            context.SaveChanges();
                        }
                    }
                }

                using (var reader = new StreamReader(fileAnagrafica))
                {
                    CsvConfiguration config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";"
                    };

                    using (var readerCsv = new CsvHelper.CsvReader(reader, config))
                    {
                        var L = readerCsv.GetRecords<Anagrafica>();
                        foreach (var item in L)
                        {
                            Anagrafica modelAnagrafica = new Anagrafica();
                            modelAnagrafica.IDCLIENTE = item.IDCLIENTE;
                            modelAnagrafica.CF = item.CF;
                            modelAnagrafica.PIVA = item.PIVA;
                            modelAnagrafica.DENOMINAZIONE = modelAnagrafica.DENOMINAZIONE;
                            modelAnagrafica.MAIL = item.MAIL;

                            context.anagrafica.Add(modelAnagrafica);
                            context.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
