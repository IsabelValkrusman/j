using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox prt;
        public Form1()
        {
            this.Height = 500;
            this.Width = 700;
            this.Text = "Vorm elementidega";
            this.BackColor = Color.Cyan;
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Märkeruut-checkbox"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-Textbox"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));


            //nupp
            btn = new Button();
            btn.Text = "vajuta siia";
            btn.Location = new Point(150, 50);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;
            //pealkiri
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(400, 30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;

            prt = new PictureBox();
            prt.Size = new Size(50, 50);
            prt.Location = new Point(150, 60);
            prt.SizeMode = PictureBoxSizeMode.StretchImage;
            prt.Image = Image.FromFile(@"..\..\Images\nature.jpg");
            prt.Image = Image.FromFile(@"..\..\Images\river.jpg");
            prt.Image = Image.FromFile(@"..\..\Images\.jpg");
            prt.Image = Image.FromFile(@"..\..\Images\nature.jpg");
            //carusel 3-4 images

            prt.DoubleClick += Prt_DoubleClick; 

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Prt_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200, 10, 20);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if(e.Node.Text=="silt")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text=="PictureBox")
            {
                this.Controls.Add(prt);
            }
        }
    }
}
