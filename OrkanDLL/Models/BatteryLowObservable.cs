using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL.Models
{
    public class BatteryLowObservable : IObservable<int>
    {
        private readonly Dron dron;

        public BatteryLowObservable(Dron dron)
        {
            this.dron = dron;
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            var batteryObservable = Observable.FromEventPattern<EventHandler<int>, int>(
                h => dron.BatteryStatusChanged += h,
                h => dron.BatteryStatusChanged -= h)
                .Select(x => x.EventArgs);

            return batteryObservable
                .Where(batteryStatus => batteryStatus < 20)
                .Subscribe(observer);
        }
    }
}
