using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class FrmPedraPaperTisora : Form
    {
        string jugadaJug = "";
        string jugadaComp = "";
        int ronda = 0;
        int puntsJug = 0;
        int puntsComp = 0;

        public event EventHandler emTanquen;
        public FrmPedraPaperTisora()
        {
            InitializeComponent();
            iniciComp();
        }

        private void iniciComp()
        {
            Random numeroRandom = new Random();
            Int32 numeroJugada;
            numeroJugada = (int)numeroRandom.Next() % 3 + 1;

            if(jugadaComp == "" && jugadaJug == "") /// si las dos estan vacias, quiere decir que es una nueva ronda
            {
                switch (numeroJugada)
                {
                    case 1:
                        jugadaComp = "pedra";
                        break;
                    case 2:
                        jugadaComp = "paper";
                        break;
                    case 3:
                        jugadaComp = "tisora";
                        break;
                }
            }
        }

        private void FrmPedraPaperTisora_FormClosing(object sender, FormClosingEventArgs e)
        {
            emTanquen(this, EventArgs.Empty);
        }

        private void btPedra_Click(object sender, EventArgs e)
        {
            jugadaJug = "pedra";
            lbJugadaActual.Text = "JUGADA ACTUAL: " + jugadaJug;
        }

        private void btPaper_Click(object sender, EventArgs e)
        {
            jugadaJug = "paper";
            lbJugadaActual.Text = "JUGADA ACTUAL: " + jugadaJug;
        }

        private void btTisora_Click(object sender, EventArgs e)
        {
            jugadaJug = "tisora";
            lbJugadaActual.Text = "JUGADA ACTUAL: " + jugadaJug;
        }

        private void btJugarRonda_Click(object sender, EventArgs e)
        {

            lbJugadaJugador.Text = "JUGADA ANTERIOR: " + jugadaJug.ToString();
            lbJugadaComputador.Text = "JUGADA ANTERIOR: " + jugadaComp.ToString();

            /// Si guanya la computadora
            if (jugadaJug == "pedra" && jugadaComp == "paper")
            {
                puntsComp++;
                lbPuntsComp.Text = "TOTAL PUNTS COMPUTADORA: " + puntsComp.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Green;
                lbStatusAnteriorComp.Text = "VICTORIA";

                lbStatusAnteriorJug.ForeColor = Color.Red;
                lbStatusAnteriorJug.Text = "DERROTA";
            }
            else if(jugadaJug == "paper" && jugadaComp == "tisora")
            {
                puntsComp++;
                lbPuntsComp.Text = "TOTAL PUNTS COMPUTADORA: " + puntsComp.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Green;
                lbStatusAnteriorComp.Text = "VICTORIA";

                lbStatusAnteriorJug.ForeColor = Color.Red;
                lbStatusAnteriorJug.Text = "DERROTA";
            }
            else if(jugadaJug == "tisora" && jugadaComp == "pedra")
            {
                puntsComp++;
                lbPuntsComp.Text = "TOTAL PUNTS COMPUTADORA: " + puntsComp.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Green;
                lbStatusAnteriorComp.Text = "VICTORIA";

                lbStatusAnteriorJug.ForeColor = Color.Red;
                lbStatusAnteriorJug.Text = "DERROTA";
            }
            /// Si guanya el jugador
            else if (jugadaJug == "paper" && jugadaComp == "pedra")
            {
                puntsJug++;
                lbPuntsJugador.Text = "TOTAL PUNTS JUGADOR: " + puntsJug.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Red;
                lbStatusAnteriorComp.Text = "DERROTA";

                lbStatusAnteriorJug.ForeColor = Color.Green;
                lbStatusAnteriorJug.Text = "VICTORIA";
            }
            else if (jugadaJug == "tisora" && jugadaComp == "paper")
            {
                puntsJug++;
                lbPuntsJugador.Text = "TOTAL PUNTS JUGADOR: " + puntsJug.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Red;
                lbStatusAnteriorComp.Text = "DERROTA";

                lbStatusAnteriorJug.ForeColor = Color.Green;
                lbStatusAnteriorJug.Text = "VICTORIA";
            }
            else if (jugadaJug == "pedra" && jugadaComp == "tisora")
            {
                puntsJug++;
                lbPuntsJugador.Text = "TOTAL PUNTS JUGADOR: " + puntsJug.ToString();

                lbStatusAnteriorComp.ForeColor = Color.Red;
                lbStatusAnteriorComp.Text = "DERROTA";

                lbStatusAnteriorJug.ForeColor = Color.Green;
                lbStatusAnteriorJug.Text = "VICTORIA";
            }
            else if(jugadaJug == jugadaComp)
            {
                lbStatusAnteriorComp.ForeColor = Color.Blue;
                lbStatusAnteriorComp.Text = "EMPAT";

                lbStatusAnteriorJug.ForeColor = Color.Blue;
                lbStatusAnteriorJug.Text = "EMPAT";
            }

            ronda++;
            lbTotalPartides.Text = "RONDA " + ronda.ToString();

            jugadaJug = "";

            jugadaComp = "";

            iniciComp();

            lbJugadaActual.Text = "***SELECCIONA***";
        }
    }
}
