namespace WinShu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            taskPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //MENU BUTTON
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Utils.showPanel(panelSubMenu);
        }

        //TASK BUTTON
        private void newTaskButton_Click(object sender, EventArgs e)
        {
            Utils.showPanel(taskPanel);   
        }

        //LIST BUTTON
        private void listButton_Click(object sender, EventArgs e)
        {
            //Utils.showPanel(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var when = Utils.Shutty(dateTimePicker.Value);
            labelOff.Text = $"Wylaczy sie za : {when}";
        }

        private void buttonEND_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}