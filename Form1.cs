using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Pilas_Práctica_No1
{
    public partial class Form1 : KryptonForm
    {
        private Stack<String> Pila = new Stack<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
            if(!string.IsNullOrEmpty(elemento))
            {
                Pila.Push(elemento);
                lbPila.Items.Insert(0, elemento);
                txtElemento.Clear();
                txtElemento.Focus();
                lblTopElement.Text = $"Elemento en el tope: {Pila.Peek()}";
            }
            else { MessageBox.Show("Por favor, ingrese un elemento para agregar a la pila."); }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (Pila.Count > 0) {
                string eliminado = Pila.Pop();
                lbPila.Items.RemoveAt(0);
                if (Pila.Count > 0)  lblTopElement.Text = $"Elemento en el tope: {Pila.Peek()}";
                else lblTopElement.Text = "La pila está vacía.";
            }
            else { MessageBox.Show("La pila está vacía."); }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (Pila.Count > 0) MessageBox.Show($"Elemento en el tope de la pila: {Pila.Peek()}", "Peek");
            else MessageBox.Show("Pila vacia.");
        }

        private void btnSalir_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
