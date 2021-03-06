namespace Pokemon_Battel
{
    public partial class Form1 : Form
    {
        Pikachu pikachu;
        Pidgeot pidgeot;
        Clefairy clefairy;
        Psyduck psyduck;
        Poliwag poliwag;
        Voltorb voltorb;
        Machamp machamp;
        //Array of Pokemon
        Pokemon[] pokemondex;
        Pokemon[] enemydex;
        public Form1()
        {
            InitializeComponent();
            pokemondex = new Pokemon[6];
            enemydex = new Pokemon[6];

            pikachu = new Pikachu();
            pidgeot = new Pidgeot();
            clefairy = new Clefairy();
            psyduck = new Psyduck();
            poliwag = new Poliwag();
            voltorb = new Voltorb();
            machamp = new Machamp();

            pokemondex[0] = pikachu;
            pokemondex[1] = pidgeot;
            pokemondex[2] = clefairy;
            pokemondex[3] = psyduck;
            pokemondex[4] = poliwag;
            pokemondex[5] = voltorb;

            enemydex[0] = machamp;
        }

        private void diaplayPokemon()
        {
            this.pictureBox1.Image = pokemondex[0].getImage();
            this.labelPokemon.Text = pokemondex[0].getName();
            this.pictureBox2.Image = pokemondex[1].getImage();
            this.pictureBox3.Image = pokemondex[2].getImage();
            this.pictureBox4.Image = pokemondex[3].getImage();
            this.pictureBox5.Image = pokemondex[4].getImage();
            this.pictureBox6.Image = pokemondex[5].getImage();

            this.pictureBox7.Image = enemydex[0].getImage();

            this.textBoxHP.Text = pokemondex[0].getHP().ToString();
            this.textBoxATK.Text = pokemondex[0].getATK().ToString();
            this.textBoxDEF.Text = pokemondex[0].getDEF().ToString();
            this.textBoxSPEED.Text = pokemondex[0].getSPEED().ToString();

            this.textBoxEnmyHP.Text = enemydex[0].getHP().ToString();

            this.buttonATK.Enabled = pokemondex[0].getHP() > 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diaplayPokemon();
        }

        private void button_switch1_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[1];
            pokemondex[1] = temp;

            diaplayPokemon();
        }

        private void button_switch2_Click(object sender, EventArgs e)
        {
            //Image temp = this.pictureBox1.Image;
            //this.pictureBox1.Image = this.pictureBox3.Image;
            //this.pictureBox3.Image = temp;

            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[2];
            pokemondex[2] = temp;

            diaplayPokemon();
        }

        private void buttonATK_Click(object sender, EventArgs e)
        {
            pokemondex[0].attackPokemon(ref enemydex[0]);

            enemydex[0].attackPokemon(ref pokemondex[0]);

            diaplayPokemon();
        }

        private void button_switch3_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[3];
            pokemondex[3] = temp;

            diaplayPokemon();
        }

        private void button_switch4_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[4];
            pokemondex[4] = temp;

            diaplayPokemon();
        }

        private void button_switch5_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemondex[0];
            pokemondex[0] = pokemondex[5];
            pokemondex[5] = temp;

            diaplayPokemon();
        }
    }
}