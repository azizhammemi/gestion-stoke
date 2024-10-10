using GMAO_IIT.usercontrol;

namespace GMAO_IIT
{
    public partial class Form1 : Form
    {
        Navigation navcontrol;
        public Form1()
        {
            InitializeComponent();
            intializenavigation();
        }
        private void intializenavigation()
        {
            List<UserControl> userControls = new List<UserControl>() { new UserControl1(),new UserControl2(),new UserControl3(),new UserControl4()};
            navcontrol = new Navigation(userControls, panel2);
            navcontrol.Display(0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ajouter du code ici si nécessaire
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Ajouter du code ici si nécessaire
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ajouter le code de gestion de l'événement du bouton "Article" ici
            navcontrol.Display(0);
         }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ajouter le code de gestion de l'événement du bouton "Machine" ici
            navcontrol.Display(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ajouter le code de gestion de l'événement du bouton "Inventaire" ici
            navcontrol.Display(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ajouter le code de gestion de l'événement du bouton "Inventaire" ici
            navcontrol.Display(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Ajouter le code de gestion de l'événement du bouton "Inventaire" ici
            Application.Exit();
        }

    }
}
