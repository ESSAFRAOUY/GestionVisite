using GestionVisite.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVisite
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        Personne Commercial;
        List<int> dejaVisité;
        List<int> dejaVisiteDist;
        List<Personne> ordre;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personne rachida = db.FindById(3);

            grd.DataSource = db.Clients.Select(c =>
            new {
                c.Id,
                c.Nom,
                c.Position.X,
                c.Position.Y,
                dist= Helper.Distance(c,rachida)

            }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaisir_Commercial_Click(object sender, EventArgs e)
        {
            
            Commercial = new Personne(Id_textBox.Text, Nom_textBox.Text, X_textBox.Text, Y_textBox.Text);
            dejaVisité = new List<int>();
            dejaVisiteDist = new List<int>();
            ordre = new List<Personne>();
            Visiter(Commercial, db.Clients);
            grdVisite.DataSource = ordre.Select(c =>
            new {
                c.Id,
                c.Nom,
                c.Position.X,
                c.Position.Y,

            }).ToList(); ;
           
               
            
         
            

        }

        private void Visiter(Personne commercial, List<Personne> clients)
        {
         
            Personne plusProche = trouverPlusProche(commercial, clients, dejaVisité);
            if(plusProche!=null)
            {
            
                ordre.Add(plusProche);
                dejaVisité.Add(plusProche.Id);
                Visiter(plusProche, clients);
                

                

            }
          
        }

        private Personne trouverPlusProche(Personne source, List<Personne> clients, List<int> dejaVisité)
        {
            Personne proche=null;
            double minDist=double.MaxValue;
            


            foreach(var cli in clients)
            {
                if (dejaVisité.Contains(cli.Id)) continue;
                double dist = Helper.Distance(source, cli);
                if(dist<minDist)
                {
                    minDist = dist;          
                    proche = cli;

                }
                
            }
            return proche;
        }


        private double trouverDistanceParcourue(Personne commercial, List<Personne> clients)
        {
            double distanceParcourue = 0;
            Personne plusProche = trouverPlusProche(commercial, clients, dejaVisiteDist);
             
            while (plusProche != null)
            {

                double disParcourue = Helper.Distance(commercial, plusProche);                
                dejaVisiteDist.Add(plusProche.Id);
                distanceParcourue = distanceParcourue + disParcourue;
                plusProche = trouverPlusProche(plusProche, clients, dejaVisiteDist);
                
               

            }

            return Math.Round(distanceParcourue,4);
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double distanceP=0;
            
            Commercial = new Personne(Id_textBox.Text, Nom_textBox.Text, X_textBox.Text, Y_textBox.Text);
            dejaVisiteDist = new List<int>();
            distanceP = trouverDistanceParcourue(Commercial, db.Clients);

            string str = distanceP.ToString();
            Dparcourue_textBox.Text = str;
            

        }

        private void Y_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dparcourue_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdVisite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void X_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
