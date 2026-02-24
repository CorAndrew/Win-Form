namespace Es._1
{
    public partial class Form1 : Form
    {
        string[] dati = { "Fahrenheit", "Miglia" };

        public Form1()
        {
            InitializeComponent();
            Dati.Items.AddRange(dati);
            // Prende il primo elemento dell' array come default
            Dati.SelectedIndex = 0;
            unit‡Input.Text = "Gradi Celsius";
        }

        private void Converti_Click(object sender, EventArgs e)
        {
            
            // Conversione dell' input in valore numerico
            if (double.TryParse(Input.Text, out double valoreInput))
            {
                double calcolo = 0;

                // Controllo selezione combobox
                if (Dati.SelectedItem.ToString() == "Fahrenheit")
                {
                    Misura.Text = "Fahrenheit";
                    Misura.Visible = true;
                    unit‡Input.Text = "Gradi Celsius";
                    calcolo = (valoreInput * 9 / 5) + 32;
                }
                else if (Dati.SelectedItem.ToString() == "Miglia")
                {
                    Misura.Text = "Miglia";
                    Misura.Visible = true;
                    unit‡Input.Text = "Chilometri";
                    calcolo = valoreInput / 1.609;
                }

                // Visualizza il risultato
                Ris.Text = calcolo.ToString();
            }
            else
            {
                MessageBox.Show("Per favore, inserisci un numero valido!");
            }
        }
    }
}