namespace Knob_form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnStop = new MaterialSkin.Controls.MaterialButton();
            btnStart = new MaterialSkin.Controls.MaterialButton();
            directionLabel = new MaterialSkin.Controls.MaterialLabel();
            positionLabel = new MaterialSkin.Controls.MaterialLabel();
            positionTextLabel = new MaterialSkin.Controls.MaterialLabel();
            directionTextLabel = new MaterialSkin.Controls.MaterialLabel();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            richTextBoxWithButton1 = new RichTextBoxWithButton();
            tabPage2 = new TabPage();
            richTextBoxWithButton2 = new RichTextBoxWithButton();
            btnSend = new MaterialSkin.Controls.MaterialButton();
            txtMessage = new MaterialSkin.Controls.MaterialTextBox2();
            materialTextBoxDetents = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxLimit2 = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxLimit1 = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonSaveMods = new MaterialSkin.Controls.MaterialButton();
            materialComboBoxMods = new MaterialSkin.Controls.MaterialComboBox();
            materialLabelLimits = new MaterialSkin.Controls.MaterialLabel();
            materialLabelDetents = new MaterialSkin.Controls.MaterialLabel();
            materialLabelMods = new MaterialSkin.Controls.MaterialLabel();
            tabPage3 = new TabPage();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            comboBoxGradientEndColor = new MaterialSkin.Controls.MaterialComboBox();
            comboBoxGradientStartColor = new MaterialSkin.Controls.MaterialComboBox();
            comboBoxIndicatorColor = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxPrimary3 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialComboBoxTextShade = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxAccent = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxPrimary2 = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxPrimary1 = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxTheme = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            baudRateList = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            comPortsList = new MaterialSkin.Controls.MaterialComboBox();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStop.Depth = 0;
            btnStop.HighEmphasis = true;
            btnStop.Icon = null;
            btnStop.Location = new Point(122, 408);
            btnStop.Margin = new Padding(0);
            btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            btnStop.Name = "btnStop";
            btnStop.NoAccentTextColor = Color.Empty;
            btnStop.Size = new Size(64, 36);
            btnStop.TabIndex = 10;
            btnStop.Text = "Stop";
            btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStop.UseAccentColor = false;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStart.Depth = 0;
            btnStart.HighEmphasis = true;
            btnStart.Icon = null;
            btnStart.Location = new Point(36, 409);
            btnStart.Margin = new Padding(0);
            btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStart.Name = "btnStart";
            btnStart.NoAccentTextColor = Color.Empty;
            btnStart.Size = new Size(67, 36);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start";
            btnStart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStart.UseAccentColor = false;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // directionLabel
            // 
            directionLabel.AutoSize = true;
            directionLabel.Depth = 0;
            directionLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            directionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            directionLabel.ForeColor = Color.Gray;
            directionLabel.HighEmphasis = true;
            directionLabel.Location = new Point(36, 86);
            directionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            directionLabel.Name = "directionLabel";
            directionLabel.Size = new Size(107, 24);
            directionLabel.TabIndex = 14;
            directionLabel.Text = "DIRECTION:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Depth = 0;
            positionLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            positionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            positionLabel.ForeColor = Color.Gainsboro;
            positionLabel.HighEmphasis = true;
            positionLabel.Location = new Point(36, 136);
            positionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(97, 24);
            positionLabel.TabIndex = 15;
            positionLabel.Text = "POSITION:";
            // 
            // positionTextLabel
            // 
            positionTextLabel.AutoSize = true;
            positionTextLabel.Depth = 0;
            positionTextLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            positionTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            positionTextLabel.Location = new Point(175, 131);
            positionTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            positionTextLabel.Name = "positionTextLabel";
            positionTextLabel.Size = new Size(19, 24);
            positionTextLabel.TabIndex = 16;
            positionTextLabel.Text = "...";
            // 
            // directionTextLabel
            // 
            directionTextLabel.AutoSize = true;
            directionTextLabel.Depth = 0;
            directionTextLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            directionTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            directionTextLabel.Location = new Point(175, 86);
            directionTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            directionTextLabel.Name = "directionTextLabel";
            directionTextLabel.Size = new Size(19, 24);
            directionTextLabel.TabIndex = 17;
            directionTextLabel.Text = "...";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(0, 88);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1845, 1058);
            materialTabControl1.TabIndex = 18;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBoxWithButton1);
            tabPage1.Controls.Add(directionLabel);
            tabPage1.Controls.Add(directionTextLabel);
            tabPage1.Controls.Add(positionLabel);
            tabPage1.Controls.Add(btnStop);
            tabPage1.Controls.Add(positionTextLabel);
            tabPage1.Controls.Add(btnStart);
            tabPage1.ImageKey = "menu-60.png";
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1837, 1025);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxWithButton1
            // 
            richTextBoxWithButton1.Dock = DockStyle.Bottom;
            richTextBoxWithButton1.Location = new Point(3, 803);
            richTextBoxWithButton1.Name = "richTextBoxWithButton1";
            richTextBoxWithButton1.Size = new Size(1831, 219);
            richTextBoxWithButton1.TabIndex = 18;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBoxWithButton2);
            tabPage2.Controls.Add(btnSend);
            tabPage2.Controls.Add(txtMessage);
            tabPage2.Controls.Add(materialTextBoxDetents);
            tabPage2.Controls.Add(materialTextBoxLimit2);
            tabPage2.Controls.Add(materialTextBoxLimit1);
            tabPage2.Controls.Add(materialButtonSaveMods);
            tabPage2.Controls.Add(materialComboBoxMods);
            tabPage2.Controls.Add(materialLabelLimits);
            tabPage2.Controls.Add(materialLabelDetents);
            tabPage2.Controls.Add(materialLabelMods);
            tabPage2.ImageKey = "knob3.png";
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1837, 1025);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Knob Mods";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxWithButton2
            // 
            richTextBoxWithButton2.Dock = DockStyle.Bottom;
            richTextBoxWithButton2.Location = new Point(3, 803);
            richTextBoxWithButton2.Name = "richTextBoxWithButton2";
            richTextBoxWithButton2.Size = new Size(1831, 219);
            richTextBoxWithButton2.TabIndex = 11;
            // 
            // btnSend
            // 
            btnSend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSend.Depth = 0;
            btnSend.HighEmphasis = true;
            btnSend.Icon = null;
            btnSend.Location = new Point(1038, 181);
            btnSend.Margin = new Padding(4, 6, 4, 6);
            btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            btnSend.Name = "btnSend";
            btnSend.NoAccentTextColor = Color.Empty;
            btnSend.Size = new Size(64, 36);
            btnSend.TabIndex = 10;
            btnSend.Text = "send";
            btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSend.UseAccentColor = false;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.AnimateReadOnly = false;
            txtMessage.BackgroundImageLayout = ImageLayout.None;
            txtMessage.CharacterCasing = CharacterCasing.Normal;
            txtMessage.Depth = 0;
            txtMessage.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMessage.HideSelection = true;
            txtMessage.LeadingIcon = null;
            txtMessage.Location = new Point(707, 103);
            txtMessage.MaxLength = 32767;
            txtMessage.MouseState = MaterialSkin.MouseState.OUT;
            txtMessage.Name = "txtMessage";
            txtMessage.PasswordChar = '\0';
            txtMessage.PrefixSuffixText = null;
            txtMessage.ReadOnly = false;
            txtMessage.RightToLeft = RightToLeft.No;
            txtMessage.SelectedText = "";
            txtMessage.SelectionLength = 0;
            txtMessage.SelectionStart = 0;
            txtMessage.ShortcutsEnabled = true;
            txtMessage.Size = new Size(395, 48);
            txtMessage.TabIndex = 9;
            txtMessage.TabStop = false;
            txtMessage.Text = "Enter a message";
            txtMessage.TextAlign = HorizontalAlignment.Left;
            txtMessage.TrailingIcon = null;
            txtMessage.UseSystemPasswordChar = false;
            // 
            // materialTextBoxDetents
            // 
            materialTextBoxDetents.AnimateReadOnly = false;
            materialTextBoxDetents.BorderStyle = BorderStyle.None;
            materialTextBoxDetents.Depth = 0;
            materialTextBoxDetents.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxDetents.LeadingIcon = null;
            materialTextBoxDetents.Location = new Point(169, 293);
            materialTextBoxDetents.MaxLength = 50;
            materialTextBoxDetents.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDetents.Multiline = false;
            materialTextBoxDetents.Name = "materialTextBoxDetents";
            materialTextBoxDetents.Size = new Size(77, 50);
            materialTextBoxDetents.TabIndex = 7;
            materialTextBoxDetents.Text = "";
            materialTextBoxDetents.TrailingIcon = null;
            // 
            // materialTextBoxLimit2
            // 
            materialTextBoxLimit2.AnimateReadOnly = false;
            materialTextBoxLimit2.BorderStyle = BorderStyle.None;
            materialTextBoxLimit2.Depth = 0;
            materialTextBoxLimit2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxLimit2.LeadingIcon = null;
            materialTextBoxLimit2.Location = new Point(264, 202);
            materialTextBoxLimit2.MaxLength = 50;
            materialTextBoxLimit2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxLimit2.Multiline = false;
            materialTextBoxLimit2.Name = "materialTextBoxLimit2";
            materialTextBoxLimit2.Size = new Size(77, 50);
            materialTextBoxLimit2.TabIndex = 6;
            materialTextBoxLimit2.Text = "";
            materialTextBoxLimit2.TrailingIcon = null;
            // 
            // materialTextBoxLimit1
            // 
            materialTextBoxLimit1.AnimateReadOnly = false;
            materialTextBoxLimit1.BorderStyle = BorderStyle.None;
            materialTextBoxLimit1.Depth = 0;
            materialTextBoxLimit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxLimit1.LeadingIcon = null;
            materialTextBoxLimit1.Location = new Point(169, 202);
            materialTextBoxLimit1.MaxLength = 50;
            materialTextBoxLimit1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxLimit1.Multiline = false;
            materialTextBoxLimit1.Name = "materialTextBoxLimit1";
            materialTextBoxLimit1.Size = new Size(77, 50);
            materialTextBoxLimit1.TabIndex = 5;
            materialTextBoxLimit1.Text = "";
            materialTextBoxLimit1.TrailingIcon = null;
            materialTextBoxLimit1.TextChanged += materialTextBoxLimit1_TextChanged;
            // 
            // materialButtonSaveMods
            // 
            materialButtonSaveMods.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonSaveMods.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonSaveMods.Depth = 0;
            materialButtonSaveMods.HighEmphasis = true;
            materialButtonSaveMods.Icon = null;
            materialButtonSaveMods.Location = new Point(1047, 409);
            materialButtonSaveMods.Margin = new Padding(4, 6, 4, 6);
            materialButtonSaveMods.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonSaveMods.Name = "materialButtonSaveMods";
            materialButtonSaveMods.NoAccentTextColor = Color.Empty;
            materialButtonSaveMods.Size = new Size(64, 36);
            materialButtonSaveMods.TabIndex = 4;
            materialButtonSaveMods.Text = "save";
            materialButtonSaveMods.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonSaveMods.UseAccentColor = false;
            materialButtonSaveMods.UseVisualStyleBackColor = true;
            materialButtonSaveMods.Click += materialButtonSaveMods_Click;
            // 
            // materialComboBoxMods
            // 
            materialComboBoxMods.AutoResize = false;
            materialComboBoxMods.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxMods.Depth = 0;
            materialComboBoxMods.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxMods.DropDownHeight = 174;
            materialComboBoxMods.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxMods.DropDownWidth = 121;
            materialComboBoxMods.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxMods.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxMods.FormattingEnabled = true;
            materialComboBoxMods.IntegralHeight = false;
            materialComboBoxMods.ItemHeight = 43;
            materialComboBoxMods.Items.AddRange(new object[] { "Endless", "ON/OFF", "Two limits", "Return to center" });
            materialComboBoxMods.Location = new Point(169, 102);
            materialComboBoxMods.MaxDropDownItems = 4;
            materialComboBoxMods.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxMods.Name = "materialComboBoxMods";
            materialComboBoxMods.Size = new Size(172, 49);
            materialComboBoxMods.StartIndex = 0;
            materialComboBoxMods.TabIndex = 3;
            materialComboBoxMods.SelectedIndexChanged += materialComboBoxMods_SelectedIndexChanged;
            // 
            // materialLabelLimits
            // 
            materialLabelLimits.AutoSize = true;
            materialLabelLimits.Depth = 0;
            materialLabelLimits.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabelLimits.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelLimits.HighEmphasis = true;
            materialLabelLimits.Location = new Point(44, 227);
            materialLabelLimits.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelLimits.Name = "materialLabelLimits";
            materialLabelLimits.Size = new Size(71, 24);
            materialLabelLimits.TabIndex = 2;
            materialLabelLimits.Text = "LIMITS:";
            // 
            // materialLabelDetents
            // 
            materialLabelDetents.AutoSize = true;
            materialLabelDetents.Depth = 0;
            materialLabelDetents.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabelDetents.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelDetents.HighEmphasis = true;
            materialLabelDetents.Location = new Point(44, 319);
            materialLabelDetents.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDetents.Name = "materialLabelDetents";
            materialLabelDetents.Size = new Size(91, 24);
            materialLabelDetents.TabIndex = 1;
            materialLabelDetents.Text = "DETENTS:";
            // 
            // materialLabelMods
            // 
            materialLabelMods.AutoSize = true;
            materialLabelMods.Depth = 0;
            materialLabelMods.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabelMods.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabelMods.HighEmphasis = true;
            materialLabelMods.Location = new Point(44, 127);
            materialLabelMods.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelMods.Name = "materialLabelMods";
            materialLabelMods.Size = new Size(51, 24);
            materialLabelMods.TabIndex = 0;
            materialLabelMods.Text = "MOD:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(materialLabel17);
            tabPage3.Controls.Add(materialLabel5);
            tabPage3.Controls.Add(comboBoxGradientEndColor);
            tabPage3.Controls.Add(comboBoxGradientStartColor);
            tabPage3.Controls.Add(comboBoxIndicatorColor);
            tabPage3.Controls.Add(materialLabel13);
            tabPage3.Controls.Add(materialComboBoxPrimary3);
            tabPage3.Controls.Add(materialLabel12);
            tabPage3.Controls.Add(materialComboBoxTextShade);
            tabPage3.Controls.Add(materialComboBoxAccent);
            tabPage3.Controls.Add(materialComboBoxPrimary2);
            tabPage3.Controls.Add(materialComboBoxPrimary1);
            tabPage3.Controls.Add(materialComboBoxTheme);
            tabPage3.Controls.Add(materialLabel4);
            tabPage3.Controls.Add(materialLabel11);
            tabPage3.Controls.Add(materialLabel10);
            tabPage3.Controls.Add(materialLabel9);
            tabPage3.Controls.Add(baudRateList);
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Controls.Add(materialLabel3);
            tabPage3.Controls.Add(comPortsList);
            tabPage3.ImageKey = "settings.png";
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1819, 978);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel17.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel17.HighEmphasis = true;
            materialLabel17.Location = new Point(221, 364);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(270, 29);
            materialLabel17.TabIndex = 24;
            materialLabel17.Text = "Knob Apparance Settings";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.HighEmphasis = true;
            materialLabel5.Location = new Point(28, 587);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(126, 24);
            materialLabel5.TabIndex = 23;
            materialLabel5.Text = "FILL COLORS:";
            // 
            // comboBoxGradientEndColor
            // 
            comboBoxGradientEndColor.AutoResize = false;
            comboBoxGradientEndColor.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxGradientEndColor.Depth = 0;
            comboBoxGradientEndColor.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxGradientEndColor.DropDownHeight = 174;
            comboBoxGradientEndColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGradientEndColor.DropDownWidth = 121;
            comboBoxGradientEndColor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxGradientEndColor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxGradientEndColor.FormattingEnabled = true;
            comboBoxGradientEndColor.IntegralHeight = false;
            comboBoxGradientEndColor.ItemHeight = 43;
            comboBoxGradientEndColor.Location = new Point(370, 562);
            comboBoxGradientEndColor.MaxDropDownItems = 4;
            comboBoxGradientEndColor.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxGradientEndColor.Name = "comboBoxGradientEndColor";
            comboBoxGradientEndColor.Size = new Size(121, 49);
            comboBoxGradientEndColor.StartIndex = 0;
            comboBoxGradientEndColor.TabIndex = 22;
            comboBoxGradientEndColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;
            // 
            // comboBoxGradientStartColor
            // 
            comboBoxGradientStartColor.AutoResize = false;
            comboBoxGradientStartColor.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxGradientStartColor.Depth = 0;
            comboBoxGradientStartColor.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxGradientStartColor.DropDownHeight = 174;
            comboBoxGradientStartColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGradientStartColor.DropDownWidth = 121;
            comboBoxGradientStartColor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxGradientStartColor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxGradientStartColor.FormattingEnabled = true;
            comboBoxGradientStartColor.IntegralHeight = false;
            comboBoxGradientStartColor.ItemHeight = 43;
            comboBoxGradientStartColor.Location = new Point(221, 562);
            comboBoxGradientStartColor.MaxDropDownItems = 4;
            comboBoxGradientStartColor.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxGradientStartColor.Name = "comboBoxGradientStartColor";
            comboBoxGradientStartColor.Size = new Size(121, 49);
            comboBoxGradientStartColor.StartIndex = 0;
            comboBoxGradientStartColor.TabIndex = 21;
            comboBoxGradientStartColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;
            // 
            // comboBoxIndicatorColor
            // 
            comboBoxIndicatorColor.AutoResize = false;
            comboBoxIndicatorColor.BackColor = Color.FromArgb(255, 255, 255);
            comboBoxIndicatorColor.Depth = 0;
            comboBoxIndicatorColor.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxIndicatorColor.DropDownHeight = 174;
            comboBoxIndicatorColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIndicatorColor.DropDownWidth = 121;
            comboBoxIndicatorColor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBoxIndicatorColor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBoxIndicatorColor.FormattingEnabled = true;
            comboBoxIndicatorColor.IntegralHeight = false;
            comboBoxIndicatorColor.ItemHeight = 43;
            comboBoxIndicatorColor.Location = new Point(221, 491);
            comboBoxIndicatorColor.MaxDropDownItems = 4;
            comboBoxIndicatorColor.MouseState = MaterialSkin.MouseState.OUT;
            comboBoxIndicatorColor.Name = "comboBoxIndicatorColor";
            comboBoxIndicatorColor.Size = new Size(121, 49);
            comboBoxIndicatorColor.StartIndex = 0;
            comboBoxIndicatorColor.TabIndex = 20;
            comboBoxIndicatorColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel13.HighEmphasis = true;
            materialLabel13.Location = new Point(28, 516);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(109, 24);
            materialLabel13.TabIndex = 19;
            materialLabel13.Text = "INDICATOR:";
            // 
            // materialComboBoxPrimary3
            // 
            materialComboBoxPrimary3.AutoResize = false;
            materialComboBoxPrimary3.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxPrimary3.Depth = 0;
            materialComboBoxPrimary3.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxPrimary3.DropDownHeight = 174;
            materialComboBoxPrimary3.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxPrimary3.DropDownWidth = 121;
            materialComboBoxPrimary3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxPrimary3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxPrimary3.FormattingEnabled = true;
            materialComboBoxPrimary3.IntegralHeight = false;
            materialComboBoxPrimary3.ItemHeight = 43;
            materialComboBoxPrimary3.Location = new Point(221, 253);
            materialComboBoxPrimary3.MaxDropDownItems = 4;
            materialComboBoxPrimary3.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxPrimary3.Name = "materialComboBoxPrimary3";
            materialComboBoxPrimary3.Size = new Size(121, 49);
            materialComboBoxPrimary3.Sorted = true;
            materialComboBoxPrimary3.StartIndex = 0;
            materialComboBoxPrimary3.TabIndex = 18;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel12.HighEmphasis = true;
            materialLabel12.Location = new Point(28, 448);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(123, 24);
            materialLabel12.TabIndex = 16;
            materialLabel12.Text = "TEXT COLOR:";
            // 
            // materialComboBoxTextShade
            // 
            materialComboBoxTextShade.AutoResize = false;
            materialComboBoxTextShade.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxTextShade.Depth = 0;
            materialComboBoxTextShade.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxTextShade.DropDownHeight = 174;
            materialComboBoxTextShade.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxTextShade.DropDownWidth = 121;
            materialComboBoxTextShade.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxTextShade.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxTextShade.FormattingEnabled = true;
            materialComboBoxTextShade.IntegralHeight = false;
            materialComboBoxTextShade.ItemHeight = 43;
            materialComboBoxTextShade.Location = new Point(221, 423);
            materialComboBoxTextShade.MaxDropDownItems = 4;
            materialComboBoxTextShade.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxTextShade.Name = "materialComboBoxTextShade";
            materialComboBoxTextShade.Size = new Size(121, 49);
            materialComboBoxTextShade.StartIndex = 0;
            materialComboBoxTextShade.TabIndex = 15;
            // 
            // materialComboBoxAccent
            // 
            materialComboBoxAccent.AutoResize = false;
            materialComboBoxAccent.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxAccent.Depth = 0;
            materialComboBoxAccent.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxAccent.DropDownHeight = 174;
            materialComboBoxAccent.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxAccent.DropDownWidth = 121;
            materialComboBoxAccent.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxAccent.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxAccent.FormattingEnabled = true;
            materialComboBoxAccent.IntegralHeight = false;
            materialComboBoxAccent.ItemHeight = 43;
            materialComboBoxAccent.Location = new Point(370, 253);
            materialComboBoxAccent.MaxDropDownItems = 4;
            materialComboBoxAccent.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxAccent.Name = "materialComboBoxAccent";
            materialComboBoxAccent.Size = new Size(121, 49);
            materialComboBoxAccent.Sorted = true;
            materialComboBoxAccent.StartIndex = 0;
            materialComboBoxAccent.TabIndex = 14;
            // 
            // materialComboBoxPrimary2
            // 
            materialComboBoxPrimary2.AutoResize = false;
            materialComboBoxPrimary2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxPrimary2.Depth = 0;
            materialComboBoxPrimary2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxPrimary2.DropDownHeight = 174;
            materialComboBoxPrimary2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxPrimary2.DropDownWidth = 121;
            materialComboBoxPrimary2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxPrimary2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxPrimary2.FormattingEnabled = true;
            materialComboBoxPrimary2.IntegralHeight = false;
            materialComboBoxPrimary2.ItemHeight = 43;
            materialComboBoxPrimary2.Location = new Point(370, 183);
            materialComboBoxPrimary2.MaxDropDownItems = 4;
            materialComboBoxPrimary2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxPrimary2.Name = "materialComboBoxPrimary2";
            materialComboBoxPrimary2.Size = new Size(121, 49);
            materialComboBoxPrimary2.Sorted = true;
            materialComboBoxPrimary2.StartIndex = 0;
            materialComboBoxPrimary2.TabIndex = 13;
            // 
            // materialComboBoxPrimary1
            // 
            materialComboBoxPrimary1.AutoResize = false;
            materialComboBoxPrimary1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxPrimary1.Depth = 0;
            materialComboBoxPrimary1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxPrimary1.DropDownHeight = 174;
            materialComboBoxPrimary1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxPrimary1.DropDownWidth = 121;
            materialComboBoxPrimary1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxPrimary1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxPrimary1.FormattingEnabled = true;
            materialComboBoxPrimary1.IntegralHeight = false;
            materialComboBoxPrimary1.ItemHeight = 43;
            materialComboBoxPrimary1.Location = new Point(221, 183);
            materialComboBoxPrimary1.MaxDropDownItems = 4;
            materialComboBoxPrimary1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxPrimary1.Name = "materialComboBoxPrimary1";
            materialComboBoxPrimary1.Size = new Size(121, 49);
            materialComboBoxPrimary1.Sorted = true;
            materialComboBoxPrimary1.StartIndex = 0;
            materialComboBoxPrimary1.TabIndex = 12;
            // 
            // materialComboBoxTheme
            // 
            materialComboBoxTheme.AutoResize = false;
            materialComboBoxTheme.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBoxTheme.Depth = 0;
            materialComboBoxTheme.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBoxTheme.DropDownHeight = 174;
            materialComboBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBoxTheme.DropDownWidth = 121;
            materialComboBoxTheme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBoxTheme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBoxTheme.FormattingEnabled = true;
            materialComboBoxTheme.IntegralHeight = false;
            materialComboBoxTheme.ItemHeight = 43;
            materialComboBoxTheme.Items.AddRange(new object[] { "DARK", "LIGHT" });
            materialComboBoxTheme.Location = new Point(221, 116);
            materialComboBoxTheme.MaxDropDownItems = 4;
            materialComboBoxTheme.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxTheme.Name = "materialComboBoxTheme";
            materialComboBoxTheme.Size = new Size(121, 49);
            materialComboBoxTheme.StartIndex = 0;
            materialComboBoxTheme.TabIndex = 11;
            materialComboBoxTheme.SelectedIndexChanged += MaterialComboBoxTheme_SelectedIndexChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.HighEmphasis = true;
            materialLabel4.Location = new Point(28, 208);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(154, 24);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "COLOR SCHEME:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel11.HighEmphasis = true;
            materialLabel11.Location = new Point(28, 141);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(72, 24);
            materialLabel11.TabIndex = 9;
            materialLabel11.Text = "THEME:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel10.HighEmphasis = true;
            materialLabel10.Location = new Point(221, 34);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(209, 29);
            materialLabel10.TabIndex = 8;
            materialLabel10.Text = "Apparance Settings";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel9.HighEmphasis = true;
            materialLabel9.Location = new Point(871, 34);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(205, 29);
            materialLabel9.TabIndex = 7;
            materialLabel9.Text = "Serial Port Settings";
            // 
            // baudRateList
            // 
            baudRateList.AutoResize = false;
            baudRateList.BackColor = Color.FromArgb(255, 255, 255);
            baudRateList.Depth = 0;
            baudRateList.DrawMode = DrawMode.OwnerDrawVariable;
            baudRateList.DropDownHeight = 174;
            baudRateList.DropDownStyle = ComboBoxStyle.DropDownList;
            baudRateList.DropDownWidth = 121;
            baudRateList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            baudRateList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            baudRateList.FormattingEnabled = true;
            baudRateList.IntegralHeight = false;
            baudRateList.ItemHeight = 43;
            baudRateList.Items.AddRange(new object[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600 ", "115200", "128000", "256000" });
            baudRateList.Location = new Point(871, 183);
            baudRateList.MaxDropDownItems = 4;
            baudRateList.MouseState = MaterialSkin.MouseState.OUT;
            baudRateList.Name = "baudRateList";
            baudRateList.Size = new Size(121, 49);
            baudRateList.StartIndex = 0;
            baudRateList.TabIndex = 6;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.HighEmphasis = true;
            materialLabel2.Location = new Point(678, 208);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(106, 24);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "BAUDRATE:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(678, 141);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(107, 24);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "COM PORT:";
            // 
            // comPortsList
            // 
            comPortsList.AutoResize = false;
            comPortsList.BackColor = Color.FromArgb(255, 255, 255);
            comPortsList.Depth = 0;
            comPortsList.DrawMode = DrawMode.OwnerDrawVariable;
            comPortsList.DropDownHeight = 174;
            comPortsList.DropDownStyle = ComboBoxStyle.DropDownList;
            comPortsList.DropDownWidth = 121;
            comPortsList.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comPortsList.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comPortsList.FormattingEnabled = true;
            comPortsList.IntegralHeight = false;
            comPortsList.ItemHeight = 43;
            comPortsList.Location = new Point(871, 116);
            comPortsList.MaxDropDownItems = 4;
            comPortsList.MouseState = MaterialSkin.MouseState.OUT;
            comPortsList.Name = "comPortsList";
            comPortsList.Size = new Size(121, 49);
            comPortsList.StartIndex = 0;
            comPortsList.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "menu-60.png");
            imageList1.Images.SetKeyName(1, "knob3.png");
            imageList1.Images.SetKeyName(2, "settings.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 1149);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormStyle = FormStyles.ActionBar_64;
            Name = "Form1";
            Padding = new Padding(0, 88, 3, 3);
            Text = "Haptic Knob";
            Load += Form1_Load;
            Resize += Form1_Resize;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnStop;
        private MaterialSkin.Controls.MaterialButton btnStart;
        private KnobControl circleControl1;
        private MaterialSkin.Controls.MaterialLabel directionLabel;
        private MaterialSkin.Controls.MaterialLabel positionLabel;
        private MaterialSkin.Controls.MaterialLabel positionTextLabel;
        private MaterialSkin.Controls.MaterialLabel directionTextLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialComboBox ComPortList;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TabPage tabPage3;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox comPortsList;
        private MaterialSkin.Controls.MaterialComboBox baudRateList;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxPrimary1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxTheme;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxTextShade;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxAccent;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxPrimary2;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxPrimary3;
        private MaterialSkin.Controls.MaterialComboBox comboBoxIndicatorColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGradientEndColor;
        private MaterialSkin.Controls.MaterialComboBox comboBoxGradientStartColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabelLimits;
        private MaterialSkin.Controls.MaterialLabel materialLabelDetents;
        private MaterialSkin.Controls.MaterialLabel materialLabelMods;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxMods;
        private MaterialSkin.Controls.MaterialButton materialButtonSaveMods;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLimit1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLimit2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDetents;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialTextBox2 txtMessage;
        private MaterialSkin.Controls.MaterialButton btnSend;
        private RichTextBoxWithButton richTextBoxWithButton1;
        private RichTextBoxWithButton richTextBoxWithButton2;
    }
}
