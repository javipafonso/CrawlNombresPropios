using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Odbc;

using Corex.Common.CSupport;
using Corex.Common.DBManager;


namespace CrawlNombresPropios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String URL = textURL.Text;
            String sHtml = Crawler.GetHtml(URL);
            String sCmd="";              
            String Genero="";
            String sExp = "";
            if (rMas.Checked)
            {
                Genero = "masculino";
                sExp = @"<b>(?<nombre>[a-zA-ZáéíóúÁÉÍÓÚ]*(.*?))</b>(.*?)\((?<origen>[a-zA-ZáéíóúÁÉÍÓÚ]*)\)\. (?<significado>(.|\n|\r|\t)*?)\.</font>";
            }
            if (rFem.Checked)
            {
                Genero = "femenino";
                sExp = @"<b>(?<nombre>[a-zA-ZáéíóúÁÉÍÓÚ]*(.*?)) </b> \((?<origen>[a-zA-ZáéíóúÁÉÍÓÚ]*)\)\. (?<significado>(.|\n|\r|\t)*?)\.(.*?)</font>";
            }
            Regex oRegex = new Regex(sExp);

            MatchCollection oMatches = oRegex.Matches(sHtml);

            label4.Text = oMatches.Count.ToString();

            DBMngr oDB = new DBMngr();
            
            foreach (Match oMatch in oMatches)
            {
                String sNombre = oMatch.Groups["nombre"].ToString().Replace(" o ","/");
                String sOrigen = oMatch.Groups["origen"].ToString();
                String sToSplit = oMatch.Groups["significado"].ToString().Replace("\r", "");
                String[] sSplitS = sToSplit.Split('\n');
                String[] sSplitN = sNombre.Split('/'); 
                String sSignificado = sToSplit;
                if ((sSplitS.Length > 1) && (sSplitS.Length != 3))
                    sSignificado = sSplitS[0].TrimEnd() + " " + sSplitS[1].TrimStart();
                if (sSplitS.Length == 3)
                    sSignificado = sSplitS[1].TrimStart() + " " + sSplitS[2].TrimStart();
                if (sSplitS.Length == 5)
                    sSignificado = sSplitS[0].TrimEnd();
                if (sSplitN.Length > 1)
                {
                    for (Int16 i = 0; i < sSplitN.Length; i++)
                    {
                        sNombre = sSplitN[i].Replace(" ","");
                      //  sNombre = sSplitN[i].TrimStart();
                        sCmd = "INSERT INTO NOMBRES_PROPIOS (NOMBRE, GENERO, ORIGEN, SIGNIFICADO) VALUES ('" + sNombre + "','" + Genero + "', '" + sOrigen + "', '" + sSignificado + "')";
                    }
                }
                else
                {

                    sCmd = "INSERT INTO NOMBRES_PROPIOS (NOMBRE, GENERO, ORIGEN, SIGNIFICADO) VALUES ('" + sNombre + "','" + Genero + "', '" + sOrigen + "', '" + sSignificado + "')";
                }
               oDB.ExecuteNonQuery(sCmd);
            }
       }
    }        
 }

