
namespace PaletaRgb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorRect = new Panel();
            redSlider = new TrackBar();
            greenSlider = new TrackBar();
            blueSlider = new TrackBar();
            redLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            greenLabel = new Label();
            blueLabel = new Label();
            label4 = new Label();
            saveButton = new Button();
            savedColorRect = new Panel();
            savedColorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)redSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).BeginInit();
            savedColorRect.SuspendLayout();
            SuspendLayout();
            // 
            // colorRect
            // 
            colorRect.BackColor = Color.White;
            colorRect.Location = new Point(29, 25);
            colorRect.Name = "colorRect";
            colorRect.Size = new Size(738, 73);
            colorRect.TabIndex = 0;
            // 
            // redSlider
            // 
            redSlider.LargeChange = 1;
            redSlider.Location = new Point(51, 171);
            redSlider.Maximum = 255;
            redSlider.Name = "redSlider";
            redSlider.Size = new Size(681, 45);
            redSlider.TabIndex = 1;
            redSlider.TickStyle = TickStyle.None;
            redSlider.Value = 255;
            redSlider.ValueChanged += OnColorChange;
            // 
            // greenSlider
            // 
            greenSlider.LargeChange = 1;
            greenSlider.Location = new Point(51, 222);
            greenSlider.Maximum = 255;
            greenSlider.Name = "greenSlider";
            greenSlider.Size = new Size(681, 45);
            greenSlider.TabIndex = 1;
            greenSlider.TickStyle = TickStyle.None;
            greenSlider.Value = 255;
            greenSlider.ValueChanged += OnColorChange;
            // 
            // blueSlider
            // 
            blueSlider.LargeChange = 1;
            blueSlider.Location = new Point(51, 273);
            blueSlider.Maximum = 255;
            blueSlider.Name = "blueSlider";
            blueSlider.Size = new Size(681, 45);
            blueSlider.TabIndex = 1;
            blueSlider.TickStyle = TickStyle.None;
            blueSlider.Value = 255;
            blueSlider.ValueChanged += OnColorChange;
            // 
            // redLabel
            // 
            redLabel.AutoSize = true;
            redLabel.Location = new Point(738, 171);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(33, 20);
            redLabel.TabIndex = 2;
            redLabel.Text = "255";
            redLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 222);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 2;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 273);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 171);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 2;
            label1.Text = "R";
            // 
            // greenLabel
            // 
            greenLabel.AutoSize = true;
            greenLabel.Location = new Point(738, 222);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(33, 20);
            greenLabel.TabIndex = 2;
            greenLabel.Text = "255";
            greenLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // blueLabel
            // 
            blueLabel.AutoSize = true;
            blueLabel.Location = new Point(738, 273);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(33, 20);
            blueLabel.TabIndex = 2;
            blueLabel.Text = "255";
            blueLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 134);
            label4.Name = "label4";
            label4.Size = new Size(303, 20);
            label4.TabIndex = 2;
            label4.Text = "Dobierz kolor suwakami i zapisz przyciskiem";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Peru;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(292, 309);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(194, 36);
            saveButton.TabIndex = 3;
            saveButton.Text = "Pobierz";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += this.OnSave;
            // 
            // savedColorRect
            // 
            savedColorRect.BackColor = Color.White;
            savedColorRect.Controls.Add(savedColorLabel);
            savedColorRect.Location = new Point(292, 384);
            savedColorRect.Name = "savedColorRect";
            savedColorRect.Size = new Size(194, 36);
            savedColorRect.TabIndex = 1;
            // 
            // savedColorLabel
            // 
            savedColorLabel.AutoSize = true;
            savedColorLabel.Location = new Point(2, 4);
            savedColorLabel.Name = "savedColorLabel";
            savedColorLabel.Size = new Size(95, 20);
            savedColorLabel.TabIndex = 4;
            savedColorLabel.Text = "255, 255, 255";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(savedColorRect);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(blueLabel);
            Controls.Add(greenLabel);
            Controls.Add(redLabel);
            Controls.Add(blueSlider);
            Controls.Add(greenSlider);
            Controls.Add(redSlider);
            Controls.Add(colorRect);
            Name = "Form1";
            Text = "Wzornik kolorów RGB. Wykonał Wiktor Czernik";
            ((System.ComponentModel.ISupportInitialize)redSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueSlider).EndInit();
            savedColorRect.ResumeLayout(false);
            savedColorRect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colorRect;
        private TrackBar redSlider;
        private TrackBar greenSlider;
        private TrackBar blueSlider;
        private Label redLabel;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label greenLabel;
        private Label blueLabel;
        private Label label4;
        private Button saveButton;
        private Panel savedColorRect;
        private Label savedColorLabel;
    }
}
