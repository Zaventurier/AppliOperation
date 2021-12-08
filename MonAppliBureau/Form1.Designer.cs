
namespace MonAppliBureau
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
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(55, 12);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(165, 22);
            this.txtValeur1.TabIndex = 1;
            this.txtValeur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur1.TextChanged += new System.EventHandler(this.txtvaleur1_TextChanged);
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(55, 40);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(165, 22);
            this.txtValeur2.TabIndex = 2;
            this.txtValeur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur2.TextChanged += new System.EventHandler(this.txtvaleur2_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(229, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(58, 50);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "+";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(12, 40);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(34, 32);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(55, 96);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(165, 22);
            this.txtResultat.TabIndex = 6;
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplier.Location = new System.Drawing.Point(229, 68);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(58, 50);
            this.btnMultiplier.TabIndex = 7;
            this.btnMultiplier.Text = "X";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::MonAppliBureau.Properties.Resources.annuler;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuitter.Location = new System.Drawing.Point(303, 68);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(54, 50);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackgroundImage = global::MonAppliBureau.Properties.Resources.gomme;
            this.btnEffacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEffacer.Location = new System.Drawing.Point(303, 12);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(54, 50);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 166);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Name = "Form1";
            this.Text = "Opération";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnMultiplier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

