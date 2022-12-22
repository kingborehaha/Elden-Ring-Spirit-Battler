namespace EldenRingSpiritBattler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SummonPosition_X = new System.Windows.Forms.NumericUpDown();
            this.SummonPosition_Z = new System.Windows.Forms.NumericUpDown();
            this.SummonPosition_Angle = new System.Windows.Forms.NumericUpDown();
            this.t_console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRegulationbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_restoreRegulation = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Execute = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpiritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_GetDataSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSpiritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_SetDataSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSpiritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_RemoveAllSpirits = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_ResetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_ReduceEnemyMapCol = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_HidePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_StatScalingLevelInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.List_Enemy = new System.Windows.Forms.ComboBox();
            this.Search_Enemy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.List_TeamPhantomColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.List_SpiritAsh = new System.Windows.Forms.ComboBox();
            this.SummonPosition_Auto = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SummonPosition_Auto_DistMagnitude = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.List_Teams = new System.Windows.Forms.ComboBox();
            this.Button_AddNewTeam = new System.Windows.Forms.Button();
            this.SpiritDataGrid = new System.Windows.Forms.DataGridView();
            this.Context_DataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Button_Context_GetSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Context_DuplicateSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Context_RemoveSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Context_UpdateSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Team = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EnemyCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Variant = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Input_NpcParamID = new System.Windows.Forms.NumericUpDown();
            this.Input_NpcThinkID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.List_StatScaling = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Input_EnemyHpMult = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Input_EnemyDamageMult = new System.Windows.Forms.NumericUpDown();
            this.List_EnemyVariant = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.List_TeamType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Input_TeamName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Option_SpiritAshNoRequirements = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_PickRandomEnemy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_RandomTeamName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_AddRandomSpirit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Angle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Auto_DistMagnitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpiritDataGrid)).BeginInit();
            this.Context_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcParamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcThinkID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyHpMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyDamageMult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "regulation.bin";
            this.openFileDialog1.Filter = "Regulation File|regulation.bin|All Files|*.*";
            this.openFileDialog1.Title = "Open \"regulation.bin\"";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // SummonPosition_X
            // 
            this.SummonPosition_X.DecimalPlaces = 2;
            this.SummonPosition_X.Enabled = false;
            this.SummonPosition_X.Location = new System.Drawing.Point(78, 282);
            this.SummonPosition_X.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SummonPosition_X.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.SummonPosition_X.Name = "SummonPosition_X";
            this.SummonPosition_X.Size = new System.Drawing.Size(49, 23);
            this.SummonPosition_X.TabIndex = 75;
            this.toolTip1.SetToolTip(this.SummonPosition_X, "Left/Right position of summon location in meters\r\nNegative values are to the left" +
        " of the player\r\nPositive values are to the right of the player");
            this.SummonPosition_X.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_X.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // SummonPosition_Z
            // 
            this.SummonPosition_Z.DecimalPlaces = 2;
            this.SummonPosition_Z.Enabled = false;
            this.SummonPosition_Z.Location = new System.Drawing.Point(78, 311);
            this.SummonPosition_Z.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SummonPosition_Z.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.SummonPosition_Z.Name = "SummonPosition_Z";
            this.SummonPosition_Z.Size = new System.Drawing.Size(49, 23);
            this.SummonPosition_Z.TabIndex = 80;
            this.toolTip1.SetToolTip(this.SummonPosition_Z, "Depth of summon location in meters\r\nNegative values are in front of the player\r\nP" +
        "ositive values are behind the player");
            this.SummonPosition_Z.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_Z.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // SummonPosition_Angle
            // 
            this.SummonPosition_Angle.DecimalPlaces = 2;
            this.SummonPosition_Angle.Enabled = false;
            this.SummonPosition_Angle.Location = new System.Drawing.Point(78, 340);
            this.SummonPosition_Angle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.SummonPosition_Angle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.SummonPosition_Angle.Name = "SummonPosition_Angle";
            this.SummonPosition_Angle.Size = new System.Drawing.Size(49, 23);
            this.SummonPosition_Angle.TabIndex = 81;
            this.toolTip1.SetToolTip(this.SummonPosition_Angle, "Facing angle of the spirit when summoned\r\nRange of -180 to 180 degrees\r\nNegative " +
        "values face left, Positive values face right\r\n");
            this.SummonPosition_Angle.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_Angle.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // t_console
            // 
            this.t_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.t_console.Location = new System.Drawing.Point(384, 555);
            this.t_console.Name = "t_console";
            this.t_console.ReadOnly = true;
            this.t_console.Size = new System.Drawing.Size(375, 23);
            this.t_console.TabIndex = 24;
            this.t_console.TabStop = false;
            this.t_console.Text = "Awaiting regulation.bin";
            this.t_console.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_Settings,
            this.Menu_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRegulationbinToolStripMenuItem,
            this.b_restoreRegulation,
            this.Button_Execute});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "File";
            // 
            // loadRegulationbinToolStripMenuItem
            // 
            this.loadRegulationbinToolStripMenuItem.Name = "loadRegulationbinToolStripMenuItem";
            this.loadRegulationbinToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadRegulationbinToolStripMenuItem.Text = "Load regulation.bin";
            this.loadRegulationbinToolStripMenuItem.Click += new System.EventHandler(this.b_browse_Click);
            // 
            // b_restoreRegulation
            // 
            this.b_restoreRegulation.Name = "b_restoreRegulation";
            this.b_restoreRegulation.Size = new System.Drawing.Size(177, 22);
            this.b_restoreRegulation.Text = "Restore Backups";
            this.b_restoreRegulation.Click += new System.EventHandler(this.b_restoreRegulation_Click);
            // 
            // Button_Execute
            // 
            this.Button_Execute.Name = "Button_Execute";
            this.Button_Execute.Size = new System.Drawing.Size(177, 22);
            this.Button_Execute.Text = "Save";
            this.Button_Execute.Click += new System.EventHandler(this.Button_Execute_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpiritToolStripMenuItem,
            this.Button_GetDataSelection,
            this.duplicateSpiritToolStripMenuItem,
            this.Button_SetDataSelection,
            this.deleteSpiritToolStripMenuItem,
            this.batchChangesToolStripMenuItem});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.Menu_Edit.Text = "Edit";
            // 
            // addSpiritToolStripMenuItem
            // 
            this.addSpiritToolStripMenuItem.Name = "addSpiritToolStripMenuItem";
            this.addSpiritToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.addSpiritToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addSpiritToolStripMenuItem.Text = "Add Random Spirit";
            this.addSpiritToolStripMenuItem.Click += new System.EventHandler(this.Button_AddRandomEnemy_Click);
            // 
            // Button_GetDataSelection
            // 
            this.Button_GetDataSelection.Name = "Button_GetDataSelection";
            this.Button_GetDataSelection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Button_GetDataSelection.Size = new System.Drawing.Size(209, 22);
            this.Button_GetDataSelection.Text = "Get Spirit Settings";
            this.Button_GetDataSelection.Visible = false;
            this.Button_GetDataSelection.Click += new System.EventHandler(this.Button_GetDataSelection_Click);
            // 
            // duplicateSpiritToolStripMenuItem
            // 
            this.duplicateSpiritToolStripMenuItem.Name = "duplicateSpiritToolStripMenuItem";
            this.duplicateSpiritToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.duplicateSpiritToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.duplicateSpiritToolStripMenuItem.Text = "Duplicate Spirit";
            this.duplicateSpiritToolStripMenuItem.Click += new System.EventHandler(this.Button_DuplicateSpirit_Click);
            // 
            // Button_SetDataSelection
            // 
            this.Button_SetDataSelection.Name = "Button_SetDataSelection";
            this.Button_SetDataSelection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Button_SetDataSelection.Size = new System.Drawing.Size(209, 22);
            this.Button_SetDataSelection.Text = "Update Spirit";
            this.Button_SetDataSelection.Visible = false;
            this.Button_SetDataSelection.Click += new System.EventHandler(this.Button_SetDataSelection_Click);
            // 
            // deleteSpiritToolStripMenuItem
            // 
            this.deleteSpiritToolStripMenuItem.Name = "deleteSpiritToolStripMenuItem";
            this.deleteSpiritToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSpiritToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.deleteSpiritToolStripMenuItem.Text = "Delete Spirit";
            this.deleteSpiritToolStripMenuItem.Click += new System.EventHandler(this.Button_RemoveSpiritFromList_Click);
            // 
            // batchChangesToolStripMenuItem
            // 
            this.batchChangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_RemoveAllSpirits,
            this.Button_ResetTool});
            this.batchChangesToolStripMenuItem.Name = "batchChangesToolStripMenuItem";
            this.batchChangesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.batchChangesToolStripMenuItem.Text = "Batch Changes";
            this.batchChangesToolStripMenuItem.Visible = false;
            // 
            // Button_RemoveAllSpirits
            // 
            this.Button_RemoveAllSpirits.Name = "Button_RemoveAllSpirits";
            this.Button_RemoveAllSpirits.Size = new System.Drawing.Size(166, 22);
            this.Button_RemoveAllSpirits.Text = "Remove all spirits";
            // 
            // Button_ResetTool
            // 
            this.Button_ResetTool.Name = "Button_ResetTool";
            this.Button_ResetTool.Size = new System.Drawing.Size(166, 22);
            this.Button_ResetTool.Text = "Reset to default";
            this.Button_ResetTool.Visible = false;
            // 
            // Menu_Settings
            // 
            this.Menu_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Option_ReduceEnemyMapCol,
            this.Option_HidePlayer});
            this.Menu_Settings.Name = "Menu_Settings";
            this.Menu_Settings.Size = new System.Drawing.Size(61, 20);
            this.Menu_Settings.Text = "Settings";
            // 
            // Option_ReduceEnemyMapCol
            // 
            this.Option_ReduceEnemyMapCol.Name = "Option_ReduceEnemyMapCol";
            this.Option_ReduceEnemyMapCol.Size = new System.Drawing.Size(266, 22);
            this.Option_ReduceEnemyMapCol.Text = "Reduce Enemy Map Collision Radius";
            this.Option_ReduceEnemyMapCol.Click += new System.EventHandler(this.Option_ReduceEnemyMapCol_clicked);
            // 
            // Option_HidePlayer
            // 
            this.Option_HidePlayer.Name = "Option_HidePlayer";
            this.Option_HidePlayer.Size = new System.Drawing.Size(266, 22);
            this.Option_HidePlayer.Text = "Hide Player";
            this.Option_HidePlayer.Visible = false;
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Info,
            this.Button_StatScalingLevelInfo});
            this.Menu_Help.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu_Help.Size = new System.Drawing.Size(44, 20);
            this.Menu_Help.Text = "Help";
            // 
            // Button_Info
            // 
            this.Button_Info.Name = "Button_Info";
            this.Button_Info.Size = new System.Drawing.Size(170, 22);
            this.Button_Info.Text = "How to use";
            this.Button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // Button_StatScalingLevelInfo
            // 
            this.Button_StatScalingLevelInfo.Name = "Button_StatScalingLevelInfo";
            this.Button_StatScalingLevelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_StatScalingLevelInfo.Size = new System.Drawing.Size(170, 22);
            this.Button_StatScalingLevelInfo.Text = "Stat Scaling Levels";
            this.Button_StatScalingLevelInfo.Click += new System.EventHandler(this.Button_StatScalingLevelInfo_Click);
            // 
            // List_Enemy
            // 
            this.List_Enemy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_Enemy.DropDownWidth = 200;
            this.List_Enemy.FormattingEnabled = true;
            this.List_Enemy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.List_Enemy.Location = new System.Drawing.Point(6, 121);
            this.List_Enemy.Name = "List_Enemy";
            this.List_Enemy.Size = new System.Drawing.Size(200, 23);
            this.List_Enemy.TabIndex = 62;
            this.List_Enemy.SelectedIndexChanged += new System.EventHandler(this.List_Enemy_SelectedIndexChanged);
            this.List_Enemy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // Search_Enemy
            // 
            this.Search_Enemy.Location = new System.Drawing.Point(6, 92);
            this.Search_Enemy.Name = "Search_Enemy";
            this.Search_Enemy.Size = new System.Drawing.Size(200, 23);
            this.Search_Enemy.TabIndex = 64;
            this.Search_Enemy.Text = "Search...";
            this.Search_Enemy.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "Phantom Color";
            // 
            // List_TeamPhantomColor
            // 
            this.List_TeamPhantomColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_TeamPhantomColor.FormattingEnabled = true;
            this.List_TeamPhantomColor.Location = new System.Drawing.Point(6, 41);
            this.List_TeamPhantomColor.Name = "List_TeamPhantomColor";
            this.List_TeamPhantomColor.Size = new System.Drawing.Size(157, 23);
            this.List_TeamPhantomColor.TabIndex = 66;
            this.List_TeamPhantomColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Spirit Ash";
            // 
            // List_SpiritAsh
            // 
            this.List_SpiritAsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_SpiritAsh.FormattingEnabled = true;
            this.List_SpiritAsh.Location = new System.Drawing.Point(6, 41);
            this.List_SpiritAsh.Name = "List_SpiritAsh";
            this.List_SpiritAsh.Size = new System.Drawing.Size(174, 23);
            this.List_SpiritAsh.TabIndex = 72;
            this.List_SpiritAsh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // SummonPosition_Auto
            // 
            this.SummonPosition_Auto.AutoSize = true;
            this.SummonPosition_Auto.Checked = true;
            this.SummonPosition_Auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SummonPosition_Auto.Enabled = false;
            this.SummonPosition_Auto.Location = new System.Drawing.Point(784, 187);
            this.SummonPosition_Auto.Name = "SummonPosition_Auto";
            this.SummonPosition_Auto.Size = new System.Drawing.Size(77, 19);
            this.SummonPosition_Auto.TabIndex = 77;
            this.SummonPosition_Auto.Text = "Auto-Dist";
            this.SummonPosition_Auto.UseVisualStyleBackColor = true;
            this.SummonPosition_Auto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Summon Position";
            this.label5.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Width (X)";
            this.label6.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Depth (Z)";
            this.label7.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Angle";
            this.label8.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // SummonPosition_Auto_DistMagnitude
            // 
            this.SummonPosition_Auto_DistMagnitude.DecimalPlaces = 2;
            this.SummonPosition_Auto_DistMagnitude.Enabled = false;
            this.SummonPosition_Auto_DistMagnitude.Location = new System.Drawing.Point(784, 228);
            this.SummonPosition_Auto_DistMagnitude.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SummonPosition_Auto_DistMagnitude.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.SummonPosition_Auto_DistMagnitude.Name = "SummonPosition_Auto_DistMagnitude";
            this.SummonPosition_Auto_DistMagnitude.Size = new System.Drawing.Size(69, 23);
            this.SummonPosition_Auto_DistMagnitude.TabIndex = 83;
            this.SummonPosition_Auto_DistMagnitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SummonPosition_Auto_DistMagnitude.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(773, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Global Auto-Dist Magnitude";
            this.label9.Visible = false;
            // 
            // List_Teams
            // 
            this.List_Teams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_Teams.FormattingEnabled = true;
            this.List_Teams.Location = new System.Drawing.Point(6, 37);
            this.List_Teams.Name = "List_Teams";
            this.List_Teams.Size = new System.Drawing.Size(200, 23);
            this.List_Teams.TabIndex = 85;
            this.List_Teams.SelectedIndexChanged += new System.EventHandler(this.EnemyWasEdited);
            this.List_Teams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // Button_AddNewTeam
            // 
            this.Button_AddNewTeam.Location = new System.Drawing.Point(298, 85);
            this.Button_AddNewTeam.Name = "Button_AddNewTeam";
            this.Button_AddNewTeam.Size = new System.Drawing.Size(69, 23);
            this.Button_AddNewTeam.TabIndex = 87;
            this.Button_AddNewTeam.Text = "Add Team";
            this.Button_AddNewTeam.UseVisualStyleBackColor = true;
            this.Button_AddNewTeam.Click += new System.EventHandler(this.Button_AddNewTeam_Click);
            // 
            // SpiritDataGrid
            // 
            this.SpiritDataGrid.AllowUserToAddRows = false;
            this.SpiritDataGrid.AllowUserToDeleteRows = false;
            this.SpiritDataGrid.AllowUserToResizeRows = false;
            this.SpiritDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpiritDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SpiritDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpiritDataGrid.ContextMenuStrip = this.Context_DataGrid;
            this.SpiritDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SpiritDataGrid.Location = new System.Drawing.Point(6, 22);
            this.SpiritDataGrid.MultiSelect = false;
            this.SpiritDataGrid.Name = "SpiritDataGrid";
            this.SpiritDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SpiritDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SpiritDataGrid.RowHeadersVisible = false;
            this.SpiritDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.SpiritDataGrid.RowTemplate.Height = 25;
            this.SpiritDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpiritDataGrid.ShowCellToolTips = false;
            this.SpiritDataGrid.Size = new System.Drawing.Size(354, 495);
            this.SpiritDataGrid.TabIndex = 90;
            this.SpiritDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpiritDataGrid_CellClick);
            this.SpiritDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SpiritDataGrid_CellMouseDown);
            // 
            // Context_DataGrid
            // 
            this.Context_DataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Context_GetSpirit,
            this.Button_Context_DuplicateSpirit,
            this.Button_Context_RemoveSpirit,
            this.Button_Context_UpdateSpirit});
            this.Context_DataGrid.Name = "Context_DataGrid";
            this.Context_DataGrid.Size = new System.Drawing.Size(210, 92);
            // 
            // Button_Context_GetSpirit
            // 
            this.Button_Context_GetSpirit.Name = "Button_Context_GetSpirit";
            this.Button_Context_GetSpirit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Button_Context_GetSpirit.Size = new System.Drawing.Size(209, 22);
            this.Button_Context_GetSpirit.Text = "Get Spirit Settings";
            this.Button_Context_GetSpirit.Visible = false;
            this.Button_Context_GetSpirit.Click += new System.EventHandler(this.Button_GetDataSelection_Click);
            // 
            // Button_Context_DuplicateSpirit
            // 
            this.Button_Context_DuplicateSpirit.Name = "Button_Context_DuplicateSpirit";
            this.Button_Context_DuplicateSpirit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Button_Context_DuplicateSpirit.Size = new System.Drawing.Size(209, 22);
            this.Button_Context_DuplicateSpirit.Text = "Duplicate Spirit";
            this.Button_Context_DuplicateSpirit.Click += new System.EventHandler(this.Button_DuplicateSpirit_Click);
            // 
            // Button_Context_RemoveSpirit
            // 
            this.Button_Context_RemoveSpirit.Name = "Button_Context_RemoveSpirit";
            this.Button_Context_RemoveSpirit.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Button_Context_RemoveSpirit.Size = new System.Drawing.Size(209, 22);
            this.Button_Context_RemoveSpirit.Text = "Remove Spirit";
            this.Button_Context_RemoveSpirit.Click += new System.EventHandler(this.Button_RemoveSpiritFromList_Click);
            // 
            // Button_Context_UpdateSpirit
            // 
            this.Button_Context_UpdateSpirit.Name = "Button_Context_UpdateSpirit";
            this.Button_Context_UpdateSpirit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Button_Context_UpdateSpirit.Size = new System.Drawing.Size(209, 22);
            this.Button_Context_UpdateSpirit.Text = "Update Spirit";
            this.Button_Context_UpdateSpirit.Visible = false;
            this.Button_Context_UpdateSpirit.Click += new System.EventHandler(this.Button_SetDataSelection_Click);
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            // 
            // EnemyCol
            // 
            this.EnemyCol.HeaderText = "Enemy";
            this.EnemyCol.Name = "EnemyCol";
            // 
            // Variant
            // 
            this.Variant.HeaderText = "Variant";
            this.Variant.Name = "Variant";
            // 
            // Input_NpcParamID
            // 
            this.Input_NpcParamID.Enabled = false;
            this.Input_NpcParamID.Location = new System.Drawing.Point(212, 166);
            this.Input_NpcParamID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Input_NpcParamID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Input_NpcParamID.Name = "Input_NpcParamID";
            this.Input_NpcParamID.Size = new System.Drawing.Size(77, 23);
            this.Input_NpcParamID.TabIndex = 92;
            this.Input_NpcParamID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Input_NpcParamID.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.Input_NpcParamID.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Input_NpcThinkID
            // 
            this.Input_NpcThinkID.Enabled = false;
            this.Input_NpcThinkID.Location = new System.Drawing.Point(295, 166);
            this.Input_NpcThinkID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Input_NpcThinkID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Input_NpcThinkID.Name = "Input_NpcThinkID";
            this.Input_NpcThinkID.Size = new System.Drawing.Size(72, 23);
            this.Input_NpcThinkID.TabIndex = 93;
            this.Input_NpcThinkID.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Input_NpcThinkID.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.Input_NpcThinkID.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 94;
            this.label3.Text = "NpcParam ID";
            this.label3.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 95;
            this.label11.Text = "NpcThink ID";
            this.label11.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_StatScaling
            // 
            this.List_StatScaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_StatScaling.FormattingEnabled = true;
            this.List_StatScaling.Location = new System.Drawing.Point(6, 229);
            this.List_StatScaling.Name = "List_StatScaling";
            this.List_StatScaling.Size = new System.Drawing.Size(121, 23);
            this.List_StatScaling.TabIndex = 98;
            this.List_StatScaling.SelectedIndexChanged += new System.EventHandler(this.EnemyWasEdited);
            this.List_StatScaling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 99;
            this.label13.Text = "Stat Scaling Level";
            this.label13.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Input_EnemyHpMult
            // 
            this.Input_EnemyHpMult.DecimalPlaces = 2;
            this.Input_EnemyHpMult.Location = new System.Drawing.Point(170, 229);
            this.Input_EnemyHpMult.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Input_EnemyHpMult.Name = "Input_EnemyHpMult";
            this.Input_EnemyHpMult.Size = new System.Drawing.Size(75, 23);
            this.Input_EnemyHpMult.TabIndex = 100;
            this.Input_EnemyHpMult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Input_EnemyHpMult.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.Input_EnemyHpMult.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(158, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 101;
            this.label14.Text = "Bonus HP Mult";
            this.label14.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(254, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 15);
            this.label15.TabIndex = 103;
            this.label15.Text = "Bonus Damage Mult";
            this.label15.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Input_EnemyDamageMult
            // 
            this.Input_EnemyDamageMult.DecimalPlaces = 2;
            this.Input_EnemyDamageMult.Location = new System.Drawing.Point(264, 229);
            this.Input_EnemyDamageMult.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Input_EnemyDamageMult.Name = "Input_EnemyDamageMult";
            this.Input_EnemyDamageMult.Size = new System.Drawing.Size(76, 23);
            this.Input_EnemyDamageMult.TabIndex = 102;
            this.Input_EnemyDamageMult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Input_EnemyDamageMult.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.Input_EnemyDamageMult.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_EnemyVariant
            // 
            this.List_EnemyVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_EnemyVariant.DropDownWidth = 200;
            this.List_EnemyVariant.FormattingEnabled = true;
            this.List_EnemyVariant.Location = new System.Drawing.Point(6, 165);
            this.List_EnemyVariant.Name = "List_EnemyVariant";
            this.List_EnemyVariant.Size = new System.Drawing.Size(200, 23);
            this.List_EnemyVariant.TabIndex = 104;
            this.List_EnemyVariant.SelectedIndexChanged += new System.EventHandler(this.EnemyWasEdited);
            this.List_EnemyVariant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(11, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 105;
            this.label16.Text = "Enemy Variant";
            this.label16.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_TeamType
            // 
            this.List_TeamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_TeamType.FormattingEnabled = true;
            this.List_TeamType.Location = new System.Drawing.Point(169, 41);
            this.List_TeamType.Name = "List_TeamType";
            this.List_TeamType.Size = new System.Drawing.Size(198, 23);
            this.List_TeamType.TabIndex = 107;
            this.List_TeamType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 15);
            this.label17.TabIndex = 106;
            this.label17.Text = "Team Type";
            // 
            // Input_TeamName
            // 
            this.Input_TeamName.Location = new System.Drawing.Point(6, 85);
            this.Input_TeamName.Name = "Input_TeamName";
            this.Input_TeamName.Size = new System.Drawing.Size(157, 23);
            this.Input_TeamName.TabIndex = 108;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 109;
            this.label18.Text = "Team Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 110;
            this.label19.Text = "Team";
            this.label19.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(11, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 15);
            this.label20.TabIndex = 111;
            this.label20.Text = "Base Enemy";
            this.label20.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Option_SpiritAshNoRequirements);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.List_SpiritAsh);
            this.groupBox1.Location = new System.Drawing.Point(765, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 117);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Targeted Spirit Ash";
            // 
            // Option_SpiritAshNoRequirements
            // 
            this.Option_SpiritAshNoRequirements.AutoSize = true;
            this.Option_SpiritAshNoRequirements.Checked = true;
            this.Option_SpiritAshNoRequirements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option_SpiritAshNoRequirements.Location = new System.Drawing.Point(15, 70);
            this.Option_SpiritAshNoRequirements.Name = "Option_SpiritAshNoRequirements";
            this.Option_SpiritAshNoRequirements.Size = new System.Drawing.Size(155, 19);
            this.Option_SpiritAshNoRequirements.TabIndex = 75;
            this.Option_SpiritAshNoRequirements.Text = "No HP/FP Consumption";
            this.Option_SpiritAshNoRequirements.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Button_PickRandomEnemy);
            this.groupBox2.Controls.Add(this.List_Enemy);
            this.groupBox2.Controls.Add(this.SummonPosition_X);
            this.groupBox2.Controls.Add(this.Search_Enemy);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SummonPosition_Z);
            this.groupBox2.Controls.Add(this.SummonPosition_Angle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.List_EnemyVariant);
            this.groupBox2.Controls.Add(this.List_Teams);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Input_NpcParamID);
            this.groupBox2.Controls.Add(this.Input_EnemyDamageMult);
            this.groupBox2.Controls.Add(this.Input_NpcThinkID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Input_EnemyHpMult);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.List_StatScaling);
            this.groupBox2.Location = new System.Drawing.Point(384, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 373);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spirit";
            // 
            // Button_PickRandomEnemy
            // 
            this.Button_PickRandomEnemy.Location = new System.Drawing.Point(212, 121);
            this.Button_PickRandomEnemy.Name = "Button_PickRandomEnemy";
            this.Button_PickRandomEnemy.Size = new System.Drawing.Size(77, 23);
            this.Button_PickRandomEnemy.TabIndex = 111;
            this.Button_PickRandomEnemy.Text = "Randomize";
            this.Button_PickRandomEnemy.UseVisualStyleBackColor = true;
            this.Button_PickRandomEnemy.Click += new System.EventHandler(this.Button_PickRandomEnemy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Button_RandomTeamName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.List_TeamPhantomColor);
            this.groupBox3.Controls.Add(this.Button_AddNewTeam);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.Input_TeamName);
            this.groupBox3.Controls.Add(this.List_TeamType);
            this.groupBox3.Location = new System.Drawing.Point(384, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 117);
            this.groupBox3.TabIndex = 114;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teams";
            // 
            // Button_RandomTeamName
            // 
            this.Button_RandomTeamName.Location = new System.Drawing.Point(169, 85);
            this.Button_RandomTeamName.Name = "Button_RandomTeamName";
            this.Button_RandomTeamName.Size = new System.Drawing.Size(66, 23);
            this.Button_RandomTeamName.TabIndex = 110;
            this.Button_RandomTeamName.Text = "Random";
            this.Button_RandomTeamName.UseVisualStyleBackColor = true;
            this.Button_RandomTeamName.Click += new System.EventHandler(this.Button_RandomTeamName_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Button_AddRandomSpirit);
            this.groupBox4.Controls.Add(this.SpiritDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 552);
            this.groupBox4.TabIndex = 115;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summons";
            // 
            // Button_AddRandomSpirit
            // 
            this.Button_AddRandomSpirit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddRandomSpirit.Location = new System.Drawing.Point(233, 523);
            this.Button_AddRandomSpirit.Name = "Button_AddRandomSpirit";
            this.Button_AddRandomSpirit.Size = new System.Drawing.Size(127, 23);
            this.Button_AddRandomSpirit.TabIndex = 112;
            this.Button_AddRandomSpirit.Text = "Add Random Spirit";
            this.Button_AddRandomSpirit.UseVisualStyleBackColor = true;
            this.Button_AddRandomSpirit.Click += new System.EventHandler(this.Button_AddRandomEnemy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 591);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.t_console);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SummonPosition_Auto_DistMagnitude);
            this.Controls.Add(this.SummonPosition_Auto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Elden Ring Spirit Battler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Angle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Auto_DistMagnitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpiritDataGrid)).EndInit();
            this.Context_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcParamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcThinkID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyHpMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyDamageMult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private TextBox t_console;
        private ToolStripMenuItem playgroundToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu_File;
        private ToolStripMenuItem loadRegulationbinToolStripMenuItem;
        private ToolStripMenuItem b_restoreRegulation;
        private ToolStripMenuItem Menu_Help;
        private ComboBox List_Enemy;
        private Button Button_InsertEnemy;
        private TextBox Search_Enemy;
        private Label label1;
        private ComboBox List_TeamPhantomColor;
        private Label label4;
        private ComboBox List_SpiritAsh;
        private CheckBox SummonPosition_Auto;
        private Label label5;
        private NumericUpDown SummonPosition_X;
        private Label label6;
        private Label label7;
        private NumericUpDown SummonPosition_Z;
        private NumericUpDown SummonPosition_Angle;
        private Label label8;
        private NumericUpDown SummonPosition_Auto_DistMagnitude;
        private Label label9;
        private ComboBox List_Teams;
        private Button Button_AddNewTeam;
        private DataGridView SpiritDataGrid;
        private DataGridViewComboBoxColumn Team;
        private DataGridViewComboBoxColumn EnemyCol;
        private DataGridViewComboBoxColumn Variant;
        private Button Button_RemoveSpiritFromList;
        private NumericUpDown Input_NpcParamID;
        private NumericUpDown Input_NpcThinkID;
        private Label label3;
        private Label label11;
        private ToolStripMenuItem Menu_Edit;
        private ComboBox List_StatScaling;
        private Label label13;
        private NumericUpDown Input_EnemyHpMult;
        private Label label14;
        private Label label15;
        private NumericUpDown Input_EnemyDamageMult;
        private ToolStripMenuItem Menu_Settings;
        private ToolStripMenuItem Option_ReduceEnemyMapCol;
        private ToolStripMenuItem Option_HidePlayer;
        private ToolStripMenuItem Button_Execute;
        private ComboBox List_EnemyVariant;
        private Label label16;
        private ComboBox List_TeamType;
        private Label label17;
        private TextBox Input_TeamName;
        private Label label18;
        private Label label19;
        private Label label20;
        private ToolStripMenuItem batchChangesToolStripMenuItem;
        private ToolStripMenuItem Button_RemoveAllSpirits;
        private ToolStripMenuItem Button_ResetTool;
        private ToolStripMenuItem Button_GetDataSelection;
        private ToolStripMenuItem Button_SetDataSelection;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button Button_RandomTeamName;
        private ToolStripMenuItem Button_Info;
        private ToolStripMenuItem Button_StatScalingLevelInfo;
        private ContextMenuStrip Context_DataGrid;
        private ToolStripMenuItem Button_Context_GetSpirit;
        private ToolStripMenuItem Button_Context_UpdateSpirit;
        private ToolStripMenuItem Button_Context_RemoveSpirit;
        private ToolStripMenuItem Button_Context_DuplicateSpirit;
        private ToolStripMenuItem duplicateSpiritToolStripMenuItem;
        private ToolStripMenuItem deleteSpiritToolStripMenuItem;
        private ToolStripMenuItem addSpiritToolStripMenuItem;
        private Button Button_PickRandomEnemy;
        private Button Button_AddRandomSpirit;
        private CheckBox Option_SpiritAshNoRequirements;
    }
}