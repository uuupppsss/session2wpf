using GraphX.Controls;
using GraphX.Logic.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimerBestBoy2.Model;


namespace TimerBestBoy2.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LoadGraph();
        }

        private void LoadGraph()
        {
            var graph = new OrgGraph();

            var root = new OrgVertex("Дороги России");
            var dept1 = new OrgVertex("Административный департамент");
            var dept2 = new OrgVertex("Академия Уменя дороги");
            var dept3 = new OrgVertex("Договорной отдел");
            var dept4 = new OrgVertex("Общий отдел");
            var dept5 = new OrgVertex("Лицензионный отдел");
            var dept6 = new OrgVertex("Управление маркетинга");

            graph.AddVertexRange(new[] { root, dept1, dept2, dept3, dept4, dept5, dept6 });

            graph.AddEdge(new OrgEdge(root, dept1));
            graph.AddEdge(new OrgEdge(root, dept2));
            graph.AddEdge(new OrgEdge(root, dept3));
            graph.AddEdge(new OrgEdge(root, dept4));
            graph.AddEdge(new OrgEdge(root, dept5));
            graph.AddEdge(new OrgEdge(root, dept6));

            var logic = new GXLogicCore<OrgVertex, OrgEdge, OrgGraph>
            {
                Graph = graph
            };

            var area = new GraphArea<OrgVertex, OrgEdge, OrgGraph> { LogicCore = logic };
            
            area.GenerateGraph();

            Content = area;
        }
    }
}