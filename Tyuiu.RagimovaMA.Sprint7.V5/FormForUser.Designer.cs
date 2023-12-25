
namespace Tyuiu.RagimovaMA.Sprint7.V5
{
    partial class FormForUser_RMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForUser_RMA));
            this.panelTitle_RMA = new System.Windows.Forms.Panel();
            this.labelTitle_RMA = new System.Windows.Forms.Label();
            this.panelOkButton_RMA = new System.Windows.Forms.Panel();
            this.buttonOk_RMA = new System.Windows.Forms.Button();
            this.panelInfo_RMA = new System.Windows.Forms.Panel();
            this.textBoxInfo_RMA = new System.Windows.Forms.TextBox();
            this.panelTitle_RMA.SuspendLayout();
            this.panelOkButton_RMA.SuspendLayout();
            this.panelInfo_RMA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_RMA
            // 
            this.panelTitle_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelTitle_RMA.Controls.Add(this.labelTitle_RMA);
            this.panelTitle_RMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle_RMA.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_RMA.Name = "panelTitle_RMA";
            this.panelTitle_RMA.Size = new System.Drawing.Size(800, 70);
            this.panelTitle_RMA.TabIndex = 0;
            // 
            // labelTitle_RMA
            // 
            this.labelTitle_RMA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle_RMA.AutoSize = true;
            this.labelTitle_RMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_RMA.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle_RMA.Location = new System.Drawing.Point(164, 22);
            this.labelTitle_RMA.Name = "labelTitle_RMA";
            this.labelTitle_RMA.Size = new System.Drawing.Size(476, 29);
            this.labelTitle_RMA.TabIndex = 0;
            this.labelTitle_RMA.Text = "ИНФОРМАЦИЯ ДЛЯ ПОЛЬЗОВАТЕЛЯ";
            // 
            // panelOkButton_RMA
            // 
            this.panelOkButton_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.panelOkButton_RMA.Controls.Add(this.buttonOk_RMA);
            this.panelOkButton_RMA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOkButton_RMA.Location = new System.Drawing.Point(0, 388);
            this.panelOkButton_RMA.Name = "panelOkButton_RMA";
            this.panelOkButton_RMA.Size = new System.Drawing.Size(800, 62);
            this.panelOkButton_RMA.TabIndex = 1;
            // 
            // buttonOk_RMA
            // 
            this.buttonOk_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOk_RMA.FlatAppearance.BorderSize = 0;
            this.buttonOk_RMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_RMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk_RMA.Location = new System.Drawing.Point(639, 15);
            this.buttonOk_RMA.Name = "buttonOk_RMA";
            this.buttonOk_RMA.Size = new System.Drawing.Size(149, 35);
            this.buttonOk_RMA.TabIndex = 0;
            this.buttonOk_RMA.Text = "ОК";
            this.buttonOk_RMA.UseVisualStyleBackColor = false;
            this.buttonOk_RMA.Click += new System.EventHandler(this.buttonOk_RMA_Click);
            // 
            // panelInfo_RMA
            // 
            this.panelInfo_RMA.Controls.Add(this.textBoxInfo_RMA);
            this.panelInfo_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_RMA.Location = new System.Drawing.Point(0, 70);
            this.panelInfo_RMA.Name = "panelInfo_RMA";
            this.panelInfo_RMA.Size = new System.Drawing.Size(800, 318);
            this.panelInfo_RMA.TabIndex = 2;
            // 
            // textBoxInfo_RMA
            // 
            this.textBoxInfo_RMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxInfo_RMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo_RMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_RMA.Location = new System.Drawing.Point(0, 0);
            this.textBoxInfo_RMA.Multiline = true;
            this.textBoxInfo_RMA.Name = "textBoxInfo_RMA";
            this.textBoxInfo_RMA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo_RMA.Size = new System.Drawing.Size(800, 318);
            this.textBoxInfo_RMA.TabIndex = 0;
            this.textBoxInfo_RMA.Text = resources.GetString("textBoxInfo_RMA.Text");
            // 
            // FormForUser_RMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo_RMA);
            this.Controls.Add(this.panelOkButton_RMA);
            this.Controls.Add(this.panelTitle_RMA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormForUser_RMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Для пользователя";
            this.panelTitle_RMA.ResumeLayout(false);
            this.panelTitle_RMA.PerformLayout();
            this.panelOkButton_RMA.ResumeLayout(false);
            this.panelInfo_RMA.ResumeLayout(false);
            this.panelInfo_RMA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle_RMA;
        private System.Windows.Forms.Label labelTitle_RMA;
        private System.Windows.Forms.Panel panelOkButton_RMA;
        private System.Windows.Forms.Button buttonOk_RMA;
        private System.Windows.Forms.Panel panelInfo_RMA;
        private System.Windows.Forms.TextBox textBoxInfo_RMA;
    }
}