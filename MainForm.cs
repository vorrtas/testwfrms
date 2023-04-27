using System.ComponentModel;

namespace megafon;

public class MainForm : Form
{
    private readonly IContainer components;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    public MainForm()
    {
        components = new Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Megafon";
    }


}