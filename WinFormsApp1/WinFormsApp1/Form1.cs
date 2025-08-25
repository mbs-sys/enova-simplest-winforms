namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enova.Enova.LoadLibsFirst();
        }

        private void btnWczytajNumeryDokumentowEnova_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            using (var enova = new Enova.Enova())
            {
                var dhNumery = enova.GetDokHandloweNumery();
                richTextBox1.Text = string.Join(", ", dhNumery);
            }
        }
    }
}
