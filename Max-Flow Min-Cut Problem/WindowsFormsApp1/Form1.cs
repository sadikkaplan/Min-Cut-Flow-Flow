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
using System.Xml;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static float maxflow = 0f;
        static float flow = 0f;
        static string edges1 = "";
        static string strSA, strSB, strSC, strAS, strAT, strAD, strAB, strBA, strBS, strBT, strBE, strCS, strCE, strDA,
            strDT, strEB, strEF, strET, strEC, strFE, strFT, strTA, strTB, strTD, strTE, strTF, strCT, strST;

        
        public Form1()
        {
            InitializeComponent();
        }
        public class Ford_Fulkerson
        {

            static Dictionary<int, Node> Nodes
            {
                get;
                set;
            }
            static Dictionary<string, Edge> Edges { get; set; }
            private const float maxDeger = float.MaxValue;
            
            public Ford_Fulkerson()
            {
                Nodes = new Dictionary<int, Node>();
                Edges = new Dictionary<string, Edge>();
            }

            void Veriler()
            {
                Reset();

                var names = new[] { "x", "s", "2", "3", "4", "5", "6", "7", "t" };
                foreach (Node node in names.Select(name => new Node() { Name = name }))
                    Nodes.Add(node.Id, node);

                
                var edges = new[]
                    { strSA, strSB, strSC, strAT, strAD, strAB,
                    strBT, strBE, strCE, strDT, strEF, strET, strFT, strCT, strST };

                foreach (var edge in edges)
                {
                    string[] str = edge.Split(' ');
                    int str0 = int.Parse(str[0]);
                    int str1 = int.Parse(str[1]);
                    float str2 = float.Parse(str[2]);

                    Node node1 = Nodes[str0];
                    Node node2 = Nodes[str1];
                    float kapasite = str2;

                    AddEdge(node1, node2, kapasite);
                    AddEdge(node2, node1, 0f); 
                }
            }
            public void Run()
            {
                Veriler();
                Algoritma();
            }

            void Algoritma()
            {
                var nSource = Nodes[1];
                var nStation = Nodes[Nodes.Count - 1];

                FFalgoritma(nSource, nStation);
            }
            private void FFalgoritma(Node nSource, Node nStation)
            {
              
                var path = Bfs(nSource, nStation);

                while (path != null && path.Count > 0)
                {
                    var minKapasite = maxDeger;
                    foreach (var edge in path)
                    {
                        if (edge.Capacity < minKapasite)
                            minKapasite = edge.Capacity;
                    }

                    if (minKapasite == maxDeger || minKapasite < 0)
                        throw new Exception("minCapacity " + minKapasite);

                    AugmentPath(path, minKapasite);
                    flow += minKapasite;

                    path = Bfs(nSource, nStation);
                }
            }
            private static void AugmentPath(IEnumerable<Edge> path, float minCapacity)
            {
                foreach (var edge in path)
                {
                    var keyResidual = GetKey(edge.NodeTo.Id, edge.NodeFrom.Id);
                    var edgeResidual = Edges[keyResidual];

                    edge.Capacity -= minCapacity;
                    edgeResidual.Capacity += minCapacity;
                }
            }
            
           
            List<Edge> Bfs(Node root, Node target)
            {
                root.caprazParent = null;
                target.caprazParent = null; 

                var kuyruk = new Queue<Node>();
                var ziyaret = new HashSet<Node>();
                kuyruk.Enqueue(root);

                while (kuyruk.Count > 0)
                {
                    Node current = kuyruk.Dequeue();
                    ziyaret.Add(current);

                    if (current.Id == target.Id)
                        return GetPath(current);

                    var nodeEdges = current.NodeEdges;
                    foreach (var edge in nodeEdges)
                    {
                        var next = edge.NodeTo;
                        var c = GetCapacity(current, next);
                        if (c > 0 && !ziyaret.Contains(next))
                        {
                            next.caprazParent = current;
                            kuyruk.Enqueue(next);
                        }
                    }
                }
                return null;
            }

            static List<Edge> GetPath(Node node)
            {
                var path = new List<Edge>();
                var current = node;
                while (current.caprazParent != null)
                {
                    var key = GetKey(current.caprazParent.Id, current.Id);
                    var edge = Edges[key];
                    path.Add(edge);
                    current = current.caprazParent;
                }
                return path;
            }

           

            public float GetCapacity(Node node1, Node node2)
            {
                var edge = Edges[GetKey(node1.Id, node2.Id)];
                return edge.Capacity; // Boru kapasitesini alıyoruz
            }

            public static string GetKey(int id1, int id2)
            {
                return id1 + "|" + id2;
            }

            public void AddEdge(Node nodeFrom, Node nodeTo, float capacity)
            {
                var key = GetKey(nodeFrom.Id, nodeTo.Id);
                var edge = new Edge() { NodeFrom = nodeFrom, NodeTo = nodeTo, Capacity = capacity, Name = key };
                Edges.Add(key, edge); // Graftaki her boruyu (edge) ekliyoruz
                nodeFrom.NodeEdges.Add(edge);
            }

            private static void Reset()
            {
                Node.SayacReset();

                Edges.Clear();

                Nodes.Clear();

            }

            public class Node
            {
                public string Name { get; set; }
                private static int sayac;
                public Node caprazParent { get; set; }
                public List<Edge> NodeEdges { get; set; }
                public readonly int Id;

                
                public override string ToString()
                {
                    return string.Format("Id={0}, Name={1}", Id, Name);
                }

                public static void SayacReset()
                {
                    sayac = 0;
                }
                public Node()
                {
                    NodeEdges = new List<Edge>();
                    Id = sayac++;

                }

            }

            public class Edge
            {
                public Node NodeTo { get; set; }
                public float Capacity { get; set; }
                public Node NodeFrom { get; set; }
                public string Name { get; set; }

                public string Info()
                {
                    return string.Format("NodeFrom=({0}), NodeTo=({1}), C={2}", NodeFrom, NodeTo, Capacity);
                }
                public override string ToString()
                {
                    return
                        string.Format("NodeFrom={0}, NodeTo={1}, C={2}", NodeFrom.Name, NodeTo.Name, Capacity);
                }
                
            }
        }

        
        private void drawNode(int k)
        {
            
            Graphics graphicsNode;
            graphicsNode = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Black, 3);
            int edgeR = groupBox1.Location.X;
            Font myFont = new Font("Helvetica", 20, FontStyle.Regular);
            Brush myBrush = new SolidBrush(Color.Red);
            if (k == 2)
            {
                graphicsNode.Clear(Color.AliceBlue);
                
                graphicsNode.DrawString("S", myFont, myBrush, 255,205 );
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawLine(pen, 290, 220, 750, 220);

            }
            if (k == 3)
            {
                graphicsNode.Clear(Color.AliceBlue);
                
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 505, 55);


                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 50, 40, 40);
                graphicsNode.DrawLine(pen, 290, 220, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 70);
                graphicsNode.DrawLine(pen, 540, 70, 750, 220);

            }
            if (k == 4)
            {
                graphicsNode.Clear(Color.AliceBlue);
                
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 505, 55);
                graphicsNode.DrawString("B", myFont, myBrush, 505, 355);

                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 50, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 350, 40, 40);
                graphicsNode.DrawLine(pen, 290, 220, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 70);
                graphicsNode.DrawLine(pen, 540, 70, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 370);
                graphicsNode.DrawLine(pen, 540, 370, 750, 220);

            }
            if (k == 5)
            {
                graphicsNode.Clear(Color.AliceBlue);
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 505, 55);
                graphicsNode.DrawString("B", myFont, myBrush, 505, 205);
                graphicsNode.DrawString("C", myFont, myBrush, 505, 355);
                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 50, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 350, 40, 40);
                graphicsNode.DrawLine(pen, 290, 220, 500, 220);
                graphicsNode.DrawLine(pen, 540, 220, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 70);
                graphicsNode.DrawLine(pen, 540, 70, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 370);
                graphicsNode.DrawLine(pen, 540, 370, 750, 220);
                graphicsNode.DrawLine(pen, 520, 90, 520, 200);
            }
            if (k == 6)
            {
                graphicsNode.Clear(Color.AliceBlue);
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 405, 55);
                graphicsNode.DrawString("D", myFont, myBrush, 605, 55);
                graphicsNode.DrawString("B", myFont, myBrush, 505, 205);
                graphicsNode.DrawString("C", myFont, myBrush, 505, 355);

                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 400, 50, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 600, 50, 40, 40);

                graphicsNode.DrawLine(pen, 290, 220, 500, 220);
                graphicsNode.DrawLine(pen, 540, 220, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 400, 70);
                graphicsNode.DrawLine(pen, 440, 70, 750, 220);
                graphicsNode.DrawLine(pen, 440, 70, 600, 70);
                graphicsNode.DrawLine(pen, 620, 90, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 500, 370);
                graphicsNode.DrawLine(pen, 540, 370, 750, 220);
                graphicsNode.DrawLine(pen, 420, 90, 520, 200);
            }
            if (k == 7)
            {
                graphicsNode.Clear(Color.AliceBlue);
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 405, 55);
                graphicsNode.DrawString("D", myFont, myBrush, 605, 55);
                graphicsNode.DrawString("B", myFont, myBrush, 505, 205);
                graphicsNode.DrawString("C", myFont, myBrush, 405, 355);
                graphicsNode.DrawString("E", myFont, myBrush, 605, 355);

                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 400, 50, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 400, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 600, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 600, 50, 40, 40);

                graphicsNode.DrawLine(pen, 290, 220, 500, 220);
                graphicsNode.DrawLine(pen, 540, 220, 750, 220);
                graphicsNode.DrawLine(pen, 540, 220, 600, 370);
                graphicsNode.DrawLine(pen, 290, 220, 400, 70);
                graphicsNode.DrawLine(pen, 440, 70, 750, 220);
                graphicsNode.DrawLine(pen, 440, 70, 600, 70);
                graphicsNode.DrawLine(pen, 620, 90, 750, 220);
                graphicsNode.DrawLine(pen, 640, 370, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 400, 370);
                graphicsNode.DrawLine(pen, 440, 370, 600, 370);
                graphicsNode.DrawLine(pen, 420, 90, 520, 200);
            }
            if (k == 8)
            {
                graphicsNode.Clear(Color.AliceBlue);
                graphicsNode.DrawString("S", myFont, myBrush, 255, 205);
                graphicsNode.DrawString("T", myFont, myBrush, 755, 205);
                graphicsNode.DrawString("A", myFont, myBrush, 405, 55);
                graphicsNode.DrawString("D", myFont, myBrush, 605, 55);
                graphicsNode.DrawString("B", myFont, myBrush, 505, 205);
                graphicsNode.DrawString("C", myFont, myBrush, 405, 355);
                graphicsNode.DrawString("E", myFont, myBrush, 605, 355);
                graphicsNode.DrawString("F", myFont, myBrush, 705, 355);

                graphicsNode.DrawEllipse(pen, 250, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 750, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 400, 50, 40, 40);
                graphicsNode.DrawEllipse(pen, 500, 200, 40, 40);
                graphicsNode.DrawEllipse(pen, 400, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 600, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 700, 350, 40, 40);
                graphicsNode.DrawEllipse(pen, 600, 50, 40, 40);

                graphicsNode.DrawLine(pen, 290, 220, 500, 220);
                graphicsNode.DrawLine(pen, 540, 220, 750, 220);
                graphicsNode.DrawLine(pen, 540, 220, 600, 370);
                graphicsNode.DrawLine(pen, 290, 220, 400, 70);
                graphicsNode.DrawLine(pen, 440, 70, 750, 220);
                graphicsNode.DrawLine(pen, 440, 70, 600, 70);
                graphicsNode.DrawLine(pen, 620, 90, 750, 220);
                graphicsNode.DrawLine(pen, 640, 370, 750, 220);
                graphicsNode.DrawLine(pen, 640, 370, 700, 370);
                graphicsNode.DrawLine(pen, 740, 370, 750, 220);
                graphicsNode.DrawLine(pen, 290, 220, 400, 370);
                graphicsNode.DrawLine(pen, 440, 370, 600, 370);
                graphicsNode.DrawLine(pen, 420, 90, 520, 200);
            }

        }
        List<Label> labels = new List<Label>();
        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            int k = int.Parse(textBox1.Text);
            drawNode(k);
            
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            flow = 0;
            // Düğümlerin karşıladığı sayılar
            // S=1, A=2, B=3, C=4, D=5, E=6, F=7, T=8

            strSA = "1 2 " + txtSA.Text.ToString();
            strSB = "1 3 " + txtSB.Text.ToString();
            strSC = "1 4 " + txtSC.Text.ToString();
            strST = "1 8 " + txtST.Text.ToString();
            strAB = "2 3 " + txtAB.Text.ToString();
            strAT = "2 8 " + txtAT.Text.ToString();
            strAD = "2 5 " + txtAD.Text.ToString();
            strBE = "3 6 " + txtBE.Text.ToString();
            strBT = "3 8 " + txtBT.Text.ToString();

            strCE = "4 6 " + txtCE.Text.ToString();
            strCT = "4 8 " + txtCT.Text.ToString();
            strDT = "5 8 " + txtDT.Text.ToString();
            strEF = "6 7 " + txtEF.Text.ToString();
            strET = "6 8 " + txtET.Text.ToString();
            strFT = "7 8 " + txtFT.Text.ToString();

            new Ford_Fulkerson().Run();
            txtMaxFlow.Text = "" + flow;
        }
    }
}
