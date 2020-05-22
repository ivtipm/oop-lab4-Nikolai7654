namespace Database
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCost = new System.Windows.Forms.TextBox();
            this.textChance = new System.Windows.Forms.TextBox();
            this.textSpell = new System.Windows.Forms.TextBox();
            this.textDurability = new System.Windows.Forms.TextBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelDurability = new System.Windows.Forms.Label();
            this.labelSpell = new System.Windows.Forms.Label();
            this.labelChance = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textLevel = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.chance,
            this.value,
            this.type,
            this.level,
            this.durability,
            this.cost,
            this.spell,
            this.status});
            this.table.Location = new System.Drawing.Point(11, 265);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 4;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(673, 205);
            this.table.TabIndex = 0;
            this.table.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_CellBeginEdit);
            this.table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellEndEdit);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 3;
            this.ID.MinimumWidth = 30;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MaxInputLength = 35;
            this.name.MinimumWidth = 30;
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.ToolTipText = "имя не должно превышать 35 символов";
            this.name.Width = 215;
            // 
            // chance
            // 
            this.chance.HeaderText = "Chance";
            this.chance.MaxInputLength = 2;
            this.chance.Name = "chance";
            this.chance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.chance.Width = 50;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.value.Width = 50;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MaxInputLength = 3;
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.type.Width = 50;
            // 
            // level
            // 
            this.level.HeaderText = "Level";
            this.level.MaxInputLength = 3;
            this.level.Name = "level";
            this.level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level.Width = 40;
            // 
            // durability
            // 
            this.durability.HeaderText = "Durability";
            this.durability.MaxInputLength = 3;
            this.durability.Name = "durability";
            this.durability.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.durability.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.durability.Width = 60;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.MaxInputLength = 9;
            this.cost.Name = "cost";
            this.cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cost.Width = 75;
            // 
            // spell
            // 
            this.spell.HeaderText = "Spell";
            this.spell.MaxInputLength = 7;
            this.spell.Name = "spell";
            this.spell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.spell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.spell.Width = 60;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MaxInputLength = 1;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Width = 40;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(86, 25);
            this.textName.MaxLength = 35;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(250, 21);
            this.textName.TabIndex = 1;
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCost.Location = new System.Drawing.Point(236, 109);
            this.textCost.MaxLength = 9;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(100, 21);
            this.textCost.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textCost, "more than 0");
            // 
            // textChance
            // 
            this.textChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textChance.Location = new System.Drawing.Point(86, 55);
            this.textChance.MaxLength = 2;
            this.textChance.Name = "textChance";
            this.textChance.Size = new System.Drawing.Size(100, 21);
            this.textChance.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textChance, "from 0 to 100");
            // 
            // textSpell
            // 
            this.textSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpell.Location = new System.Drawing.Point(86, 136);
            this.textSpell.MaxLength = 7;
            this.textSpell.Name = "textSpell";
            this.textSpell.Size = new System.Drawing.Size(100, 21);
            this.textSpell.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textSpell, "more than 0");
            // 
            // textDurability
            // 
            this.textDurability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDurability.Location = new System.Drawing.Point(86, 109);
            this.textDurability.MaxLength = 3;
            this.textDurability.Name = "textDurability";
            this.textDurability.Size = new System.Drawing.Size(100, 21);
            this.textDurability.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textDurability, "from 0 to 100");
            // 
            // textValue
            // 
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValue.Location = new System.Drawing.Point(236, 54);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(100, 21);
            this.textValue.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textValue, "greater than or equal to 0");
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(8, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(186, 112);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(36, 17);
            this.labelCost.TabIndex = 8;
            this.labelCost.Text = "Cost";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(186, 57);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 17);
            this.labelValue.TabIndex = 9;
            this.labelValue.Text = "Value";
            // 
            // labelDurability
            // 
            this.labelDurability.AutoSize = true;
            this.labelDurability.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDurability.Location = new System.Drawing.Point(8, 112);
            this.labelDurability.Name = "labelDurability";
            this.labelDurability.Size = new System.Drawing.Size(67, 17);
            this.labelDurability.TabIndex = 10;
            this.labelDurability.Text = "Durability";
            // 
            // labelSpell
            // 
            this.labelSpell.AutoSize = true;
            this.labelSpell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpell.Location = new System.Drawing.Point(8, 139);
            this.labelSpell.Name = "labelSpell";
            this.labelSpell.Size = new System.Drawing.Size(39, 17);
            this.labelSpell.TabIndex = 11;
            this.labelSpell.Text = "Spell";
            // 
            // labelChance
            // 
            this.labelChance.AutoSize = true;
            this.labelChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChance.Location = new System.Drawing.Point(8, 58);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(56, 17);
            this.labelChance.TabIndex = 12;
            this.labelChance.Text = "Chance";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 41);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(86, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 41);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(8, 85);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 17;
            this.labelType.Text = "Type";
            // 
            // textType
            // 
            this.textType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textType.Location = new System.Drawing.Point(86, 82);
            this.textType.MaxLength = 3;
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 21);
            this.textType.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textType, "more than 0");
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.Location = new System.Drawing.Point(186, 85);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(42, 17);
            this.labelLevel.TabIndex = 19;
            this.labelLevel.Text = "Level";
            // 
            // textLevel
            // 
            this.textLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLevel.Location = new System.Drawing.Point(236, 82);
            this.textLevel.Name = "textLevel";
            this.textLevel.Size = new System.Drawing.Size(100, 21);
            this.textLevel.TabIndex = 18;
            this.toolTip1.SetToolTip(this.textLevel, "more than 0");
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(186, 140);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 17);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(236, 137);
            this.textStatus.MaxLength = 2;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(100, 21);
            this.textStatus.TabIndex = 20;
            this.toolTip1.SetToolTip(this.textStatus, "from 1 to 3");
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(11, 178);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(62, 41);
            this.buttonDeleteAll.TabIndex = 22;
            this.buttonDeleteAll.Text = "Delete All";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(440, 28);
            this.textSearch.MaxLength = 35;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(155, 21);
            this.textSearch.TabIndex = 23;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(456, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 41);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.buttonSearch, "Search by id and name");
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.createNewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.createNewToolStripMenuItem.Text = "Create new";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgramToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutTheProgramToolStripMenuItem.Text = "About the program";
            this.aboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutTheProgramToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "ID",
            "Type",
            "Level",
            "Value",
            "Status",
            "Spell"});
            this.comboBoxSort.Location = new System.Drawing.Point(456, 121);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(116, 21);
            this.comboBoxSort.TabIndex = 26;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(456, 177);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(116, 41);
            this.buttonSort.TabIndex = 27;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxDirection.Location = new System.Drawing.Point(456, 148);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(116, 21);
            this.comboBoxDirection.TabIndex = 28;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipTitle = "Prompt";
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoSave.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAutoSave.Location = new System.Drawing.Point(613, 28);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(71, 16);
            this.labelAutoSave.TabIndex = 29;
            this.labelAutoSave.Text = "Auto Save...";
            this.labelAutoSave.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(697, 482);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textLevel);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelChance);
            this.Controls.Add(this.labelSpell);
            this.Controls.Add(this.labelDurability);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.textDurability);
            this.Controls.Add(this.textSpell);
            this.Controls.Add(this.textChance);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "database item";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.TextBox textChance;
        private System.Windows.Forms.TextBox textSpell;
        private System.Windows.Forms.TextBox textDurability;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelDurability;
        private System.Windows.Forms.Label labelSpell;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textLevel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Timer timerLabel;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chance;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn durability;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn spell;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

