using System;
using System.Windows.Forms;

namespace Kruskal_LVUB0T
{
    public partial class InputGraph : Form
    {
        //Az élünk amit a felhasználó megad
        private Edge newEdge;

        public InputGraph()
        {
            InitializeComponent();            
        }

        private void NoMore_BTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        //Az imént beírt adatokat megpróbáljuk felvenni egy új élként
        private void OneMore_BTN_Click(object sender, EventArgs e)
        {
            string start = startV_TextBox.Text.Trim();
            string end = endV_TextBox.Text.Trim();
            string weight = weightE_TextBox.Text.Trim();

            //Persze ezt csak akkor tesszük, ha a felhasználó helyes adatokat adott meg
            if (inputIsValid(start, end, weight))
            {
                //Hozzáadunk egy új élet a bemeneti gráfhoz
                newEdge = new Edge(Convert.ToInt32(start), Convert.ToInt32(end), Convert.ToInt32(weight));
                //Ez alapján fogja látni a szülő form, hogy sikeres volt az adatbevitel
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Hibás adatbevitel! Számokat adj meg, valamint csak a súly lehet negatív!");
        }

        private bool inputIsValid(string start, string end, string weight)
        {
            int s, e, w;
            
            //Valamelyik mező üres, vagy csak szóközöket tartalmaz
            if (start == "" || end == "" || weight == "")
                return false;

            //Csak számot tartalmaznak a mezők?
            try
            {
                s = Convert.ToInt32(start);
                e = Convert.ToInt32(end);
                w = Convert.ToInt32(weight);
            }
            catch
            {
                return false;
            }

            //Az él start és végcsúcsa 0 vagy nagyobb indexű lehet csak!
            if (s < 0 || e < 0)
                return false;

            //Ha a fentebbi ellenőrzéseken átment a felhasználó által megadott adat, elfogadjuk
            return true;
        }

        public Edge getEdge()
        {
            return newEdge;
        }
    }
}
