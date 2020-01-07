using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace OSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string osd_env_path = Directory.GetCurrentDirectory();

            string osd_soft_path = osd_env_path + @"\software" ;

              try
            {
                if (!Directory.Exists(osd_soft_path))
                {
                    Directory.CreateDirectory(osd_soft_path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, could not create Software Collection, due to an IO Error. Try Restarting with Adminrights.");
            }

            lbl_path.Text = "Current Path: " + osd_soft_path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_MM_Local_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_MM_Server_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_path_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_software_Click(object sender, EventArgs e)
        {
            string osd_path = Directory.GetCurrentDirectory();
            string path_software = osd_path+@"\software";
            liste_leeren();

            foreach (string file in Directory.GetDirectories(path_software))
            {
                string sven_ist_ein_fotzenkopf = Convert.ToString(file.Remove(0, path_software.Length+1));
                clb_Software.Items.Add(sven_ist_ein_fotzenkopf, true);
            }


            outToLog("Software erfolgreich geladen!");
            
        }

        private void liste_leeren()
        {
            clb_Software.Items.Clear();
        }

        void outToLog(string output)
        {
            if (!string.IsNullOrWhiteSpace(rtb_status.Text))
            {
                rtb_status.AppendText("\r\n" + output);
            }
            else
            {
                rtb_status.AppendText(output);
            }
            rtb_status.ScrollToCaret();
        }

        private void installSoftware(string msi_installer, string msi_ini)
        {
            Process p = new Process();
            p.StartInfo.FileName = "msiexec.exe";
            p.StartInfo.Arguments = "/i " + msi_installer + " /qb-";
            p.Start();
            p.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string osd_path = Directory.GetCurrentDirectory();
            string path_software = osd_path + @"\software";

            foreach (string file in clb_Software.CheckedItems)
            {
                string software_name = file;
                string path_installer = path_software +  @"\" + file + @"\setup.msi";
                string path_config = path_software + @"\" + file + @"\parameter.ini";


                //Prüfen ob MSI-File anwesend ist.
                if (File.Exists(path_installer))
                {
                    //Prüfen ob Ini-File anwesend ist.
                    if (File.Exists(path_config))
                    {
                        installSoftware(path_installer, path_config);
                    }

                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ini konnte nicht gefunden werden, " + file + " trotzdem installieren?", "Ini nicht gefunden!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            installSoftware(path_installer, path_config);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Ini prüfen!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Konnte Installer von " + file + " nicht finden, bitte den Stick prüfen");
                }
                outToLog(file + " wurde installiert!");
            }
            outToLog("Alle Softwares wurden installiert!"); 
        }
    }
}
