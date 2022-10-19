using CommandPattern.implementations;
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
            ICommand newCom = new ChangeColor();
            newCom.Execute(player);
            stack.Add(newCom);
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            ICommand newCom = new MoveUp();
            newCom.Execute(player);
            stack.Add(newCom);
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            ICommand newCom = new MoveLeft();
            newCom.Execute(player);
            stack.Add(newCom);
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            ICommand newCom = new MoveRight();
            newCom.Execute(player);
            stack.Add(newCom);
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            ICommand newCom = new MoveDown();
            newCom.Execute(player);
            stack.Add(newCom);
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                int index = stack.Count - 1;
                stack[index].Undo();
                stack.RemoveAt(index);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            while(stack.Count > 0)
            {
                Thread.Sleep(2000); // 2000ms should be 2 seconds
                btn_Undo_Click(sender, e);
            }
        }

        private void lab_Player_Click(object sender, EventArgs e)
        {
            
        }
    }
}