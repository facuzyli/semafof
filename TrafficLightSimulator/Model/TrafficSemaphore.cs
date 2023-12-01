using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightSimulator.Model
{
    public class TrafficSemaphore
    {
        public Panel redLight;
        public Panel yellowLight;
        public Panel greenLight;

        public TrafficSemaphore(Panel red, Panel yellow, Panel green)
        {
            redLight = red;
            yellowLight = yellow;
            greenLight = green;
        }

        public void ChangeToRed()
        {
            UpdateLight(redLight, Color.Red);
            UpdateLight(yellowLight, Color.Gray);
            UpdateLight(greenLight, Color.Gray);
        }

        public void ChangeToYellow()
        {
            UpdateLight(redLight, Color.Gray);
            UpdateLight(yellowLight, Color.Yellow);
            UpdateLight(greenLight, Color.Gray);
        }

        public void ChangeToGreen()
        {
            UpdateLight(redLight, Color.Gray);
            UpdateLight(yellowLight, Color.Gray);
            UpdateLight(greenLight, Color.Green);
        }

        private void UpdateLight(Panel light, Color color)
        {
            if (light.InvokeRequired)
            {
                light.Invoke(new MethodInvoker(() => light.BackColor = color));
            }
            else
            {
                light.BackColor = color;
            }
        }
    }
}