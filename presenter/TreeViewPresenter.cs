using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    class TreeViewPresenter
    {
        private TreeView _treeView;
        public TreeViewPresenter(TreeView treeView)
        {
            _treeView = treeView;
        }
        public void VisualizzaEserciziSvolti(EsercizioSvolto[] eserciziSvolti)
        {
            _treeView.Nodes.Clear();
            TreeNode treeNode = new TreeNode("Esercizi Svolti");
            VisualizzaSottoEsercizi(eserciziSvolti, treeNode);
            _treeView.Nodes.Add(treeNode);
        }
        private void VisualizzaSottoEsercizi(EsercizioSvolto[] esercizi, TreeNode nodeEs)
        {
            if (esercizi.Length == 0)
                return;
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
                if (es is CircuitoSvolto)
                    VisualizzaSottoEsercizi(((CircuitoSvolto)es).SottoEserciziSvolti.ToArray(), node);

            }
        }
        public void VisualizzaSedute(Seduta[] sedute)
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
            if (esercizi.Count == 0)
                return;
            foreach (Esercizio es in esercizi)
            {
                TreeNode nodeEs = new TreeNode(es.ToString());
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
