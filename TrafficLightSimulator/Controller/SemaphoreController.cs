using System.Collections.Generic;
using System.Threading;
using TrafficLightSimulator.Model;

namespace TrafficLightSimulator.Controller
{
    public class SemaphoreController
    {
        private List<TrafficSemaphore> semaphores;

        public SemaphoreController(List<TrafficSemaphore> semaphores)
        {
            this.semaphores = semaphores;
        }

        public void Run()
        {
            foreach (var semaphore in semaphores)
            {
                Thread semaphoreThread = new Thread(() => ControlSemaphore(semaphore));
                semaphoreThread.Start();
            }
        }

        private void ControlSemaphore(TrafficSemaphore semaphore)
        {
            while (true)
            {
                semaphore.ChangeToGreen();
                Thread.Sleep(5000);

                semaphore.ChangeToYellow();
                Thread.Sleep(2000);

                semaphore.ChangeToRed();
                Thread.Sleep(5000);
            }
        }
    }
}