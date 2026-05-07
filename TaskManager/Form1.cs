using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dgvTasks.CellPainting += dgvTasks_CellPainting;
            UpdateStats();
        }

        // ─── Статистика ───────────────────────────────────────────────

        private void UpdateStats()
        {
            int total = dgvTasks.Rows.Count;
            int done = 0;
            int notDone = 0;
            int overdue = 0;

            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                string dueDateStr = row.Cells["colDueDate"].Value?.ToString() ?? "";

                if (status == "Выполнено")
                    done++;
                else
                    notDone++;

                DateTime due;
                if (status == "Не выполнено"
                    && DateTime.TryParse(dueDateStr, out due)
                    && due.Date < DateTime.Today)
                    overdue++;
            }

            lblTotal.Text = "Всего: " + total;
            lblDone.Text = "Выполнено: " + done;
            lblNotDone.Text = "Не выполнено: " + notDone;
            lblOverdue.Text = "Просрочено: " + overdue;
        }

        // ─── Добавить ─────────────────────────────────────────────────

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Введите название задачи.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string priority = cmbPriority.SelectedItem != null ? cmbPriority.SelectedItem.ToString() : "";
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string dueDate = dtpDueDate.Value.ToShortDateString();
            string status = chkComplited.Checked ? "Выполнено" : "Не выполнено";

            dgvTasks.Rows.Add(priority, title, description, dueDate, status);

            txtTitle.Clear();
            txtDescription.Clear();
            dtpDueDate.Value = DateTime.Now;
            cmbPriority.SelectedIndex = -1;
            chkComplited.Checked = false;

            UpdateStats();
        }

        // ─── Удалить выбранные ────────────────────────────────────────

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для удаления.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Удалить выбранные задачи (" + dgvTasks.SelectedRows.Count + ")?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            foreach (DataGridViewRow row in dgvTasks.SelectedRows)
            {
                if (!row.IsNewRow)
                    dgvTasks.Rows.Remove(row);
            }

            UpdateStats();
        }

        // ─── Бейджи приоритета (CellPainting) ────────────────────────

        private void dgvTasks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvTasks.Columns[e.ColumnIndex].Name != "colPriority") return;

            string priority = e.Value?.ToString() ?? "";

            Color bg;
            switch (priority)
            {
                case "High": bg = Color.FromArgb(220, 70, 70); break;
                case "Medium": bg = Color.FromArgb(230, 175, 40); break;
                case "Low": bg = Color.FromArgb(70, 175, 90); break;
                default: bg = Color.LightGray; break;
            }

            bool selected = (e.State & DataGridViewElementStates.Selected) != 0;
            e.Graphics.FillRectangle(
                new SolidBrush(selected ? dgvTasks.DefaultCellStyle.SelectionBackColor : Color.White),
                e.CellBounds);

            int padX = 8, padY = 5;
            Rectangle badge = new Rectangle(
                e.CellBounds.X + padX,
                e.CellBounds.Y + padY,
                e.CellBounds.Width - padX * 2,
                e.CellBounds.Height - padY * 2);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = RoundedRect(badge, 4))
            using (SolidBrush fill = new SolidBrush(bg))
            {
                e.Graphics.FillPath(fill, path);
            }

            using (Font font = new Font("Segoe UI", 8f, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.White))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(priority, font, textBrush, badge, sf);
            }

            e.Handled = true;
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // ─── Окраска ячеек ────────────────────────────────────────────

        private void dgvTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTasks.Rows[e.RowIndex];
            string colName = dgvTasks.Columns[e.ColumnIndex].Name;
            string status = row.Cells["colStatus"].Value?.ToString() ?? "";
            string dueDateStr = row.Cells["colDueDate"].Value?.ToString() ?? "";

            if (colName == "colStatus")
            {
                if (status == "Не выполнено")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
                else if (status == "Выполнено")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.Green;
                }
            }

            if (colName == "colDueDate")
            {
                DateTime due;
                if (DateTime.TryParse(dueDateStr, out due) && due.Date < DateTime.Today)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnResetFilter_Click(object sender, EventArgs e) { }
        private void btnApplyFilter_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void grpFilters_Enter(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
    }
}