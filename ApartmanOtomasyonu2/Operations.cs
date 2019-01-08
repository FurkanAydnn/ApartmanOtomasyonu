using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu2
{
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }
        ApartmentAutomationEntities db = new ApartmentAutomationEntities();

        public void SelectTab()
        {
            tabControl1.SelectedTab = tpExpenses;
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            Incomes newIncome = new Incomes();
            newIncome.Amount = nudIncomeAmount.Value;
            newIncome.Date = dtpIncomeDate.Value;
            newIncome.RoomNo = (int)nudRoomNo.Value;
            db.Incomes.Add(newIncome);
            db.SaveChanges();
            Operations_Load(sender, e);
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpIncomes)
                GetIncomesTable();
            else if (tabControl1.SelectedTab == tpExpenses)
                GetExpensesTable();

            ClearControls();
        }

        private void ClearControls()
        {
            nudExpenseAmount.Value = 0;
            nudIncomeAmount.Value = 0;
            nudRoomNo.Value = 0;
            dtpExpenseDate.Value = DateTime.Today;
            dtpIncomeDate.Value = DateTime.Today;
            rbtnClean.Checked = false;
            rbtnElectricity.Checked = false;
            rbtnElevator.Checked = false;
            rbtnSu.Checked = false;
        }

        private void GetExpensesTable()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = (from a in db.Expenses join b in db.ExpenseTypes on a.ExpenseType equals b.TypeID select new { a.Date, a.Amount, b.TypeName })
                .ToList()
                .Select(x => new
                {
                    x.TypeName,
                    Tutar = x.Amount.ToString("C"),
                    Tarih = x.Date,
                })
                .ToList();
            SetDataGridViewDisplay();
        }

        private void GetIncomesTable()
        {
            dgvIncomes.DataSource = null;
            dgvIncomes.DataSource = db.Incomes
                .ToList()
                .Select(x => new
                {
                    DaireNo = x.RoomNo,
                    Tutar = x.Amount.ToString("c"),
                    Tarih = x.Date
                })
                .ToList();
            SetDataGridViewDisplay();
        }

        private void SetDataGridViewDisplay()
        {
            foreach (DataGridViewColumn item in dgvIncomes.Columns)
            {
                item.Width = 97;
            }
            foreach (DataGridViewColumn item in dgvExpenses.Columns)
            {
                item.Width = 97;
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            Expenses newExpense = new Expenses();
            newExpense.Amount = nudExpenseAmount.Value;
            newExpense.Date = dtpExpenseDate.Value;
            newExpense.ExpenseType = SetExpenseType();
            db.Expenses.Add(newExpense);
            db.SaveChanges();
            Operations_Load(sender, e);
        }

        private int? SetExpenseType()
        {
            if (rbtnElectricity.Checked)
                return 1;
            else if (rbtnSu.Checked)
                return 2;
            else if (rbtnClean.Checked)
                return 3;
            else
                return 4;
        }

        private void Operations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
