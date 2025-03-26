using Knob_form.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO.Ports;
using System.Net.Sockets;
using static Knob_form.KnobControl;


namespace Knob_form
{
    public partial class Form1 : MaterialForm
    {
        private IUIManager _uiManager;
        private KnobObject _knob;
        private ITimersManager _timersManager;
        private ISerialCom _serialCom;
        private HelperService _helperService;


        /* Step size for the gradient animation : (0-100)*/
        private int knobStepSize;
        /* Number of steps for smooth animation*/
        private int knobStepDivisor = 50;
        /* Indicator start position */
        private int startTop = 270;
        /* Set  default size */
        private readonly Size defaultSize = new Size(1200, 800);

        private float indicatorCurrentAngle = 270;
        private float indicatorTargetAngle = 270;
        private float indicatorStepSize = 1;

        private int currentPercent = 0;
        private int targetPercent = 0;

        private float angleDifference;

        public Form1()
        {
            InitializeComponent();
            InitPort_BaudRate();
            PopulateComboBoxes();
            AttachEventHandlers();


            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            string selectedComPort = comPortsList.SelectedItem.ToString();
            int selectedBaudRate = int.Parse(baudRateList.SelectedItem.ToString());

            _uiManager = new UIManager(this);
            _uiManager.InitializeMaterialSkin();
         
            _timersManager = new TimersManager(KnobTimer_Tick, IndicatorTimer_Tick);

            _helperService = new HelperService(materialLabelDetents, materialLabelLimits, materialTextBoxLimit1, materialTextBoxLimit2, materialTextBoxDetents);
            _serialCom = new SerialCom(selectedComPort, selectedBaudRate, ReadData);
            //_serialCom = new SerialCom("COM6", 19200, ReadData);
            //_serialCom = new MockSerialCom(2000, ReadData); // 2000 ms = 2 seconds interval 

        }

        public void InitPort_BaudRate()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comPortsList.Items.Add(s);
            }

            if (comPortsList.Items.Count > 0)
            {
                comPortsList.SelectedIndex = 0;
            }

        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = defaultSize;

            /* Start timers*/
            _timersManager.StartTimers();

            /* Hide "LIMITS" and "DETENTS" section */
            _helperService.SetControlState(labelsVisible: false, textBoxesVisible: false, textBoxesEnabled: false);
            LoadUserSettings();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Size = defaultSize; 
            }

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _uiManager.SaveSettings(
            materialComboBoxPrimary1,
            materialComboBoxPrimary2,
            materialComboBoxPrimary3,
            materialComboBoxAccent,
            materialComboBoxTextShade,
            comboBoxGradientStartColor,
            comboBoxGradientEndColor,
            comboBoxIndicatorColor,
            comPortsList,
            baudRateList
            );
        }

        private void LoadUserSettings()
        {
            _uiManager.LoadSettings(
           materialComboBoxPrimary1,
           materialComboBoxPrimary2,
           materialComboBoxPrimary3,
           materialComboBoxAccent,
           materialComboBoxTextShade,
           comboBoxGradientStartColor,
           comboBoxGradientEndColor,
           comboBoxIndicatorColor,
           comPortsList,
           baudRateList
       );
        }
        private void PopulateComboBoxes()
        {
            /*Populate form color scheme fields*/
            materialComboBoxPrimary1.Items.AddRange(Enum.GetNames(typeof(Primary)));
            materialComboBoxPrimary2.Items.AddRange(Enum.GetNames(typeof(Primary)));
            materialComboBoxPrimary3.Items.AddRange(Enum.GetNames(typeof(Primary)));
            materialComboBoxAccent.Items.AddRange(Enum.GetNames(typeof(Accent)));
            materialComboBoxTextShade.Items.AddRange(Enum.GetNames(typeof(TextShade)));

            /*Populate animation color scheme fields*/
            comboBoxGradientStartColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            comboBoxGradientEndColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));
            comboBoxIndicatorColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));

            /*Set default form color scheme fields*/
            materialComboBoxPrimary1.SelectedItem = Primary.Grey600.ToString();
            materialComboBoxPrimary2.SelectedItem = Primary.Grey800.ToString();
            materialComboBoxPrimary3.SelectedItem = Primary.BlueGrey500.ToString();
            materialComboBoxAccent.SelectedItem = Accent.Pink100.ToString();
            materialComboBoxTextShade.SelectedItem = TextShade.WHITE.ToString();
        }
        private void AttachEventHandlers()
        {
            /* Handlers for idex selection */
            materialComboBoxPrimary1.SelectedIndexChanged += ComboBoxColorScheme_SelectedIndexChanged;
            materialComboBoxPrimary2.SelectedIndexChanged += ComboBoxColorScheme_SelectedIndexChanged;
            materialComboBoxPrimary3.SelectedIndexChanged += ComboBoxColorScheme_SelectedIndexChanged;
            materialComboBoxAccent.SelectedIndexChanged += ComboBoxColorScheme_SelectedIndexChanged;
            materialComboBoxTextShade.SelectedIndexChanged += ComboBoxColorScheme_SelectedIndexChanged;

            comboBoxGradientStartColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;
            comboBoxGradientEndColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;
            comboBoxIndicatorColor.SelectedIndexChanged += ComboBoxKnobColor_SelectedIndexChanged;

            comPortsList.SelectedIndexChanged += ComboBoxSelectionChanged;
            baudRateList.SelectedIndexChanged += ComboBoxSelectionChanged;

            materialTextBoxLimit1.TextChanged += materialTextBoxLimit1_TextChanged;
           
            materialTextBoxLimit1.TextChanged += TextBoxLimit_TextChanged;
            materialTextBoxLimit2.TextChanged += TextBoxLimit_TextChanged;
        }

        private void TextBoxLimit_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(materialTextBoxLimit1.Text, out int limit1) && int.TryParse(materialTextBoxLimit2.Text, out int limit2))
            {
                if (limit1 >= 0 && limit1 <= 360 && limit2 >= 0 && limit2 <= 360)
                {
                    _uiManager.circleControl.Limit1Angle = limit1;
                    _uiManager.circleControl.Limit2Angle = limit2;
                    _uiManager.circleControl.Invalidate();  
                }
                else
                {
                    MessageBox.Show("Please enter a valid angle between 0 and 360.");
                }
            }
            else
            {
                //MessageBox.Show("Please enter valid numbers for both limits.");
            }
        }
        private void ComboBoxSelectionChanged(object sender, EventArgs e)
        {

            if (comPortsList.SelectedItem != null && baudRateList.SelectedItem != null)
            {
                string selectedComPort = comPortsList.SelectedItem.ToString();
                int selectedBaudRate = int.Parse(baudRateList.SelectedItem.ToString());


                _serialCom?.Close();
                _serialCom = new SerialCom(selectedComPort, selectedBaudRate, ReadData);

                try
                {
                    _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], $"Serial port: {selectedComPort}, Baudrate {selectedBaudRate}.", Color.DarkOliveGreen);
                    _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], $"Serial port: {selectedComPort}, Baudrate {selectedBaudRate}.", Color.DarkOliveGreen);
                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show($"Error opening serial port: {ex.Message}");
                }
            }
        }

        private void ComboBoxColorScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            var primary1 = (Primary)Enum.Parse(typeof(Primary), materialComboBoxPrimary1.SelectedItem.ToString());
            var primary2 = (Primary)Enum.Parse(typeof(Primary), materialComboBoxPrimary2.SelectedItem.ToString());
            var primary3 = (Primary)Enum.Parse(typeof(Primary), materialComboBoxPrimary3.SelectedItem.ToString());
            var accent = (Accent)Enum.Parse(typeof(Accent), materialComboBoxAccent.SelectedItem.ToString());
            var textShade = (TextShade)Enum.Parse(typeof(TextShade), materialComboBoxTextShade.SelectedItem.ToString());

            _uiManager.UpdateColorScheme(primary1, primary2, primary3, accent, textShade);

            this.Invalidate();
        }
        private void ComboBoxKnobColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGradientStartColor.SelectedItem != null &&
                comboBoxGradientEndColor.SelectedItem != null &&
                comboBoxIndicatorColor.SelectedItem != null)
            {
                var gradientStart = Color.FromName(comboBoxGradientStartColor.SelectedItem.ToString());
                var gradientEnd = Color.FromName(comboBoxGradientEndColor.SelectedItem.ToString());
                var indicator = Color.FromName(comboBoxIndicatorColor.SelectedItem.ToString());

                _uiManager.UpdateKnobColors(gradientStart, gradientEnd, indicator);
            }
        }

        private void MaterialComboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Update theme based on selection */
            if (materialComboBoxTheme.SelectedItem.ToString() == "DARK")
            {
                _uiManager.materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else if (materialComboBoxTheme.SelectedItem.ToString() == "LIGHT")
            {
                _uiManager.materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            this.Invalidate();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialTabControl1.SelectedIndex)
            {
                case 0:
                    {
                        _uiManager.ShowCircleControl();
                        break;
                    }
                case 1:
                    {
                        _uiManager.HideCircleControl();
                        break;
                    }
                case 2:
                    {
                        _uiManager.HideCircleControl();
                        break;
                    }
            }
        }

        private void materialComboBoxMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBoxMods.SelectedItem.ToString())
            {
                case "Endless":
                    _helperService.SetControlState(labelsVisible: false, textBoxesVisible: false, textBoxesEnabled: false);
                    _uiManager.circleControl.SetMode(Mode.Endless);
                    break;

                case "ON/OFF":
                    _helperService.SetControlState(labelsVisible: true, textBoxesVisible: true, textBoxesEnabled: false, limit1Text: "1", limit2Text: "359", detentsText: "1");
                    _uiManager.circleControl.SetMode(Mode.OnOff);
                    break;

                case "Two limits":
                    _helperService.SetControlState(labelsVisible: true, textBoxesVisible: true, textBoxesEnabled: true);
                    _uiManager.circleControl.SetMode(Mode.TwoLimits);
                    break;

                case "Return to center":
                    _helperService.SetControlState(labelsVisible: true, textBoxesVisible: true, textBoxesEnabled: true);
                    _uiManager.circleControl.SetMode(Mode.ReturnToCenter);
                    break;
            }

            Invalidate();
        }

        private void materialTextBoxLimit1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(materialTextBoxLimit1.Text, out int value))
            {
                if (value > 0 && value < 360)
                {
                    int complement = _helperService.CalculateComplement(value);

                    materialTextBoxLimit2.Text = complement.ToString();
                }
                else
                {
                    MaterialMessageBox.Show("Please enter a value between 0 and 360.");
                }
            }
            else if (!string.IsNullOrEmpty(materialTextBoxLimit1.Text))
            {
                MaterialMessageBox.Show("Please enter a valid number.");
            }
        }

        public void KnobTimer_Tick(object sender, EventArgs e)
        {
            if (currentPercent != targetPercent)
            {
                if (currentPercent < targetPercent)
                {
                    currentPercent += knobStepSize;
                    if (currentPercent > targetPercent)
                    {
                        currentPercent = targetPercent;
                    }
                }
                else
                {
                    currentPercent -= knobStepSize;
                    if (currentPercent < targetPercent)
                    {
                        currentPercent = targetPercent;
                    }
                }

                try
                {
                    _uiManager.UpdateKnob(currentPercent);
                }
                catch
                {
                    //MaterialMessageBox.Show("Position should be smaller than 360 degrees.");
                    _timersManager.StopAnimationTimer();
                }
            }
        }

        public void IndicatorTimer_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(indicatorCurrentAngle - indicatorTargetAngle) > indicatorStepSize)
            {
                angleDifference = indicatorTargetAngle - indicatorCurrentAngle;

                if (_knob.Direction == 0) // Invers sensului acelor de ceasornic
                {
                    if (angleDifference < 0)
                        angleDifference += 360;
                }
                else if (_knob.Direction == 1) // În sensul acelor de ceasornic
                {
                    if (angleDifference > 0)
                        angleDifference -= 360;
                }

                indicatorCurrentAngle += Math.Sign(angleDifference) * indicatorStepSize;
                indicatorCurrentAngle = (indicatorCurrentAngle + 360) % 360;
                Invalidate();
            }
            else
            {
                indicatorCurrentAngle = indicatorTargetAngle;
                Invalidate();
            }

            try
            {
                _uiManager.UpdateIndicator(indicatorCurrentAngle);
            }
            catch
            {
                MaterialMessageBox.Show("Error to be treated");
                _timersManager.StopSmallCircleTimer();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                _serialCom.Open();
               
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], "->Serial port open.", Color.GreenYellow);
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], "->Serial port open.", Color.GreenYellow);

            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error opening serial port: {ex.Message}");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                _serialCom?.Close();
                
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], "⚠ Serial port closed.", Color.OrangeRed);
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], "⚠ Serial port closed.", Color.OrangeRed);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error closing serial port: {ex.Message}");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serialCom.IsOpen())
                {
                    string message = txtMessage.Text;

                    await _serialCom.SendAsync(message);

                    _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], $"Sent: {message}", Color.DeepPink);
                    _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], $"Sent: {message}", Color.DeepPink);
                    
                }
                else
                {
                    MaterialMessageBox.Show("Serial port is not open.");
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error sending message: {ex.Message}");
            }
        }

        private void ReadData(string receivedData)
        {
            try
            {
                _knob = new KnobObject(receivedData);

                /* Used to fill the knob animation */
                int fillValue = (_knob.Position[0] << 8) | (_knob.Position[1]);
                fillValue = fillValue * 100 / 360;

                /* Used for indicator animation*/
                int positionValue = (_knob.Position[0] << 8) | _knob.Position[1];
                int directionValue = _knob.Direction;

                this.Invoke(new Action(() =>
                {
                    /* Start timers for animation */
                    _timersManager.StartTimers();

                    targetPercent = fillValue;
                    knobStepSize = Math.Max(1, (targetPercent - currentPercent) / knobStepDivisor);

                    /* Calculate and update the target angle for the indicator */
                    float newAngle = (positionValue % 360 + startTop) % 360;
                    indicatorTargetAngle = newAngle;
                    indicatorStepSize = Math.Max(1, Math.Abs(indicatorTargetAngle - indicatorCurrentAngle) / 10);

                    /* Display direction value : 
                     * 00 - clockwise 
                     * 01 - counter clockwise
                     */
                    if (directionValue == 0)
                    {
                        directionTextLabel.Text = "clockwise"; // left
                    }
                    else if (directionValue == 1)
                    {
                        directionTextLabel.Text = "counterclockwise"; // right
                    }
                    /* Display position */
                    positionTextLabel.Text = positionValue.ToString() + " ° ";

                }));
            }
            catch
            {
                this.Invoke(new Action(() =>
                {
                    //MaterialMessageBox.Show($"Message format is incorrect: {receivedData}");

                }));
            }

            this.Invoke(new Action(() =>
            {
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], $"Received: {receivedData}", Color.LightBlue);
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], $"Received: {receivedData}", Color.LightBlue);

            }));
        }

        private async void materialButtonSaveMods_Click(object sender, EventArgs e)
        {
            /* Format the message to be sent via serial */

            byte modeCode = 0;
            bool sendFullMessage = true;
            switch (materialComboBoxMods.SelectedItem.ToString())
            {
                case "Endless":
                    modeCode = 0xA0;
                    sendFullMessage = false;
                    break;
                case "ON/OFF":
                    modeCode = 0xA1;
                    break;
                case "Two limits":
                    modeCode = 0xA2;
                    break;
                case "Return to center":
                    modeCode = 0xA3;
                    break;
            }
            byte[] uartMessage;

            if (sendFullMessage)
            {
                ushort limit1 = ushort.Parse(materialTextBoxLimit1.Text); // 2 byte (ushort)
                ushort limit2 = ushort.Parse(materialTextBoxLimit2.Text); // 2 byte (ushort)
                ushort detents = ushort.Parse(materialTextBoxDetents.Text); // 2 byte (ushort)

                uartMessage = new byte[7];


                uartMessage[0] = modeCode;

                uartMessage[1] = (byte)(limit1 >> 8);
                uartMessage[2] = (byte)(limit1 & 0xFF);

                uartMessage[3] = (byte)(limit2 >> 8);
                uartMessage[4] = (byte)(limit2 & 0xFF);

                uartMessage[5] = (byte)(detents >> 8);
                uartMessage[6] = (byte)(detents & 0xFF);
            }
            else
            {
                uartMessage = new byte[1];
                uartMessage[0] = modeCode;
            }

            
            
                string uartMessageHex = _helperService.ConvertToHexString(uartMessage);
                await _serialCom.SendAsync(uartMessageHex);
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton1.Controls["richTextBox1"], $"Sent: {uartMessageHex}", Color.DeepPink);
                _uiManager.AppendColoredText((RichTextBox)richTextBoxWithButton2.Controls["richTextBox1"], $"Sent: {uartMessageHex}", Color.DeepPink);

            
           
        }
    }
}
