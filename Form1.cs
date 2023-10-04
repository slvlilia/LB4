using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Отримуємо значення координат X та Y з TextBox.
                if (int.TryParse(textBoxX.Text, out int x) && int.TryParse(textBoxY.Text, out int y))
                {
                    // Визначаємо четверть системи координат.
                    string quarter = "";
                    if (x > 0 && y > 0)
                        quarter = "I";
                    else if (x < 0 && y > 0)
                        quarter = "II";
                    else if (x < 0 && y < 0)
                        quarter = "III";
                    else if (x > 0 && y < 0)
                        quarter = "IV";

                    // Відображаємо результат на PictureBox.
                    Graphics graphics = pictureBox1.CreateGraphics();
                    graphics.Clear(Color.White);
                    Brush brush = new SolidBrush(Color.Red);
                    int radius = 5;
                    int centerX = pictureBox1.Width / 2;
                    int centerY = pictureBox1.Height / 2;
                    graphics.FillEllipse(brush, centerX + x - radius, centerY - y - radius, 2 * radius, 2 * radius);

                    // Відображаємо результат (четверть) в Label.
                    labelResult.Text = "Четверть: " + quarter;
                }
                else
                {
                    MessageBox.Show("Некоректні дані. Введіть цілі числа для координат X та Y.");
                }
            }

        }
    }

