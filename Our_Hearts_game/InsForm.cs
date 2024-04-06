using System;
using System.Windows.Forms;

public class InsForm : Form
{
    public InsForm(string instructions)
    {
        InitializeComponent();

        this.Text = "Instructions for the Game";
        this.Controls.Add(new Label { Text = instructions, Dock = DockStyle.Fill });
    }
    private void InitializeComponent()
    {
        this.SuspendLayout();
        this.ResumeLayout(false);
    }
}
