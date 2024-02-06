namespace WinFormsApp1
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            Tasks = new CheckedListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 516);
            button1.Name = "button1";
            button1.Size = new Size(121, 63);
            button1.TabIndex = 0;
            button1.Text = "Delete done tasks";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.MinimumSize = new Size(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(351, 75);
            label1.TabIndex = 1;
            label1.Text = "To Do List ";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(177, 516);
            button2.Name = "button2";
            button2.Size = new Size(121, 63);
            button2.TabIndex = 2;
            button2.Text = "Add task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tasks
            // 
            Tasks.CheckOnClick = true;
            Tasks.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tasks.FormattingEnabled = true;
            Tasks.Location = new Point(38, 107);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(604, 378);
            Tasks.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(304, 537);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 33);
            textBox1.TabIndex = 4;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(697, 601);
            Controls.Add(textBox1);
            Controls.Add(Tasks);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            KeyPreview = true;
            Name = "ToDoList";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private CheckedListBox Tasks;
        private TextBox textBox1;
    }
}
