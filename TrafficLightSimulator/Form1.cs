using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLightSimulator.Controller;
using TrafficLightSimulator.Model;

namespace TrafficLightSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializa el controlador de semáforos
            InitializeSemaphoreController();
        }

        // Método para inicializar el controlador de semáforos
        private void InitializeSemaphoreController()
        {
            var semaphores = new List<Semaphore>(); // Lista para almacenar los semáforos

            // Asegúrate de que los controles redLight1, yellowLight1, greenLight1, etc., estén definidos en Form1.Designer.cs
            semaphores.Add(new Semaphore(redLight1, yellowLight1, greenLight1));
            // Repite para los demás semáforos...

            semaphoreController = new SemaphoreController(semaphores); // Inicializar el controlador
            semaphoreController.Run(); // Comenzar a controlar los semáforos
        }

        private Panel CreateLight(Color color, Point location)
        {
            Panel light = new Panel();
            light.BackColor = color;
            light.Size = new Size(50, 50); // Tamaño de la luz del semáforo
            light.Location = location;
            return light;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
