
namespace GestionVisite
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_afficher = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Distance = new System.Windows.Forms.Button();
            this.Dparcourue_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdVisite = new System.Windows.Forms.DataGridView();
            this.btnSaisir_Commercial = new System.Windows.Forms.Button();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.Nom_textBox = new System.Windows.Forms.TextBox();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.Pos_label = new System.Windows.Forms.Label();
            this.Nom_label = new System.Windows.Forms.Label();
            this.Id_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_afficher
            // 
            this.btn_afficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afficher.Location = new System.Drawing.Point(564, 214);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_afficher.TabIndex = 0;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = false;
            this.btn_afficher.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(445, 40);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(298, 159);
            this.grd.TabIndex = 1;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn_Distance);
            this.groupBox1.Controls.Add(this.Dparcourue_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdVisite);
            this.groupBox1.Controls.Add(this.btnSaisir_Commercial);
            this.groupBox1.Controls.Add(this.Y_textBox);
            this.groupBox1.Controls.Add(this.X_textBox);
            this.groupBox1.Controls.Add(this.Nom_textBox);
            this.groupBox1.Controls.Add(this.Id_textBox);
            this.groupBox1.Controls.Add(this.Pos_label);
            this.groupBox1.Controls.Add(this.Nom_label);
            this.groupBox1.Controls.Add(this.Id_label);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 364);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commercial";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Distance
            // 
            this.btn_Distance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Distance.FlatAppearance.BorderSize = 0;
            this.btn_Distance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Distance.Location = new System.Drawing.Point(309, 323);
            this.btn_Distance.Name = "btn_Distance";
            this.btn_Distance.Size = new System.Drawing.Size(75, 23);
            this.btn_Distance.TabIndex = 15;
            this.btn_Distance.Text = "Calculer";
            this.btn_Distance.UseVisualStyleBackColor = false;
            this.btn_Distance.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dparcourue_textBox
            // 
            this.Dparcourue_textBox.Enabled = false;
            this.Dparcourue_textBox.Location = new System.Drawing.Point(195, 325);
            this.Dparcourue_textBox.Name = "Dparcourue_textBox";
            this.Dparcourue_textBox.Size = new System.Drawing.Size(87, 21);
            this.Dparcourue_textBox.TabIndex = 14;
            this.Dparcourue_textBox.TextChanged += new System.EventHandler(this.Dparcourue_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Distance parcourue :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grdVisite
            // 
            this.grdVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisite.Location = new System.Drawing.Point(46, 152);
            this.grdVisite.Name = "grdVisite";
            this.grdVisite.Size = new System.Drawing.Size(338, 149);
            this.grdVisite.TabIndex = 12;
            this.grdVisite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVisite_CellContentClick);
            // 
            // btnSaisir_Commercial
            // 
            this.btnSaisir_Commercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaisir_Commercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaisir_Commercial.Location = new System.Drawing.Point(309, 105);
            this.btnSaisir_Commercial.Name = "btnSaisir_Commercial";
            this.btnSaisir_Commercial.Size = new System.Drawing.Size(75, 23);
            this.btnSaisir_Commercial.TabIndex = 11;
            this.btnSaisir_Commercial.Text = "Saisir";
            this.btnSaisir_Commercial.UseVisualStyleBackColor = false;
            this.btnSaisir_Commercial.Click += new System.EventHandler(this.btnSaisir_Commercial_Click);
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(219, 107);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(73, 21);
            this.Y_textBox.TabIndex = 7;
            this.Y_textBox.TextChanged += new System.EventHandler(this.Y_textBox_TextChanged);
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(104, 107);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(73, 21);
            this.X_textBox.TabIndex = 8;
            this.X_textBox.TextChanged += new System.EventHandler(this.X_textBox_TextChanged);
            // 
            // Nom_textBox
            // 
            this.Nom_textBox.Location = new System.Drawing.Point(46, 77);
            this.Nom_textBox.Name = "Nom_textBox";
            this.Nom_textBox.Size = new System.Drawing.Size(99, 21);
            this.Nom_textBox.TabIndex = 9;
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(46, 44);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(99, 21);
            this.Id_textBox.TabIndex = 10;
            // 
            // Pos_label
            // 
            this.Pos_label.AutoSize = true;
            this.Pos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos_label.Location = new System.Drawing.Point(5, 110);
            this.Pos_label.Name = "Pos_label";
            this.Pos_label.Size = new System.Drawing.Size(262, 13);
            this.Pos_label.TabIndex = 6;
            this.Pos_label.Text = "Position :     X =                        Y =            ";
            // 
            // Nom_label
            // 
            this.Nom_label.AutoSize = true;
            this.Nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_label.Location = new System.Drawing.Point(5, 80);
            this.Nom_label.Name = "Nom_label";
            this.Nom_label.Size = new System.Drawing.Size(40, 13);
            this.Nom_label.TabIndex = 5;
            this.Nom_label.Text = "Nom :";
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_label.Location = new System.Drawing.Point(5, 47);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(26, 13);
            this.Id_label.TabIndex = 4;
            this.Id_label.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "La liste des clients";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(758, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btn_afficher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Gestion de Visite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.TextBox Nom_textBox;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.Label Pos_label;
        private System.Windows.Forms.Label Nom_label;
        private System.Windows.Forms.Label Id_label;
        private System.Windows.Forms.Button btnSaisir_Commercial;
        private System.Windows.Forms.DataGridView grdVisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dparcourue_textBox;
        private System.Windows.Forms.Button btn_Distance;
        private System.Windows.Forms.Label label2;
    }
}

