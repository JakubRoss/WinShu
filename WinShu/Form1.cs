using System.Diagnostics;


namespace WinShu
{
    public partial class MainForm : Form
    {
        public List<Process> processList = new List<Process>();
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
            Utils.hidePanel(listPanel);
            Utils.showPanel(taskPanel);   
        }

        //LIST BUTTON
        private void listButton_Click(object sender, EventArgs e)
        {
            Utils.hidePanel(taskPanel);
            Utils.showPanel(listPanel);
            foreach (Process process in processList)
            {
                string[] row = {
               process.Id.ToString(),
               process.StartInfo.FileName,
               process.StartTime.ToString(),
               process.StartInfo.FileName
               };

               ListViewItem listViewItem = new ListViewItem(row);
                processListView.Items.Add(listViewItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var process = Utils.Shutty(dateTimePicker.Value);
            processList.Add(process);
            labelOff.Text = $"komp wylaczy sie : {process.StartInfo.Arguments}";
        }

        private void buttonEND_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void delteTaskBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", $"-a");
            processListView.Items.Clear();
        }
    }
}