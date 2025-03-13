namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void Timer_Tick(object sender, EventArgs e)
        {


            string charachterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=[]{}|;:,.<>?/";

            string inputString = "Password Manager";

            Random random = new Random();

            char[] charArray = inputString.ToCharArray();

            int numberOfChanges = 4;

            for (int i = 0; i < numberOfChanges; i++)
            {
                int randomIndex = random.Next(0, charArray.Length);

                char randomChar = charachterSet[random.Next(charachterSet.Length)];

                charArray[randomIndex] = randomChar;
            }

            string alteredString = new string(charArray);

            lblPasswordManager.Text = alteredString;

        }

        private void lblPasswordManager_MouseHover(object sender, EventArgs e)
        {
            lblAnimation.Tick += Timer_Tick;
            lblAnimation.Interval = 160;
            lblAnimation.Start();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            lblAnimation.Stop();
        }
    }
}
