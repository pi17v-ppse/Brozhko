using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace interface_example_Grishenko
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("Авто",435);
            chart1.Series["Series1"].Points.AddXY("Медицина", 631);
            chart1.Series["Series1"].Points.AddXY("Еда", 887);
            chart1.Series["Series1"].Points.AddXY("Работа", 236);
            chart1.Series["Series1"].Points.AddXY("Развлечения", 169);
            chart1.Series["Series1"].Points.AddXY("Разное", 194);

            chart2.Series["Series1"].Points.AddXY("Авто", 832);
            chart2.Series["Series1"].Points.AddXY("Медицина", 989);
            chart2.Series["Series1"].Points.AddXY("Еда", 111);
            chart2.Series["Series1"].Points.AddXY("Работа", 823);
            chart2.Series["Series1"].Points.AddXY("Развлечения", 564);
            chart2.Series["Series1"].Points.AddXY("Разное", 564);
        }
    }
}
