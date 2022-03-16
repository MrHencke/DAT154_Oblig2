using CelestialsLib;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace View
{
    public partial class Form1 : Form
    {
        private SolarSystem _solarSystem;
        private int _xCenter;
        private int _yCenter;
        private CustomTimer _timer;

        public Form1()
        {
            this._solarSystem = new MilkyWay();
            this._timer = new CustomTimer();
            this.InitializeComponent();
            this._xCenter = ClientSize.Width / 2;
            this._yCenter = ClientSize.Height / 2;
            this.SetCenter();
            this.MouseClick += Form1_MouseClick;
            this.comboBox1.SelectedIndexChanged += Refresh;
            this.checkBox1.CheckedChanged += Refresh;
            this.checkBox2.CheckedChanged += Refresh;
            this.checkBox3.CheckedChanged += this._timer.ToggleTimer;
            this._timer.Refresh += Refresh;
            this.comboBox1.Items.Add("All");
            this.comboBox1.SelectedIndex = 0;
            this._solarSystem.objects.ForEach(o => this.comboBox1.Items.Add(o.Name));
            this._solarSystem.objects.ForEach(o => this._timer.UpdatePosition += o.UpdatePosition);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DrawSolarSystem(e.Graphics);
        }

        private void DrawSolarSystem(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            this.DrawBackground(g);
            this.SetCenter();
            var selected = this.comboBox1.SelectedItem;
            switch (selected)
            {
                case "All":
                    this.DrawAllObjects(g);
                    this.ClearInfoSection();
                    break;

                default:
                    CelestialObject obj = this._solarSystem.objects.Find(i => i.Name == selected.ToString());
                    this.DrawInfoSection(obj);
                    int scaling = 5;
                    g.TranslateTransform(this._xCenter - (scaling * obj.XPos), this._yCenter - (scaling * obj.YPos));
                    g.ScaleTransform(scaling, scaling);
                    this.DrawAllObjects(g);
                    break;
            }
        }

        public void DrawAllObjects(Graphics g)
        {
            this._solarSystem.objects.ForEach(i =>
            {
                i.DrawForms(g);
                if (this.checkBox1.Checked)
                {
                    i.DrawObjectName(g);
                }
                if (this.checkBox2.Checked)
                {
                    i.DrawObjectOrbit(g);
                }
            });
        }

        public void DrawInfoSection(CelestialObject obj)
        {
            this.ObjectName.Text = String.Format("Object Name: {0}", obj.Name);
            this.ObjectOrbits.Text = String.Format("Object Orbits: {0}", obj.Orbits.Name);
            this.ObjectRadius.Text = String.Format("Object Radius: {0} km", obj.UnscaledObjectRadius);
            this.OrbitalRadius.Text = String.Format("Orbital Radius: {0} km", obj.UnscaledOrbitalRadius);
            this.OrbitalPeriod.Text = String.Format("Orbital Period: {0} earth days", obj.OrbitalPeriod);
            this.RotationalPeriod.Text = String.Format("Rotational Period: {0} earth days", obj.RotationalPeriod);
            if (obj is Planet)
            {
            String moonString = String.Empty;
            Planet planet = (Planet)obj;
            if(planet.Moons.Count > 0) { 
                planet.Moons.ForEach(i => moonString += i.Name + "\n");
                this.ObjectMoons.Text = String.Format("Moons: {0}", moonString);
                }
            }
        }

        public void ClearInfoSection()
        {
            this.ObjectName.Text = String.Empty;
            this.ObjectOrbits.Text = String.Empty;
            this.ObjectRadius.Text = String.Empty;
            this.OrbitalRadius.Text = String.Empty;
            this.OrbitalPeriod.Text = String.Empty;
            this.RotationalPeriod.Text = String.Empty;
            this.ObjectMoons.Text = String.Empty;
        }

        private void Refresh(object sender, System.EventArgs e)
        {
            this.TickRate.Text = String.Format("{0} ms/tick", this._timer.GetIntervalTime());
            this.ElapsedTime.Text = String.Format("{0} earth days elapsed", this._timer.Time);
            this.Refresh();
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.Refresh();
                    break;

                case MouseButtons.Right:
                    this.comboBox1.SelectedIndex = 0;
                    break;
            }
        }
        private void SetCenter()
        {
            this._xCenter = ClientSize.Width / 2;
            this._yCenter = ClientSize.Height / 2;
            this._solarSystem.GravitationalCenter.SetPosition(this._xCenter, this._yCenter);
        }
        private void DrawBackground(Graphics g)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 65, 74, 76));
            g.FillRectangle(brush, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            brush.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            this.SetCenter();
            this.Refresh();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                this._timer.IncreaseInterval();
                return true;    
            }
            else if (keyData == Keys.Down)
            {
                this._timer.DecreaseInterval();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }        
}
