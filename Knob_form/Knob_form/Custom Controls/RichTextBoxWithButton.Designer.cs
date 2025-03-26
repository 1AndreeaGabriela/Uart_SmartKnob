namespace Knob_form
{
    partial class RichTextBoxWithButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            materialButtonClear = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(762, 175);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // materialButtonClear
            // 
            materialButtonClear.AutoSize = false;
            materialButtonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonClear.Depth = 0;
            materialButtonClear.Dock = DockStyle.Bottom;
            materialButtonClear.HighEmphasis = true;
            materialButtonClear.Icon = null;
            materialButtonClear.Location = new Point(0, 139);
            materialButtonClear.Margin = new Padding(0);
            materialButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonClear.Name = "materialButtonClear";
            materialButtonClear.NoAccentTextColor = Color.Empty;
            materialButtonClear.RightToLeft = RightToLeft.Yes;
            materialButtonClear.Size = new Size(762, 36);
            materialButtonClear.TabIndex = 1;
            materialButtonClear.Text = "Clear";
            materialButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonClear.UseAccentColor = false;
            materialButtonClear.UseVisualStyleBackColor = true;
            materialButtonClear.Click += materialButtonClear_Click;
            // 
            // RichTextBoxWithButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialButtonClear);
            Controls.Add(richTextBox1);
            Name = "RichTextBoxWithButton";
            Size = new Size(762, 175);
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButtonClear;
    }
}
