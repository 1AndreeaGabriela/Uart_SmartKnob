using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knob_form
{
    public class HelperService
    {
        
        private Label materialLabelDetents;
        private Label materialLabelLimits;
        private MaterialTextBox materialTextBoxLimit1;
        private MaterialTextBox materialTextBoxLimit2;
        private MaterialTextBox materialTextBoxDetents;

        public HelperService(MaterialLabel labelDetents, MaterialLabel labelLimits, MaterialTextBox materialTextBoxLimit1, MaterialTextBox materialTextBoxLimit2, MaterialTextBox materialTextBoxDetents)
        {
            this.materialLabelDetents = labelDetents;
            this.materialLabelLimits = labelLimits;
            this.materialTextBoxLimit1 = materialTextBoxLimit1;
            this.materialTextBoxLimit2 = materialTextBoxLimit2;
            this.materialTextBoxDetents = materialTextBoxDetents;
        }

        /* Function to set controls state */
        public void SetControlState(bool labelsVisible, bool textBoxesVisible, bool textBoxesEnabled, string limit1Text = "", string limit2Text = "", string detentsText = "")
        {
            /* Set labels visibility*/
            materialLabelDetents.Visible = labelsVisible;
            materialLabelLimits.Visible = labelsVisible;

            /* Set textboxes visibility*/
            materialTextBoxLimit1.Visible = textBoxesVisible;
            materialTextBoxLimit2.Visible = textBoxesVisible;
            materialTextBoxDetents.Visible = textBoxesVisible;

            /* Set text and read and write permission for textboxes */
            materialTextBoxLimit1.Text = limit1Text;
            materialTextBoxLimit2.Text = limit2Text;
            materialTextBoxDetents.Text = detentsText;

            materialTextBoxLimit1.Enabled = textBoxesEnabled;
            materialTextBoxLimit2.Enabled = textBoxesEnabled;
            materialTextBoxDetents.Enabled = textBoxesEnabled;
        }

        /* Funtion for calculating the angle complement */
        public int CalculateComplement(int angle)
        {
            if (angle < 0 || angle > 360)
            {
                throw new ArgumentOutOfRangeException("Angle must be between 0 and 360 degrees.");
            }

            int complement = 360 - angle;

            if (complement == 360)
            {
                complement = 0;
            }

            return complement;
        }

        public string ConvertToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", " ");
        }

    }


}
