using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prana.Notepad
{
	

	public class FrmFind : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.TextBox txtFind;
		
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.CheckBox chkMatchCase;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdoUp;
		private System.Windows.Forms.RadioButton rdoDown;


		
		private System.Windows.Forms.RichTextBox txtContent;

		public FrmFind()
		{
			
			InitializeComponent();

			
		}


		
		public FrmFind(System.Windows.Forms.RichTextBox  textBox1)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFind));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "��������";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(80, 16);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(232, 21);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(328, 16);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 32);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "������һ��";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ȡ��";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Location = new System.Drawing.Point(40, 58);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(88, 24);
            this.chkMatchCase.TabIndex = 7;
            this.chkMatchCase.Text = "���ִ�Сд";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDown);
            this.groupBox1.Controls.Add(this.rdoUp);
            this.groupBox1.Location = new System.Drawing.Point(144, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 56);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "����";
            // 
            // rdoDown
            // 
            this.rdoDown.Checked = true;
            this.rdoDown.Location = new System.Drawing.Point(104, 24);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(48, 24);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "����";
            // 
            // rdoUp
            // 
            this.rdoUp.Location = new System.Drawing.Point(16, 24);
            this.rdoUp.Name = "rdoUp";
            this.rdoUp.Size = new System.Drawing.Size(48, 24);
            this.rdoUp.TabIndex = 0;
            this.rdoUp.Text = "����";
            // 
            // FrmFind
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(426, 119);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "����";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// λ��
		/// </summary>
		private int location = -1;

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			
			int start;
			int end;
			
			if(rdoUp.Checked == true)
			{
				start =0;
				end = txtContent.SelectionStart;
				location = -1;
				int l= 0;
				while (l!=-1&&start<end)
				{
					
					if (chkMatchCase.Checked == true)
						l = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.MatchCase);
					else
						l = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
					if (l != -1)
					{
						location = l;
						start = l+1;
					}
				}
			}
			else
			{
				if (location == -1)
				{
					if (txtContent.SelectionStart < txtContent.Text.Length)
						start = txtContent.SelectionStart;
					else
						start = txtContent.Text.Length - 1;
				}
				else
					start = location;
				end = txtContent.Text.Length - 1;
				if (chkMatchCase.Checked)
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.MatchCase);
				else
					location = txtContent.Find(txtFind.Text, start, end, RichTextBoxFinds.None);
			}
			
			if (location == -1)
			{
				
				MessageBox.Show(string.Format("û���ҵ� [ {0} ]��", txtFind.Text), "C#���±�", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				
				this.txtContent.Select(location, txtFind.Text.Length);
				this.txtContent.Focus();
				location += txtFind.Text.Length;
			}
		}

		private void FrmFind_Load(object sender, System.EventArgs e)
		{
			 this.txtFind.Focus();
		}

		private void txtFind_TextChanged(object sender, System.EventArgs e)
		{
			if(txtFind.Text .Length > 0)
			{
				btnFind.Enabled = true;
			}
			else 
			{
				btnFind.Enabled =false ;
			}
		}
	}
}
