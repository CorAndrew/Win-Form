namespace Es._2
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
            components = new System.ComponentModel.Container();
            Input = new TextBox();
            Lista = new ListBox();
            Aggiungi = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(109, 72);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(100, 23);
            Input.TabIndex = 0;
            // 
            // Lista
            // 
            Lista.FormattingEnabled = true;
            Lista.Location = new Point(459, 72);
            Lista.Name = "Lista";
            Lista.Size = new Size(120, 94);
            Lista.TabIndex = 1;
            // 
            // Aggiungi
            // 
            Aggiungi.Location = new Point(273, 72);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(138, 35);
            Aggiungi.TabIndex = 2;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // label1
            // 
            label1.Location = new Point(26, 72);
            label1.Name = "label1";
            label1.Size = new Size(77, 62);
            label1.TabIndex = 3;
            label1.Text = "Inserisci gli argomentio della lista";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Aggiungi);
            Controls.Add(Lista);
            Controls.Add(Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input;
        private ListBox Lista;
        private Button Aggiungi;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
