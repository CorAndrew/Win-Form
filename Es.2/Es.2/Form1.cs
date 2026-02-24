namespace Es._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            string cose = Input.Text;

            if (string.IsNullOrEmpty(cose))
            {
                MessageBox.Show("Inserisci il campo");
            }
            else
            {
                Lista.Items.Add((cose));
                Input.Text = "";
            }
        }
    }
    }
