using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Kruskal_LVUB0T
{
    [Serializable]
    public class Graph
    {
        //Gráf éleit tartalmazó lista        
        private List<Edge> edges = new List<Edge>();
        //Gráf csúcsait tartalmazó halmaz        
        private HashSet<int> verts = new HashSet<int>();

        //Éllista getter/setter        
        public List<Edge> Edges { get => edges; set => edges = value; }
        //Csúcsok getter/setter        
        public HashSet<int> Verts { get => verts; set => verts = value; }

        public Graph(List<Edge> edges)
        {
            this.edges = edges;

            foreach (var edge in edges)
            {
                //Csúcsok felvétele a csúcslistába
                Verts.Add(edge.Start);
                Verts.Add(edge.End);
            }
        }

        public Graph()
        {
            //Üres konstruktor, üres gráfhoz. Ehhez az AddEdge metódussal ugyanúgy hozzáadhatunk éleket később
        }

        public void AddEdge(Edge edge)
        {
            this.edges.Add(edge);

            Verts.Add(edge.Start);
            Verts.Add(edge.End);
        }

        public static Graph readGraph(string fileName)
        {
            try
            {
                return JsonConvert.DeserializeObject<Graph>(File.ReadAllText(fileName));
            }
            catch (IOException e)
            {                
                MessageBox.Show(e.Message, "Fájl olvasási hiba");
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message, "Fájlszerkezet hiba");
            }
            return null;
        }

        public void writeGraph(string fileName)
        {
            try
            {
                File.WriteAllText((fileName), JsonConvert.SerializeObject(this, Formatting.Indented));
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Fájl írási hiba");                
            }            
        }

        public string printGraph()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var edge in edges)
            {
                sb.Append(edge.PrintEdge());
            }
            return sb.ToString();
        }

        public Graph inputGraph()
        {

            return null;
        }

    }

    class Kruskal
    {
        //A gráf amit feldolgozunk
        Graph graph;
        //A kezdetben a csúcsokat egyenként tartalmazó halmazokból álló lista
        private List<HashSet<int>> sets = new List<HashSet<int>>();
        //A struktogramban A-val jelölt élhalmaz
        private List<Edge> minSpan = new List<Edge>();

        public Kruskal(Graph graph)
        {
            this.graph = graph;
        }

        public Graph GenMinSpanTree(ref string log)
        {
            log += "Algoritmus inicializációja...\r\n";
            //G.E mon. növ. rendezés súly szerint
            log += "Élek súly szerinti monoton növekvő rendezése.\r\n";
            graph.Edges = graph.Edges.OrderBy(x => x.Weight).ToList();
            //minden u eleme G.V-re 
            foreach(int vert in graph.Verts)
            {
                log += "make_set(" + vert + ")\r\n";
                //make_set(u)
                HashSet<int> temp = new HashSet<int>(); temp.Add(vert);
                sets.Add(temp);
            }
            //minden (u,v) eleme G.E-re
            foreach(var edge in graph.Edges)
            {
                int x = HolVan(edge.Start);
                int y = HolVan(edge.End);

                if (x != y)
                {
                    minSpan.Add(edge);
                    log += "A = A unió {(" + edge.Start + "," + edge.End + ")}\r\n";
                    Union(x, y);
                    log += "Unió("+x+". halmaz ,"+y+". halmaz)\r\n";
                }
            }

            return new Graph(minSpan);
        }

        private int HolVan(int u)
        {
            //Végigmegyünk a csúcsokat tartalmazó halmazainkon
            for (int i = 0; i < sets.Count; i++)
            {
                //Ebben a halmazban van a keresett csúcs? Ha igen, térjünk vissza az indexével
                if (sets[i].Contains(u))
                    return i;
            }

            return -99;
        }

        private void Union(int x, int y)
        {            
            //Az x-edik halmazhoz hozzá uniózzuk az y.-at. Ilyenkor az y. megmaradna külön is, így azt el kell távolítani!
            sets[x].UnionWith(sets[y]);
            sets.RemoveAt(y);
        }
    }

    public class Edge
    {        
        private int start, end, weight;

        public int Start { get => start; set => start = value; }
        public int Weight { get => weight; set => weight = value; }
        public int End { get => end; set => end = value; }

        public Edge(int start, int end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }

        public string PrintEdge()
        {
            return "Kezdőcsúcs: " + Start + " Végcsúcs: " + End + " Súly: " + Weight + "\r\n";
        }
    }
}
