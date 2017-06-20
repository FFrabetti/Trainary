using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;

namespace Trainary.presenter
{
    public class TreeViewPresenter
    {
        private TreeView _treeView;

        public TreeViewPresenter(TreeView treeView)
        {
            _treeView = treeView;
        }

        public void VisualizzaEserciziSvolti(IEnumerable<EsercizioSvolto> eserciziSvolti)
        {
            _treeView.Nodes.Clear();
            TreeNode treeNode = new TreeNode("Esercizi Svolti");
            VisualizzaSottoEsercizi(eserciziSvolti, treeNode);
            _treeView.Nodes.Add(treeNode);
        }

        private void VisualizzaSottoEsercizi(IEnumerable<EsercizioSvolto> esercizi, TreeNode nodeEs)
        {
            foreach (EsercizioSvolto es in esercizi)
            {
                TreeNode node = new TreeNode(es.ToString());
                node.Tag = es;
                if (es.Esercizio.Targets.Length > 0)
                {
                    TreeNode nodoTargets = new TreeNode("Targets");
                    foreach (Attributo target in es.Esercizio.Targets)
                    {
                        TreeNode nodoTarget = new TreeNode(target.ToString());
                        nodoTargets.Nodes.Add(nodoTarget);
                    }
                    node.Nodes.Add(nodoTargets);
                }
                if (es.Dati.Count > 0)
                {
                    TreeNode nodoDati = new TreeNode("Dati");
                    foreach (Attributo dato in es.Dati)
                    {
                        TreeNode nodoTarget = new TreeNode(dato.ToString());
                        nodoDati.Nodes.Add(nodoTarget);
                    }
                    node.Nodes.Add(nodoDati);
                }
                nodeEs.Nodes.Add(node);

                VisualizzaSottoEsercizi(es.SottoEserciziSvolti, node);
            }
        }

        public void VisualizzaSedute(IEnumerable<Seduta> sedute)
        {
            _treeView.Nodes.Clear();
            foreach (Seduta seduta in sedute)
            {
                VisualizzaSeduta(seduta);
            }
        }

        public void VisualizzaSeduta(Seduta seduta)
        {
            TreeNode node = new TreeNode(seduta.ToString());
            node.Tag = seduta;
            VisualizzaEserciziSeduta(node, seduta.Esercizi);
            _treeView.Nodes.Add(node);
        }

        private void VisualizzaEserciziSeduta(TreeNode node, IList<Esercizio> esercizi)
        {
            foreach (Esercizio es in esercizi)
            {
                TreeNode nodeEs = new TreeNode(es.Label);
                nodeEs.Tag = es;
                foreach (Attributo target in es.Targets)
                {
                    TreeNode nodoTarget = new TreeNode(target.ToString());
                    nodeEs.Nodes.Add(nodoTarget);
                }
                node.Nodes.Add(nodeEs);
                if (es is Circuito)
                    VisualizzaEserciziSeduta(nodeEs, ((Circuito)es).Esercizi);
            }
        }
    }
}
