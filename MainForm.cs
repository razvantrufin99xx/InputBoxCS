/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/27/2024
 * Time: 12:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.CSharp;
using Microsoft.VisualBasic;


namespace utilitare
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//		
//		private string inputBox()
//	{
//    	string input = Microsoft.VisualBasic.Interaction.InputBox("Prompt", "Title",Name, 0, 0);
//	    MessageBox.Show(Name);
//	    return input;
//	}
		private static DialogResult ShowInputDialog(ref string input, ref string tothisvar)
    {
        System.Drawing.Size size = new System.Drawing.Size(200, 70);
        Form inputBox = new Form();

        inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        inputBox.ClientSize = size;
        inputBox.Text = "Name";

        System.Windows.Forms.TextBox textBox = new TextBox();
        textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
        textBox.Location = new System.Drawing.Point(5, 5);
        textBox.Text = input;
        inputBox.Controls.Add(textBox);

        Button okButton = new Button();
        okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        okButton.Name = "okButton";
        okButton.Size = new System.Drawing.Size(75, 23);
        okButton.Text = "&OK";
        okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
        inputBox.Controls.Add(okButton);

        Button cancelButton = new Button();
        cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new System.Drawing.Size(75, 23);
        cancelButton.Text = "&Cancel";
        cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
        inputBox.Controls.Add(cancelButton);

        inputBox.AcceptButton = okButton;
        inputBox.CancelButton = cancelButton; 

        DialogResult result = inputBox.ShowDialog();
        input = textBox.Text;
        tothisvar = input;
        return result;
    }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//string s = inputBox();
			
			string input="hede";
			string s = "";
			DialogResult x = ShowInputDialog(ref input,ref s);
			Text = x.ToString() + " : " + s;
		}
	}
}
