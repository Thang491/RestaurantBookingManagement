﻿using BussinessObject2;
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
    public partial class StaffForm : Form
    {
        IFoodRepository _foodRepository;
        IOrderDetailRepository _orderDetailRepository;
        IPayment _payment;
        IReservationRepository _reservationRepository;
        IOrderRepository _orderRepository = new OrderRepository();
        ICustomerRepository _customerRepository;
        ITableRepository _table;

        private int LastCreatedOrderId;
        public StaffForm()
        {
            InitializeComponent();
            _orderDetailRepository = new OrderDetailRepository();
            _foodRepository = new FoodRepository();
            _payment = new PaymentRepository();
            _reservationRepository = new ReservationRepository();
            _orderRepository = new OrderRepository();
            _customerRepository = new CustomerRepository();
            _table = new TableRepository();

            txtStatus.Enabled = false;
            txtStatus2.Enabled = false;
            txtTableCapacity.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail order = new OrderDetail();

            var fid = int.Parse(cbbFood.SelectedValue.ToString());
            var quantity = int.Parse(txtQuantity.Text);

            order.Oid = LastCreatedOrderId;
            order.Fid = fid;
            order.Quantity = quantity;
            order.AmountOfFood = (_foodRepository.GetFoodById(fid).Price) * quantity;

            _orderDetailRepository.AddOrderDetail(order);

            var listOrderDetail = _orderDetailRepository.GetOrderDetails().Where(x => x.Oid == LastCreatedOrderId);
            dgvFood.DataSource = new BindingSource() { DataSource = listOrderDetail };

            txtStatus2.Text = "Add Food Successfully";
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNumG.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPrepay.Text = string.Empty;
            txtStatus.Text = "Status";
            txtStatus2.Text = "Done Booking";
            txtQuantity.Text = string.Empty;

            Order order = new Order();

            var CalculateOrderTotal = _orderDetailRepository.GetOrderDetails().Where(x => x.Oid == LastCreatedOrderId).Sum(x => x.AmountOfFood);
            order.TotalPrice = CalculateOrderTotal;
            order.Oid = LastCreatedOrderId;
            _orderRepository.UpdateOrder(order);
            btnReverse.Enabled = true;
            dgvFood.DataSource = null;
            button1.Enabled = false;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            var cbb = _foodRepository.GetFoods().ToArray();
            var cbb2 = _payment.GetDepositCates().ToArray();
            var cbb3 = _table.getListTable().ToArray();

            cbbPrepay.DataSource = new BindingSource { DataSource = cbb2 };
            cbbPrepay.DisplayMember = "DepositName";
            cbbPrepay.ValueMember = "DepositId";
            cbbPrepay.SelectedIndex = 0;

            cbbFood.DataSource = new BindingSource { DataSource = cbb };
            cbbFood.DisplayMember = "Fname";
            cbbFood.ValueMember = "Fid";
            cbbFood.SelectedIndex = 0;

            cbbTable.DataSource = new BindingSource { DataSource = cbb3 };
            cbbTable.DisplayMember = "TableName";
            cbbTable.ValueMember = "Tid";
            cbbTable.SelectedIndex = 0;

            cbbTable.SelectedIndexChanged += cbbTable_SelectedIndexChanged;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = new Reservation();
                Order order = new Order();
                Customer customer = new Customer();
                ReserveDetail reserveDetail = new ReserveDetail();

                customer.CustomerName = txtName.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;

                _customerRepository.AddCustomer(customer);

                reservation.Aid = 2;
                reservation.Cid = customer.Cid;
                reservation.ResDate = dateTimePicker1.Value;
                reservation.NumGuest = int.Parse(txtNumG.Text);
                reservation.DepositType = int.Parse(cbbPrepay.SelectedValue.ToString());
                reservation.DepositValue = decimal.Parse(txtPrepay.Text);

                _reservationRepository.AddReservation(reservation);

                reserveDetail.Rid = reservation.Rid;
                reserveDetail.Tid = int.Parse(cbbTable.SelectedValue.ToString());

                _reservationRepository.AddReservationDetail(reserveDetail);

                order.OrderDate = dateTimePicker1.Value;
                order.NumGuest = int.Parse(txtNumG.Text);
                order.Rid = reservation.Rid;

                _orderRepository.AddOrder(order);

                reservation.Oid = order.Oid;

                _reservationRepository.UpdateReservation(reservation);

                LastCreatedOrderId = int.Parse(order.Oid.ToString());

                btnReverse.Enabled = false;

                txtStatus.Text = "Successfully Add";
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There something Wrong", "Error");
            }
        }

        private void cbbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb3 = _table.getListTable().ToArray();
            int selected = cbbTable.SelectedIndex;
            if (selected >= 0 && selected < cbb3.Length)
            {
                int? capacity = cbb3[selected].Capacity;
                txtTableCapacity.Text = capacity.ToString();
            }
        }
    }
}
