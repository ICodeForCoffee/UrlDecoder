using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Encode_Click(object sender, EventArgs e)
		{
			outputBox.Text = System.Web.HttpUtility.UrlEncode(inputBox.Text);
		}

		private void Decode_Click(object sender, EventArgs e)
		{
			outputBox.Text = System.Web.HttpUtility.UrlDecode(inputBox.Text);
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{

		}
	}
}
