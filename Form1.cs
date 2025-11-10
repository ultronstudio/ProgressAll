using System;
using System.Drawing;
using System.Windows.Forms;
using Ultron.WinForms.HelpAbout;

namespace ProgressAll
{
    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private int currentProgress = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents(); // Inicializace specifických nastavení
            ResetProgressBar();

            this.UseStandardHelpAbout(new HelpAboutOptions
            {
                Category = TaskCategory.PraceVHodine,
                Author = "Petr Vurm",
                ExtraLines = "SPŠ Hradební — PROGRAMOVÁNÍ"
            });
        }

        /// <summary>
        /// Inicializuje vlastní komponenty a jejich výchozí stavy.
        /// </summary>
        private void InitializeCustomComponents()
        {
            // Nastavení textu na ProgressBar
            UpdateStatusStrip();

            // Vizuálního vynulování
            pbarProgress.Minimum = 0;
            pbarProgress.Maximum = 100;
        }

        private void btnAkce_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                ResetProgressBar();
            }
            else
            {
                StartProgressBar();
            }
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            // Kontrola maxima průběhu
            if (currentProgress >= pbarProgress.Maximum)
            {
                ResetProgressBar();
                return; // Ukočení - nesmí dál pracovat
            }

            // Inkrementace průběhu
            currentProgress += 1;

            // Aktualizace ProgressBar a StatusStrip
            pbarProgress.Value = currentProgress;
            UpdateStatusStrip();
        }

        /// <summary>
        /// Spustí animaci ProgressBar.
        /// </summary>
        private void StartProgressBar()
        {
            isRunning = true;
            currentProgress = 0; // Vždy začátek od nuly
            pbarProgress.Value = currentProgress;
            btnAkce.Text = "Reset";
            timerProgress.Enabled = true;
            UpdateStatusStrip("Načítání...");
        }

        /// <summary>
        /// Resetuje ProgressBar do výchozího stavu.
        /// </summary>
        private void ResetProgressBar()
        {
            isRunning = false;
            currentProgress = 0;
            pbarProgress.Value = currentProgress;
            btnAkce.Text = "Start";
            timerProgress.Enabled = false;
            UpdateStatusStrip("Připraven");
        }

        /// <summary>
        /// Aktualizuje text ve StatusStrip s aktuálním průběhem nebo vlastní zprávou.
        /// </summary>
        /// <param name="message">Zpráva k zobrazení. Pokud není zadána, zobrazí se procenta.</param>
        private void UpdateStatusStrip(string message = null)
        {
            if (message != null)
            {
                stripStatus_Stav.Text = message;
            }
            else
            {
                stripStatus_Stav.Text = $"Načítání... {currentProgress}%";
            }
        }
    }
}