using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.IO;

namespace EtiquetaSafata
{
    public partial class Form1 : Form
    {
        public Form1(int idProcessatFinal)
        {
            InitializeComponent();
            setup(idProcessatFinal);
        }

        private void setup(int idProcessatFinal)
        {
            string Path;
            ReportDocument cryRpt = new ReportDocument();

            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            Path = Application.StartupPath.Substring(0, Application.StartupPath.IndexOf("DLL"));
            cryRpt.Load($"{Path}EtiquetaSafata\\CrystalReport1.rpt");

            crConnectionInfo.ServerName = "den1.mssql4.gear.host";
            crConnectionInfo.DatabaseName = "escorxadam2";
            crConnectionInfo.UserID = "escorxadam2";
            crConnectionInfo.Password = "Ag69!J031s1?";

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            cryRpt.RecordSelectionFormula = "{processats_finals.idProcessatFinal} = " + idProcessatFinal;

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Print(cryRpt, idProcessatFinal, Path);
        }

        private void Print(ReportDocument cryRpt, int idProcessatFinal, string Path)
        {
            //cryRpt.PrintToPrinter(1, true, 1, 2);

            try
            {
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                if (!Directory.Exists($"{Path}\\Tickets"))
                {
                    Directory.CreateDirectory($"{Path}\\Tickets");
                }
                CrDiskFileDestinationOptions.DiskFileName = $"{Path}Tickets\\Ticket{idProcessatFinal}.pdf";
                CrExportOptions = cryRpt.ExportOptions;
                {
                    CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                    CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                    CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                    CrExportOptions.FormatOptions = CrFormatTypeOptions;
                }
                cryRpt.Export();
                MessageBox.Show($"Se ha imprimido el PDF: Ticket{idProcessatFinal}.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
