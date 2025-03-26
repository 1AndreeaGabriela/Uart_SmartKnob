using Knob_form;
using MaterialSkin;
using MaterialSkin.Controls;
using Knob_form.Properties;
using Microsoft.Azure.Amqp.Framing;
using Knob_form.Interfaces;

public class UIManager : IUIManager
{
    private MaterialForm form;
    public KnobControl circleControl { get; private set; }
    public MaterialSkinManager materialSkinManager { get; private set; }
   
    private Label materialLabelDetents;
    private Label materialLabelLimits;
    private MaterialTextBox materialTextBoxLimit1;
    private MaterialTextBox materialTextBoxLimit2;
    private MaterialTextBox materialTextBoxDetents;

    public UIManager(MaterialForm form)
    {
        this.form = form;
        InitializeControls();
    }
    public UIManager(MaterialLabel labelDetents, MaterialLabel labelLimits, MaterialTextBox materialTextBoxLimit1, MaterialTextBox materialTextBoxLimit2, MaterialTextBox materialTextBoxDetents)
    {
        this.materialLabelDetents = labelDetents;
        this.materialLabelLimits = labelLimits;
        this.materialTextBoxLimit1 = materialTextBoxLimit1;
        this.materialTextBoxLimit2 = materialTextBoxLimit2;
        this.materialTextBoxDetents = materialTextBoxDetents;
    }
    /* Initialize form design*/
    public void InitializeMaterialSkin()
    {
        materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(form);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey600, Primary.Grey800, Primary.BlueGrey500, Accent.Pink100, TextShade.WHITE);
    }

    /* Draw animation at certain location on form */
    public void InitializeControls()
    {
        circleControl = new KnobControl
        {
            Size = new Size(350, 350),
            Location = new Point(810, 120)
        };
        form.Controls.Add(circleControl);
        circleControl.BringToFront();

    }

    /* Update animation for the knob */ 
    //TODO: MOVE THIS FUNTION 
    public void UpdateKnob(int percent)
    {
        circleControl.PercentFilled = percent;
    }

    /* Update animation for indicator */
    //TODO: MOVE THIS FUNTION 
    public void UpdateIndicator(float angle)
    {
        circleControl.IndicatorAngle = angle;
    }

    /* Method to show the circle control */
    public void ShowCircleControl()
    {
        circleControl.Visible = true;
    }

    /* Method to hide the circle control */
    public void HideCircleControl()
    {
        circleControl.Visible = false;
    }

    public void UpdateColorScheme(Primary primary1, Primary primary2, Primary primary3, Accent accent, TextShade textShade)
    {
        materialSkinManager.ColorScheme = new ColorScheme(primary1, primary2, primary3, accent, textShade);
    }
    public void UpdateKnobColors(Color gradientStart, Color gradientEnd, Color indicator)
    {
        circleControl.GradientStartColor = gradientStart;
        circleControl.GradientEndColor = gradientEnd;
        circleControl.IndicatorColor = indicator;
        circleControl.Invalidate(); // Re-desenare pentru a reflecta schimbările
    }

    public void SaveSettings(ComboBox primary1, ComboBox primary2, ComboBox primary3, ComboBox accent, ComboBox textShade, ComboBox gradientStart, ComboBox gradientEnd, ComboBox indicator, ComboBox comPortsList, ComboBox baudRateList)
    {
        /* Save selected theme */
        Settings.Default.Theme = materialSkinManager.Theme.ToString();

        /* Save selected color scheme */
        Settings.Default.Primary1Color = primary1.SelectedItem.ToString();
        Settings.Default.Primary2Color = primary2.SelectedItem.ToString();
        Settings.Default.Primary3Color = primary3.SelectedItem.ToString();
        Settings.Default.AccentColor = accent.SelectedItem.ToString();
        Settings.Default.TextShade = textShade.SelectedItem.ToString();

        /* Save animation colors */
        Settings.Default.gradientStart = gradientStart.SelectedItem.ToString();
        Settings.Default.gradientEnd = gradientEnd.SelectedItem.ToString();
        Settings.Default.indicator = indicator.SelectedItem.ToString();

        /* Save COM port settings */
        Settings.Default.LastComPort = comPortsList.SelectedItem.ToString();
        Settings.Default.LastBaudRate = int.Parse(baudRateList.SelectedItem.ToString());

        /* Save all */
        Settings.Default.Save();
    }

    public void LoadSettings(ComboBox primary1ComboBox, ComboBox primary2ComboBox, ComboBox primary3ComboBox, ComboBox accentComboBox, ComboBox textShadeComboBox, ComboBox gradientStartComboBox, ComboBox gradientEndComboBox, ComboBox indicatorComboBox, ComboBox comPortsList, ComboBox baudRateList)
    {
        /* Load Theme */
        if (Enum.TryParse(Settings.Default.Theme, out MaterialSkinManager.Themes theme))
        {
            materialSkinManager.Theme = theme;
        }

        /* Load form color scheme */
        primary1ComboBox.SelectedItem = Settings.Default.Primary1Color;
        primary2ComboBox.SelectedItem = Settings.Default.Primary2Color;
        primary3ComboBox.SelectedItem = Settings.Default.Primary3Color;
        accentComboBox.SelectedItem = Settings.Default.AccentColor;
        textShadeComboBox.SelectedItem = Settings.Default.TextShade;

        /* Load animation color scheme */
        gradientStartComboBox.SelectedItem = Settings.Default.gradientStart;
        gradientEndComboBox.SelectedItem = Settings.Default.gradientEnd;
        indicatorComboBox.SelectedItem = Settings.Default.indicator;

        comPortsList.SelectedItem = Settings.Default.LastComPort;
        baudRateList.SelectedItem = Settings.Default.LastBaudRate.ToString();

        /* Apply color scheme */
        var primary1 = (Primary)Enum.Parse(typeof(Primary), primary1ComboBox.SelectedItem.ToString());
        var primary2 = (Primary)Enum.Parse(typeof(Primary), primary2ComboBox.SelectedItem.ToString());
        var primary3 = (Primary)Enum.Parse(typeof(Primary), primary3ComboBox.SelectedItem.ToString());
        var accent = (Accent)Enum.Parse(typeof(Accent), accentComboBox.SelectedItem.ToString());
        var textShade = (TextShade)Enum.Parse(typeof(TextShade), textShadeComboBox.SelectedItem.ToString());

        UpdateColorScheme(primary1, primary2, primary3, accent, textShade);
    }



    /*
     * Appends a message to the RichTextBox with the specified text color, 
     * then resets the color back to the default
     */
    public void AppendColoredText(RichTextBox richTextBox, string message, Color textColor)
    {
        // Poziționează cursorul la finalul textului existent
        richTextBox.SelectionStart = richTextBox.TextLength;
        richTextBox.SelectionLength = 0; // Nicio selecție
                                         // Setează culoarea textului
        richTextBox.SelectionColor = textColor;


        richTextBox.AppendText(message + "\n");

        // Resetează culoarea înapoi la culoarea implicită (dacă este necesar)
        richTextBox.SelectionColor = richTextBox.ForeColor;
    }
}

