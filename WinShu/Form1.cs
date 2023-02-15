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
        private void hidePanel(Panel panel)
        {
            if(panel.Visible == true)
            {
                panel.Visible = false;
            }
        }
        private void showPanel(Panel panel)
        {
            if(panel.Visible == false)
            {
                hidePanel(panel);
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        //MENU BUTTON
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            showPanel(panelSubMenu);
        }

        //TASK BUTTON
        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if(taskPanel.Visible == false)
            {
                taskPanel.Visible = true;
            }
        }

        //LIST BUTTON
        private void listButton_Click(object sender, EventArgs e)
        {
            taskPanel.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var when = TaskService.Shutty(dateTimePicker.Value);
            labelOff.Text = $"Wylaczy sie za : {when}";
        }
    }
}