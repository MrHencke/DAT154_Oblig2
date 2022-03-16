using CelestialsLib;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly Timer t = new();
        private int time;

        public Form1()
        {
            this.solarSystem = new DebugWay();
            InitializeComponent();
            this.center = Tuple.Create(ClientSize.Width / 2, ClientSize.Height / 2);
            setCenter();
            this.MouseClick += Form1_MouseClick;
            this.comboBox1.SelectedIndexChanged += refresh;
            this.checkBox1.CheckedChanged += refresh;
            this.checkBox2.CheckedChanged += refresh;
            this.checkBox3.CheckedChanged += refresh;
            this.comboBox1.Items.Add("All");
            this.comboBox1.SelectedIndex = 0;
            this.solarSystem.objects.ForEach(o => this.comboBox1.Items.Add(o.Name));
            t.Interval = 11;
            this.TickRate.Text = String.Format("{0} ms/tick",t.Interval);
            t.Tick += T_Tick;
            time = 0;
            t.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawSolarSystem(e.Graphics);
        }

        private void DrawSolarSystem(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawBackground(g);
            setCenter();
            var selected = this.comboBox1.SelectedItem;
            switch (selected)
            {
                case "All":
                    DrawAllObjects(g);
                    ClearInfoSection();
                    break;

                default:
                    CelestialObject obj = this.solarSystem.objects.Find(i => i.Name == selected.ToString());
                    DrawInfoSection(obj);
                    int scaling = 5;
                    g.TranslateTransform(center.Item1 - (scaling * obj.XPos), center.Item2 - (scaling * obj.YPos));
                    g.ScaleTransform(scaling, scaling);
                    DrawAllObjects(g);
                    break;
            }
        }

        public void DrawAllObjects(Graphics g)
        {
            this.solarSystem.objects.ForEach(i =>
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
            ObjectName.Text = String.Format("Object Name: {0}", obj.Name);
            ObjectOrbits.Text = String.Format("Object Orbits: {0}", obj.Orbits.Name);
            ObjectRadius.Text = String.Format("Object Radius: {0} km", obj.UnscaledObjectRadius);
            OrbitalRadius.Text = String.Format("Orbital Radius: {0} km", obj.UnscaledOrbitalRadius);
            OrbitalPeriod.Text = String.Format("Orbital Period: {0} earth days", obj.OrbitalPeriod);
            RotationalPeriod.Text = String.Format("Rotational Period: {0} earth days", obj.RotationalPeriod);
            if (obj is Planet)
            {
            String moonString = String.Empty;
            Planet planet = (Planet)obj;
            if(planet.Moons.Count > 0) { 
            planet.Moons.ForEach(i => moonString += i.Name + "\n");
            ObjectMoons.Text = String.Format("Moons: {0}", moonString);
                }
            }
        }

        public void ClearInfoSection()
        {
            ObjectName.Text = String.Empty;
            ObjectOrbits.Text = String.Empty;
            ObjectRadius.Text = String.Empty;
            OrbitalRadius.Text = String.Empty;
            OrbitalPeriod.Text = String.Empty;
            RotationalPeriod.Text = String.Empty;
            ObjectMoons.Text = String.Empty;
        }

        private void refresh(object sender, System.EventArgs e)
        {
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
        private void setCenter()
        {
            Tuple<int, int> center = Tuple.Create(ClientSize.Width / 2, ClientSize.Height / 2);
            this.center = center;
            this.solarSystem.GravitationalCenter.SetPosition(this.center);
        }
        private void DrawBackground(Graphics g)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 65, 74, 76));
            g.FillRectangle(brush, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            brush.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            setCenter();
            this.Refresh();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.time++;
                this.ElapsedTime.Text = String.Format("{0} earth days elapsed", time);
                this.solarSystem.objects.ForEach(o => o.UpdatePosition(time));
                this.Refresh();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                t.Stop();
                t.Interval = t.Interval + 10;
                t.Start();
                this.TickRate.Text = String.Format("{0} ms/tick", t.Interval.ToString());
                return true;    
            }
            else if (keyData == Keys.Down)
            {
                if (t.Interval - 10 > 0)
                {
                    t.Stop();
                    t.Interval = t.Interval - 10;
                    t.Start();
                    this.TickRate.Text = String.Format("{0} ms/tick", t.Interval.ToString());
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }        
}
