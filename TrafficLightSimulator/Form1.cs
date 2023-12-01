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
        private SemaphoreController semaphoreController;

        public Form1()
        {
            InitializeComponent();
            InitializeSemaphoreController();
        }

        private void InitializeSemaphoreController()
        {
            var semaphores = new List<TrafficSemaphore>();

            // Crear y agregar semáforos a la lista
            // Asegúrate de que los nombres de los paneles coincidan con los de Form1.Designer.cs
            semaphores.Add(new TrafficSemaphore(redLight, yellowLight, greenLight));
            semaphores.Add(new TrafficSemaphore(panel3, panel2, panel4));
            semaphores.Add(new TrafficSemaphore(panel7, panel6, panel8));
            // Continúa agregando los semáforos restantes aquí...

            semaphoreController = new SemaphoreController(semaphores);
            semaphoreController.Run();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
