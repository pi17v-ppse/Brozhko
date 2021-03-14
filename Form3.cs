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

        // money decrease statistic
        public statistic()
        {
            table.sqlquery("select * from operations");
            table.add(query);
        }

        // add money decrease operation
        public add()
        {
            table.add(id, name, summ, category);
        }
    }
}
