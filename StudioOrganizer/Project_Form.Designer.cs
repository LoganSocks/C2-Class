namespace StudioOrganizer
{
    partial class Project_Form
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
            project_DGV = new DataGridView();
            Project_Title_tb = new TextBox();
            Status_cb = new ComboBox();
            BPM_num = new NumericUpDown();
            Key_cb = new ComboBox();
            Save_btn = new Button();
            Samples_btn = new Button();
            ML_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)project_DGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BPM_num).BeginInit();
            SuspendLayout();
            // 
            // project_DGV
            // 
            project_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            project_DGV.Location = new Point(1, 2);
            project_DGV.Name = "project_DGV";
            project_DGV.Size = new Size(799, 282);
            project_DGV.TabIndex = 0;
            // 
            // Project_Title_tb
            // 
            Project_Title_tb.Location = new Point(140, 317);
            Project_Title_tb.Name = "Project_Title_tb";
            Project_Title_tb.PlaceholderText = "Project Name";
            Project_Title_tb.Size = new Size(100, 23);
            Project_Title_tb.TabIndex = 1;
            // 
            // Status_cb
            // 
            Status_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Status_cb.FormattingEnabled = true;
            Status_cb.Items.AddRange(new object[] { "Idea", "Draft", "Mixing", "Mastered" });
            Status_cb.Location = new Point(256, 317);
            Status_cb.Name = "Status_cb";
            Status_cb.Size = new Size(121, 23);
            Status_cb.TabIndex = 2;
            // 
            // BPM_num
            // 
            BPM_num.Location = new Point(395, 317);
            BPM_num.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            BPM_num.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            BPM_num.Name = "BPM_num";
            BPM_num.Size = new Size(120, 23);
            BPM_num.TabIndex = 3;
            BPM_num.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // Key_cb
            // 
            Key_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Key_cb.FormattingEnabled = true;
            Key_cb.Items.AddRange(new object[] { "C Major", "D Major", "G Major", "A Major", "E Major", "F Major", "E♭ Major", "B♭ Major", "D♭ Major", "F♯ Major", "B Major", "A♭ Major", "A Minor", "E Minor", "C Minor", "D Minor", "B Minor", "G Minor", "F♯ Minor", "F Minor", "C♯ Minor", "D♯ Minor", "B♭ Minor", "G♯ Minor", "A Mixolydian", "G Mixolydian", "E Mixolydian", "D Mixolydian", "C Mixolydian", "B Mixolydian", "F Mixolydian", "B♭ Mixolydian", "A♭ Mixolydian", "E♭ Mixolydian", "C♯ Mixolydian", "F♯ Mixolydian", "D Dorian", "A Dorian", "E Dorian", "C Dorian", "G Dorian", "F Dorian", "B Dorian", "E♭ Dorian", "F♯ Dorian", "C♯ Dorian", "G♯ Dorian", "B♭ Dorian ", "C Lydian", "F Lydian", "A Lydian", "G Lydian", "D Lydian", "A♭ Lydian", "E Lydian", "D♭ Lydian", "B♭ Lydian", "E♭ Lydian", "B Lydian", "G♭ Lydian", "E Phrygian", "C Phrygian", "D Phrygian", "D♯ Phrygian", "F Phrygian", "G Phrygian", "A Phrygian", "C♯ Phrygian", "B Phrygian", "F♯ Phrygian", "A♯ Phrygian", "G♯ Phrygian", "B Locrian", "D Locrian", "D♯ Locrian", "C Locrian", "E Locrian", "F♯ Locrian", "A Locrian", "C♯ Locrian", "G Locrian", "A♯ Locrian", "E♯ Locrian" });
            Key_cb.Location = new Point(532, 317);
            Key_cb.Name = "Key_cb";
            Key_cb.Size = new Size(98, 23);
            Key_cb.TabIndex = 4;
            Key_cb.SelectedIndexChanged += Key_cb_SelectedIndexChanged;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(350, 369);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 23);
            Save_btn.TabIndex = 5;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Samples_btn
            // 
            Samples_btn.Location = new Point(532, 369);
            Samples_btn.Name = "Samples_btn";
            Samples_btn.Size = new Size(75, 23);
            Samples_btn.TabIndex = 6;
            Samples_btn.Text = "Samples";
            Samples_btn.UseVisualStyleBackColor = true;
            Samples_btn.Click += Samples_btn_Click;
            // 
            // ML_Button
            // 
            ML_Button.Location = new Point(197, 369);
            ML_Button.Name = "ML_Button";
            ML_Button.Size = new Size(104, 23);
            ML_Button.TabIndex = 7;
            ML_Button.Text = "Priority Sort";
            ML_Button.UseVisualStyleBackColor = true;
            ML_Button.Click += ML_Button_Click;
            // 
            // Project_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ML_Button);
            Controls.Add(Samples_btn);
            Controls.Add(Save_btn);
            Controls.Add(Key_cb);
            Controls.Add(BPM_num);
            Controls.Add(Status_cb);
            Controls.Add(Project_Title_tb);
            Controls.Add(project_DGV);
            Name = "Project_Form";
            Text = "Project Manager";
            Load += Project_Form_Load;
            ((System.ComponentModel.ISupportInitialize)project_DGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)BPM_num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView project_DGV;
        private TextBox Project_Title_tb;
        private ComboBox Status_cb;
        private NumericUpDown BPM_num;
        private ComboBox Key_cb;
        private Button Save_btn;
        private Button Samples_btn;
        private Button ML_Button;
    }
}
