namespace StudioOrganizer
{
    partial class Samples_Form
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
            Sample_DGV = new DataGridView();
            Sample_Name_tb = new TextBox();
            Sample_Type_cb = new ComboBox();
            Project_Select_cb = new ComboBox();
            Save_btn = new Button();
            Key_cb = new ComboBox();
            Projects_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Sample_DGV).BeginInit();
            SuspendLayout();
            // 
            // Sample_DGV
            // 
            Sample_DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Sample_DGV.Location = new Point(0, 0);
            Sample_DGV.Name = "Sample_DGV";
            Sample_DGV.Size = new Size(800, 265);
            Sample_DGV.TabIndex = 0;
            // 
            // Sample_Name_tb
            // 
            Sample_Name_tb.Location = new Point(177, 301);
            Sample_Name_tb.Name = "Sample_Name_tb";
            Sample_Name_tb.PlaceholderText = "Sample Name";
            Sample_Name_tb.Size = new Size(100, 23);
            Sample_Name_tb.TabIndex = 1;
            // 
            // Sample_Type_cb
            // 
            Sample_Type_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Sample_Type_cb.FormattingEnabled = true;
            Sample_Type_cb.Items.AddRange(new object[] { "Drum", "Synth", "Vocal", "Bell", "Piano", "Mechanical" });
            Sample_Type_cb.Location = new Point(283, 301);
            Sample_Type_cb.Name = "Sample_Type_cb";
            Sample_Type_cb.Size = new Size(121, 23);
            Sample_Type_cb.TabIndex = 2;
            // 
            // Project_Select_cb
            // 
            Project_Select_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Project_Select_cb.FormattingEnabled = true;
            Project_Select_cb.Location = new Point(537, 302);
            Project_Select_cb.Name = "Project_Select_cb";
            Project_Select_cb.Size = new Size(121, 23);
            Project_Select_cb.TabIndex = 3;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(370, 330);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 23);
            Save_btn.TabIndex = 4;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Key_cb
            // 
            Key_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            Key_cb.FormattingEnabled = true;
            Key_cb.Items.AddRange(new object[] { "C Major", "D Major", "G Major", "A Major", "E Major", "F Major", "E♭ Major", "B♭ Major", "D♭ Major", "F♯ Major", "B Major", "A♭ Major", "A Minor", "E Minor", "C Minor", "D Minor", "B Minor", "G Minor", "F♯ Minor", "F Minor", "C♯ Minor", "D♯ Minor", "B♭ Minor", "G♯ Minor", "A Mixolydian", "G Mixolydian", "E Mixolydian", "D Mixolydian", "C Mixolydian", "B Mixolydian", "F Mixolydian", "B♭ Mixolydian", "A♭ Mixolydian", "E♭ Mixolydian", "C♯ Mixolydian", "F♯ Mixolydian", "D Dorian", "A Dorian", "E Dorian", "C Dorian", "G Dorian", "F Dorian", "B Dorian", "E♭ Dorian", "F♯ Dorian", "C♯ Dorian", "G♯ Dorian", "B♭ Dorian ", "C Lydian", "F Lydian", "A Lydian", "G Lydian", "D Lydian", "A♭ Lydian", "E Lydian", "D♭ Lydian", "B♭ Lydian", "E♭ Lydian", "B Lydian", "G♭ Lydian", "E Phrygian", "C Phrygian", "D Phrygian", "D♯ Phrygian", "F Phrygian", "G Phrygian", "A Phrygian", "C♯ Phrygian", "B Phrygian", "F♯ Phrygian", "A♯ Phrygian", "G♯ Phrygian", "B Locrian", "D Locrian", "D♯ Locrian", "C Locrian", "E Locrian", "F♯ Locrian", "A Locrian", "C♯ Locrian", "G Locrian", "A♯ Locrian", "E♯ Locrian" });
            Key_cb.Location = new Point(410, 302);
            Key_cb.Name = "Key_cb";
            Key_cb.Size = new Size(121, 23);
            Key_cb.TabIndex = 5;
            // 
            // Projects_btn
            // 
            Projects_btn.Location = new Point(537, 331);
            Projects_btn.Name = "Projects_btn";
            Projects_btn.Size = new Size(75, 23);
            Projects_btn.TabIndex = 6;
            Projects_btn.Text = "Projects";
            Projects_btn.UseVisualStyleBackColor = true;
            Projects_btn.Click += Projects_btn_Click;
            // 
            // Samples_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Projects_btn);
            Controls.Add(Key_cb);
            Controls.Add(Save_btn);
            Controls.Add(Project_Select_cb);
            Controls.Add(Sample_Type_cb);
            Controls.Add(Sample_Name_tb);
            Controls.Add(Sample_DGV);
            Name = "Samples_Form";
            Text = "Samples_Form";
            Load += Samples_Form_Load;
            ((System.ComponentModel.ISupportInitialize)Sample_DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Sample_DGV;
        private TextBox Sample_Name_tb;
        private ComboBox Sample_Type_cb;
        private ComboBox Project_Select_cb;
        private Button Save_btn;
        private ComboBox Key_cb;
        private Button Projects_btn;
    }
}