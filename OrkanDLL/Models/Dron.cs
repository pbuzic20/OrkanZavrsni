using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkanDLL.Models
{
    public class Dron
    {

        public int Id { get; set; }
        private int _batteryStatus;
        public int BatteryStatus
        {
            get { return _batteryStatus; }
            set
            {
                _batteryStatus = value;
                BatteryStatusChanged?.Invoke(this, value);
            }
        }

        public event EventHandler<int> BatteryStatusChanged;

        private Point _location;

        public Point Location
        {
            get { return _location; }
            set
            {
                _location = value;
                LocationChanged?.Invoke(this, value);
            }
        }

        public event EventHandler<Point> LocationChanged;

        private double _totalDistance = 0;

        public double TotalDistance
        {
            get { return _totalDistance; }
            private set { _totalDistance = value; }
        }
    }
}
