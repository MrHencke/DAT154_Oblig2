using System.Drawing.Drawing2D;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.DoubleBuffered = true;
            DrawBackground(g);
            DrawSolarSystem(g);
        }

        private void DrawSolarSystem(Graphics g)
        {
            setCenter();
            this.solarSystem.objects.ForEach(i =>
            {
                i.updatePosition(0);
                i.DrawForms(g);
            });
        }

        private void setCenter()
        {
            int xCenter = ClientSize.Width / 2;
            int yCenter = ClientSize.Height / 2;
            Tuple<int, int> center = Tuple.Create(xCenter, yCenter);
            this.solarSystem.Sun.setPosition(center);
        }
        private void DrawBackground(Graphics g)
        {
            Brush brush = new SolidBrush(Color.FromArgb(255, 65, 74, 76));
            g.FillRectangle(brush, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            brush.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            this.Refresh();
        }
        protected override void OnClick(EventArgs e)
        {
            this.Refresh();
        }
    }
}