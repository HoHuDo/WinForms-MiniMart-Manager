using System.ComponentModel;
using System.Drawing.Drawing2D;
namespace MiniMart_Manager.Classes
{
    public class RoundedButton : Button
    {
        private int _borderRadius = 15;

        // Thuộc tính tùy chỉnh hiển thị trong Properties Window
        [Category("Giao diện")]
        [Description("Bán kính bo tròn góc")]
        [DefaultValue(15)]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        public RoundedButton()
        {
            // Thiết lập mặc định để dễ tùy chỉnh
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; // Xóa viền mặc định
            this.Size = new Size(150, 40);
        }

        // Ghi đè OnResize để cắt hình dạng control theo góc bo tròn
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Cần tạo lại Region mỗi khi control thay đổi kích thước
            using (var path = GetRoundedPath(this.ClientRectangle, _borderRadius))
            {
                this.Region = new Region(path);
            }
        }

        // Phương thức tạo GraphicsPath để định hình góc bo tròn
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius * 2; // Đường kính
            Rectangle roundRect = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);

            // Thêm 4 cung tròn vào đường dẫn
            // Góc trên trái
            path.AddArc(roundRect.X, roundRect.Y, r, r, 180, 90);
            // Góc trên phải
            path.AddArc(roundRect.X + roundRect.Width - r, roundRect.Y, r, r, 270, 90);
            // Góc dưới phải
            path.AddArc(roundRect.X + roundRect.Width - r, roundRect.Y + roundRect.Height - r, r, r, 0, 90);
            // Góc dưới trái
            path.AddArc(roundRect.X, roundRect.Y + roundRect.Height - r, r, r, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Ghi đè OnPaint để vẽ lại (Nếu cần tùy chỉnh màu nền/viền/chữ)
        protected override void OnPaint(PaintEventArgs e)
        {
            // Kích hoạt chế độ làm mịn cho đồ họa
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Tự vẽ nền:
            using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, _borderRadius))
            {
                // Vẽ nền Button
                using (Brush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Vẽ viền (tùy chọn)
                // using (Pen pen = new Pen(this.ForeColor, 1))
                // {
                //     e.Graphics.DrawPath(pen, path);
                // }
            }

            // Đảm bảo chữ (Text) vẫn được vẽ
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}