using Repository;
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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }
        public BindingSource source;
        IReservationRepository reservationRepo = new ReservationRepository();

        public void loadListReser()
        {

            var list = reservationRepo.GetReservations();
            source = new BindingSource();
            source.DataSource = list;
            dgvRevervation.DataSource = null;
            dgvRevervation.DataSource = source;

        }

        private void dgvRevervation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dgvRevervation.Rows[e.RowIndex].Cells[1].Value.ToString();
            IOrderRepository orderRepo = new OrderRepository();
            var order = orderRepo.getOrderById(int.Parse(value));
            if(order != null)
            {
                frmOrder frmorder1 = new frmOrder();
                frmorder1.LoadOrder(order);
                frmorder1.ShowDialog();
            }
        }

        private void dgvRevervation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dgvRevervation.CurrentCell.RowIndex;
            var reser = reservationRepo.GetReservationByIndex(Index);
            if (reser != null)
            {
                txtReservation.Text = reser.Rid.ToString();
                txtOrderId.Text = reser.Oid.ToString();
                txtCustomerId.Text = reser.Cid.ToString();
                txtAccountId.Text = reser.Aid.ToString();
                dtimeRDate.Text = reser.ResDate.ToString();
                txtNumberguest.Text = reser.NumGuest.ToString();
                txtDeposit.Text = reser.DepositType.ToString();
                txtDepositvalue.Text = reser.DepositValue.ToString();
            }
            else
            {
                MessageBox.Show("Nullllllllllllllll!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}
