using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prana.Notepad
{
	
	public class FrmReplace : System.Windows.Forms.Form
    {
		private System.Windows.Forms.CheckBox chkMatchCase;
		public System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFind;
		public System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnReplaceAll;
		
		private System.ComponentModel.Container components = null;

		public FrmReplace()
		{
			
			InitializeComponent();

			
		}

		
		private System.Windows.Forms.RichTextBox txtContent;

		
		public FrmReplace(System.Windows.Forms.RichTextBox textBox1)
		{
			InitializeComponent();
			this.txtContent = textBox1;
		}
        
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReplace));
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.chkMatchCase.Location = new System.Drawing.Point(40, 72);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(88, 24);
            this.chkMatchCase.TabIndex = 13;
            this.chkMatchCase.Text = "区分大小写";
             
            this.txtFind.Location = new System.Drawing.Point(80, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(232, 21);
            this.txtFind.TabIndex = 10;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "查找内容";
            
            this.btnCancel.Location = new System.Drawing.Point(328, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(328, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 24);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "查找下一个";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            
            this.txtReplace.Location = new System.Drawing.Point(80, 40);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(232, 21);
            this.txtReplace.TabIndex = 15;
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "替换为";
            
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(328, 37);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(80, 24);
            this.btnReplace.TabIndex = 16;
            this.btnReplace.Text = "替换";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            
            this.btnReplaceAll.Enabled = false;
            this.btnReplaceAll.Location = new System.Drawing.Point(328, 66);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(80, 24);
            this.btnReplaceAll.TabIndex = 17;
            this.btnReplaceAll.Text = "全部替换";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
             
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(426, 135);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReplace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "替换";
            this.Load += new System.EventHandler(this.FrmReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		
		private void btnReplace_Click(object sender, System.EventArgs e)
		{
			
			if (txtContent.SelectedText == txtFind.Text)
			{
				txtContent.SelectedText = txtReplace.Text;
				location += txtFind.Text.Length;
			}
			btnFind_Click(sender, e);
		}

		
		private void btnReplaceAll_Click(object sender, System.EventArgs e)
		{
			int numbers = 0;
			int start;
			int end;
			if (location == -1)
				start = 0;
			else
				start = location;
			end = txtContent.Text.Length - 1;
			
			while (start!= end)
			{
		
				if (chkMatchCase.Checked)
				{
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.MatchCase);
				}
				else
				{
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
				}
				
				if (location == -1)
				{
					
					break;
				}
				else
				{
					
					numbers++;
					this.txtContent.Select(location, txtFind.Text.Length);
					this.txtContent.Focus();
					location += txtFind.Text.Length;
				}

	
				if (txtContent.SelectedText == txtFind.Text)
				{
					txtContent.SelectedText = txtReplace.Text;
					location += txtFind.Text.Length;
				}
			}
		
			if (numbers == 0)
			{
				MessageBox.Show(string.Format("没有找到 [ {0} ]！", txtFind.Text), "C#记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		 private int location = -1;

		
		private void btnFind_Click(object sender, System.EventArgs e)
		{
			int start;
			int end;
			if (location == -1)
			{
				if (txtContent.SelectionStart < txtContent.Text.Length)
					start = txtContent.SelectionStart;
				else
					start = txtContent.Text.Length - 1;
			}
			else
				start = location;
			end = txtContent.Text.Length-1;
			if (chkMatchCase.Checked)
			{
				location = txtContent.Find(txtFind.Text , start, end, RichTextBoxFinds.MatchCase);
			}
			else
			{
				location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
			}
			if (location == -1)
            {
                MessageBox.Show(string.Format("没有找到 [ {0} ]！", txtFind.Text), "C#记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				this.txtContent .Select(location, txtFind.Text.Length);
				this.txtContent.Focus();
				location += txtFind.Text.Length;
			}
		}

		private void txtFind_TextChanged(object sender, System.EventArgs e)
		{
			if(txtFind.Text.Length > 0)
			{
				btnFind.Enabled = true;
				btnReplace.Enabled = true;
				btnReplaceAll.Enabled = true;
			}
			else 
			{
				btnFind.Enabled = false ;
				btnReplace.Enabled = false;
				btnReplaceAll.Enabled = false;
			}
		}

		private void FrmReplace_Load(object sender, System.EventArgs e)
		{
			 this.txtFind.Focus();
		}
	}
}
