namespace StudioOrganizer
{
    partial class ML_Form
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
            ML_Button = new Button();
            ML_dgv = new DataGridView();
            Project_Button = new Button();
            Samples_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)ML_dgv).BeginInit();
            SuspendLayout();
            // 
            // ML_Button
            // 
            ML_Button.Location = new Point(343, 325);
            ML_Button.Name = "ML_Button";
            ML_Button.Size = new Size(75, 23);
            ML_Button.TabIndex = 0;
            ML_Button.Text = "Sort";
            ML_Button.UseVisualStyleBackColor = true;
            ML_Button.Click += ML_Button_Click;
            // 
            // ML_dgv
            // 
            ML_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ML_dgv.Location = new Point(107, 36);
            ML_dgv.Name = "ML_dgv";
            ML_dgv.Size = new Size(554, 283);
            ML_dgv.TabIndex = 1;
            // 
            // Project_Button
            // 
            Project_Button.Location = new Point(203, 325);
            Project_Button.Name = "Project_Button";
            Project_Button.Size = new Size(91, 23);
            Project_Button.TabIndex = 2;
            Project_Button.Text = "Project Page";
            Project_Button.UseVisualStyleBackColor = true;
            Project_Button.Click += Project_Button_Click;
            // 
            // Samples_Button
            // 
            Samples_Button.Location = new Point(485, 325);
            Samples_Button.Name = "Samples_Button";
            Samples_Button.Size = new Size(94, 23);
            Samples_Button.TabIndex = 3;
            Samples_Button.Text = "Samples Page";
            Samples_Button.UseVisualStyleBackColor = true;
            Samples_Button.Click += Samples_Button_Click;
            // 
            // ML_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Samples_Button);
            Controls.Add(Project_Button);
            Controls.Add(ML_dgv);
            Controls.Add(ML_Button);
            Name = "ML_Form";
            Text = "ML Form";
            ((System.ComponentModel.ISupportInitialize)ML_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ML_Button;
        private DataGridView ML_dgv;
        private Button Project_Button;
        private Button Samples_Button;
    }
}