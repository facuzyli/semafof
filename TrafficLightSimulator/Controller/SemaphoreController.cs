using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrafficLightSimulator.Model;
using Semaphore = TrafficLightSimulator.Model.Semaphore;

namespace TrafficLightSimulator.Controller
{
    public class SemaphoreController
    {
        public List<Semaphore> semaphores; // Lista de semáforos

        public SemaphoreController(List<Semaphore> semaphores) => this.semaphores = semaphores; // Inicializar la lista de semáforos

        public void Run()
        {
            foreach (var semaphore in semaphores)
            {
                Thread semaphoreThread = new Thread(() => ControlSemaphore(semaphore));
                semaphoreThread.Start(); // Iniciar un hilo para cada semáforo
            }
        }

        public void ControlSemaphore(Semaphore semaphore)
        {
            while (true) // Ciclo infinito para el funcionamiento continuo
            {
                semaphore.ChangeToGreen();
                Thread.Sleep(5000); // Verde durante 5 segundos

                semaphore.ChangeToYellow();
                Thread.Sleep(2000); // Amarillo durante 2 segundos

                semaphore.ChangeToRed();
                Thread.Sleep(5000); // Rojo durante 5 segundos
            }
        }
    }
}