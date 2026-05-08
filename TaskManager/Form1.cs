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
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Индекс редактируемой строки, -1 если не редактируем.
        /// </summary>
        private int _editingRowIndex = -1;

        /// <summary>
        /// Инициализация формы, подписка на событие отрисовки ячеек.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dgvTasks.CellPainting += dgvTasks_CellPainting;
            UpdateStats();
        }

        // ─── Статистика ───────────────────────────────────────────────

        /// <summary>
        /// Пересчитывает и выводит статистику по задачам.
        /// </summary>
        private void UpdateStats()
        {
            int total = 0;
            int done = 0;
            int notDone = 0;
            int overdue = 0;

            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                total++;
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                string dueDateStr = row.Cells["colDueDate"].Value?.ToString() ?? "";

                if (status == "Выполнено")
                    done++;
                else
                    notDone++;

                DateTime due;
                if (DateTime.TryParse(dueDateStr, out due)
                    && due.Date < DateTime.Today)
                    overdue++;
            }

            lblTotal.Text = "Всего: " + total;
            lblDone.Text = "Выполнено: " + done;
            lblNotDone.Text = "Не выполнено: " + notDone;
            lblOverdue.Text = "Просрочено: " + overdue;
        }

        // ─── Добавить / Сохранить ─────────────────────────────────────

        /// <summary>
        /// Добавляет новую задачу или сохраняет изменения при редактировании.
        /// </summary>
        /// <param name="sender">Кнопка добавления/сохранения.</param>
        /// <param name="e">Аргументы события.</param>
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

            if (_editingRowIndex >= 0)
            {
                DataGridViewRow row = dgvTasks.Rows[_editingRowIndex];
                row.Cells["colPriority"].Value = priority;
                row.Cells["colTitle"].Value = title;
                row.Cells["colDescription"].Value = description;
                row.Cells["colDueDate"].Value = dueDate;
                row.Cells["colStatus"].Value = status;

                _editingRowIndex = -1;
                btnAdd.Text = "Добавить";
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                dgvTasks.Rows.Add(priority, title, description, dueDate, status);
            }

            ClearForm();
            UpdateStats();
        }

        // ─── Редактировать ────────────────────────────────────────────

        /// <summary>
        /// Загружает выбранную задачу в поля формы для редактирования.
        /// </summary>
        /// <param name="sender">Кнопка редактирования.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задачу для редактирования.", "Редактирование",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvTasks.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну задачу для редактирования.", "Редактирование",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selected = dgvTasks.SelectedRows[0];
            _editingRowIndex = selected.Index;

            string priority = selected.Cells["colPriority"].Value?.ToString() ?? "";
            txtTitle.Text = selected.Cells["colTitle"].Value?.ToString() ?? "";
            txtDescription.Text = selected.Cells["colDescription"].Value?.ToString() ?? "";
            chkComplited.Checked = (selected.Cells["colStatus"].Value?.ToString() == "Выполнено");

            string dueDateStr = selected.Cells["colDueDate"].Value?.ToString() ?? "";
            DateTime due;
            if (DateTime.TryParse(dueDateStr, out due))
                dtpDueDate.Value = due;

            cmbPriority.SelectedIndex = -1;
            for (int i = 0; i < cmbPriority.Items.Count; i++)
            {
                if (cmbPriority.Items[i].ToString() == priority)
                {
                    cmbPriority.SelectedIndex = i;
                    break;
                }
            }

            btnAdd.Text = "Сохранить";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtTitle.Focus();
        }

        // ─── Удалить выбранные ────────────────────────────────────────

        /// <summary>
        /// Удаляет выбранные задачи после подтверждения.
        /// </summary>
        /// <param name="sender">Кнопка удаления.</param>
        /// <param name="e">Аргументы события.</param>
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

        // ─── Фильтры ──────────────────────────────────────────────────

        /// <summary>
        /// Применяет фильтры к списку задач.
        /// </summary>
        /// <param name="sender">Кнопка применения фильтра.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        /// <summary>
        /// Сбрасывает все фильтры и показывает все задачи.
        /// </summary>
        /// <param name="sender">Кнопка сброса фильтра.</param>
        /// <param name="e">Аргументы события.</param>
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            // Сброс статуса
            rbAll.Checked = true;

            // Сброс приоритетов
            chkHigh.Checked = true;
            chkMedium.Checked = true;
            chkLow.Checked = true;

            // Сброс срока
            cmbDueDate.SelectedIndex = 0;

            // Показываем все строки
            foreach (DataGridViewRow row in dgvTasks.Rows)
                row.Visible = true;
        }

        /// <summary>
        /// Фильтрует строки таблицы по статусу, приоритету и сроку.
        /// </summary>
        private void ApplyFilters()
        {
            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                string priority = row.Cells["colPriority"].Value?.ToString() ?? "";
                string dueDateStr = row.Cells["colDueDate"].Value?.ToString() ?? "";

                bool show = true;

                // ── Фильтр по статусу ──
                if (rbDone.Checked && status != "Выполнено")
                    show = false;
                else if (rbNotDone.Checked && status != "Не выполнено")
                    show = false;

                // ── Фильтр по приоритету ──
                if (show)
                {
                    bool priorityMatch =
                        (priority == "High" && chkHigh.Checked) ||
                        (priority == "Medium" && chkMedium.Checked) ||
                        (priority == "Low" && chkLow.Checked) ||
                        (priority == "");

                    if (!priorityMatch)
                        show = false;
                }

                // ── Фильтр по сроку ──
                if (show && cmbDueDate.SelectedIndex > 0)
                {
                    DateTime due;
                    bool parsed = DateTime.TryParse(dueDateStr, out due);

                    switch (cmbDueDate.SelectedIndex)
                    {
                        case 1: // Сегодня
                            if (!parsed || due.Date != DateTime.Today)
                                show = false;
                            break;
                        case 2: // На этой неделе
                            if (!parsed)
                            {
                                show = false;
                            }
                            else
                            {
                                DateTime weekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);
                                DateTime weekEnd = weekStart.AddDays(6);
                                if (due.Date < weekStart || due.Date > weekEnd)
                                    show = false;
                            }
                            break;
                        case 3: // Просрочено
                            if (!parsed || due.Date >= DateTime.Today)
                                show = false;
                            break;
                    }
                }

                row.Visible = show;
            }
        }

        // ─── Очистка формы ────────────────────────────────────────────

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        private void ClearForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtpDueDate.Value = DateTime.Now;
            cmbPriority.SelectedIndex = -1;
            chkComplited.Checked = false;
        }

        // ─── Бейджи приоритета (CellPainting) ────────────────────────

        /// <summary>
        /// Рисует цветной бейдж в ячейке приоритета вместо обычного текста.
        /// </summary>
        /// <param name="sender">Таблица задач.</param>
        /// <param name="e">Данные для отрисовки ячейки.</param>
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

        /// <summary>
        /// Строит путь прямоугольника с закруглёнными углами.
        /// </summary>
        /// <param name="bounds">Прямоугольник.</param>
        /// <param name="radius">Радиус скругления.</param>
        /// <returns>Готовый GraphicsPath.</returns>
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

        /// <summary>
        /// Красит текст в колонках статуса и срока в зависимости от значения.
        /// </summary>
        /// <param name="sender">Таблица задач.</param>
        /// <param name="e">Данные форматирования ячейки.</param>
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
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void grpFilters_Enter(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
    }
}

