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
            this.solarSystem.objects.ForEach(o => this.comboBox1.Items.Add(o.name));
            t.Interval = 10;
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
            DrawBackground(g);
            setCenter();
            var selected = this.comboBox1.SelectedItem;
            switch (selected)
            {
                case "All":
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
                        break;

                default:
                    CelestialObject obj = this.solarSystem.objects.Find(i => i.name == selected.ToString());
                        obj.DrawForms(g, this.center.Item1, this.center.Item2);
                        if (this.checkBox1.Checked)
                        {
                            obj.DrawObjectName(g, this.center.Item1, this.center.Item2);
                        }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            setCenter();
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
            this.solarSystem.GravitationalCenter.setPosition(this.center);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.time++;
                this.label1.Text = this.time.ToString();
                this.solarSystem.objects.ForEach(o => o.updatePosition(time));
                this.Refresh();
            }
        }
    }
}
