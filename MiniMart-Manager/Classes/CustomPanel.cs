using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MiniMart_Manager.Classes
{
    internal class CustomPanel : Panel
    {
        private int _borderRadius = 10;

        // Các thuộc tính [Category], [Description], [DefaultValue] giúp nó hiển thị đúng cách
        [Category("Giao diện")]
        [Description("Bán kính bo tròn góc")]
        [DefaultValue(10)]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate(); // Yêu cầu vẽ lại control khi thuộc tính thay đổi
            }
        }

        // Khởi tạo CustomPanel
        public CustomPanel()
        {
            this.Size = new Size(200, 100);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Bật chế độ làm mịn khi vẽ (Anti-aliasing)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Lấy kích thước hiện tại
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            // Tạo đường dẫn đồ họa bo tròn (sử dụng BorderRadius đã set)
            GraphicsPath path = new GraphicsPath();
            int r = _borderRadius * 2;

            // Vẽ 4 góc (phần này phức tạp, cần tính toán 4 cung tròn)
            path.AddArc(bounds.X, bounds.Y, r, r, 180, 90); // Góc trên trái
            path.AddArc(bounds.X + bounds.Width - r, bounds.Y, r, r, 270, 90); // Góc trên phải
            path.AddArc(bounds.X + bounds.Width - r, bounds.Y + bounds.Height - r, r, r, 0, 90); // Góc dưới phải
            path.AddArc(bounds.X, bounds.Y + bounds.Height - r, r, r, 90, 90); // Góc dưới trái
            path.CloseFigure();

            // Thiết lập Region (vùng) của control theo đường dẫn bo tròn
            this.Region = new Region(path);

            // Vẽ nền bên trong Region
            e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

            // Nếu bạn muốn vẽ viền
            // e.Graphics.DrawPath(new Pen(Color.Black, 1), path);
        }
    }
}
