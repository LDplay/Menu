namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        private MenuStrip mainMenuStrip;
        private int childMenuCounter = 2;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            mainMenuStrip = new MenuStrip();
            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("1");
            menuItem1.MouseEnter += MenuItem1_MouseEnter;
            mainMenuStrip.Items.Add(menuItem1);

            Controls.Add(mainMenuStrip);
        }

        private void MenuItem1_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem parentMenuItem = (ToolStripMenuItem)sender;

            if (parentMenuItem.DropDownItems.Count == 0)
            {
                ToolStripMenuItem childMenuItem = new ToolStripMenuItem(childMenuCounter.ToString());
                childMenuCounter++;

                childMenuItem.MouseEnter += MenuItem1_MouseEnter; // Добавляем обработчик события для дальнейших меню

                parentMenuItem.DropDownItems.Add(childMenuItem);
            }
        }
    }
}
