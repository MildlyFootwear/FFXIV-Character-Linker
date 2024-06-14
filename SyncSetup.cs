namespace FFXIV_Character_Linker
{
    public partial class SyncSetup : Form
    {
        public SyncSetup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GameDocumentsDirectory = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Documents\\My Games\\FINAL FANTASY XIV - A Realm Reborn\\";
            if (Directory.Exists(GameDocumentsDirectory))
            {
                label1.Text = "Directory found";
            } else
            {
                label1.Text = "Directory not found";
            }
            
        }
    }
}
