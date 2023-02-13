namespace WinShu
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
        private void hidePanelSubMenu()
        {
            if(panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }
        private void showPanelSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hidePanelSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            showPanelSubMenu(panelSubMenu);
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            hidePanelSubMenu();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            
            hidePanelSubMenu();
        }
    }
}