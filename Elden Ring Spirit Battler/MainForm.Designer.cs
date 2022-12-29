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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SummonPosition_X = new System.Windows.Forms.NumericUpDown();
            this.SummonPosition_Z = new System.Windows.Forms.NumericUpDown();
            this.SummonPosition_Angle = new System.Windows.Forms.NumericUpDown();
            this.Input_TeamSummonPos_X = new System.Windows.Forms.NumericUpDown();
            this.Input_TeamSummonPos_Z = new System.Windows.Forms.NumericUpDown();
            this.Input_TeamSummonPos_Ang = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.List_Enemy = new System.Windows.Forms.ComboBox();
            this.Search_Enemy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.List_TeamPhantomColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Button_AddNewTeam = new System.Windows.Forms.Button();
            this.Input_NpcParamID = new System.Windows.Forms.NumericUpDown();
            this.Input_NpcThinkID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.List_StatScaling = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.List_EnemyVariant = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.List_TeamType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Input_TeamName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Label_SearchText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.List_EnemyChosenTeam = new System.Windows.Forms.ComboBox();
            this.Button_PickRandomEnemy = new System.Windows.Forms.Button();
            this.List_TeamSummonPreset = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Input_TeamDamageMult = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.Input_TeamHpMult = new System.Windows.Forms.NumericUpDown();
            this.Button_AddRandomSpirit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.List_SpiritAsh = new System.Windows.Forms.ComboBox();
            this.Option_SpiritAshNoRequirements = new System.Windows.Forms.CheckBox();
            this.t_console = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRegulationbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_restoreRegulation = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Execute = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpiritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Menu_DuplicateTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSpiritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Menu_DeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_DeleteSpiritFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.batchChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_RemoveAllSpirits = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_ResetTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_ReduceEnemyMapCol = new System.Windows.Forms.ToolStripMenuItem();
            this.Option_HidePlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_StatScalingLevelInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.SpiritDataGrid = new System.Windows.Forms.DataGridView();
            this.Context_DataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Button_Context_DuplicateSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Context_RemoveSpirit = new System.Windows.Forms.ToolStripMenuItem();
            this.Team = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EnemyCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Variant = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Input_EnemyHpMult = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Input_EnemyDamageMult = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Option_TargetAllSpiritAshes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Option_Randomize_PhantomColor = new System.Windows.Forms.Button();
            this.Group_TeamSummonPos_Manual = new System.Windows.Forms.GroupBox();
            this.Button_RandomTeamName = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TeamDataGrid = new System.Windows.Forms.DataGridView();
            this.Context_TeamDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Button_Context_DuplicateTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Context_DeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxRandomize = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Button_Randomize_SvE = new System.Windows.Forms.Button();
            this.Button_Randomize_PvE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_Ang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcParamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcThinkID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamDamageMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamHpMult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpiritDataGrid)).BeginInit();
            this.Context_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyHpMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyDamageMult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Group_TeamSummonPos_Manual.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGrid)).BeginInit();
            this.Context_TeamDataGrid.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxRandomize.SuspendLayout();
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
            this.SummonPosition_X.DecimalPlaces = 1;
            this.SummonPosition_X.Location = new System.Drawing.Point(78, 276);
            this.SummonPosition_X.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SummonPosition_X.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.SummonPosition_X.Name = "SummonPosition_X";
            this.SummonPosition_X.Size = new System.Drawing.Size(57, 23);
            this.SummonPosition_X.TabIndex = 75;
            this.toolTip1.SetToolTip(this.SummonPosition_X, "Left/Right position of summon location in meters");
            this.SummonPosition_X.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_X.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // SummonPosition_Z
            // 
            this.SummonPosition_Z.DecimalPlaces = 1;
            this.SummonPosition_Z.Location = new System.Drawing.Point(78, 305);
            this.SummonPosition_Z.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SummonPosition_Z.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.SummonPosition_Z.Name = "SummonPosition_Z";
            this.SummonPosition_Z.Size = new System.Drawing.Size(57, 23);
            this.SummonPosition_Z.TabIndex = 80;
            this.toolTip1.SetToolTip(this.SummonPosition_Z, "Depth of summon location in meters");
            this.SummonPosition_Z.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_Z.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // SummonPosition_Angle
            // 
            this.SummonPosition_Angle.DecimalPlaces = 1;
            this.SummonPosition_Angle.Location = new System.Drawing.Point(78, 334);
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
            this.SummonPosition_Angle.Size = new System.Drawing.Size(57, 23);
            this.SummonPosition_Angle.TabIndex = 81;
            this.toolTip1.SetToolTip(this.SummonPosition_Angle, "Facing angle of the spirit when summoned");
            this.SummonPosition_Angle.Visible = false;
            this.SummonPosition_Angle.ValueChanged += new System.EventHandler(this.EnemyWasEdited);
            this.SummonPosition_Angle.Click += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Input_TeamSummonPos_X
            // 
            this.Input_TeamSummonPos_X.DecimalPlaces = 1;
            this.Input_TeamSummonPos_X.Location = new System.Drawing.Point(67, 56);
            this.Input_TeamSummonPos_X.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Input_TeamSummonPos_X.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.Input_TeamSummonPos_X.Name = "Input_TeamSummonPos_X";
            this.Input_TeamSummonPos_X.Size = new System.Drawing.Size(59, 23);
            this.Input_TeamSummonPos_X.TabIndex = 9;
            this.toolTip1.SetToolTip(this.Input_TeamSummonPos_X, "Left/Right position of summon location in meters");
            // 
            // Input_TeamSummonPos_Z
            // 
            this.Input_TeamSummonPos_Z.DecimalPlaces = 1;
            this.Input_TeamSummonPos_Z.Location = new System.Drawing.Point(67, 85);
            this.Input_TeamSummonPos_Z.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Input_TeamSummonPos_Z.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.Input_TeamSummonPos_Z.Name = "Input_TeamSummonPos_Z";
            this.Input_TeamSummonPos_Z.Size = new System.Drawing.Size(59, 23);
            this.Input_TeamSummonPos_Z.TabIndex = 10;
            this.toolTip1.SetToolTip(this.Input_TeamSummonPos_Z, "Depth of summon location in meters");
            // 
            // Input_TeamSummonPos_Ang
            // 
            this.Input_TeamSummonPos_Ang.DecimalPlaces = 1;
            this.Input_TeamSummonPos_Ang.Location = new System.Drawing.Point(67, 114);
            this.Input_TeamSummonPos_Ang.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Input_TeamSummonPos_Ang.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.Input_TeamSummonPos_Ang.Name = "Input_TeamSummonPos_Ang";
            this.Input_TeamSummonPos_Ang.Size = new System.Drawing.Size(59, 23);
            this.Input_TeamSummonPos_Ang.TabIndex = 11;
            this.toolTip1.SetToolTip(this.Input_TeamSummonPos_Ang, "Facing angle of the spirit when summoned");
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 104);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 23);
            this.numericUpDown1.TabIndex = 121;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Facing angle of the spirit when summoned\r\nRange of -180 to 180 degrees\r\nNegative " +
        "values face left, Positive values face right\r\n");
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // List_Enemy
            // 
            this.List_Enemy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_Enemy.DropDownWidth = 200;
            this.List_Enemy.FormattingEnabled = true;
            this.List_Enemy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.List_Enemy.Location = new System.Drawing.Point(6, 115);
            this.List_Enemy.Name = "List_Enemy";
            this.List_Enemy.Size = new System.Drawing.Size(200, 23);
            this.List_Enemy.TabIndex = 62;
            this.toolTip1.SetToolTip(this.List_Enemy, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact " +
        "enemy details is determined by Enemy Variant.");
            this.List_Enemy.SelectedIndexChanged += new System.EventHandler(this.List_Enemy_SelectedIndexChanged);
            this.List_Enemy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // Search_Enemy
            // 
            this.Search_Enemy.Location = new System.Drawing.Point(6, 86);
            this.Search_Enemy.Name = "Search_Enemy";
            this.Search_Enemy.Size = new System.Drawing.Size(200, 23);
            this.Search_Enemy.TabIndex = 10;
            this.toolTip1.SetToolTip(this.Search_Enemy, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact " +
        "enemy details is determined by Enemy Variant.");
            this.Search_Enemy.Click += new System.EventHandler(this.Search_Enemy_Click);
            this.Search_Enemy.TextChanged += new System.EventHandler(this.Search_Enemy_TextChanged);
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
            this.toolTip1.SetToolTip(this.label1, "Phantom color and other shader attributes given to members of this team\r\n");
            // 
            // List_TeamPhantomColor
            // 
            this.List_TeamPhantomColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_TeamPhantomColor.FormattingEnabled = true;
            this.List_TeamPhantomColor.Location = new System.Drawing.Point(6, 41);
            this.List_TeamPhantomColor.Name = "List_TeamPhantomColor";
            this.List_TeamPhantomColor.Size = new System.Drawing.Size(129, 23);
            this.List_TeamPhantomColor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.List_TeamPhantomColor, "Phantom color and other shader attributes given to members of this team\r\n");
            this.List_TeamPhantomColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Width (X)";
            this.toolTip1.SetToolTip(this.label6, "Left/Right position of summon location in meters");
            this.label6.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Depth (Z)";
            this.toolTip1.SetToolTip(this.label7, "Depth of summon location in meters");
            this.label7.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Angle";
            this.toolTip1.SetToolTip(this.label8, "Facing angle of the spirit when summoned");
            this.label8.Visible = false;
            this.label8.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Button_AddNewTeam
            // 
            this.Button_AddNewTeam.Location = new System.Drawing.Point(6, 114);
            this.Button_AddNewTeam.Name = "Button_AddNewTeam";
            this.Button_AddNewTeam.Size = new System.Drawing.Size(116, 23);
            this.Button_AddNewTeam.TabIndex = 5;
            this.Button_AddNewTeam.Text = "Add/Update Team";
            this.toolTip1.SetToolTip(this.Button_AddNewTeam, "Updates a team\'s settings if Team Name exists in list.\r\nAdds a new team otherwise" +
        ".");
            this.Button_AddNewTeam.UseVisualStyleBackColor = true;
            this.Button_AddNewTeam.Click += new System.EventHandler(this.Button_AddUpdateTeam_Click);
            // 
            // Input_NpcParamID
            // 
            this.Input_NpcParamID.Enabled = false;
            this.Input_NpcParamID.Location = new System.Drawing.Point(212, 160);
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
            this.toolTip1.SetToolTip(this.Input_NpcParamID, "NpcParam ID used by this enemy variant");
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
            this.Input_NpcThinkID.Location = new System.Drawing.Point(295, 160);
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
            this.toolTip1.SetToolTip(this.Input_NpcThinkID, "NpcThinkParam ID used by this enemy variant");
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
            this.label3.Location = new System.Drawing.Point(212, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 94;
            this.label3.Text = "NpcParam ID";
            this.toolTip1.SetToolTip(this.label3, "NpcParam ID used by this enemy variant");
            this.label3.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 95;
            this.label11.Text = "NpcThink ID";
            this.toolTip1.SetToolTip(this.label11, "NpcThinkParam ID used by this enemy variant");
            this.label11.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_StatScaling
            // 
            this.List_StatScaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_StatScaling.FormattingEnabled = true;
            this.List_StatScaling.Location = new System.Drawing.Point(6, 223);
            this.List_StatScaling.Name = "List_StatScaling";
            this.List_StatScaling.Size = new System.Drawing.Size(129, 23);
            this.List_StatScaling.TabIndex = 98;
            this.toolTip1.SetToolTip(this.List_StatScaling, resources.GetString("List_StatScaling.ToolTip"));
            this.List_StatScaling.SelectedIndexChanged += new System.EventHandler(this.EnemyWasEdited);
            this.List_StatScaling.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(11, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 15);
            this.label13.TabIndex = 99;
            this.label13.Text = "Stat Scaling Level";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            this.label13.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_EnemyVariant
            // 
            this.List_EnemyVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_EnemyVariant.DropDownWidth = 200;
            this.List_EnemyVariant.FormattingEnabled = true;
            this.List_EnemyVariant.Location = new System.Drawing.Point(6, 159);
            this.List_EnemyVariant.Name = "List_EnemyVariant";
            this.List_EnemyVariant.Size = new System.Drawing.Size(200, 23);
            this.List_EnemyVariant.TabIndex = 104;
            this.toolTip1.SetToolTip(this.List_EnemyVariant, "Specific enemy variant this summon will be, generated from EnemyInfoResource.txt");
            this.List_EnemyVariant.SelectedIndexChanged += new System.EventHandler(this.List_EnemyVariant_SelectedIndexChanged);
            this.List_EnemyVariant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(11, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 105;
            this.label16.Text = "Enemy Variant";
            this.toolTip1.SetToolTip(this.label16, "Specific enemy variant this summon will be, generated from EnemyInfoResource.txt");
            this.label16.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // List_TeamType
            // 
            this.List_TeamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_TeamType.FormattingEnabled = true;
            this.List_TeamType.Location = new System.Drawing.Point(169, 41);
            this.List_TeamType.Name = "List_TeamType";
            this.List_TeamType.Size = new System.Drawing.Size(131, 23);
            this.List_TeamType.TabIndex = 2;
            this.toolTip1.SetToolTip(this.List_TeamType, "Determines who members of this team hate, can hurt, hated by, and can be hurt by " +
        "(all mutually exclusive)");
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
            this.toolTip1.SetToolTip(this.label17, "Determines who members of this team hate, can hurt, hated by, and can be hurt by " +
        "(all mutually exclusive)\r\n");
            // 
            // Input_TeamName
            // 
            this.Input_TeamName.Location = new System.Drawing.Point(6, 85);
            this.Input_TeamName.Name = "Input_TeamName";
            this.Input_TeamName.Size = new System.Drawing.Size(157, 23);
            this.Input_TeamName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Input_TeamName, "Purely for in-tool organization (at the moment)");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(11, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 15);
            this.label20.TabIndex = 111;
            this.label20.Text = "Base Enemy";
            this.toolTip1.SetToolTip(this.label20, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact " +
        "enemy details is determined by Enemy Variant.");
            this.label20.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Label_SearchText
            // 
            this.Label_SearchText.AutoSize = true;
            this.Label_SearchText.BackColor = System.Drawing.SystemColors.Window;
            this.Label_SearchText.CausesValidation = false;
            this.Label_SearchText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_SearchText.Location = new System.Drawing.Point(11, 89);
            this.Label_SearchText.Name = "Label_SearchText";
            this.Label_SearchText.Size = new System.Drawing.Size(51, 15);
            this.Label_SearchText.TabIndex = 0;
            this.Label_SearchText.Text = "Search...";
            this.toolTip1.SetToolTip(this.Label_SearchText, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact " +
        "enemy details is determined by Enemy Variant.");
            this.Label_SearchText.Click += new System.EventHandler(this.Label_SearchText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 113;
            this.label2.Text = "Team";
            this.toolTip1.SetToolTip(this.label2, "Which team this enemy belongs to");
            // 
            // List_EnemyChosenTeam
            // 
            this.List_EnemyChosenTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_EnemyChosenTeam.DropDownWidth = 200;
            this.List_EnemyChosenTeam.FormattingEnabled = true;
            this.List_EnemyChosenTeam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.List_EnemyChosenTeam.Location = new System.Drawing.Point(6, 42);
            this.List_EnemyChosenTeam.Name = "List_EnemyChosenTeam";
            this.List_EnemyChosenTeam.Size = new System.Drawing.Size(157, 23);
            this.List_EnemyChosenTeam.TabIndex = 20;
            this.toolTip1.SetToolTip(this.List_EnemyChosenTeam, "Which team this enemy belongs to");
            this.List_EnemyChosenTeam.SelectedIndexChanged += new System.EventHandler(this.List_EnemyChosenTeam_SelectedIndexChanged);
            this.List_EnemyChosenTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // Button_PickRandomEnemy
            // 
            this.Button_PickRandomEnemy.Location = new System.Drawing.Point(212, 115);
            this.Button_PickRandomEnemy.Name = "Button_PickRandomEnemy";
            this.Button_PickRandomEnemy.Size = new System.Drawing.Size(19, 23);
            this.Button_PickRandomEnemy.TabIndex = 111;
            this.Button_PickRandomEnemy.Text = "?";
            this.toolTip1.SetToolTip(this.Button_PickRandomEnemy, "Picks a random Enemy Variant");
            this.Button_PickRandomEnemy.UseVisualStyleBackColor = true;
            this.Button_PickRandomEnemy.Click += new System.EventHandler(this.Button_PickRandomEnemy_Click);
            // 
            // List_TeamSummonPreset
            // 
            this.List_TeamSummonPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_TeamSummonPreset.DropDownWidth = 100;
            this.List_TeamSummonPreset.FormattingEnabled = true;
            this.List_TeamSummonPreset.Location = new System.Drawing.Point(6, 27);
            this.List_TeamSummonPreset.Name = "List_TeamSummonPreset";
            this.List_TeamSummonPreset.Size = new System.Drawing.Size(131, 23);
            this.List_TeamSummonPreset.TabIndex = 8;
            this.toolTip1.SetToolTip(this.List_TeamSummonPreset, "Summon positon presets\r\nNon-manual automatically offset and increment position fo" +
        "r each additional enemy");
            this.List_TeamSummonPreset.SelectedIndexChanged += new System.EventHandler(this.List_TeamSummonPreset_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 15);
            this.label21.TabIndex = 116;
            this.label21.Text = "Width (X)";
            this.toolTip1.SetToolTip(this.label21, "Left/Right position of summon location in meters");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 15);
            this.label22.TabIndex = 117;
            this.label22.Text = "Depth (Z)";
            this.toolTip1.SetToolTip(this.label22, "Depth of summon location in meters");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 15);
            this.label23.TabIndex = 119;
            this.label23.Text = "Angle";
            this.toolTip1.SetToolTip(this.label23, "Facing angle of the spirit when summoned");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(298, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 114;
            this.label10.Text = "Team Damage Mult";
            this.toolTip1.SetToolTip(this.label10, "Damage Multiplier applied to members of team");
            // 
            // Input_TeamDamageMult
            // 
            this.Input_TeamDamageMult.DecimalPlaces = 2;
            this.Input_TeamDamageMult.Location = new System.Drawing.Point(312, 109);
            this.Input_TeamDamageMult.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Input_TeamDamageMult.Name = "Input_TeamDamageMult";
            this.Input_TeamDamageMult.Size = new System.Drawing.Size(61, 23);
            this.Input_TeamDamageMult.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Input_TeamDamageMult, "Damage Multiplier applied to members of team");
            this.Input_TeamDamageMult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(305, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 112;
            this.label12.Text = "Team HP Mult";
            this.toolTip1.SetToolTip(this.label12, "HP Multiplier applied to members of team");
            // 
            // Input_TeamHpMult
            // 
            this.Input_TeamHpMult.DecimalPlaces = 2;
            this.Input_TeamHpMult.Location = new System.Drawing.Point(312, 65);
            this.Input_TeamHpMult.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Input_TeamHpMult.Name = "Input_TeamHpMult";
            this.Input_TeamHpMult.Size = new System.Drawing.Size(61, 23);
            this.Input_TeamHpMult.TabIndex = 6;
            this.toolTip1.SetToolTip(this.Input_TeamHpMult, "HP Multiplier applied to members of team");
            this.Input_TeamHpMult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Button_AddRandomSpirit
            // 
            this.Button_AddRandomSpirit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddRandomSpirit.Location = new System.Drawing.Point(449, 332);
            this.Button_AddRandomSpirit.Name = "Button_AddRandomSpirit";
            this.Button_AddRandomSpirit.Size = new System.Drawing.Size(127, 23);
            this.Button_AddRandomSpirit.TabIndex = 112;
            this.Button_AddRandomSpirit.Text = "Add Random Spirit";
            this.toolTip1.SetToolTip(this.Button_AddRandomSpirit, "Duplicates selected summon and randomizes Enemy Variant");
            this.Button_AddRandomSpirit.UseVisualStyleBackColor = true;
            this.Button_AddRandomSpirit.Click += new System.EventHandler(this.Button_AddRandomEnemy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Spirit Ash";
            this.toolTip1.SetToolTip(this.label4, "Which spirit ash item will be overwritten with new summon data");
            // 
            // List_SpiritAsh
            // 
            this.List_SpiritAsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.List_SpiritAsh.FormattingEnabled = true;
            this.List_SpiritAsh.Location = new System.Drawing.Point(6, 41);
            this.List_SpiritAsh.Name = "List_SpiritAsh";
            this.List_SpiritAsh.Size = new System.Drawing.Size(174, 23);
            this.List_SpiritAsh.TabIndex = 72;
            this.toolTip1.SetToolTip(this.List_SpiritAsh, "Which spirit ash item will be overwritten with new summon data");
            this.List_SpiritAsh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyPress);
            // 
            // Option_SpiritAshNoRequirements
            // 
            this.Option_SpiritAshNoRequirements.AutoSize = true;
            this.Option_SpiritAshNoRequirements.Checked = true;
            this.Option_SpiritAshNoRequirements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option_SpiritAshNoRequirements.Location = new System.Drawing.Point(6, 70);
            this.Option_SpiritAshNoRequirements.Name = "Option_SpiritAshNoRequirements";
            this.Option_SpiritAshNoRequirements.Size = new System.Drawing.Size(155, 19);
            this.Option_SpiritAshNoRequirements.TabIndex = 75;
            this.Option_SpiritAshNoRequirements.Text = "No HP/FP Consumption";
            this.toolTip1.SetToolTip(this.Option_SpiritAshNoRequirements, "Whether the Spirit ash will consume zero HP and FP");
            this.Option_SpiritAshNoRequirements.UseVisualStyleBackColor = true;
            // 
            // t_console
            // 
            this.t_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t_console.Location = new System.Drawing.Point(595, 550);
            this.t_console.Name = "t_console";
            this.t_console.ReadOnly = true;
            this.t_console.Size = new System.Drawing.Size(376, 23);
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
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
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
            this.Button_Execute.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Button_Execute.Size = new System.Drawing.Size(177, 22);
            this.Button_Execute.Text = "Save";
            this.Button_Execute.Click += new System.EventHandler(this.Button_Execute_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpiritToolStripMenuItem,
            this.Button_Menu_DuplicateTeam,
            this.duplicateSpiritToolStripMenuItem,
            this.Button_Menu_DeleteTeam,
            this.Button_DeleteSpiritFromList,
            this.batchChangesToolStripMenuItem});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.Menu_Edit.Text = "Edit";
            // 
            // addSpiritToolStripMenuItem
            // 
            this.addSpiritToolStripMenuItem.Name = "addSpiritToolStripMenuItem";
            this.addSpiritToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.addSpiritToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.addSpiritToolStripMenuItem.Text = "Add Random Spirit";
            this.addSpiritToolStripMenuItem.Click += new System.EventHandler(this.Button_AddRandomEnemy_Click);
            // 
            // Button_Menu_DuplicateTeam
            // 
            this.Button_Menu_DuplicateTeam.Name = "Button_Menu_DuplicateTeam";
            this.Button_Menu_DuplicateTeam.Size = new System.Drawing.Size(196, 22);
            this.Button_Menu_DuplicateTeam.Text = "Duplicate Team";
            this.Button_Menu_DuplicateTeam.Click += new System.EventHandler(this.Button_DuplicateTeam_Click);
            // 
            // duplicateSpiritToolStripMenuItem
            // 
            this.duplicateSpiritToolStripMenuItem.Name = "duplicateSpiritToolStripMenuItem";
            this.duplicateSpiritToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.duplicateSpiritToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.duplicateSpiritToolStripMenuItem.Text = "Duplicate Spirit";
            this.duplicateSpiritToolStripMenuItem.Click += new System.EventHandler(this.Button_DuplicateSpirit_Click);
            // 
            // Button_Menu_DeleteTeam
            // 
            this.Button_Menu_DeleteTeam.Name = "Button_Menu_DeleteTeam";
            this.Button_Menu_DeleteTeam.Size = new System.Drawing.Size(196, 22);
            this.Button_Menu_DeleteTeam.Text = "Delete Team";
            this.Button_Menu_DeleteTeam.Click += new System.EventHandler(this.Button_DeleteTeam_Click);
            // 
            // Button_DeleteSpiritFromList
            // 
            this.Button_DeleteSpiritFromList.Name = "Button_DeleteSpiritFromList";
            this.Button_DeleteSpiritFromList.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Button_DeleteSpiritFromList.Size = new System.Drawing.Size(196, 22);
            this.Button_DeleteSpiritFromList.Text = "Delete Spirit";
            this.Button_DeleteSpiritFromList.Click += new System.EventHandler(this.Button_DeleteSpiritFromList_Click);
            // 
            // batchChangesToolStripMenuItem
            // 
            this.batchChangesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_RemoveAllSpirits,
            this.Button_ResetTool});
            this.batchChangesToolStripMenuItem.Name = "batchChangesToolStripMenuItem";
            this.batchChangesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
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
            this.Option_ReduceEnemyMapCol.Checked = true;
            this.Option_ReduceEnemyMapCol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Option_ReduceEnemyMapCol.Name = "Option_ReduceEnemyMapCol";
            this.Option_ReduceEnemyMapCol.Size = new System.Drawing.Size(266, 22);
            this.Option_ReduceEnemyMapCol.Text = "Reduce Enemy Map Collision Radius";
            this.Option_ReduceEnemyMapCol.ToolTipText = "Helps prevent big enemies from spawning inside the ground and makes them fit insi" +
    "de of tight areas\r\n";
            this.Option_ReduceEnemyMapCol.Click += new System.EventHandler(this.Option_ReduceEnemyMapCol_clicked);
            // 
            // Option_HidePlayer
            // 
            this.Option_HidePlayer.Name = "Option_HidePlayer";
            this.Option_HidePlayer.Size = new System.Drawing.Size(266, 22);
            this.Option_HidePlayer.Text = "Hide Player";
            this.Option_HidePlayer.ToolTipText = "Makes player get ignored by enemies and turn invisible";
            this.Option_HidePlayer.Click += new System.EventHandler(this.Option_HidePlayer_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Summon Position";
            this.label5.Validated += new System.EventHandler(this.EnemyWasEdited);
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
            this.SpiritDataGrid.Location = new System.Drawing.Point(4, 22);
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
            this.SpiritDataGrid.Size = new System.Drawing.Size(572, 304);
            this.SpiritDataGrid.TabIndex = 90;
            this.SpiritDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpiritDataGrid_CellClick);
            this.SpiritDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SpiritDataGrid_CellMouseDown);
            // 
            // Context_DataGrid
            // 
            this.Context_DataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Context_DuplicateSpirit,
            this.Button_Context_RemoveSpirit});
            this.Context_DataGrid.Name = "Context_DataGrid";
            this.Context_DataGrid.Size = new System.Drawing.Size(197, 48);
            // 
            // Button_Context_DuplicateSpirit
            // 
            this.Button_Context_DuplicateSpirit.Name = "Button_Context_DuplicateSpirit";
            this.Button_Context_DuplicateSpirit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Button_Context_DuplicateSpirit.Size = new System.Drawing.Size(196, 22);
            this.Button_Context_DuplicateSpirit.Text = "Duplicate Spirit";
            this.Button_Context_DuplicateSpirit.Click += new System.EventHandler(this.Button_DuplicateSpirit_Click);
            // 
            // Button_Context_RemoveSpirit
            // 
            this.Button_Context_RemoveSpirit.Name = "Button_Context_RemoveSpirit";
            this.Button_Context_RemoveSpirit.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Button_Context_RemoveSpirit.Size = new System.Drawing.Size(196, 22);
            this.Button_Context_RemoveSpirit.Text = "Delete Spirit";
            this.Button_Context_RemoveSpirit.Click += new System.EventHandler(this.Button_DeleteSpiritFromList_Click);
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
            // Input_EnemyHpMult
            // 
            this.Input_EnemyHpMult.DecimalPlaces = 2;
            this.Input_EnemyHpMult.Location = new System.Drawing.Point(170, 223);
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
            this.label14.Location = new System.Drawing.Point(158, 205);
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
            this.label15.Location = new System.Drawing.Point(254, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 15);
            this.label15.TabIndex = 103;
            this.label15.Text = "Bonus Damage Mult";
            this.label15.Validated += new System.EventHandler(this.EnemyWasEdited);
            // 
            // Input_EnemyDamageMult
            // 
            this.Input_EnemyDamageMult.DecimalPlaces = 2;
            this.Input_EnemyDamageMult.Location = new System.Drawing.Point(264, 223);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 15);
            this.label18.TabIndex = 109;
            this.label18.Text = "Team Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Option_TargetAllSpiritAshes);
            this.groupBox1.Controls.Add(this.Option_SpiritAshNoRequirements);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.List_SpiritAsh);
            this.groupBox1.Location = new System.Drawing.Point(977, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 128);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Targeted Spirit Ash";
            // 
            // Option_TargetAllSpiritAshes
            // 
            this.Option_TargetAllSpiritAshes.AutoSize = true;
            this.Option_TargetAllSpiritAshes.Location = new System.Drawing.Point(6, 95);
            this.Option_TargetAllSpiritAshes.Name = "Option_TargetAllSpiritAshes";
            this.Option_TargetAllSpiritAshes.Size = new System.Drawing.Size(74, 19);
            this.Option_TargetAllSpiritAshes.TabIndex = 76;
            this.Option_TargetAllSpiritAshes.Text = "All Ashes";
            this.Option_TargetAllSpiritAshes.UseVisualStyleBackColor = true;
            this.Option_TargetAllSpiritAshes.Visible = false;
            this.Option_TargetAllSpiritAshes.CheckedChanged += new System.EventHandler(this.Option_TargetAllSpiritAshes_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Label_SearchText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.List_EnemyChosenTeam);
            this.groupBox2.Controls.Add(this.Button_PickRandomEnemy);
            this.groupBox2.Controls.Add(this.List_Enemy);
            this.groupBox2.Controls.Add(this.SummonPosition_X);
            this.groupBox2.Controls.Add(this.Search_Enemy);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SummonPosition_Z);
            this.groupBox2.Controls.Add(this.SummonPosition_Angle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.List_EnemyVariant);
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
            this.groupBox2.Location = new System.Drawing.Point(598, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 368);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summon";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Option_Randomize_PhantomColor);
            this.groupBox3.Controls.Add(this.Group_TeamSummonPos_Manual);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Input_TeamDamageMult);
            this.groupBox3.Controls.Add(this.Button_AddNewTeam);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.Input_TeamHpMult);
            this.groupBox3.Controls.Add(this.Button_RandomTeamName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.List_TeamPhantomColor);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.Input_TeamName);
            this.groupBox3.Controls.Add(this.List_TeamType);
            this.groupBox3.Location = new System.Drawing.Point(598, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 143);
            this.groupBox3.TabIndex = 114;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Team";
            // 
            // Option_Randomize_PhantomColor
            // 
            this.Option_Randomize_PhantomColor.Location = new System.Drawing.Point(137, 41);
            this.Option_Randomize_PhantomColor.Name = "Option_Randomize_PhantomColor";
            this.Option_Randomize_PhantomColor.Size = new System.Drawing.Size(22, 23);
            this.Option_Randomize_PhantomColor.TabIndex = 117;
            this.Option_Randomize_PhantomColor.Text = "?";
            this.toolTip1.SetToolTip(this.Option_Randomize_PhantomColor, "Picks a random phantom color");
            this.Option_Randomize_PhantomColor.UseVisualStyleBackColor = true;
            this.Option_Randomize_PhantomColor.Click += new System.EventHandler(this.Option_Randomize_PhantomColor_Click);
            // 
            // Group_TeamSummonPos_Manual
            // 
            this.Group_TeamSummonPos_Manual.Controls.Add(this.List_TeamSummonPreset);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.Input_TeamSummonPos_Ang);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.label21);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.label22);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.label23);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.Input_TeamSummonPos_Z);
            this.Group_TeamSummonPos_Manual.Controls.Add(this.Input_TeamSummonPos_X);
            this.Group_TeamSummonPos_Manual.Location = new System.Drawing.Point(414, 0);
            this.Group_TeamSummonPos_Manual.Name = "Group_TeamSummonPos_Manual";
            this.Group_TeamSummonPos_Manual.Size = new System.Drawing.Size(152, 143);
            this.Group_TeamSummonPos_Manual.TabIndex = 116;
            this.Group_TeamSummonPos_Manual.TabStop = false;
            this.Group_TeamSummonPos_Manual.Text = "Team Summon Position";
            // 
            // Button_RandomTeamName
            // 
            this.Button_RandomTeamName.Location = new System.Drawing.Point(166, 85);
            this.Button_RandomTeamName.Name = "Button_RandomTeamName";
            this.Button_RandomTeamName.Size = new System.Drawing.Size(22, 23);
            this.Button_RandomTeamName.TabIndex = 4;
            this.Button_RandomTeamName.Text = "?";
            this.toolTip1.SetToolTip(this.Button_RandomTeamName, "Picks a random team name");
            this.Button_RandomTeamName.UseVisualStyleBackColor = true;
            this.Button_RandomTeamName.Click += new System.EventHandler(this.Button_RandomizeTeam_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Button_AddRandomSpirit);
            this.groupBox4.Controls.Add(this.SpiritDataGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 359);
            this.groupBox4.TabIndex = 115;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summons";
            // 
            // TeamDataGrid
            // 
            this.TeamDataGrid.AllowUserToAddRows = false;
            this.TeamDataGrid.AllowUserToDeleteRows = false;
            this.TeamDataGrid.AllowUserToResizeRows = false;
            this.TeamDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TeamDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamDataGrid.ContextMenuStrip = this.Context_TeamDataGrid;
            this.TeamDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TeamDataGrid.Location = new System.Drawing.Point(4, 22);
            this.TeamDataGrid.MultiSelect = false;
            this.TeamDataGrid.Name = "TeamDataGrid";
            this.TeamDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TeamDataGrid.RowHeadersVisible = false;
            this.TeamDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.TeamDataGrid.RowTemplate.Height = 25;
            this.TeamDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeamDataGrid.ShowCellToolTips = false;
            this.TeamDataGrid.Size = new System.Drawing.Size(572, 157);
            this.TeamDataGrid.TabIndex = 113;
            this.TeamDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamDataGrid_CellClick);
            this.TeamDataGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TeamDataGrid_CellMouseDown);
            // 
            // Context_TeamDataGrid
            // 
            this.Context_TeamDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_Context_DuplicateTeam,
            this.Button_Context_DeleteTeam});
            this.Context_TeamDataGrid.Name = "Context_DataGrid";
            this.Context_TeamDataGrid.Size = new System.Drawing.Size(149, 48);
            // 
            // Button_Context_DuplicateTeam
            // 
            this.Button_Context_DuplicateTeam.Name = "Button_Context_DuplicateTeam";
            this.Button_Context_DuplicateTeam.ShowShortcutKeys = false;
            this.Button_Context_DuplicateTeam.Size = new System.Drawing.Size(148, 22);
            this.Button_Context_DuplicateTeam.Text = "Duplicate Team";
            this.Button_Context_DuplicateTeam.Click += new System.EventHandler(this.Button_DuplicateTeam_Click);
            // 
            // Button_Context_DeleteTeam
            // 
            this.Button_Context_DeleteTeam.Name = "Button_Context_DeleteTeam";
            this.Button_Context_DeleteTeam.ShowShortcutKeys = false;
            this.Button_Context_DeleteTeam.Size = new System.Drawing.Size(148, 22);
            this.Button_Context_DeleteTeam.Text = "Remove Team";
            this.Button_Context_DeleteTeam.Click += new System.EventHandler(this.Button_DeleteTeam_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.TeamDataGrid);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(580, 185);
            this.groupBox5.TabIndex = 116;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teams";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(499, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 112;
            this.button1.Text = "Add Random Spirit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxRandomize
            // 
            this.groupBoxRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRandomize.Controls.Add(this.comboBox1);
            this.groupBoxRandomize.Controls.Add(this.label25);
            this.groupBoxRandomize.Controls.Add(this.label24);
            this.groupBoxRandomize.Controls.Add(this.numericUpDown1);
            this.groupBoxRandomize.Controls.Add(this.Button_Randomize_SvE);
            this.groupBoxRandomize.Controls.Add(this.Button_Randomize_PvE);
            this.groupBoxRandomize.Location = new System.Drawing.Point(977, 176);
            this.groupBoxRandomize.Name = "groupBoxRandomize";
            this.groupBoxRandomize.Size = new System.Drawing.Size(187, 258);
            this.groupBoxRandomize.TabIndex = 113;
            this.groupBoxRandomize.TabStop = false;
            this.groupBoxRandomize.Text = "Randomizer";
            this.groupBoxRandomize.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 123;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 15);
            this.label25.TabIndex = 122;
            this.label25.Text = "Stat Scaling Level";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 15);
            this.label24.TabIndex = 114;
            this.label24.Text = "Summon Amount";
            // 
            // Button_Randomize_SvE
            // 
            this.Button_Randomize_SvE.Location = new System.Drawing.Point(6, 51);
            this.Button_Randomize_SvE.Name = "Button_Randomize_SvE";
            this.Button_Randomize_SvE.Size = new System.Drawing.Size(140, 23);
            this.Button_Randomize_SvE.TabIndex = 1;
            this.Button_Randomize_SvE.Text = "Summons vs Enemies";
            this.Button_Randomize_SvE.UseVisualStyleBackColor = true;
            // 
            // Button_Randomize_PvE
            // 
            this.Button_Randomize_PvE.Location = new System.Drawing.Point(6, 22);
            this.Button_Randomize_PvE.Name = "Button_Randomize_PvE";
            this.Button_Randomize_PvE.Size = new System.Drawing.Size(140, 23);
            this.Button_Randomize_PvE.TabIndex = 0;
            this.Button_Randomize_PvE.Text = "Player vs enemies";
            this.Button_Randomize_PvE.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 589);
            this.Controls.Add(this.groupBoxRandomize);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.t_console);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Elden Ring Spirit Battler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummonPosition_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamSummonPos_Ang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcParamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_NpcThinkID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamDamageMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_TeamHpMult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpiritDataGrid)).EndInit();
            this.Context_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyHpMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_EnemyDamageMult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Group_TeamSummonPos_Manual.ResumeLayout(false);
            this.Group_TeamSummonPos_Manual.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGrid)).EndInit();
            this.Context_TeamDataGrid.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBoxRandomize.ResumeLayout(false);
            this.groupBoxRandomize.PerformLayout();
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
        private Label label5;
        private NumericUpDown SummonPosition_X;
        private Label label6;
        private Label label7;
        private NumericUpDown SummonPosition_Z;
        private NumericUpDown SummonPosition_Angle;
        private Label label8;
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
        private Label label20;
        private ToolStripMenuItem batchChangesToolStripMenuItem;
        private ToolStripMenuItem Button_RemoveAllSpirits;
        private ToolStripMenuItem Button_ResetTool;
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
        private ToolStripMenuItem Button_DeleteSpiritFromList;
        private ToolStripMenuItem addSpiritToolStripMenuItem;
        private Button Button_PickRandomEnemy;
        private Button Button_AddRandomSpirit;
        private CheckBox Option_SpiritAshNoRequirements;
        private DataGridView TeamDataGrid;
        private ContextMenuStrip Context_TeamDataGrid;
        private ToolStripMenuItem Button_Context_DuplicateTeam;
        private ToolStripMenuItem Button_Context_DeleteTeam;
        private GroupBox groupBox5;
        private Button button1;
        private ToolStripMenuItem Button_Menu_DeleteTeam;
        private ToolStripMenuItem Button_Menu_DuplicateTeam;
        private Label label2;
        private ComboBox List_EnemyChosenTeam;
        private Label label10;
        private NumericUpDown Input_TeamDamageMult;
        private Label label12;
        private NumericUpDown Input_TeamHpMult;
        private GroupBox groupBoxRandomize;
        private NumericUpDown Input_TeamSummonPos_Ang;
        private NumericUpDown Input_TeamSummonPos_X;
        private Label label21;
        private Label label22;
        private NumericUpDown Input_TeamSummonPos_Z;
        private Label label23;
        private Button Button_Randomize_SvE;
        private Button Button_Randomize_PvE;
        private CheckBox Option_TargetAllSpiritAshes;
        private ComboBox comboBox1;
        private Label label25;
        private Label label24;
        private NumericUpDown numericUpDown1;
        private GroupBox Group_TeamSummonPos_Manual;
        private ComboBox List_TeamSummonPreset;
        private Label Label_SearchText;
        private Button Option_Randomize_PhantomColor;
    }
}