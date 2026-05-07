namespace TaskManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.rbNotDone = new System.Windows.Forms.RadioButton();
            this.chkLow = new System.Windows.Forms.CheckBox();
            this.chkMedium = new System.Windows.Forms.CheckBox();
            this.chkHigh = new System.Windows.Forms.CheckBox();
            this.cmbDueDate = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblNotDone = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.grpTaskList = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpTaskInfo = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.chkComplited = new System.Windows.Forms.CheckBox();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpTaskList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.grpTaskInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlLeft.Controls.Add(this.grpStats);
            this.pnlLeft.Controls.Add(this.btnResetFilter);
            this.pnlLeft.Controls.Add(this.cmbDueDate);
            this.pnlLeft.Controls.Add(this.btnApplyFilter);
            this.pnlLeft.Controls.Add(this.chkHigh);
            this.pnlLeft.Controls.Add(this.grpFilters);
            this.pnlLeft.Controls.Add(this.chkMedium);
            this.pnlLeft.Controls.Add(this.chkLow);
            resources.ApplyResources(this.pnlLeft, "pnlLeft");
            this.pnlLeft.ForeColor = System.Drawing.Color.White;
            this.pnlLeft.Name = "pnlLeft";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpTaskInfo);
            this.pnlMain.Controls.Add(this.grpTaskList);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.rbNotDone);
            this.grpFilters.Controls.Add(this.rbAll);
            this.grpFilters.Controls.Add(this.rbDone);
            resources.ApplyResources(this.grpFilters, "grpFilters");
            this.grpFilters.ForeColor = System.Drawing.Color.White;
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.TabStop = false;
            // 
            // rbAll
            // 
            resources.ApplyResources(this.rbAll, "rbAll");
            this.rbAll.Checked = true;
            this.rbAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAll.ForeColor = System.Drawing.Color.White;
            this.rbAll.Name = "rbAll";
            this.rbAll.TabStop = true;
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbDone
            // 
            resources.ApplyResources(this.rbDone, "rbDone");
            this.rbDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDone.ForeColor = System.Drawing.Color.White;
            this.rbDone.Name = "rbDone";
            this.rbDone.UseVisualStyleBackColor = true;
            // 
            // rbNotDone
            // 
            resources.ApplyResources(this.rbNotDone, "rbNotDone");
            this.rbNotDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNotDone.ForeColor = System.Drawing.Color.White;
            this.rbNotDone.Name = "rbNotDone";
            this.rbNotDone.UseVisualStyleBackColor = true;
            // 
            // chkLow
            // 
            resources.ApplyResources(this.chkLow, "chkLow");
            this.chkLow.Checked = true;
            this.chkLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkLow.ForeColor = System.Drawing.Color.White;
            this.chkLow.Name = "chkLow";
            this.chkLow.UseVisualStyleBackColor = true;
            // 
            // chkMedium
            // 
            resources.ApplyResources(this.chkMedium, "chkMedium");
            this.chkMedium.Checked = true;
            this.chkMedium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMedium.ForeColor = System.Drawing.Color.White;
            this.chkMedium.Name = "chkMedium";
            this.chkMedium.UseVisualStyleBackColor = true;
            // 
            // chkHigh
            // 
            resources.ApplyResources(this.chkHigh, "chkHigh");
            this.chkHigh.Checked = true;
            this.chkHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHigh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHigh.ForeColor = System.Drawing.Color.White;
            this.chkHigh.Name = "chkHigh";
            this.chkHigh.UseVisualStyleBackColor = true;
            // 
            // cmbDueDate
            // 
            this.cmbDueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDueDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDueDate.FormattingEnabled = true;
            this.cmbDueDate.Items.AddRange(new object[] {
            resources.GetString("cmbDueDate.Items"),
            resources.GetString("cmbDueDate.Items1"),
            resources.GetString("cmbDueDate.Items2"),
            resources.GetString("cmbDueDate.Items3")});
            resources.ApplyResources(this.cmbDueDate, "cmbDueDate");
            this.cmbDueDate.Name = "cmbDueDate";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnApplyFilter, "btnApplyFilter");
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.DimGray;
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnResetFilter, "btnResetFilter");
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // grpStats
            // 
            resources.ApplyResources(this.grpStats, "grpStats");
            this.grpStats.Controls.Add(this.lblOverdue);
            this.grpStats.Controls.Add(this.lblNotDone);
            this.grpStats.Controls.Add(this.lblDone);
            this.grpStats.Controls.Add(this.lblTotal);
            this.grpStats.Name = "grpStats";
            this.grpStats.TabStop = false;
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDone
            // 
            resources.ApplyResources(this.lblDone, "lblDone");
            this.lblDone.Name = "lblDone";
            // 
            // lblNotDone
            // 
            resources.ApplyResources(this.lblNotDone, "lblNotDone");
            this.lblNotDone.Name = "lblNotDone";
            // 
            // lblOverdue
            // 
            resources.ApplyResources(this.lblOverdue, "lblOverdue");
            this.lblOverdue.ForeColor = System.Drawing.Color.Red;
            this.lblOverdue.Name = "lblOverdue";
            // 
            // grpTaskList
            // 
            this.grpTaskList.Controls.Add(this.flpButtons);
            this.grpTaskList.Controls.Add(this.dgvTasks);
            resources.ApplyResources(this.grpTaskList, "grpTaskList");
            this.grpTaskList.Name = "grpTaskList";
            this.grpTaskList.TabStop = false;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPriority,
            this.colTitle,
            this.colDueDate,
            this.colStatus});
            resources.ApplyResources(this.dgvTasks, "dgvTasks");
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnEdit);
            this.flpButtons.Controls.Add(this.btnDelete);
            resources.ApplyResources(this.flpButtons, "flpButtons");
            this.flpButtons.Name = "flpButtons";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Khaki;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // grpTaskInfo
            // 
            this.grpTaskInfo.Controls.Add(this.chkComplited);
            this.grpTaskInfo.Controls.Add(this.cmbPriority);
            this.grpTaskInfo.Controls.Add(this.dtpDueDate);
            this.grpTaskInfo.Controls.Add(this.txtDescription);
            this.grpTaskInfo.Controls.Add(this.txtTitle);
            this.grpTaskInfo.Controls.Add(this.label5);
            this.grpTaskInfo.Controls.Add(this.lblPriority);
            this.grpTaskInfo.Controls.Add(this.lblDueDate);
            this.grpTaskInfo.Controls.Add(this.lblDescription);
            this.grpTaskInfo.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.grpTaskInfo, "grpTaskInfo");
            this.grpTaskInfo.Name = "grpTaskInfo";
            this.grpTaskInfo.TabStop = false;
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblDueDate
            // 
            resources.ApplyResources(this.lblDueDate, "lblDueDate");
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPriority
            // 
            resources.ApplyResources(this.lblPriority, "lblPriority");
            this.lblPriority.Name = "lblPriority";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTitle.Name = "txtTitle";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescription.Name = "txtDescription";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpDueDate, "dtpDueDate");
            this.dtpDueDate.Name = "dtpDueDate";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            resources.GetString("cmbPriority.Items"),
            resources.GetString("cmbPriority.Items1"),
            resources.GetString("cmbPriority.Items2")});
            resources.ApplyResources(this.cmbPriority, "cmbPriority");
            this.cmbPriority.Name = "cmbPriority";
            // 
            // chkComplited
            // 
            resources.ApplyResources(this.chkComplited, "chkComplited");
            this.chkComplited.Name = "chkComplited";
            this.chkComplited.UseVisualStyleBackColor = true;
            // 
            // colPriority
            // 
            resources.ApplyResources(this.colPriority, "colPriority");
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
            // 
            // colTitle
            // 
            resources.ApplyResources(this.colTitle, "colTitle");
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colDueDate
            // 
            resources.ApplyResources(this.colDueDate, "colDueDate");
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colStatus
            // 
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Name = "MainForm";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpTaskList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.grpTaskInfo.ResumeLayout(false);
            this.grpTaskInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.RadioButton rbNotDone;
        private System.Windows.Forms.CheckBox chkHigh;
        private System.Windows.Forms.CheckBox chkMedium;
        private System.Windows.Forms.CheckBox chkLow;
        private System.Windows.Forms.ComboBox cmbDueDate;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Label lblNotDone;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.GroupBox grpTaskList;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpTaskInfo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.CheckBox chkComplited;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

