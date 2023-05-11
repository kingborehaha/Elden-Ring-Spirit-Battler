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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            FileDialog_Regulation = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            SummonPosition_X = new NumericUpDown();
            SummonPosition_Z = new NumericUpDown();
            SummonPosition_Angle = new NumericUpDown();
            Input_TeamSummonPos_X = new NumericUpDown();
            Input_TeamSummonPos_Z = new NumericUpDown();
            Input_TeamSummonPos_Ang = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            List_Enemy = new ComboBox();
            Search_Enemy = new TextBox();
            label1 = new Label();
            List_TeamPhantomColor = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Button_AddNewTeam = new Button();
            Input_NpcParamID = new NumericUpDown();
            Input_NpcThinkID = new NumericUpDown();
            label3 = new Label();
            label11 = new Label();
            List_StatScaling = new ComboBox();
            label13 = new Label();
            List_EnemyVariant = new ComboBox();
            label16 = new Label();
            List_TeamType = new ComboBox();
            label17 = new Label();
            Input_TeamName = new TextBox();
            label20 = new Label();
            Label_SearchEnemyText = new Label();
            label2 = new Label();
            List_EnemyChosenTeam = new ComboBox();
            Button_PickRandomEnemy = new Button();
            List_TeamSummonPreset = new ComboBox();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label10 = new Label();
            Input_TeamDamageMult = new NumericUpDown();
            label12 = new Label();
            Input_TeamHpMult = new NumericUpDown();
            Button_AddRandomSpirit = new Button();
            label4 = new Label();
            List_SpiritAsh = new ComboBox();
            Option_SpiritAshNoRequirements = new CheckBox();
            Option_Randomize_PhantomColor = new Button();
            Button_RandomTeamName = new Button();
            Search_SpiritAsh = new TextBox();
            Label_SearchSpiritAshText = new Label();
            Input_CharaInitID = new NumericUpDown();
            label9 = new Label();
            Option_TeamFollowPlayer = new CheckBox();
            Option_Spirit_SearchesLongRange = new CheckBox();
            t_console = new TextBox();
            menuStrip1 = new MenuStrip();
            Menu_File = new ToolStripMenuItem();
            loadRegulationbinToolStripMenuItem = new ToolStripMenuItem();
            b_restoreRegulation = new ToolStripMenuItem();
            saveLoadPresetToolStripMenuItem = new ToolStripMenuItem();
            Button_LoadSummonBackup = new ToolStripMenuItem();
            Button_SaveSummonBackup = new ToolStripMenuItem();
            Button_Execute = new ToolStripMenuItem();
            Menu_Edit = new ToolStripMenuItem();
            addSpiritToolStripMenuItem = new ToolStripMenuItem();
            Button_Menu_DuplicateTeam = new ToolStripMenuItem();
            duplicateSpiritToolStripMenuItem = new ToolStripMenuItem();
            Button_Menu_DeleteTeam = new ToolStripMenuItem();
            Button_DeleteSpiritFromList = new ToolStripMenuItem();
            batchChangesToolStripMenuItem = new ToolStripMenuItem();
            Button_RemoveAllSpirits = new ToolStripMenuItem();
            Button_ResetTool = new ToolStripMenuItem();
            Menu_Settings = new ToolStripMenuItem();
            Option_ReduceEnemyMapCol = new ToolStripMenuItem();
            Option_EnableResummoning = new ToolStripMenuItem();
            Option_MoreSummonAreas = new ToolStripMenuItem();
            Option_HidePlayer = new ToolStripMenuItem();
            Option_SummonsEasilyFindTargets = new ToolStripMenuItem();
            Menu_Help = new ToolStripMenuItem();
            Button_Info = new ToolStripMenuItem();
            Button_StatScalingLevelInfo = new ToolStripMenuItem();
            fAQToolStripMenuItem = new ToolStripMenuItem();
            label5 = new Label();
            SpiritDataGrid = new DataGridView();
            Context_DataGrid = new ContextMenuStrip(components);
            Button_Context_DuplicateSpirit = new ToolStripMenuItem();
            Button_Context_RemoveSpirit = new ToolStripMenuItem();
            Team = new DataGridViewComboBoxColumn();
            EnemyCol = new DataGridViewComboBoxColumn();
            Variant = new DataGridViewComboBoxColumn();
            Input_EnemyHpMult = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            Input_EnemyDamageMult = new NumericUpDown();
            label18 = new Label();
            groupBox1 = new GroupBox();
            Option_TargetAllSpiritAshes = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            Group_TeamSummonPos_Manual = new GroupBox();
            groupBox4 = new GroupBox();
            TeamDataGrid = new DataGridView();
            Context_TeamDataGrid = new ContextMenuStrip(components);
            Button_Context_DuplicateTeam = new ToolStripMenuItem();
            Button_Context_DeleteTeam = new ToolStripMenuItem();
            groupBox5 = new GroupBox();
            groupBoxRandomize = new GroupBox();
            comboBox1 = new ComboBox();
            label25 = new Label();
            label24 = new Label();
            Button_Randomize_SvE = new Button();
            Button_Randomize_PvE = new Button();
            FileDialog_LoadJson = new OpenFileDialog();
            FileDialog_SaveJson = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)SummonPosition_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SummonPosition_Z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SummonPosition_Angle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_Z).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_Ang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_NpcParamID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_NpcThinkID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamDamageMult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamHpMult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_CharaInitID).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpiritDataGrid).BeginInit();
            Context_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Input_EnemyHpMult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Input_EnemyDamageMult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            Group_TeamSummonPos_Manual.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeamDataGrid).BeginInit();
            Context_TeamDataGrid.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBoxRandomize.SuspendLayout();
            SuspendLayout();
            // 
            // FileDialog_Regulation
            // 
            FileDialog_Regulation.FileName = "regulation.bin";
            FileDialog_Regulation.Filter = "Regulation File|regulation.bin|All Files|*.*";
            FileDialog_Regulation.RestoreDirectory = true;
            FileDialog_Regulation.Title = "Open \"regulation.bin\"";
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 200;
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 40;
            // 
            // SummonPosition_X
            // 
            SummonPosition_X.DecimalPlaces = 1;
            SummonPosition_X.Location = new Point(286, 270);
            SummonPosition_X.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            SummonPosition_X.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            SummonPosition_X.Name = "SummonPosition_X";
            SummonPosition_X.Size = new Size(57, 23);
            SummonPosition_X.TabIndex = 75;
            toolTip1.SetToolTip(SummonPosition_X, "Left/Right position of summon location in meters");
            SummonPosition_X.ValueChanged += EnemyWasEdited;
            SummonPosition_X.Click += EnemyWasEdited;
            // 
            // SummonPosition_Z
            // 
            SummonPosition_Z.DecimalPlaces = 1;
            SummonPosition_Z.Location = new Point(286, 299);
            SummonPosition_Z.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            SummonPosition_Z.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            SummonPosition_Z.Name = "SummonPosition_Z";
            SummonPosition_Z.Size = new Size(57, 23);
            SummonPosition_Z.TabIndex = 80;
            toolTip1.SetToolTip(SummonPosition_Z, "Depth of summon location in meters");
            SummonPosition_Z.ValueChanged += EnemyWasEdited;
            SummonPosition_Z.Click += EnemyWasEdited;
            // 
            // SummonPosition_Angle
            // 
            SummonPosition_Angle.DecimalPlaces = 1;
            SummonPosition_Angle.Location = new Point(286, 328);
            SummonPosition_Angle.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            SummonPosition_Angle.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            SummonPosition_Angle.Name = "SummonPosition_Angle";
            SummonPosition_Angle.Size = new Size(57, 23);
            SummonPosition_Angle.TabIndex = 81;
            toolTip1.SetToolTip(SummonPosition_Angle, "Facing angle of the spirit when summoned");
            SummonPosition_Angle.Visible = false;
            SummonPosition_Angle.ValueChanged += EnemyWasEdited;
            SummonPosition_Angle.Click += EnemyWasEdited;
            // 
            // Input_TeamSummonPos_X
            // 
            Input_TeamSummonPos_X.DecimalPlaces = 1;
            Input_TeamSummonPos_X.Location = new Point(67, 56);
            Input_TeamSummonPos_X.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            Input_TeamSummonPos_X.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            Input_TeamSummonPos_X.Name = "Input_TeamSummonPos_X";
            Input_TeamSummonPos_X.Size = new Size(59, 23);
            Input_TeamSummonPos_X.TabIndex = 9;
            toolTip1.SetToolTip(Input_TeamSummonPos_X, "Left/Right position of summon location in meters");
            // 
            // Input_TeamSummonPos_Z
            // 
            Input_TeamSummonPos_Z.DecimalPlaces = 1;
            Input_TeamSummonPos_Z.Location = new Point(67, 85);
            Input_TeamSummonPos_Z.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            Input_TeamSummonPos_Z.Minimum = new decimal(new int[] { 9999, 0, 0, int.MinValue });
            Input_TeamSummonPos_Z.Name = "Input_TeamSummonPos_Z";
            Input_TeamSummonPos_Z.Size = new Size(59, 23);
            Input_TeamSummonPos_Z.TabIndex = 10;
            toolTip1.SetToolTip(Input_TeamSummonPos_Z, "Depth of summon location in meters");
            // 
            // Input_TeamSummonPos_Ang
            // 
            Input_TeamSummonPos_Ang.DecimalPlaces = 1;
            Input_TeamSummonPos_Ang.Location = new Point(67, 114);
            Input_TeamSummonPos_Ang.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            Input_TeamSummonPos_Ang.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            Input_TeamSummonPos_Ang.Name = "Input_TeamSummonPos_Ang";
            Input_TeamSummonPos_Ang.Size = new Size(59, 23);
            Input_TeamSummonPos_Ang.TabIndex = 11;
            toolTip1.SetToolTip(Input_TeamSummonPos_Ang, "Facing angle of the spirit when summoned");
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(15, 104);
            numericUpDown1.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 121;
            toolTip1.SetToolTip(numericUpDown1, "Facing angle of the spirit when summoned\r\nRange of -180 to 180 degrees\r\nNegative values face left, Positive values face right\r\n");
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // List_Enemy
            // 
            List_Enemy.DropDownStyle = ComboBoxStyle.DropDownList;
            List_Enemy.DropDownWidth = 200;
            List_Enemy.FormattingEnabled = true;
            List_Enemy.ImeMode = ImeMode.NoControl;
            List_Enemy.Location = new Point(6, 115);
            List_Enemy.Name = "List_Enemy";
            List_Enemy.Size = new Size(200, 23);
            List_Enemy.TabIndex = 62;
            toolTip1.SetToolTip(List_Enemy, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            List_Enemy.SelectedIndexChanged += List_Enemy_SelectedIndexChanged;
            List_Enemy.KeyDown += ComboBox_KeyPress;
            // 
            // Search_Enemy
            // 
            Search_Enemy.Location = new Point(6, 86);
            Search_Enemy.Name = "Search_Enemy";
            Search_Enemy.Size = new Size(200, 23);
            Search_Enemy.TabIndex = 10;
            toolTip1.SetToolTip(Search_Enemy, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            Search_Enemy.Click += Search_Enemy_Click;
            Search_Enemy.TextChanged += Search_Enemy_TextChanged;
            Search_Enemy.Validated += EnemyWasEdited;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 65;
            label1.Text = "Phantom Color";
            toolTip1.SetToolTip(label1, "Phantom color and other shader attributes given to members of this team\r\n");
            // 
            // List_TeamPhantomColor
            // 
            List_TeamPhantomColor.DropDownStyle = ComboBoxStyle.DropDownList;
            List_TeamPhantomColor.FormattingEnabled = true;
            List_TeamPhantomColor.Location = new Point(6, 41);
            List_TeamPhantomColor.Name = "List_TeamPhantomColor";
            List_TeamPhantomColor.Size = new Size(129, 23);
            List_TeamPhantomColor.TabIndex = 1;
            toolTip1.SetToolTip(List_TeamPhantomColor, "Phantom color and other shader attributes given to members of this team\r\n");
            List_TeamPhantomColor.KeyDown += ComboBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 272);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 78;
            label6.Text = "Width (X)";
            toolTip1.SetToolTip(label6, "Left/Right position of summon location in meters");
            label6.Validated += EnemyWasEdited;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 301);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 79;
            label7.Text = "Depth (Z)";
            toolTip1.SetToolTip(label7, "Depth of summon location in meters");
            label7.Validated += EnemyWasEdited;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 330);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 82;
            label8.Text = "Angle";
            toolTip1.SetToolTip(label8, "Facing angle of the spirit when summoned");
            label8.Visible = false;
            label8.Validated += EnemyWasEdited;
            // 
            // Button_AddNewTeam
            // 
            Button_AddNewTeam.Location = new Point(6, 114);
            Button_AddNewTeam.Name = "Button_AddNewTeam";
            Button_AddNewTeam.Size = new Size(116, 23);
            Button_AddNewTeam.TabIndex = 5;
            Button_AddNewTeam.Text = "Add/Update Team";
            toolTip1.SetToolTip(Button_AddNewTeam, "Updates a team's settings if Team Name exists in list.\r\nAdds a new team otherwise.");
            Button_AddNewTeam.UseVisualStyleBackColor = true;
            Button_AddNewTeam.Click += Button_AddUpdateTeam_Click;
            // 
            // Input_NpcParamID
            // 
            Input_NpcParamID.Enabled = false;
            Input_NpcParamID.Location = new Point(6, 214);
            Input_NpcParamID.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            Input_NpcParamID.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_NpcParamID.Name = "Input_NpcParamID";
            Input_NpcParamID.Size = new Size(77, 23);
            Input_NpcParamID.TabIndex = 92;
            toolTip1.SetToolTip(Input_NpcParamID, "NpcParam ID used by this enemy variant");
            Input_NpcParamID.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_NpcParamID.ValueChanged += EnemyWasEdited;
            Input_NpcParamID.Click += EnemyWasEdited;
            // 
            // Input_NpcThinkID
            // 
            Input_NpcThinkID.Enabled = false;
            Input_NpcThinkID.Location = new Point(89, 214);
            Input_NpcThinkID.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            Input_NpcThinkID.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_NpcThinkID.Name = "Input_NpcThinkID";
            Input_NpcThinkID.Size = new Size(77, 23);
            Input_NpcThinkID.TabIndex = 93;
            toolTip1.SetToolTip(Input_NpcThinkID, "NpcThinkParam ID used by this enemy variant");
            Input_NpcThinkID.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_NpcThinkID.ValueChanged += EnemyWasEdited;
            Input_NpcThinkID.Click += EnemyWasEdited;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 196);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 94;
            label3.Text = "NpcParam ID";
            toolTip1.SetToolTip(label3, "NpcParam ID used by this enemy variant");
            label3.Validated += EnemyWasEdited;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(89, 196);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 95;
            label11.Text = "NpcThink ID";
            toolTip1.SetToolTip(label11, "NpcThinkParam ID used by this enemy variant");
            label11.Validated += EnemyWasEdited;
            // 
            // List_StatScaling
            // 
            List_StatScaling.DropDownStyle = ComboBoxStyle.DropDownList;
            List_StatScaling.FormattingEnabled = true;
            List_StatScaling.Location = new Point(98, 263);
            List_StatScaling.Name = "List_StatScaling";
            List_StatScaling.Size = new Size(98, 23);
            List_StatScaling.TabIndex = 98;
            toolTip1.SetToolTip(List_StatScaling, resources.GetString("List_StatScaling.ToolTip"));
            List_StatScaling.SelectedIndexChanged += EnemyWasEdited;
            List_StatScaling.KeyDown += ComboBox_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(98, 246);
            label13.Name = "label13";
            label13.Size = new Size(98, 15);
            label13.TabIndex = 99;
            label13.Text = "Stat Scaling Level";
            toolTip1.SetToolTip(label13, resources.GetString("label13.ToolTip"));
            label13.Validated += EnemyWasEdited;
            // 
            // List_EnemyVariant
            // 
            List_EnemyVariant.DropDownStyle = ComboBoxStyle.DropDownList;
            List_EnemyVariant.DropDownWidth = 200;
            List_EnemyVariant.FormattingEnabled = true;
            List_EnemyVariant.Location = new Point(6, 159);
            List_EnemyVariant.Name = "List_EnemyVariant";
            List_EnemyVariant.Size = new Size(200, 23);
            List_EnemyVariant.TabIndex = 104;
            toolTip1.SetToolTip(List_EnemyVariant, "Specific enemy variant this summon will be, generated from EnemyInfoResource.txt");
            List_EnemyVariant.SelectedIndexChanged += List_EnemyVariant_SelectedIndexChanged;
            List_EnemyVariant.KeyDown += ComboBox_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(11, 142);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 105;
            label16.Text = "Enemy Variant";
            toolTip1.SetToolTip(label16, "Specific enemy variant this summon will be, generated from EnemyInfoResource.txt");
            label16.Validated += EnemyWasEdited;
            // 
            // List_TeamType
            // 
            List_TeamType.DropDownStyle = ComboBoxStyle.DropDownList;
            List_TeamType.FormattingEnabled = true;
            List_TeamType.Location = new Point(169, 41);
            List_TeamType.Name = "List_TeamType";
            List_TeamType.Size = new Size(131, 23);
            List_TeamType.TabIndex = 2;
            toolTip1.SetToolTip(List_TeamType, "Determines who members of this team hate, can hurt, hated by, and can be hurt by (all mutually exclusive)");
            List_TeamType.KeyDown += ComboBox_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(169, 23);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 106;
            label17.Text = "Team Type";
            toolTip1.SetToolTip(label17, "Determines who members of this team hate, can hurt, hated by, and can be hurt by (all mutually exclusive)\r\n");
            // 
            // Input_TeamName
            // 
            Input_TeamName.Location = new Point(6, 85);
            Input_TeamName.Name = "Input_TeamName";
            Input_TeamName.Size = new Size(157, 23);
            Input_TeamName.TabIndex = 3;
            toolTip1.SetToolTip(Input_TeamName, "Purely for in-tool organization (at the moment)");
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(11, 68);
            label20.Name = "label20";
            label20.Size = new Size(70, 15);
            label20.TabIndex = 111;
            label20.Text = "Base Enemy";
            toolTip1.SetToolTip(label20, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            label20.Validated += EnemyWasEdited;
            // 
            // Label_SearchEnemyText
            // 
            Label_SearchEnemyText.AutoSize = true;
            Label_SearchEnemyText.BackColor = SystemColors.Window;
            Label_SearchEnemyText.CausesValidation = false;
            Label_SearchEnemyText.Cursor = Cursors.IBeam;
            Label_SearchEnemyText.ForeColor = SystemColors.GrayText;
            Label_SearchEnemyText.Location = new Point(10, 91);
            Label_SearchEnemyText.Name = "Label_SearchEnemyText";
            Label_SearchEnemyText.Size = new Size(51, 15);
            Label_SearchEnemyText.TabIndex = 0;
            Label_SearchEnemyText.Text = "Search...";
            toolTip1.SetToolTip(Label_SearchEnemyText, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            Label_SearchEnemyText.Click += Label_SearchText_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 113;
            label2.Text = "Team";
            toolTip1.SetToolTip(label2, "Which team this enemy belongs to");
            // 
            // List_EnemyChosenTeam
            // 
            List_EnemyChosenTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            List_EnemyChosenTeam.DropDownWidth = 200;
            List_EnemyChosenTeam.FormattingEnabled = true;
            List_EnemyChosenTeam.ImeMode = ImeMode.NoControl;
            List_EnemyChosenTeam.Location = new Point(6, 42);
            List_EnemyChosenTeam.Name = "List_EnemyChosenTeam";
            List_EnemyChosenTeam.Size = new Size(157, 23);
            List_EnemyChosenTeam.TabIndex = 20;
            toolTip1.SetToolTip(List_EnemyChosenTeam, "Which team this enemy belongs to");
            List_EnemyChosenTeam.SelectedIndexChanged += List_EnemyChosenTeam_SelectedIndexChanged;
            List_EnemyChosenTeam.KeyDown += ComboBox_KeyPress;
            // 
            // Button_PickRandomEnemy
            // 
            Button_PickRandomEnemy.Location = new Point(209, 159);
            Button_PickRandomEnemy.Name = "Button_PickRandomEnemy";
            Button_PickRandomEnemy.Size = new Size(22, 24);
            Button_PickRandomEnemy.TabIndex = 111;
            Button_PickRandomEnemy.Text = "?";
            toolTip1.SetToolTip(Button_PickRandomEnemy, "Picks a random Enemy Variant");
            Button_PickRandomEnemy.UseVisualStyleBackColor = true;
            Button_PickRandomEnemy.Click += Button_PickRandomEnemy_Click;
            // 
            // List_TeamSummonPreset
            // 
            List_TeamSummonPreset.DropDownStyle = ComboBoxStyle.DropDownList;
            List_TeamSummonPreset.DropDownWidth = 100;
            List_TeamSummonPreset.FormattingEnabled = true;
            List_TeamSummonPreset.Location = new Point(6, 27);
            List_TeamSummonPreset.Name = "List_TeamSummonPreset";
            List_TeamSummonPreset.Size = new Size(131, 23);
            List_TeamSummonPreset.TabIndex = 8;
            toolTip1.SetToolTip(List_TeamSummonPreset, "Summon positon presets\r\nNon-manual automatically offset and increment position for each additional enemy");
            List_TeamSummonPreset.SelectedIndexChanged += List_TeamSummonPreset_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(4, 58);
            label21.Name = "label21";
            label21.Size = new Size(57, 15);
            label21.TabIndex = 116;
            label21.Text = "Width (X)";
            toolTip1.SetToolTip(label21, "Left/Right position of summon location in meters");
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(4, 87);
            label22.Name = "label22";
            label22.Size = new Size(57, 15);
            label22.TabIndex = 117;
            label22.Text = "Depth (Z)";
            toolTip1.SetToolTip(label22, "Depth of summon location in meters");
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(23, 116);
            label23.Name = "label23";
            label23.Size = new Size(38, 15);
            label23.TabIndex = 119;
            label23.Text = "Angle";
            toolTip1.SetToolTip(label23, "Facing angle of the spirit when summoned");
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(298, 91);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 114;
            label10.Text = "Team Damage Mult";
            toolTip1.SetToolTip(label10, "Damage Multiplier applied to members of team");
            // 
            // Input_TeamDamageMult
            // 
            Input_TeamDamageMult.DecimalPlaces = 2;
            Input_TeamDamageMult.Location = new Point(312, 109);
            Input_TeamDamageMult.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Input_TeamDamageMult.Name = "Input_TeamDamageMult";
            Input_TeamDamageMult.Size = new Size(61, 23);
            Input_TeamDamageMult.TabIndex = 7;
            toolTip1.SetToolTip(Input_TeamDamageMult, "Damage Multiplier applied to members of team");
            Input_TeamDamageMult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(305, 47);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 112;
            label12.Text = "Team HP Mult";
            toolTip1.SetToolTip(label12, "HP Multiplier applied to members of team");
            // 
            // Input_TeamHpMult
            // 
            Input_TeamHpMult.DecimalPlaces = 2;
            Input_TeamHpMult.Location = new Point(312, 65);
            Input_TeamHpMult.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Input_TeamHpMult.Name = "Input_TeamHpMult";
            Input_TeamHpMult.Size = new Size(61, 23);
            Input_TeamHpMult.TabIndex = 6;
            toolTip1.SetToolTip(Input_TeamHpMult, "HP Multiplier applied to members of team");
            Input_TeamHpMult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Button_AddRandomSpirit
            // 
            Button_AddRandomSpirit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_AddRandomSpirit.Location = new Point(449, 332);
            Button_AddRandomSpirit.Name = "Button_AddRandomSpirit";
            Button_AddRandomSpirit.Size = new Size(127, 23);
            Button_AddRandomSpirit.TabIndex = 112;
            Button_AddRandomSpirit.Text = "Add Random Spirit";
            toolTip1.SetToolTip(Button_AddRandomSpirit, "Duplicates selected summon and randomizes Enemy Variant");
            Button_AddRandomSpirit.UseVisualStyleBackColor = true;
            Button_AddRandomSpirit.Click += Button_AddRandomEnemy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 35);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 74;
            label4.Text = "Spirit Ash";
            toolTip1.SetToolTip(label4, "Which spirit ash item will be overwritten with new summon data");
            // 
            // List_SpiritAsh
            // 
            List_SpiritAsh.DropDownStyle = ComboBoxStyle.DropDownList;
            List_SpiritAsh.FormattingEnabled = true;
            List_SpiritAsh.Location = new Point(6, 82);
            List_SpiritAsh.Name = "List_SpiritAsh";
            List_SpiritAsh.Size = new Size(166, 23);
            List_SpiritAsh.TabIndex = 72;
            toolTip1.SetToolTip(List_SpiritAsh, "Which spirit ash item will be overwritten with new summon data");
            List_SpiritAsh.KeyDown += ComboBox_KeyPress;
            // 
            // Option_SpiritAshNoRequirements
            // 
            Option_SpiritAshNoRequirements.AutoSize = true;
            Option_SpiritAshNoRequirements.Checked = true;
            Option_SpiritAshNoRequirements.CheckState = CheckState.Checked;
            Option_SpiritAshNoRequirements.Location = new Point(6, 111);
            Option_SpiritAshNoRequirements.Name = "Option_SpiritAshNoRequirements";
            Option_SpiritAshNoRequirements.Size = new Size(155, 19);
            Option_SpiritAshNoRequirements.TabIndex = 75;
            Option_SpiritAshNoRequirements.Text = "No HP/FP Consumption";
            toolTip1.SetToolTip(Option_SpiritAshNoRequirements, "Whether the Spirit ash will consume zero HP and FP");
            Option_SpiritAshNoRequirements.UseVisualStyleBackColor = true;
            // 
            // Option_Randomize_PhantomColor
            // 
            Option_Randomize_PhantomColor.Location = new Point(137, 41);
            Option_Randomize_PhantomColor.Name = "Option_Randomize_PhantomColor";
            Option_Randomize_PhantomColor.Size = new Size(22, 23);
            Option_Randomize_PhantomColor.TabIndex = 117;
            Option_Randomize_PhantomColor.Text = "?";
            toolTip1.SetToolTip(Option_Randomize_PhantomColor, "Picks a random phantom color");
            Option_Randomize_PhantomColor.UseVisualStyleBackColor = true;
            Option_Randomize_PhantomColor.Click += Option_Randomize_PhantomColor_Click;
            // 
            // Button_RandomTeamName
            // 
            Button_RandomTeamName.Location = new Point(165, 85);
            Button_RandomTeamName.Name = "Button_RandomTeamName";
            Button_RandomTeamName.Size = new Size(22, 23);
            Button_RandomTeamName.TabIndex = 4;
            Button_RandomTeamName.Text = "?";
            toolTip1.SetToolTip(Button_RandomTeamName, "Picks a random team name");
            Button_RandomTeamName.UseVisualStyleBackColor = true;
            Button_RandomTeamName.Click += Button_RandomizeTeam_Click;
            // 
            // Search_SpiritAsh
            // 
            Search_SpiritAsh.Location = new Point(6, 53);
            Search_SpiritAsh.Name = "Search_SpiritAsh";
            Search_SpiritAsh.Size = new Size(166, 23);
            Search_SpiritAsh.TabIndex = 77;
            toolTip1.SetToolTip(Search_SpiritAsh, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            Search_SpiritAsh.Click += Search_SpiritAsh_Click;
            Search_SpiritAsh.TextChanged += Search_SpiritAsh_TextChanged;
            // 
            // Label_SearchSpiritAshText
            // 
            Label_SearchSpiritAshText.AutoSize = true;
            Label_SearchSpiritAshText.BackColor = SystemColors.Window;
            Label_SearchSpiritAshText.CausesValidation = false;
            Label_SearchSpiritAshText.Cursor = Cursors.IBeam;
            Label_SearchSpiritAshText.ForeColor = SystemColors.GrayText;
            Label_SearchSpiritAshText.Location = new Point(12, 57);
            Label_SearchSpiritAshText.Name = "Label_SearchSpiritAshText";
            Label_SearchSpiritAshText.Size = new Size(51, 15);
            Label_SearchSpiritAshText.TabIndex = 78;
            Label_SearchSpiritAshText.Text = "Search...";
            toolTip1.SetToolTip(Label_SearchSpiritAshText, "Base enemy type this summon will be, generated from EnemyInfoResource.txt\r\nExact enemy details is determined by Enemy Variant.");
            Label_SearchSpiritAshText.Click += Label_SearchSpiritAshText_Click;
            // 
            // Input_CharaInitID
            // 
            Input_CharaInitID.Enabled = false;
            Input_CharaInitID.Location = new Point(172, 214);
            Input_CharaInitID.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            Input_CharaInitID.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_CharaInitID.Name = "Input_CharaInitID";
            Input_CharaInitID.Size = new Size(72, 23);
            Input_CharaInitID.TabIndex = 114;
            toolTip1.SetToolTip(Input_CharaInitID, "NpcParam ID used by this enemy variant");
            Input_CharaInitID.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            Input_CharaInitID.ValueChanged += EnemyWasEdited;
            Input_CharaInitID.Click += EnemyWasEdited;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 196);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 115;
            label9.Text = "Character ID";
            toolTip1.SetToolTip(label9, "NpcParam ID used by this enemy variant");
            // 
            // Option_TeamFollowPlayer
            // 
            Option_TeamFollowPlayer.AutoSize = true;
            Option_TeamFollowPlayer.Location = new Point(193, 87);
            Option_TeamFollowPlayer.Name = "Option_TeamFollowPlayer";
            Option_TeamFollowPlayer.Size = new Size(96, 19);
            Option_TeamFollowPlayer.TabIndex = 118;
            Option_TeamFollowPlayer.Text = "Follow Player";
            toolTip1.SetToolTip(Option_TeamFollowPlayer, "If checked, members of this team will follow/teleport to the player when far away.");
            Option_TeamFollowPlayer.UseVisualStyleBackColor = true;
            // 
            // Option_Spirit_SearchesLongRange
            // 
            Option_Spirit_SearchesLongRange.AutoSize = true;
            Option_Spirit_SearchesLongRange.Checked = true;
            Option_Spirit_SearchesLongRange.CheckState = CheckState.Checked;
            Option_Spirit_SearchesLongRange.Location = new Point(6, 338);
            Option_Spirit_SearchesLongRange.Name = "Option_Spirit_SearchesLongRange";
            Option_Spirit_SearchesLongRange.Size = new Size(139, 19);
            Option_Spirit_SearchesLongRange.TabIndex = 116;
            Option_Spirit_SearchesLongRange.Text = "Long-Distance Aggro";
            toolTip1.SetToolTip(Option_Spirit_SearchesLongRange, resources.GetString("Option_Spirit_SearchesLongRange.ToolTip"));
            Option_Spirit_SearchesLongRange.UseVisualStyleBackColor = true;
            Option_Spirit_SearchesLongRange.CheckedChanged += EnemyWasEdited;
            Option_Spirit_SearchesLongRange.Click += EnemyWasEdited;
            // 
            // t_console
            // 
            t_console.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            t_console.Location = new Point(595, 550);
            t_console.Name = "t_console";
            t_console.ReadOnly = true;
            t_console.Size = new Size(376, 23);
            t_console.TabIndex = 24;
            t_console.TabStop = false;
            t_console.Text = "Awaiting regulation.bin";
            t_console.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu_File, Menu_Edit, Menu_Settings, Menu_Help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 24);
            menuStrip1.TabIndex = 51;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            Menu_File.DropDownItems.AddRange(new ToolStripItem[] { loadRegulationbinToolStripMenuItem, b_restoreRegulation, saveLoadPresetToolStripMenuItem, Button_Execute });
            Menu_File.Name = "Menu_File";
            Menu_File.Size = new Size(37, 20);
            Menu_File.Text = "File";
            // 
            // loadRegulationbinToolStripMenuItem
            // 
            loadRegulationbinToolStripMenuItem.Name = "loadRegulationbinToolStripMenuItem";
            loadRegulationbinToolStripMenuItem.Size = new Size(184, 22);
            loadRegulationbinToolStripMenuItem.Text = "Load regulation.bin";
            loadRegulationbinToolStripMenuItem.Click += b_browse_Click;
            // 
            // b_restoreRegulation
            // 
            b_restoreRegulation.Name = "b_restoreRegulation";
            b_restoreRegulation.Size = new Size(184, 22);
            b_restoreRegulation.Text = "Revert regulation.bin";
            b_restoreRegulation.Click += b_restoreRegulation_Click;
            // 
            // saveLoadPresetToolStripMenuItem
            // 
            saveLoadPresetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Button_LoadSummonBackup, Button_SaveSummonBackup });
            saveLoadPresetToolStripMenuItem.Name = "saveLoadPresetToolStripMenuItem";
            saveLoadPresetToolStripMenuItem.Size = new Size(184, 22);
            saveLoadPresetToolStripMenuItem.Text = "Summon Backups";
            // 
            // Button_LoadSummonBackup
            // 
            Button_LoadSummonBackup.Name = "Button_LoadSummonBackup";
            Button_LoadSummonBackup.Size = new Size(194, 22);
            Button_LoadSummonBackup.Text = "Load Summon Backup";
            Button_LoadSummonBackup.Click += Button_LoadSummonBackup_Click;
            // 
            // Button_SaveSummonBackup
            // 
            Button_SaveSummonBackup.Name = "Button_SaveSummonBackup";
            Button_SaveSummonBackup.Size = new Size(194, 22);
            Button_SaveSummonBackup.Text = "Save Summon Backup";
            Button_SaveSummonBackup.Click += Button_SaveSummonBackup_Click;
            // 
            // Button_Execute
            // 
            Button_Execute.Name = "Button_Execute";
            Button_Execute.ShortcutKeys = Keys.Control | Keys.S;
            Button_Execute.Size = new Size(184, 22);
            Button_Execute.Text = "Save";
            Button_Execute.Click += Button_Execute_Click;
            // 
            // Menu_Edit
            // 
            Menu_Edit.DropDownItems.AddRange(new ToolStripItem[] { addSpiritToolStripMenuItem, Button_Menu_DuplicateTeam, duplicateSpiritToolStripMenuItem, Button_Menu_DeleteTeam, Button_DeleteSpiritFromList, batchChangesToolStripMenuItem });
            Menu_Edit.Name = "Menu_Edit";
            Menu_Edit.Size = new Size(39, 20);
            Menu_Edit.Text = "Edit";
            // 
            // addSpiritToolStripMenuItem
            // 
            addSpiritToolStripMenuItem.Name = "addSpiritToolStripMenuItem";
            addSpiritToolStripMenuItem.ShortcutKeys = Keys.Insert;
            addSpiritToolStripMenuItem.Size = new Size(196, 22);
            addSpiritToolStripMenuItem.Text = "Add Random Spirit";
            addSpiritToolStripMenuItem.Click += Button_AddRandomEnemy_Click;
            // 
            // Button_Menu_DuplicateTeam
            // 
            Button_Menu_DuplicateTeam.Name = "Button_Menu_DuplicateTeam";
            Button_Menu_DuplicateTeam.Size = new Size(196, 22);
            Button_Menu_DuplicateTeam.Text = "Duplicate Team";
            Button_Menu_DuplicateTeam.Click += Button_DuplicateTeam_Click;
            // 
            // duplicateSpiritToolStripMenuItem
            // 
            duplicateSpiritToolStripMenuItem.Name = "duplicateSpiritToolStripMenuItem";
            duplicateSpiritToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            duplicateSpiritToolStripMenuItem.Size = new Size(196, 22);
            duplicateSpiritToolStripMenuItem.Text = "Duplicate Spirit";
            duplicateSpiritToolStripMenuItem.Click += Button_DuplicateSpirit_Click;
            // 
            // Button_Menu_DeleteTeam
            // 
            Button_Menu_DeleteTeam.Name = "Button_Menu_DeleteTeam";
            Button_Menu_DeleteTeam.Size = new Size(196, 22);
            Button_Menu_DeleteTeam.Text = "Delete Team";
            Button_Menu_DeleteTeam.Click += Button_DeleteTeam_Click;
            // 
            // Button_DeleteSpiritFromList
            // 
            Button_DeleteSpiritFromList.Name = "Button_DeleteSpiritFromList";
            Button_DeleteSpiritFromList.ShortcutKeys = Keys.Delete;
            Button_DeleteSpiritFromList.Size = new Size(196, 22);
            Button_DeleteSpiritFromList.Text = "Delete Spirit";
            Button_DeleteSpiritFromList.Click += Button_DeleteSpiritFromList_Click;
            // 
            // batchChangesToolStripMenuItem
            // 
            batchChangesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Button_RemoveAllSpirits, Button_ResetTool });
            batchChangesToolStripMenuItem.Name = "batchChangesToolStripMenuItem";
            batchChangesToolStripMenuItem.Size = new Size(196, 22);
            batchChangesToolStripMenuItem.Text = "Batch Changes";
            batchChangesToolStripMenuItem.Visible = false;
            // 
            // Button_RemoveAllSpirits
            // 
            Button_RemoveAllSpirits.Name = "Button_RemoveAllSpirits";
            Button_RemoveAllSpirits.Size = new Size(166, 22);
            Button_RemoveAllSpirits.Text = "Remove all spirits";
            // 
            // Button_ResetTool
            // 
            Button_ResetTool.Name = "Button_ResetTool";
            Button_ResetTool.Size = new Size(166, 22);
            Button_ResetTool.Text = "Reset to default";
            Button_ResetTool.Visible = false;
            // 
            // Menu_Settings
            // 
            Menu_Settings.DropDownItems.AddRange(new ToolStripItem[] { Option_ReduceEnemyMapCol, Option_EnableResummoning, Option_MoreSummonAreas, Option_HidePlayer, Option_SummonsEasilyFindTargets });
            Menu_Settings.Name = "Menu_Settings";
            Menu_Settings.Size = new Size(61, 20);
            Menu_Settings.Text = "Settings";
            // 
            // Option_ReduceEnemyMapCol
            // 
            Option_ReduceEnemyMapCol.Checked = true;
            Option_ReduceEnemyMapCol.CheckState = CheckState.Checked;
            Option_ReduceEnemyMapCol.Name = "Option_ReduceEnemyMapCol";
            Option_ReduceEnemyMapCol.Size = new Size(279, 22);
            Option_ReduceEnemyMapCol.Text = "Reduce Enemy Map Collision Radius";
            Option_ReduceEnemyMapCol.ToolTipText = "Helps prevent big enemies from spawning inside the ground and makes them fit inside of tight areas\r\n";
            Option_ReduceEnemyMapCol.Click += Option_ReduceEnemyMapCol_clicked;
            // 
            // Option_EnableResummoning
            // 
            Option_EnableResummoning.Checked = true;
            Option_EnableResummoning.CheckState = CheckState.Checked;
            Option_EnableResummoning.Name = "Option_EnableResummoning";
            Option_EnableResummoning.Size = new Size(279, 22);
            Option_EnableResummoning.Text = "Enable Resummoning (Cannot Undo)";
            Option_EnableResummoning.ToolTipText = "Allows resummoning spirit ashes repeatedly.\r\nAlso makes summons not disappear when defeating enemies in the area.\r\nThis setting requires restoring backups to undo.\r\n";
            Option_EnableResummoning.Click += Option_EnableResummoning_Click;
            // 
            // Option_MoreSummonAreas
            // 
            Option_MoreSummonAreas.Checked = true;
            Option_MoreSummonAreas.CheckState = CheckState.Checked;
            Option_MoreSummonAreas.Name = "Option_MoreSummonAreas";
            Option_MoreSummonAreas.Size = new Size(279, 22);
            Option_MoreSummonAreas.Text = "Expand Summon Areas (Cannot Undo)";
            Option_MoreSummonAreas.ToolTipText = "Greatly increases the number of areas you can summon spirits in.\r\nThis setting requires restoring backups to undo.";
            Option_MoreSummonAreas.Click += Option_MoreSummonAreas_Click;
            // 
            // Option_HidePlayer
            // 
            Option_HidePlayer.Name = "Option_HidePlayer";
            Option_HidePlayer.Size = new Size(279, 22);
            Option_HidePlayer.Text = "Hidden Player";
            Option_HidePlayer.ToolTipText = "Makes player invisible and unable to hurt/be hurt enemies";
            Option_HidePlayer.Click += Option_HidePlayer_Click;
            // 
            // Option_SummonsEasilyFindTargets
            // 
            Option_SummonsEasilyFindTargets.Name = "Option_SummonsEasilyFindTargets";
            Option_SummonsEasilyFindTargets.Size = new Size(279, 22);
            Option_SummonsEasilyFindTargets.Text = "Summons Easily Find Targets";
            Option_SummonsEasilyFindTargets.ToolTipText = "Makes summons find targets easily at long distances and through walls.\r\nAlso makes them not forget location of targets for a long period of time.\r\n";
            Option_SummonsEasilyFindTargets.Click += Option_SummonsEasilyFindTargets_Click;
            // 
            // Menu_Help
            // 
            Menu_Help.DropDownItems.AddRange(new ToolStripItem[] { Button_Info, Button_StatScalingLevelInfo, fAQToolStripMenuItem });
            Menu_Help.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Menu_Help.Name = "Menu_Help";
            Menu_Help.RightToLeft = RightToLeft.No;
            Menu_Help.Size = new Size(44, 20);
            Menu_Help.Text = "Help";
            // 
            // Button_Info
            // 
            Button_Info.Name = "Button_Info";
            Button_Info.Size = new Size(170, 22);
            Button_Info.Text = "How to use";
            Button_Info.Click += Button_Info_Click;
            // 
            // Button_StatScalingLevelInfo
            // 
            Button_StatScalingLevelInfo.Name = "Button_StatScalingLevelInfo";
            Button_StatScalingLevelInfo.RightToLeft = RightToLeft.No;
            Button_StatScalingLevelInfo.Size = new Size(170, 22);
            Button_StatScalingLevelInfo.Text = "Stat Scaling Levels";
            Button_StatScalingLevelInfo.Click += Button_StatScalingLevelInfo_Click;
            // 
            // fAQToolStripMenuItem
            // 
            fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            fAQToolStripMenuItem.Size = new Size(170, 22);
            fAQToolStripMenuItem.Text = "FAQ";
            fAQToolStripMenuItem.Click += fAQToolStripMenuItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(219, 247);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 76;
            label5.Text = "Summon Position";
            label5.Validated += EnemyWasEdited;
            // 
            // SpiritDataGrid
            // 
            SpiritDataGrid.AllowUserToAddRows = false;
            SpiritDataGrid.AllowUserToDeleteRows = false;
            SpiritDataGrid.AllowUserToResizeRows = false;
            SpiritDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SpiritDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SpiritDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpiritDataGrid.ContextMenuStrip = Context_DataGrid;
            SpiritDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            SpiritDataGrid.Location = new Point(4, 22);
            SpiritDataGrid.MultiSelect = false;
            SpiritDataGrid.Name = "SpiritDataGrid";
            SpiritDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SpiritDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SpiritDataGrid.RowHeadersVisible = false;
            SpiritDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            SpiritDataGrid.RowTemplate.Height = 25;
            SpiritDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SpiritDataGrid.ShowCellToolTips = false;
            SpiritDataGrid.Size = new Size(572, 304);
            SpiritDataGrid.TabIndex = 90;
            SpiritDataGrid.CellClick += SpiritDataGrid_CellClick;
            SpiritDataGrid.CellMouseDown += SpiritDataGrid_CellMouseDown;
            // 
            // Context_DataGrid
            // 
            Context_DataGrid.Items.AddRange(new ToolStripItem[] { Button_Context_DuplicateSpirit, Button_Context_RemoveSpirit });
            Context_DataGrid.Name = "Context_DataGrid";
            Context_DataGrid.Size = new Size(197, 48);
            // 
            // Button_Context_DuplicateSpirit
            // 
            Button_Context_DuplicateSpirit.Name = "Button_Context_DuplicateSpirit";
            Button_Context_DuplicateSpirit.ShortcutKeys = Keys.Control | Keys.D;
            Button_Context_DuplicateSpirit.Size = new Size(196, 22);
            Button_Context_DuplicateSpirit.Text = "Duplicate Spirit";
            Button_Context_DuplicateSpirit.Click += Button_DuplicateSpirit_Click;
            // 
            // Button_Context_RemoveSpirit
            // 
            Button_Context_RemoveSpirit.Name = "Button_Context_RemoveSpirit";
            Button_Context_RemoveSpirit.ShortcutKeys = Keys.Delete;
            Button_Context_RemoveSpirit.Size = new Size(196, 22);
            Button_Context_RemoveSpirit.Text = "Delete Spirit";
            Button_Context_RemoveSpirit.Click += Button_DeleteSpiritFromList_Click;
            // 
            // Team
            // 
            Team.HeaderText = "Team";
            Team.Name = "Team";
            // 
            // EnemyCol
            // 
            EnemyCol.HeaderText = "Enemy";
            EnemyCol.Name = "EnemyCol";
            // 
            // Variant
            // 
            Variant.HeaderText = "Variant";
            Variant.Name = "Variant";
            // 
            // Input_EnemyHpMult
            // 
            Input_EnemyHpMult.DecimalPlaces = 2;
            Input_EnemyHpMult.Location = new Point(6, 264);
            Input_EnemyHpMult.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Input_EnemyHpMult.Name = "Input_EnemyHpMult";
            Input_EnemyHpMult.Size = new Size(75, 23);
            Input_EnemyHpMult.TabIndex = 100;
            Input_EnemyHpMult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Input_EnemyHpMult.ValueChanged += EnemyWasEdited;
            Input_EnemyHpMult.Click += EnemyWasEdited;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1, 246);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 101;
            label14.Text = "Bonus HP Mult";
            label14.Click += EnemyWasEdited;
            label14.Validated += EnemyWasEdited;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1, 291);
            label15.Name = "label15";
            label15.Size = new Size(115, 15);
            label15.TabIndex = 103;
            label15.Text = "Bonus Damage Mult";
            label15.Validated += EnemyWasEdited;
            // 
            // Input_EnemyDamageMult
            // 
            Input_EnemyDamageMult.DecimalPlaces = 2;
            Input_EnemyDamageMult.Location = new Point(6, 309);
            Input_EnemyDamageMult.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            Input_EnemyDamageMult.Name = "Input_EnemyDamageMult";
            Input_EnemyDamageMult.Size = new Size(75, 23);
            Input_EnemyDamageMult.TabIndex = 102;
            Input_EnemyDamageMult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Input_EnemyDamageMult.ValueChanged += EnemyWasEdited;
            Input_EnemyDamageMult.Click += EnemyWasEdited;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 67);
            label18.Name = "label18";
            label18.Size = new Size(70, 15);
            label18.TabIndex = 109;
            label18.Text = "Team Name";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(Label_SearchSpiritAshText);
            groupBox1.Controls.Add(Search_SpiritAsh);
            groupBox1.Controls.Add(Option_TargetAllSpiritAshes);
            groupBox1.Controls.Add(Option_SpiritAshNoRequirements);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(List_SpiritAsh);
            groupBox1.Location = new Point(977, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 159);
            groupBox1.TabIndex = 112;
            groupBox1.TabStop = false;
            groupBox1.Text = "Targeted Spirit Ash";
            // 
            // Option_TargetAllSpiritAshes
            // 
            Option_TargetAllSpiritAshes.AutoSize = true;
            Option_TargetAllSpiritAshes.Location = new Point(6, 136);
            Option_TargetAllSpiritAshes.Name = "Option_TargetAllSpiritAshes";
            Option_TargetAllSpiritAshes.Size = new Size(74, 19);
            Option_TargetAllSpiritAshes.TabIndex = 76;
            Option_TargetAllSpiritAshes.Text = "All Ashes";
            Option_TargetAllSpiritAshes.UseVisualStyleBackColor = true;
            Option_TargetAllSpiritAshes.Visible = false;
            Option_TargetAllSpiritAshes.CheckedChanged += Option_TargetAllSpiritAshes_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(Option_Spirit_SearchesLongRange);
            groupBox2.Controls.Add(Input_CharaInitID);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(Label_SearchEnemyText);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(List_EnemyChosenTeam);
            groupBox2.Controls.Add(Button_PickRandomEnemy);
            groupBox2.Controls.Add(List_Enemy);
            groupBox2.Controls.Add(SummonPosition_X);
            groupBox2.Controls.Add(Search_Enemy);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(SummonPosition_Z);
            groupBox2.Controls.Add(SummonPosition_Angle);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(List_EnemyVariant);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(Input_NpcParamID);
            groupBox2.Controls.Add(Input_EnemyDamageMult);
            groupBox2.Controls.Add(Input_NpcThinkID);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Input_EnemyHpMult);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(List_StatScaling);
            groupBox2.Location = new Point(598, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 368);
            groupBox2.TabIndex = 113;
            groupBox2.TabStop = false;
            groupBox2.Text = "Summon";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(Option_TeamFollowPlayer);
            groupBox3.Controls.Add(Option_Randomize_PhantomColor);
            groupBox3.Controls.Add(Group_TeamSummonPos_Manual);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(Input_TeamDamageMult);
            groupBox3.Controls.Add(Button_AddNewTeam);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(Input_TeamHpMult);
            groupBox3.Controls.Add(Button_RandomTeamName);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(List_TeamPhantomColor);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(Input_TeamName);
            groupBox3.Controls.Add(List_TeamType);
            groupBox3.Location = new Point(598, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(566, 143);
            groupBox3.TabIndex = 114;
            groupBox3.TabStop = false;
            groupBox3.Text = "Team";
            // 
            // Group_TeamSummonPos_Manual
            // 
            Group_TeamSummonPos_Manual.Controls.Add(List_TeamSummonPreset);
            Group_TeamSummonPos_Manual.Controls.Add(Input_TeamSummonPos_Ang);
            Group_TeamSummonPos_Manual.Controls.Add(label21);
            Group_TeamSummonPos_Manual.Controls.Add(label22);
            Group_TeamSummonPos_Manual.Controls.Add(label23);
            Group_TeamSummonPos_Manual.Controls.Add(Input_TeamSummonPos_Z);
            Group_TeamSummonPos_Manual.Controls.Add(Input_TeamSummonPos_X);
            Group_TeamSummonPos_Manual.Location = new Point(414, 0);
            Group_TeamSummonPos_Manual.Name = "Group_TeamSummonPos_Manual";
            Group_TeamSummonPos_Manual.Size = new Size(152, 143);
            Group_TeamSummonPos_Manual.TabIndex = 116;
            Group_TeamSummonPos_Manual.TabStop = false;
            Group_TeamSummonPos_Manual.Text = "Team Summon Position";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(Button_AddRandomSpirit);
            groupBox4.Controls.Add(SpiritDataGrid);
            groupBox4.Location = new Point(12, 218);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(580, 359);
            groupBox4.TabIndex = 115;
            groupBox4.TabStop = false;
            groupBox4.Text = "Summons";
            // 
            // TeamDataGrid
            // 
            TeamDataGrid.AllowUserToAddRows = false;
            TeamDataGrid.AllowUserToDeleteRows = false;
            TeamDataGrid.AllowUserToResizeRows = false;
            TeamDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TeamDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TeamDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeamDataGrid.ContextMenuStrip = Context_TeamDataGrid;
            TeamDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            TeamDataGrid.Location = new Point(4, 22);
            TeamDataGrid.MultiSelect = false;
            TeamDataGrid.Name = "TeamDataGrid";
            TeamDataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TeamDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TeamDataGrid.RowHeadersVisible = false;
            TeamDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            TeamDataGrid.RowTemplate.Height = 25;
            TeamDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TeamDataGrid.ShowCellToolTips = false;
            TeamDataGrid.Size = new Size(572, 157);
            TeamDataGrid.TabIndex = 113;
            TeamDataGrid.CellClick += TeamDataGrid_CellClick;
            TeamDataGrid.CellMouseDown += TeamDataGrid_CellMouseDown;
            // 
            // Context_TeamDataGrid
            // 
            Context_TeamDataGrid.Items.AddRange(new ToolStripItem[] { Button_Context_DuplicateTeam, Button_Context_DeleteTeam });
            Context_TeamDataGrid.Name = "Context_DataGrid";
            Context_TeamDataGrid.Size = new Size(149, 48);
            // 
            // Button_Context_DuplicateTeam
            // 
            Button_Context_DuplicateTeam.Name = "Button_Context_DuplicateTeam";
            Button_Context_DuplicateTeam.ShowShortcutKeys = false;
            Button_Context_DuplicateTeam.Size = new Size(148, 22);
            Button_Context_DuplicateTeam.Text = "Duplicate Team";
            Button_Context_DuplicateTeam.Click += Button_DuplicateTeam_Click;
            // 
            // Button_Context_DeleteTeam
            // 
            Button_Context_DeleteTeam.Name = "Button_Context_DeleteTeam";
            Button_Context_DeleteTeam.ShowShortcutKeys = false;
            Button_Context_DeleteTeam.Size = new Size(148, 22);
            Button_Context_DeleteTeam.Text = "Remove Team";
            Button_Context_DeleteTeam.Click += Button_DeleteTeam_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(TeamDataGrid);
            groupBox5.Location = new Point(12, 27);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(580, 185);
            groupBox5.TabIndex = 116;
            groupBox5.TabStop = false;
            groupBox5.Text = "Teams";
            // 
            // groupBoxRandomize
            // 
            groupBoxRandomize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxRandomize.Controls.Add(comboBox1);
            groupBoxRandomize.Controls.Add(label25);
            groupBoxRandomize.Controls.Add(label24);
            groupBoxRandomize.Controls.Add(numericUpDown1);
            groupBoxRandomize.Controls.Add(Button_Randomize_SvE);
            groupBoxRandomize.Controls.Add(Button_Randomize_PvE);
            groupBoxRandomize.Location = new Point(977, 176);
            groupBoxRandomize.Name = "groupBoxRandomize";
            groupBoxRandomize.Size = new Size(187, 200);
            groupBoxRandomize.TabIndex = 113;
            groupBoxRandomize.TabStop = false;
            groupBoxRandomize.Text = "Randomizer";
            groupBoxRandomize.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 123;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 141);
            label25.Name = "label25";
            label25.Size = new Size(98, 15);
            label25.TabIndex = 122;
            label25.Text = "Stat Scaling Level";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 86);
            label24.Name = "label24";
            label24.Size = new Size(103, 15);
            label24.TabIndex = 114;
            label24.Text = "Summon Amount";
            // 
            // Button_Randomize_SvE
            // 
            Button_Randomize_SvE.Location = new Point(6, 51);
            Button_Randomize_SvE.Name = "Button_Randomize_SvE";
            Button_Randomize_SvE.Size = new Size(140, 23);
            Button_Randomize_SvE.TabIndex = 1;
            Button_Randomize_SvE.Text = "Summons vs Enemies";
            Button_Randomize_SvE.UseVisualStyleBackColor = true;
            // 
            // Button_Randomize_PvE
            // 
            Button_Randomize_PvE.Location = new Point(6, 22);
            Button_Randomize_PvE.Name = "Button_Randomize_PvE";
            Button_Randomize_PvE.Size = new Size(140, 23);
            Button_Randomize_PvE.TabIndex = 0;
            Button_Randomize_PvE.Text = "Player vs enemies";
            Button_Randomize_PvE.UseVisualStyleBackColor = true;
            // 
            // FileDialog_LoadJson
            // 
            FileDialog_LoadJson.DefaultExt = "json";
            FileDialog_LoadJson.Filter = "Json backup|*.json|All Files|*.*";
            FileDialog_LoadJson.RestoreDirectory = true;
            FileDialog_LoadJson.Title = "Choose summon backup to load";
            // 
            // FileDialog_SaveJson
            // 
            FileDialog_SaveJson.DefaultExt = "json";
            FileDialog_SaveJson.Filter = "Json backup|*.json|All Files|*.*";
            FileDialog_SaveJson.RestoreDirectory = true;
            FileDialog_SaveJson.Title = "Choose where to save summon backup";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 589);
            Controls.Add(groupBoxRandomize);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(t_console);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Elden Ring Spirit Battler";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)SummonPosition_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)SummonPosition_Z).EndInit();
            ((System.ComponentModel.ISupportInitialize)SummonPosition_Angle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_X).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_Z).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamSummonPos_Ang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_NpcParamID).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_NpcThinkID).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamDamageMult).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_TeamHpMult).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_CharaInitID).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpiritDataGrid).EndInit();
            Context_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Input_EnemyHpMult).EndInit();
            ((System.ComponentModel.ISupportInitialize)Input_EnemyDamageMult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            Group_TeamSummonPos_Manual.ResumeLayout(false);
            Group_TeamSummonPos_Manual.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TeamDataGrid).EndInit();
            Context_TeamDataGrid.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBoxRandomize.ResumeLayout(false);
            groupBoxRandomize.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog FileDialog_Regulation;
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
        private Label Label_SearchEnemyText;
        private Button Option_Randomize_PhantomColor;
        private Label Label_SearchSpiritAshText;
        private TextBox Search_SpiritAsh;
        private ToolStripMenuItem Option_MoreSummonAreas;
        private ToolStripMenuItem Option_EnableResummoning;
        private ToolStripMenuItem fAQToolStripMenuItem;
        private NumericUpDown Input_CharaInitID;
        private Label label9;
        private CheckBox Option_TeamFollowPlayer;
        private ToolStripMenuItem saveLoadPresetToolStripMenuItem;
        private ToolStripMenuItem Button_SaveSummonBackup;
        private ToolStripMenuItem Button_LoadSummonBackup;
        private OpenFileDialog FileDialog_LoadJson;
        private SaveFileDialog FileDialog_SaveJson;
        private ToolStripMenuItem Option_SummonsEasilyFindTargets;
        private CheckBox Option_Spirit_SearchesLongRange;
    }
}