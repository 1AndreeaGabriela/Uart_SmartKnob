using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knob_form.Interfaces
{
    public interface IUIManager
    {
        /* Method to initialize the Material Skin theme and color scheme */
        MaterialSkinManager materialSkinManager { get; }
        public KnobControl circleControl { get; }
        void InitializeMaterialSkin();

        /* Method to initialize controls on the form */
        void InitializeControls();

        /* Method to update the knob's percentage filled */
        void UpdateKnob(int percent);

        /* Method to update the indicator's angle */
        void UpdateIndicator(float angle);

        /* Method to show the circle control */
        void ShowCircleControl();

        /* Method to hide the circle control */
        public void HideCircleControl();
        void UpdateColorScheme(Primary primary1, Primary primary2, Primary primary3, Accent accent, TextShade textShade);
        void UpdateKnobColors(Color gradientStart, Color gradientEnd, Color indicator);

        public void SaveSettings(ComboBox primary1, ComboBox primary2, ComboBox primary3, ComboBox accent,
                                 ComboBox textShade, ComboBox gradientStart, ComboBox gradientEnd, ComboBox indicator,
                                 ComboBox comPortsList, ComboBox baudRateList);
        public void LoadSettings(ComboBox primary1ComboBox, ComboBox primary2ComboBox, ComboBox primary3ComboBox,
                                 ComboBox accentComboBox, ComboBox textShadeComboBox, ComboBox gradientStartComboBox,
                                 ComboBox gradientEndComboBox, ComboBox indicatorComboBox, ComboBox comPortList,
                                 ComboBox baudRateList);
        public void AppendColoredText(RichTextBox richTextBox, string message, Color textColor);


    }
}

