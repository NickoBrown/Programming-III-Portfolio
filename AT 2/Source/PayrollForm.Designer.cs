
namespace PayrollProject
{
    partial class FormPayroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNameList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxRemoveName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxFindName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAutoFill = new System.Windows.Forms.Button();
            this.labelRoot = new System.Windows.Forms.Label();
            this.groupBoxAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNameList
            // 
            this.textBoxNameList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxNameList.Enabled = false;
            this.textBoxNameList.Location = new System.Drawing.Point(25, 43);
            this.textBoxNameList.Multiline = true;
            this.textBoxNameList.Name = "textBoxNameList";
            this.textBoxNameList.Size = new System.Drawing.Size(449, 29);
            this.textBoxNameList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Names";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNewName.Location = new System.Drawing.Point(21, 34);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxNewName);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Location = new System.Drawing.Point(25, 118);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(145, 100);
            this.groupBoxAdd.TabIndex = 4;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(21, 60);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.textBoxRemoveName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(187, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Name";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(21, 60);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxRemoveName
            // 
            this.textBoxRemoveName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRemoveName.Location = new System.Drawing.Point(21, 34);
            this.textBoxRemoveName.Name = "textBoxRemoveName";
            this.textBoxRemoveName.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemoveName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFind);
            this.groupBox2.Controls.Add(this.textBoxFindName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(350, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Name";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(21, 60);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 23);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxFindName
            // 
            this.textBoxFindName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFindName.Location = new System.Drawing.Point(21, 34);
            this.textBoxFindName.Name = "textBoxFindName";
            this.textBoxFindName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // buttonAutoFill
            // 
            this.buttonAutoFill.Location = new System.Drawing.Point(350, 236);
            this.buttonAutoFill.Name = "buttonAutoFill";
            this.buttonAutoFill.Size = new System.Drawing.Size(145, 32);
            this.buttonAutoFill.TabIndex = 8;
            this.buttonAutoFill.Text = "Autofill with sample data";
            this.buttonAutoFill.UseVisualStyleBackColor = true;
            this.buttonAutoFill.Click += new System.EventHandler(this.buttonAutoFill_Click);
            // 
            // labelRoot
            // 
            this.labelRoot.AutoSize = true;
            this.labelRoot.Enabled = false;
            this.labelRoot.Location = new System.Drawing.Point(22, 75);
            this.labelRoot.Name = "labelRoot";
            this.labelRoot.Size = new System.Drawing.Size(70, 13);
            this.labelRoot.TabIndex = 9;
            this.labelRoot.Text = "Current Root:";
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 280);
            this.Controls.Add(this.labelRoot);
            this.Controls.Add(this.buttonAutoFill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameList);
            this.Name = "FormPayroll";
            this.Text = "Payroll";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxRemoveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxFindName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAutoFill;
        private System.Windows.Forms.Label labelRoot;
    }
}

