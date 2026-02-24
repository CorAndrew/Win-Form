namespace Es._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Converti = new Button();
            Input = new TextBox();
            Ris = new TextBox();
            Dati = new ComboBox();
            Misura = new Label();
            label1 = new Label();
            unitàInput = new Label();
            SuspendLayout();
            // 
            // Converti
            // 
            Converti.Location = new Point(434, 144);
            Converti.Name = "Converti";
            Converti.Size = new Size(127, 27);
            Converti.TabIndex = 0;
            Converti.Text = "Converti";
            Converti.UseVisualStyleBackColor = true;
            Converti.Click += Converti_Click;
            // 
            // Input
            // 
            Input.Location = new Point(434, 92);
            Input.Name = "Input";
            Input.Size = new Size(100, 23);
            Input.TabIndex = 1;
            // 
            // Ris
            // 
            Ris.Location = new Point(434, 209);
            Ris.Name = "Ris";
            Ris.ReadOnly = true;
            Ris.Size = new Size(100, 23);
            Ris.TabIndex = 2;
            // 
            // Dati
            // 
            Dati.DropDownStyle = ComboBoxStyle.DropDownList;
            Dati.FormattingEnabled = true;
            Dati.Location = new Point(612, 148);
            Dati.Name = "Dati";
            Dati.Size = new Size(121, 23);
            Dati.TabIndex = 3;
            // 
            // Misura
            // 
            Misura.AutoSize = true;
            Misura.Location = new Point(599, 217);
            Misura.Name = "Misura";
            Misura.Size = new Size(87, 15);
            Misura.TabIndex = 4;
            Misura.Text = "Unità di misura";
            Misura.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // unitàInput
            // 
            unitàInput.AutoSize = true;
            unitàInput.Location = new Point(612, 95);
            unitàInput.Name = "unitàInput";
            unitàInput.Size = new Size(131, 15);
            unitàInput.TabIndex = 6;
            unitàInput.Text = "Unità di misura in input";
            unitàInput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 601);
            Controls.Add(unitàInput);
            Controls.Add(label1);
            Controls.Add(Misura);
            Controls.Add(Dati);
            Controls.Add(Ris);
            Controls.Add(Input);
            Controls.Add(Converti);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Converti;
        private TextBox Input;
        private TextBox Ris;
        private ComboBox Dati;
        private Label Misura;
        private Label label1;
        private Label unitàInput;
    }
}
