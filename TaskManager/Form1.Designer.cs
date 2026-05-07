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
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblNotDone = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrioritet = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.chkMedium = new System.Windows.Forms.CheckBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.chkLow = new System.Windows.Forms.CheckBox();
            this.chkHigh = new System.Windows.Forms.CheckBox();
            this.rbNotDone = new System.Windows.Forms.RadioButton();
            this.cmbDueDate = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpTaskInfo = new System.Windows.Forms.GroupBox();
            this.chkComplited = new System.Windows.Forms.CheckBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTaskList = new System.Windows.Forms.GroupBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpTaskInfo.SuspendLayout();
            this.grpTaskList.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.pnlLeft.Controls.Add(this.grpStats);
            this.pnlLeft.Controls.Add(this.grpFilters);
            resources.ApplyResources(this.pnlLeft, "pnlLeft");
            this.pnlLeft.ForeColor = System.Drawing.Color.White;
            this.pnlLeft.Name = "pnlLeft";
            // 
            // grpStats
            // 
            resources.ApplyResources(this.grpStats, "grpStats");
            this.grpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.grpStats.Controls.Add(this.lblOverdue);
            this.grpStats.Controls.Add(this.lblNotDone);
            this.grpStats.Controls.Add(this.lblDone);
            this.grpStats.Controls.Add(this.lblTotal);
            this.grpStats.ForeColor = System.Drawing.Color.White;
            this.grpStats.Name = "grpStats";
            this.grpStats.TabStop = false;
            // 
            // lblOverdue
            // 
            resources.ApplyResources(this.lblOverdue, "lblOverdue");
            this.lblOverdue.ForeColor = System.Drawing.Color.Red;
            this.lblOverdue.Name = "lblOverdue";
            // 
            // lblNotDone
            // 
            resources.ApplyResources(this.lblNotDone, "lblNotDone");
            this.lblNotDone.Name = "lblNotDone";
            // 
            // lblDone
            // 
            resources.ApplyResources(this.lblDone, "lblDone");
            this.lblDone.Name = "lblDone";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpFilters
            // 
            this.grpFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.grpFilters.Controls.Add(this.label2);
            this.grpFilters.Controls.Add(this.label1);
            this.grpFilters.Controls.Add(this.labelPrioritet);
            this.grpFilters.Controls.Add(this.labelStatus);
            this.grpFilters.Controls.Add(this.chkMedium);
            this.grpFilters.Controls.Add(this.labelDueDate);
            this.grpFilters.Controls.Add(this.chkLow);
            this.grpFilters.Controls.Add(this.chkHigh);
            this.grpFilters.Controls.Add(this.rbNotDone);
            this.grpFilters.Controls.Add(this.cmbDueDate);
            this.grpFilters.Controls.Add(this.btnResetFilter);
            this.grpFilters.Controls.Add(this.rbAll);
            this.grpFilters.Controls.Add(this.rbDone);
            this.grpFilters.Controls.Add(this.btnApplyFilter);
            resources.ApplyResources(this.grpFilters, "grpFilters");
            this.grpFilters.ForeColor = System.Drawing.Color.White;
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.TabStop = false;
            this.grpFilters.Enter += new System.EventHandler(this.grpFilters_Enter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelPrioritet
            // 
            resources.ApplyResources(this.labelPrioritet, "labelPrioritet");
            this.labelPrioritet.Name = "labelPrioritet";
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
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
            // labelDueDate
            // 
            resources.ApplyResources(this.labelDueDate, "labelDueDate");
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Click += new System.EventHandler(this.label1_Click_1);
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
            // rbNotDone
            // 
            resources.ApplyResources(this.rbNotDone, "rbNotDone");
            this.rbNotDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNotDone.ForeColor = System.Drawing.Color.White;
            this.rbNotDone.Name = "rbNotDone";
            this.rbNotDone.UseVisualStyleBackColor = true;
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
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnResetFilter, "btnResetFilter");
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
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
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(79)))), ((int)(((byte)(169)))));
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnApplyFilter, "btnApplyFilter");
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.grpTaskInfo);
            this.pnlMain.Controls.Add(this.grpTaskList);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
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
            this.grpTaskInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTaskInfo.Name = "grpTaskInfo";
            this.grpTaskInfo.TabStop = false;
            // 
            // chkComplited
            // 
            resources.ApplyResources(this.chkComplited, "chkComplited");
            this.chkComplited.Name = "chkComplited";
            this.chkComplited.UseVisualStyleBackColor = true;
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
            // dtpDueDate
            // 
            this.dtpDueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpDueDate, "dtpDueDate");
            this.dtpDueDate.Name = "dtpDueDate";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescription.Name = "txtDescription";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTitle.Name = "txtTitle";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblPriority
            // 
            resources.ApplyResources(this.lblPriority, "lblPriority");
            this.lblPriority.Name = "lblPriority";
            // 
            // lblDueDate
            // 
            resources.ApplyResources(this.lblDueDate, "lblDueDate");
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // grpTaskList
            // 
            this.grpTaskList.Controls.Add(this.flpButtons);
            this.grpTaskList.Controls.Add(this.dgvTasks);
            resources.ApplyResources(this.grpTaskList, "grpTaskList");
            this.grpTaskList.Name = "grpTaskList";
            this.grpTaskList.TabStop = false;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.panel1);
            this.flpButtons.Controls.Add(this.btnEdit);
            this.flpButtons.Controls.Add(this.panel2);
            this.flpButtons.Controls.Add(this.btnDelete);
            resources.ApplyResources(this.flpButtons, "flpButtons");
            this.flpButtons.Name = "flpButtons";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(214)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(178)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.colDescription,
            this.colDueDate,
            this.colStatus});
            resources.ApplyResources(this.dgvTasks, "dgvTasks");
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTasks_CellFormatting);
            // 
            // colPriority
            // 
            this.colPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.colPriority, "colPriority");
            this.colPriority.Name = "colPriority";
            this.colPriority.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.colTitle, "colTitle");
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.colDescription, "colDescription");
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.colDueDate, "colDueDate");
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpTaskInfo.ResumeLayout(false);
            this.grpTaskInfo.PerformLayout();
            this.grpTaskList.ResumeLayout(false);
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFilters;
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
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.RadioButton rbNotDone;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.Label labelPrioritet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}