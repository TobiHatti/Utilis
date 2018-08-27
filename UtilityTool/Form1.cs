using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityTool
{
    public partial class UtilisForm : Form
    {
        public UtilisForm()
        {
            InitializeComponent();
            pbxSideBanner.Image = Properties.Resources.UtilisBanner;
            pbxSideBanner.SizeMode = PictureBoxSizeMode.CenterImage;

            pbxPowerSymbol.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnTabPower_Click(object sender, EventArgs e)
        {
            tbcRegisters.SelectTab(1);
        }

        #region Power_Button_Click_Events
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich Herunterhahren?", "Herunterfahren", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden heruntergefahren...", "PC wird Heruntergefahren", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Shutdown_SG_ctr++;
                Properties.Settings.Default.Power_Shutdown_SG_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/sg /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnShutdownFull_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich Herunterhahren?", "Herunterfahren", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden heruntergefahren...", "PC wird Heruntergefahren", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Shutdown_S_ctr++;
                Properties.Settings.Default.Power_Shutdown_S_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/s /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnQuickStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich Herunterhahren?", "Herunterfahren", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden heruntergefahren...", "PC wird Heruntergefahren", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Quickstart_Hybrid_ctr++;
                Properties.Settings.Default.Power_Quickstart_Hybrid_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/s /hybrid /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich Neu Starten?", "Neu Starten", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden neu gestartet...", "PC wird neu gestartet", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Restart_G_ctr++;
                Properties.Settings.Default.Power_Restart_G_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/g /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnRestartFull_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich Neu Starten?", "Neu Starten", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden neu gestartet...", "PC wird neu gestartet", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Restart_R_ctr++;
                Properties.Settings.Default.Power_Restart_R_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/r /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie den PC wirklich in den Ruhemodus Versetzen?", "Ruhemodus", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("PC wird in 5 Sekunden in den Ruhemodus versetzt...", "PC wird in den Ruhemodus versetzt", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Hibernate_H_ctr++;
                Properties.Settings.Default.Power_Hibernate_H_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/h /t 5";
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie sich wirklich abmelden?", "Abmelden", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Sie werden in kürze abgemeldet", "Abmelden", MessageBoxButtons.OK);

                Properties.Settings.Default.Power_Signoff_L_ctr++;
                Properties.Settings.Default.Power_Signoff_L_date = DateTime.Now;
                Properties.Settings.Default.Save();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.FileName = "shutdown.exe";
                startInfo.Arguments = "/l";
                process.StartInfo = startInfo;
                process.Start();
            }
        }
        #endregion

        #region Power_Button_Hover_Events
        private void btnShutdown_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Shutdown;

            lblPowerTitle.Text = "Herunterfahren (Windows-Standart)";
            lblPowerDescription.Text = 
                "Standart Herunterfahr-Routine von Windows 10\r\n\r\n" +
                "Bei diesem Verfahren werden alle Programme nach dem Herunterfahren wieder gestartet.\r\n\r\n" +
                "Diese Routine sollte nicht nach Arbeitsspeicherintensiven\r\n" +
                "Programmen ausgeführt werden, stattdessen sollte das vollständige\r\n" +
                "Herunterfahren gewählt werden."; 
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Shutdown_SG_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Shutdown_SG_date.ToString();
        }

        private void btnShutdownFull_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Shutdown;

            lblPowerTitle.Text = "Herunterfahren (Vollständig/Empfohlen)";
            lblPowerDescription.Text =
                "Vollständige Herunterfahr-Routine\r\n\r\n" +
                "Bei dieser Routine wird der PC vollständig Heruntergefahren\r\n" +
                "und für einen Sauberen Neustart vorbereitet.\r\n\r\n" +
                "Diese Option sollte regelmäßig gewählt werden, vor allem nach\r\n" +
                "Arbeitsspeicherintensiven Programmen.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Shutdown_S_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Shutdown_S_date.ToString();
        }

        private void btnQuickStart_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Shutdown;

            lblPowerTitle.Text = "Schnellstart (Experimentell)";
            lblPowerDescription.Text =
                "Experimentelle Herunterfahr-Routine\r\n\r\n" +
                "Diese Routine soll das schnellere starten den PCs ermöglichen.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Quickstart_Hybrid_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Quickstart_Hybrid_date.ToString();
        }

        private void btnRestart_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Restart;

            lblPowerTitle.Text = "Neu Starten (Windows-Standart)";
            lblPowerDescription.Text =
                "Standart Neustart-Routine von Windows 10\r\n\r\n" +
                "Bei diesem Verfahren werden alle Programme nach dem Neustart wieder gestartet.\r\n\r\n" +
                "Diese Routine sollte nicht nach Arbeitsspeicherintensiven\r\n" +
                "Programmen ausgeführt werden, stattdessen sollte der vollständige\r\n" +
                "Neustart gewählt werden.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Restart_G_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Restart_G_date.ToString();
        }

        private void btnRestartFull_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Restart;

            lblPowerTitle.Text = "Neu Starten (Vollständig/Empfohlen)";
            lblPowerDescription.Text =
                "Vollständige Neustart-Routine\r\n\r\n" +
                "Bei dieser Routine wird der PC vollständig Neu gestartet\r\n\r\n" +
                "Diese Option sollte regelmäßig gewählt werden, vor allem nach\r\n" +
                "Arbeitsspeicherintensiven Programmen.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Restart_R_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Restart_R_date.ToString();
        }

        private void btnHibernate_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Hibernate;

            lblPowerTitle.Text = "Ruhezustand (Windows-Standart)";
            lblPowerDescription.Text =
                "Standart Ruhezustand-Routine\r\n\r\n" +
                "Diese Methode ist ähnlich zum Energiesparmodus:\r\n" +
                "Der PC kann schnell starten und alle Programme sind nach dem\r\n" +
                "Start nach wie vor geöffnet.\r\n\r\n" +
                "Der Vorteil im vergleich zum Energiesparmodus ist:\r\n" +
                "Der PC wird vollständig ausgeschaltet, demnach verbraucht er keinen Strom.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Hibernate_H_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Hibernate_H_date.ToString();
        }

        private void btnSignOff_MouseEnter(object sender, EventArgs e)
        {
            pbxPowerSymbol.Image = Properties.Resources.Logoff;
            
            lblPowerTitle.Text = "Abmelden (Alle Programme Schließen)";
            lblPowerDescription.Text =
                "Standart Abmelde-Routine\r\n\r\n" +
                "Der Nutzer wird von seinem Konto Abgemeldet und alle geöffneten Programme werden\r\n" +
                "geschlossen.";
            lblPowerExecutedCtr.Text = "Funktion Ausgeführt: " + Properties.Settings.Default.Power_Signoff_L_ctr.ToString();
            lblPowerExecutedDate.Text = "Zuletzt Ausgeführt: " + Properties.Settings.Default.Power_Signoff_L_date.ToString();
        }
        #endregion

        
    }
}
