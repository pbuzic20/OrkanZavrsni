using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL.Models
{
    public class FormationObservable : IObservable<Point>
    {
        private readonly Dron dron;

        public FormationObservable(Dron dron)
        {
            this.dron = dron;
        }

        public IDisposable Subscribe(IObserver<Point> observer)
        {
            var locationObservable = Observable.FromEventPattern<Point>(
                h => dron.LocationChanged += h,
                h => dron.LocationChanged -= h)
                .Select(x => x.EventArgs);

            return locationObservable.Subscribe(observer);
        }
    }
}
