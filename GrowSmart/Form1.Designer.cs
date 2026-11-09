namespace GrowSmart
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            dtpPlanting = new DateTimePicker();
            lblResult = new Label();
            label3 = new Label();
            txtDirections = new TextBox();
            txtSearch = new TextBox();
            lstPlants = new ListBox();
            lblCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Plant Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Planting Date:";
            // 
            // dtpPlanting
            // 
            dtpPlanting.Location = new Point(189, 78);
            dtpPlanting.Margin = new Padding(3, 2, 3, 2);
            dtpPlanting.Name = "dtpPlanting";
            dtpPlanting.Size = new Size(240, 23);
            dtpPlanting.TabIndex = 3;
            dtpPlanting.ValueChanged += dtpPlanting_ValueChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(389, 34);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(36, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "blank";
            lblResult.Click += lblResult_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 128);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 5;
            label3.Text = "Growing directions:";
            // 
            // txtDirections
            // 
            txtDirections.Location = new Point(192, 130);
            txtDirections.Margin = new Padding(3, 2, 3, 2);
            txtDirections.Multiline = true;
            txtDirections.Name = "txtDirections";
            txtDirections.ReadOnly = true;
            txtDirections.Size = new Size(97, 7);
            txtDirections.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(189, 28);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(166, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lstPlants
            // 
            lstPlants.FormattingEnabled = true;
            lstPlants.Location = new Point(399, 141);
            lstPlants.Margin = new Padding(3, 2, 3, 2);
            lstPlants.Name = "lstPlants";
            lstPlants.Size = new Size(255, 184);
            lstPlants.TabIndex = 8;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(23, 169);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(38, 15);
            lblCount.TabIndex = 9;
            lblCount.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblCount);
            Controls.Add(lstPlants);
            Controls.Add(txtSearch);
            Controls.Add(txtDirections);
            Controls.Add(label3);
            Controls.Add(lblResult);
            Controls.Add(dtpPlanting);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpPlanting;
        private Label lblResult;
        private Label label3;
        private TextBox txtDirections;
        private TextBox txtSearch;
        private ListBox lstPlants;
        private Label lblCount;
    }
}
