using BussinessObject2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManagement
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        public BindingSource source;
        public void LoadOrder(Order order)
        {
            if (order != null)
            {
                source = new BindingSource();
                source.DataSource = order;
                dgvOrrder.DataSource = null;
                dgvOrrder.DataSource = source;
            }
        }
    }
}
