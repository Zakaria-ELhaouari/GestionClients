
namespace ClientGestion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientsView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afficher = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_ville = new System.Windows.Forms.TextBox();
            this.input_adress = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsView
            // 
            this.ClientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nom,
            this.Prenom,
            this.Adress,
            this.Ville});
            this.ClientsView.Location = new System.Drawing.Point(65, 117);
            this.ClientsView.Name = "ClientsView";
            this.ClientsView.RowHeadersWidth = 51;
            this.ClientsView.RowTemplate.Height = 24;
            this.ClientsView.Size = new System.Drawing.Size(678, 321);
            this.ClientsView.TabIndex = 0;
            this.ClientsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsView_CellClick);
            this.ClientsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.Width = 125;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.Width = 125;
            // 
            // afficher
            // 
            this.afficher.Location = new System.Drawing.Point(596, 453);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(147, 31);
            this.afficher.TabIndex = 1;
            this.afficher.Text = "afficher";
            this.afficher.UseVisualStyleBackColor = true;
            this.afficher.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(136, 24);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(157, 22);
            this.name_input.TabIndex = 2;
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(136, 68);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(157, 22);
            this.input_prenom.TabIndex = 3;
            // 
            // input_ville
            // 
            this.input_ville.Location = new System.Drawing.Point(445, 68);
            this.input_ville.Name = "input_ville";
            this.input_ville.Size = new System.Drawing.Size(157, 22);
            this.input_ville.TabIndex = 4;
            // 
            // input_adress
            // 
            this.input_adress.Location = new System.Drawing.Point(445, 24);
            this.input_adress.Name = "input_adress";
            this.input_adress.Size = new System.Drawing.Size(157, 22);
            this.input_adress.TabIndex = 5;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(620, 22);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(120, 23);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ville";
            // 
            // suprimer
            // 
            this.suprimer.Location = new System.Drawing.Point(65, 453);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(147, 31);
            this.suprimer.TabIndex = 11;
            this.suprimer.Text = "Suprimer";
            this.suprimer.UseVisualStyleBackColor = true;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(620, 65);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(120, 23);
            this.modifier.TabIndex = 12;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(327, 453);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(147, 31);
            this.newBtn.TabIndex = 13;
            this.newBtn.Text = "Nouveau";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 496);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.input_adress);
            this.Controls.Add(this.input_ville);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.afficher);
            this.Controls.Add(this.ClientsView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_ville;
        private System.Windows.Forms.TextBox input_adress;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button newBtn;
    }
}

