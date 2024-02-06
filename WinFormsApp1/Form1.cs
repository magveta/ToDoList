using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
            this.Text = "ToDo List";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Tasks.Items.Count - 1; i >= 0; i--)
            {
                if (Tasks.GetItemChecked(i))
                {
                    Tasks.Items.Remove(Tasks.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string theText = textBox1.Text;
            if (String.IsNullOrWhiteSpace(theText))
            {
                // pass
            }
            else
            {
                Tasks.Items.Insert(0, theText);
                textBox1.Text = ""; 
            }
        }
    }
}
