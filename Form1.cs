﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_example_Grishenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // refresh informations about money operations
        public refresh()
        {
        	for (int i = 0; i < 10; i ++)
        	{
        		table.add(database[i]);
        	}
        }

        // add new money operations
        public add()
        {
        	table.add(id, summ, date);
        }

        // sorting operations
        public sort()
        {
        	table.sort;
        }

    }
}
