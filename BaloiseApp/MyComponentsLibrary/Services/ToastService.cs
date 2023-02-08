using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyComponentsLibrary.Services
{
    public class ToastService:IDisposable
    {
        public event Action<string, ToastLevel>? OnShow;
        public event Action? OnHide;
        private System.Timers.Timer? timer;

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
            startTimer();
        }

        public void HideToast()
        {
            OnHide?.Invoke();
        }

        private void startTimer()
        {
            if(timer == null)
            {
                timer = new System.Timers.Timer(5000);
                timer.Elapsed += HideToast;
                timer.AutoReset = false;
            }
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Start();
            }
            else
            {
                timer.Start();
            }

        }

        public void HideToast(object? source, ElapsedEventArgs args) => OnHide?.Invoke();

        public void Dispose() => timer?.Dispose();
    }
}
