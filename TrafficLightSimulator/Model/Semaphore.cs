using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightSimulator.Model
{
    public class Semaphore
    {
        // Paneles que representan las luces del semáforo
        public Panel redLight;
        public Panel yellowLight;
        public Panel greenLight;

        // Constructor que inicializa los paneles de las luces del semáforo
        public Semaphore(Panel red, Panel yellow, Panel green)
        {
            redLight = red;
            yellowLight = yellow;
            greenLight = green;
        }

        // Método para cambiar a luz roja
        public void ChangeToRed()
        {
            UpdateLight(redLight, Color.Red);
            UpdateLight(yellowLight, Color.Gray);
            UpdateLight(greenLight, Color.Gray);
        }

        // Método para cambiar a luz amarilla
        public void ChangeToYellow()
        {
            UpdateLight(redLight, Color.Gray);
            UpdateLight(yellowLight, Color.Yellow);
            UpdateLight(greenLight, Color.Gray);
        }

        // Método para cambiar a luz verde
        public void ChangeToGreen()
        {
            UpdateLight(redLight, Color.Gray);
            UpdateLight(yellowLight, Color.Gray);
            UpdateLight(greenLight, Color.Green);
        }

        // Método privado para actualizar el color de una luz específica
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
