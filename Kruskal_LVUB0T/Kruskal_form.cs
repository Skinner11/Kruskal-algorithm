using System;
using System.Windows.Forms;
using System.IO;

namespace Kruskal_LVUB0T
{
    //Kruskal algoritmus C# WinForms implementáció
    //Készítette: Láber Attila / LVUB0T
    //Megjegyzések: Nem összefüggő gráfokra is lefut az algoritmus, de nem feltétlenül ad helyes minimális feszítőerdőt!
    //Üres gráfokra, negatív súlyokat tartalmazó gráfokra tesztelve lett, mellékeltem is mintabemenetet ezen esetekre.
    //Manuálisan is meg lehet adni gráfot, élenként.

    public partial class Kruskal_form : Form
    {
        string initDir = Path.Combine(Environment.CurrentDirectory, "graphs");
        static Graph openedGraph;
        static Graph openedMinSpanTree;
        static Graph inputGraph;

        public Kruskal_form()
        {
            InitializeComponent();
            //Ha nem létezik a program indítási helye mellett a "graphs" mappa, hozzuk létre            
            Directory.CreateDirectory(initDir);
        }

        private void gráfBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Konzol törlése
            console_TextBox.Text = "";
            //Gráfot leíró json betöltése
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = initDir,
                Title = "Válaszd ki a betöltendő gráfot!",
                Filter = "json files (*.json)|*.json|All files (*.*)|*.*"
            };

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                openedGraph = Graph.readGraph(ofd.FileName);
                if (openedGraph != null)
                {
                    loadedGraph_TextBox.Text = openedGraph.printGraph();
                    console_TextBox.Text += "Gráf sikeresen betöltve!\r\n";
                }                 

            }
        }

        private void genMinSpanTree_Click(object sender, EventArgs e)
        {
            if(openedGraph==null)
            {
                MessageBox.Show("Előbb tölts be, vagy adj meg egy gráfot!", "Lassan a testtel!");
                return;
            }
            //Átadjuk az algoritmusnak a feldolgozandó gráfunkat
            Kruskal kruskal = new Kruskal(openedGraph);
            //Valamint egy stringet amibe a lépéseket jegyzi majd
            string log = "";
            //Legeneráltatjuk a minimális feszítőfát
            openedMinSpanTree = kruskal.GenMinSpanTree(ref log);
            if (openedMinSpanTree != null)
                //Majd megjelenítjük
                minSpanTree_TextBox.Text = openedMinSpanTree.printGraph();
            //Végül kiírjuk az egyes lépéseket a konzolra
            console_TextBox.Text += log;                        
        }

        private void gráfMegadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            console_TextBox.Text += "Manuális gráf megadás inicializálva.\r\n";

            //"Lenullázzuk" a felhasználó által megadott gráfot
            inputGraph = new Graph();
            //Leállási feltétel
            bool addMore = true;

            //Amíg újabb élet szeretne felvenni a felhasználó, dobunk neki egy új InputGraph formot amin megteheti ezt
            while (addMore)
            {
                InputGraph ig = new InputGraph();
                if (ig.ShowDialog() == DialogResult.OK)
                {
                    inputGraph.AddEdge(ig.getEdge());
                    console_TextBox.Text += "Él hozzáadva: "+ ig.getEdge().PrintEdge();
                }                  
                else
                {
                    addMore = false;
                    console_TextBox.Text += "Manuális gráf megadás leállítva.\r\n";
                }                  
            }

            
            if (inputGraph != null)
            {
                //Megkérdezzük a felhasználót, menteni is szeretné-e a megadott gráfot (.json)
                DialogResult dr = MessageBox.Show("Szeretnéd fájlba menteni a megadott gráfot?", "Gráf mentése", MessageBoxButtons.YesNo);
                if (dr==DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        InitialDirectory = initDir,
                        Title = "Válaszd ki a mentés helyét és a fájlnevet!",
                        Filter = "json files (*.json)|*.json|All files (*.*)|*.*"
                    };

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        inputGraph.writeGraph(sfd.FileName);
                        console_TextBox.Text += "Gráf fájlba mentve " + Path.GetFileName(sfd.FileName)+" néven.\r\n";
                    }
                }

                //Megkérdezzük a felhasználót, szeretné-e aktuális gráfnak betölteni a megadott gráfot
                dr = MessageBox.Show("Szeretnéd használni az imént megadott gráfot?", "Gráf feldolgozása", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    openedGraph = inputGraph;
                    loadedGraph_TextBox.Text = openedGraph.printGraph();
                    console_TextBox.Text += "Manuálisan megadott gráf betöltve feldolgozáshoz.\r\n";
                }
            }            
        }

        private void clearConsole_BTN_Click(object sender, EventArgs e)
        {
            console_TextBox.Text = "";
        }
    }
}
