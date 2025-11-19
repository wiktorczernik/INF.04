namespace PaletaRgb
{
    public partial class Form1 : Form
    {
        public int red = 255;
        public int green = 255;
        public int blue = 255;

        public Form1()
        {
            InitializeComponent();
        }

        public void OnSave(object sender, EventArgs e)
        {
            savedColorLabel.Text = $"{red}, {green}, {blue}";
            savedColorRect.BackColor = Color.FromArgb(red, green, blue);
        }
        public void OnColorChange(object sender, EventArgs e)
        {
            red = redSlider.Value;
            green = greenSlider.Value;
            blue = blueSlider.Value;
            colorRect.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
