namespace Projeto_Mostra_Patas
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        private void Animais_Load(object sender, EventArgs e)
        {
            cboAnimais.Items.Clear();

            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Pássaro");

        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            String strAnimal;

            strAnimal = cboAnimais.Text;

            switch (strAnimal)
            {
                case "Cavalo":
                case "Cachorro":
                case "Gato":
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Centopeia":
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Cobra":
                    MessageBox.Show("Este animal tem não patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Passaro":
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("Selecione um animal", "Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}