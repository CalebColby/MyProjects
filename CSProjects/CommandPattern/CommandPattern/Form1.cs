using CommandPattern.Interfaces;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        private Label player;

        private List<ICommand> stack = new List<ICommand>();
        public Form1()
        {
            InitializeComponent();
            player = (Label)this.Controls[this.Controls.IndexOfKey("lbl_player")];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Color_Click(object sender, EventArgs e)
        {

        }

        private void btn_Up_Click(object sender, EventArgs e)
        {

        }

        private void btn_Left_Click(object sender, EventArgs e)
        {

        }

        private void btn_Right_Click(object sender, EventArgs e)
        {

        }

        private void btn_Down_Click(object sender, EventArgs e)
        {

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            while(stack.Count > 0)
            {
                btn_Undo_Click(sender, e);
            }
        }

        private void lab_Player_Click(object sender, EventArgs e)
        {

        }
    }
}