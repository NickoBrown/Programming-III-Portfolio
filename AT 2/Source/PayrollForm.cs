using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nicholas Brown
//30032159

//Balanced binary tree containing a list of names.
namespace PayrollProject
{
    public partial class FormPayroll : Form
    {

        AVLTree tree = new AVLTree();
        public FormPayroll()
        {
            InitializeComponent();
        }

        private void displayNames()
        {
            textBoxNameList.Text = tree.Display();
            labelRoot.Text = "Current root: " + tree.GetRoot();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNewName.Text))
            {
                tree.Add(textBoxNewName.Text);
                displayNames();
            }
            else MessageBox.Show("A valid name must be entered.");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (tree.Find(textBoxRemoveName.Text) != "Nothing found!")
            {
                tree.Delete(textBoxRemoveName.Text);
                displayNames();
            }
            else MessageBox.Show("A valid name must be specified.");
            
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindName(textBoxFindName.Text);
        }

        private void FindName(string key, bool showMessage = true)
        {
            if (showMessage)
            {
                MessageBox.Show(tree.Find(key));
            }
        }

        private void buttonAutoFill_Click(object sender, EventArgs e)
        {
            tree.Add("Andy");
            tree.Add("Bill");
            tree.Add("Carrie");
            tree.Add("Dennis");
            tree.Add("Edmund");
            tree.Add("Francesca");
            tree.Add("Gail");
            tree.Add("Harry");
            tree.Add("India");
            tree.Add("Jean");
            tree.Add("Kevin");
            displayNames();
        }

    }
}
