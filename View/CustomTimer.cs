using Timer = System.Windows.Forms.Timer;

namespace View
{
    public delegate void UpdatePosition(int time);
    public delegate void Refresh(object sender, EventArgs e);
    public class CustomTimer
    {
        private readonly Timer _timer = new Timer();
        public int Time { private set; get; }
        public event UpdatePosition UpdatePosition;
        public event Refresh Refresh;


        public CustomTimer()
        {
            Time = 0;
            _timer.Interval = 11;
            _timer.Tick += Tick;
            _timer.Start();
        }

        public void Tick(object sender, EventArgs e)
        {
            Time++;
            UpdatePosition(Time);
            Refresh(this, EventArgs.Empty);
        }

        public void IncreaseInterval()
        {
            this._timer.Stop();
            this._timer.Interval += 10;
            this._timer.Start();
        }
        public void DecreaseInterval()
        {
            if (this._timer.Interval - 10 > 0)
            {
                this._timer.Stop();
                this._timer.Interval -= 10;
                this._timer.Start();
            }
        }

        public int GetIntervalTime()
        {
            return this._timer.Interval;
        }
        
        public void ToggleTimer(object sender, EventArgs e)
        {
            this._timer.Enabled = !this._timer.Enabled;
        }
    }

}
