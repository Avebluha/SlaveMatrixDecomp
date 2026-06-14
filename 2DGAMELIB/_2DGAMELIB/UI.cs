using System;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace _2DGAMELIB
{
    public class UI //: Form
    {
    	private ModeEventDispatcher modeEventDispatcher;

    	private GlImage wpfImage1;

    	//private System.Windows.Controls.Image hostedComponent1;

    	private string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Config.ini");

    	private bool BigWindow;

    	public UI(ModeEventDispatcher Med)
    	{
            this.modeEventDispatcher = Med;
            InitializeComponent();
    	}

    	private void UI_Load(object sender, EventArgs e)
    	{
    		//base.ClientSize = 
    			modeEventDispatcher.Setting(wpfImage1);
    		//base.ClientSize = new Size(1024, 768);
    		try
    		{
    			if (!File.Exists(ConfigPath))
    			{
    				BigWindow = false;
    			}
    			else
    			{
    				string[] source = ConfigPath.ReadLines();
    				BigWindow = source.First((string s) => s.StartsWith("BigWindow:")).Last() == '1';
    			}
    		}
    		catch
    		{
    			BigWindow = false;
    		}
    		if (BigWindow)
    		{
    			//base.ClientSize = new Size(1280, 960);
    		}
    		UI_Resize(null, null);
    	}

    	private void UI_FormClosing()
    	{
    		modeEventDispatcher.Drive = false;
    	}

    	private void UI_Resize(object sender, EventArgs e)
    	{
    		//wpfImage1.ImageSetting();
    		//wpfImage1.Image.Width = (double)base.ClientSize.Width * Med.DpiX;
    		//wpfImage1.Image.Height = (double)base.ClientSize.Height * Med.DpiY;
    	}

    	/*
    	protected override void Dispose(bool disposing)
    	{
    		if (disposing && components != null)
    		{
    			components.Dispose();
    		}
    		base.Dispose(disposing);
    	}*/

    	private void InitializeComponent()
    	{
    		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2DGAMELIB.UI));
    		this.wpfImage1 = new GlImage();
    		//this.hostedComponent1 = new System.Windows.Controls.Image();

    		//base.SuspendLayout();

    		/*
    		this.wpfImage1.BackColor = System.Drawing.Color.Black;
    		this.wpfImage1.Dock = System.Windows.Forms.DockStyle.Fill;
    		this.wpfImage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
    		this.wpfImage1.Location = new System.Drawing.Point(0, 0);
    		this.wpfImage1.Name = "wpfImage1";
            this.wpfImage1.Text = "wpfImage1";
            this.wpfImage1.TabIndex = 0;
    		this.wpfImage1.Child = this.hostedComponent1;*/

            //this.Text = "UI";

            //base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
    		//base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

    		//base.Controls.Add(this.wpfImage1);

    		//base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
    		//base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
    		//base.Name = "UI";
    		//base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

    		//base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(UI_FormClosing);

    		//beauty
    		this.wpfImage1.Closing = delegate () { UI_FormClosing(); };
            //TODO fix?
            //base.Load += new System.EventHandler(UI_Load);
            UI_Load(null, null);
    		//base.Resize += new System.EventHandler(UI_Resize);
    		//base.ResumeLayout(false);
    	}
    }
}
