namespace GandusR6
{
    partial class Form1
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
            panel1 = new Panel();
            RecoilOn = new CheckBox();
            SettingsBtn = new Button();
            RecoilPageBtn = new Button();
            HomeBtn = new Button();
            panel2 = new Panel();
            CloseBtn = new Button();
            GANDUSR6 = new Label();
            HomePanel = new Panel();
            lbGameStatus = new Label();
            LiveTime = new Label();
            HomeTitle = new Label();
            RecoilPanel = new Panel();
            RecoilTitle = new Label();
            panelRcSell = new Panel();
            btnRcSellMp = new Button();
            btnRcSellAr = new Button();
            btnRcSellSmg = new Button();
            panelRcSmg = new Panel();
            btnSMGBack = new Button();
            lbSubmachineGuns = new Label();
            panelWpSmg = new FlowLayoutPanel();
            panelMP = new Panel();
            panelWpMp = new FlowLayoutPanel();
            btnMPBack = new Button();
            lbMP = new Label();
            panelRcAr = new Panel();
            panelWpAr = new FlowLayoutPanel();
            btnBackAr = new Button();
            lbRcAr = new Label();
            panelRcSet = new Panel();
            btnRcLoad = new Button();
            btnRcSave = new Button();
            xBar = new TrackBar();
            yBar = new TrackBar();
            btnBackRcSet = new Button();
            lbPosX = new Label();
            lbPosY = new Label();
            lbRcWeponSet = new Label();
            SettingsPanel = new Panel();
            SettingsTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            recoilTimer = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            HomePanel.SuspendLayout();
            RecoilPanel.SuspendLayout();
            panelRcSell.SuspendLayout();
            panelRcSmg.SuspendLayout();
            panelMP.SuspendLayout();
            panelRcAr.SuspendLayout();
            panelRcSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yBar).BeginInit();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 49, 54);
            panel1.Controls.Add(RecoilOn);
            panel1.Controls.Add(SettingsBtn);
            panel1.Controls.Add(RecoilPageBtn);
            panel1.Controls.Add(HomeBtn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 603);
            panel1.TabIndex = 0;
            // 
            // RecoilOn
            // 
            RecoilOn.AutoSize = true;
            RecoilOn.FlatAppearance.BorderSize = 0;
            RecoilOn.FlatStyle = FlatStyle.Flat;
            RecoilOn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoilOn.ForeColor = Color.White;
            RecoilOn.Location = new Point(35, 524);
            RecoilOn.Name = "RecoilOn";
            RecoilOn.Size = new Size(131, 34);
            RecoilOn.TabIndex = 11;
            RecoilOn.Text = "Recoil On";
            RecoilOn.UseVisualStyleBackColor = true;
            RecoilOn.CheckedChanged += RecoilOn_CheckedChanged;
            // 
            // SettingsBtn
            // 
            SettingsBtn.BackColor = Color.FromArgb(64, 68, 75);
            SettingsBtn.FlatAppearance.BorderColor = Color.White;
            SettingsBtn.FlatAppearance.BorderSize = 0;
            SettingsBtn.FlatStyle = FlatStyle.Flat;
            SettingsBtn.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsBtn.ForeColor = Color.White;
            SettingsBtn.Location = new Point(0, 277);
            SettingsBtn.Name = "SettingsBtn";
            SettingsBtn.Size = new Size(214, 65);
            SettingsBtn.TabIndex = 1;
            SettingsBtn.Text = "Settings";
            SettingsBtn.UseVisualStyleBackColor = false;
            SettingsBtn.Click += SettingsBtn_Click;
            // 
            // RecoilPageBtn
            // 
            RecoilPageBtn.BackColor = Color.FromArgb(64, 68, 75);
            RecoilPageBtn.FlatAppearance.BorderColor = Color.White;
            RecoilPageBtn.FlatAppearance.BorderSize = 0;
            RecoilPageBtn.FlatStyle = FlatStyle.Flat;
            RecoilPageBtn.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoilPageBtn.ForeColor = Color.White;
            RecoilPageBtn.Location = new Point(0, 206);
            RecoilPageBtn.Name = "RecoilPageBtn";
            RecoilPageBtn.Size = new Size(214, 65);
            RecoilPageBtn.TabIndex = 1;
            RecoilPageBtn.Text = "Recoil";
            RecoilPageBtn.UseVisualStyleBackColor = false;
            RecoilPageBtn.Click += RecoilPageBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(64, 68, 75);
            HomeBtn.FlatAppearance.BorderColor = Color.White;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Location = new Point(0, 135);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(214, 65);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 119);
            panel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(64, 68, 75);
            CloseBtn.FlatAppearance.BorderColor = Color.White;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Nirmala UI", 8.142858F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(1226, -2);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(62, 39);
            CloseBtn.TabIndex = 2;
            CloseBtn.Text = "X";
            CloseBtn.TextAlign = ContentAlignment.TopCenter;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // GANDUSR6
            // 
            GANDUSR6.AutoSize = true;
            GANDUSR6.Font = new Font("Nirmala UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GANDUSR6.ForeColor = Color.White;
            GANDUSR6.Location = new Point(12, 5);
            GANDUSR6.Name = "GANDUSR6";
            GANDUSR6.Size = new Size(150, 32);
            GANDUSR6.TabIndex = 0;
            GANDUSR6.Text = "Gandus ReC";
            // 
            // HomePanel
            // 
            HomePanel.BackColor = Color.FromArgb(44, 47, 51);
            HomePanel.Controls.Add(lbGameStatus);
            HomePanel.Controls.Add(LiveTime);
            HomePanel.Controls.Add(HomeTitle);
            HomePanel.Location = new Point(217, 40);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1086, 617);
            HomePanel.TabIndex = 1;
            HomePanel.Paint += panel3_Paint;
            // 
            // lbGameStatus
            // 
            lbGameStatus.AutoSize = true;
            lbGameStatus.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGameStatus.ForeColor = Color.Chartreuse;
            lbGameStatus.Location = new Point(430, 9);
            lbGameStatus.Name = "lbGameStatus";
            lbGameStatus.Size = new Size(194, 37);
            lbGameStatus.TabIndex = 2;
            lbGameStatus.Text = "R6 Not Found";
            lbGameStatus.Click += lbGameStatus_Click;
            // 
            // LiveTime
            // 
            LiveTime.AutoSize = true;
            LiveTime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LiveTime.Location = new Point(921, 9);
            LiveTime.Name = "LiveTime";
            LiveTime.Size = new Size(89, 38);
            LiveTime.TabIndex = 1;
            LiveTime.Text = "00:00";
            // 
            // HomeTitle
            // 
            HomeTitle.AutoSize = true;
            HomeTitle.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeTitle.ForeColor = Color.White;
            HomeTitle.Location = new Point(13, 9);
            HomeTitle.Name = "HomeTitle";
            HomeTitle.Size = new Size(113, 45);
            HomeTitle.TabIndex = 0;
            HomeTitle.Text = "Home";
            // 
            // RecoilPanel
            // 
            RecoilPanel.BackColor = Color.FromArgb(44, 47, 51);
            RecoilPanel.Controls.Add(RecoilTitle);
            RecoilPanel.Controls.Add(panelRcSell);
            RecoilPanel.Controls.Add(panelRcSmg);
            RecoilPanel.Controls.Add(panelMP);
            RecoilPanel.Controls.Add(panelRcAr);
            RecoilPanel.Location = new Point(217, 40);
            RecoilPanel.Name = "RecoilPanel";
            RecoilPanel.Size = new Size(1086, 617);
            RecoilPanel.TabIndex = 1;
            RecoilPanel.Visible = false;
            RecoilPanel.Paint += panel3_Paint;
            // 
            // RecoilTitle
            // 
            RecoilTitle.AutoSize = true;
            RecoilTitle.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecoilTitle.ForeColor = Color.White;
            RecoilTitle.Location = new Point(13, 9);
            RecoilTitle.Name = "RecoilTitle";
            RecoilTitle.Size = new Size(113, 45);
            RecoilTitle.TabIndex = 0;
            RecoilTitle.Text = "Recoil";
            // 
            // panelRcSell
            // 
            panelRcSell.AutoScroll = true;
            panelRcSell.Controls.Add(btnRcSellMp);
            panelRcSell.Controls.Add(btnRcSellAr);
            panelRcSell.Controls.Add(btnRcSellSmg);
            panelRcSell.Location = new Point(0, 54);
            panelRcSell.Name = "panelRcSell";
            panelRcSell.Size = new Size(1057, 533);
            panelRcSell.TabIndex = 1;
            // 
            // btnRcSellMp
            // 
            btnRcSellMp.BackColor = Color.FromArgb(64, 68, 75);
            btnRcSellMp.FlatAppearance.BorderColor = Color.White;
            btnRcSellMp.FlatAppearance.BorderSize = 0;
            btnRcSellMp.FlatStyle = FlatStyle.Flat;
            btnRcSellMp.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRcSellMp.ForeColor = Color.White;
            btnRcSellMp.Image = Properties.Resources.R6S_wpn_SMG_12;
            btnRcSellMp.ImageAlign = ContentAlignment.TopCenter;
            btnRcSellMp.Location = new Point(559, 16);
            btnRcSellMp.Name = "btnRcSellMp";
            btnRcSellMp.Size = new Size(282, 151);
            btnRcSellMp.TabIndex = 5;
            btnRcSellMp.Text = "Machine Pistols";
            btnRcSellMp.TextAlign = ContentAlignment.BottomCenter;
            btnRcSellMp.UseVisualStyleBackColor = false;
            btnRcSellMp.Click += btnRcSellMp_Click;
            // 
            // btnRcSellAr
            // 
            btnRcSellAr.BackColor = Color.FromArgb(64, 68, 75);
            btnRcSellAr.FlatAppearance.BorderColor = Color.White;
            btnRcSellAr.FlatAppearance.BorderSize = 0;
            btnRcSellAr.FlatStyle = FlatStyle.Flat;
            btnRcSellAr.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRcSellAr.ForeColor = Color.White;
            btnRcSellAr.Image = Properties.Resources.R6S_wpn_R4_C;
            btnRcSellAr.ImageAlign = ContentAlignment.TopCenter;
            btnRcSellAr.Location = new Point(271, 16);
            btnRcSellAr.Name = "btnRcSellAr";
            btnRcSellAr.Size = new Size(282, 151);
            btnRcSellAr.TabIndex = 4;
            btnRcSellAr.Text = "Assault Rifles";
            btnRcSellAr.TextAlign = ContentAlignment.BottomCenter;
            btnRcSellAr.UseVisualStyleBackColor = false;
            btnRcSellAr.Click += btnRcSellAr_Click;
            // 
            // btnRcSellSmg
            // 
            btnRcSellSmg.BackColor = Color.FromArgb(64, 68, 75);
            btnRcSellSmg.FlatAppearance.BorderColor = Color.White;
            btnRcSellSmg.FlatAppearance.BorderSize = 0;
            btnRcSellSmg.FlatStyle = FlatStyle.Flat;
            btnRcSellSmg.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRcSellSmg.ForeColor = Color.White;
            btnRcSellSmg.Image = Properties.Resources.R6S_MP5;
            btnRcSellSmg.ImageAlign = ContentAlignment.TopCenter;
            btnRcSellSmg.Location = new Point(13, 16);
            btnRcSellSmg.Name = "btnRcSellSmg";
            btnRcSellSmg.Size = new Size(252, 151);
            btnRcSellSmg.TabIndex = 3;
            btnRcSellSmg.Text = "Submachine Guns";
            btnRcSellSmg.TextAlign = ContentAlignment.BottomCenter;
            btnRcSellSmg.UseVisualStyleBackColor = false;
            btnRcSellSmg.Click += btnRcSellSmg_Click;
            // 
            // panelRcSmg
            // 
            panelRcSmg.BackColor = Color.FromArgb(32, 34, 37);
            panelRcSmg.Controls.Add(btnSMGBack);
            panelRcSmg.Controls.Add(lbSubmachineGuns);
            panelRcSmg.Controls.Add(panelWpSmg);
            panelRcSmg.Location = new Point(6, 54);
            panelRcSmg.Name = "panelRcSmg";
            panelRcSmg.Size = new Size(1080, 568);
            panelRcSmg.TabIndex = 6;
            panelRcSmg.Visible = false;
            // 
            // btnSMGBack
            // 
            btnSMGBack.BackColor = Color.FromArgb(64, 68, 75);
            btnSMGBack.FlatAppearance.BorderColor = Color.White;
            btnSMGBack.FlatAppearance.BorderSize = 0;
            btnSMGBack.FlatStyle = FlatStyle.Flat;
            btnSMGBack.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSMGBack.ForeColor = Color.White;
            btnSMGBack.Location = new Point(903, 11);
            btnSMGBack.Name = "btnSMGBack";
            btnSMGBack.Size = new Size(146, 45);
            btnSMGBack.TabIndex = 3;
            btnSMGBack.Text = "Back";
            btnSMGBack.UseVisualStyleBackColor = false;
            btnSMGBack.Click += btnSMGBack_Click;
            // 
            // lbSubmachineGuns
            // 
            lbSubmachineGuns.AutoSize = true;
            lbSubmachineGuns.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubmachineGuns.ForeColor = Color.White;
            lbSubmachineGuns.Location = new Point(10, 8);
            lbSubmachineGuns.Name = "lbSubmachineGuns";
            lbSubmachineGuns.Size = new Size(297, 45);
            lbSubmachineGuns.TabIndex = 7;
            lbSubmachineGuns.Text = "Submachine Guns";
            // 
            // panelWpSmg
            // 
            panelWpSmg.Location = new Point(7, 65);
            panelWpSmg.Name = "panelWpSmg";
            panelWpSmg.Size = new Size(1047, 468);
            panelWpSmg.TabIndex = 10;
            // 
            // panelMP
            // 
            panelMP.BackColor = Color.FromArgb(32, 34, 37);
            panelMP.Controls.Add(panelWpMp);
            panelMP.Controls.Add(btnMPBack);
            panelMP.Controls.Add(lbMP);
            panelMP.Location = new Point(0, 54);
            panelMP.Name = "panelMP";
            panelMP.Size = new Size(1080, 571);
            panelMP.TabIndex = 9;
            panelMP.Visible = false;
            // 
            // panelWpMp
            // 
            panelWpMp.Location = new Point(13, 65);
            panelWpMp.Name = "panelWpMp";
            panelWpMp.Size = new Size(1039, 506);
            panelWpMp.TabIndex = 8;
            // 
            // btnMPBack
            // 
            btnMPBack.BackColor = Color.FromArgb(64, 68, 75);
            btnMPBack.FlatAppearance.BorderColor = Color.White;
            btnMPBack.FlatAppearance.BorderSize = 0;
            btnMPBack.FlatStyle = FlatStyle.Flat;
            btnMPBack.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMPBack.ForeColor = Color.White;
            btnMPBack.Location = new Point(908, 8);
            btnMPBack.Name = "btnMPBack";
            btnMPBack.Size = new Size(146, 45);
            btnMPBack.TabIndex = 3;
            btnMPBack.Text = "Back";
            btnMPBack.UseVisualStyleBackColor = false;
            btnMPBack.Click += btnMPBack_Click;
            // 
            // lbMP
            // 
            lbMP.AutoSize = true;
            lbMP.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMP.ForeColor = Color.White;
            lbMP.Location = new Point(10, 8);
            lbMP.Name = "lbMP";
            lbMP.Size = new Size(263, 45);
            lbMP.TabIndex = 7;
            lbMP.Text = "Machine Pistols";
            // 
            // panelRcAr
            // 
            panelRcAr.BackColor = Color.FromArgb(32, 34, 37);
            panelRcAr.Controls.Add(panelWpAr);
            panelRcAr.Controls.Add(btnBackAr);
            panelRcAr.Controls.Add(lbRcAr);
            panelRcAr.Location = new Point(3, 57);
            panelRcAr.Name = "panelRcAr";
            panelRcAr.Size = new Size(1068, 564);
            panelRcAr.TabIndex = 10;
            panelRcAr.Visible = false;
            // 
            // panelWpAr
            // 
            panelWpAr.Location = new Point(13, 65);
            panelWpAr.Name = "panelWpAr";
            panelWpAr.Size = new Size(1039, 806);
            panelWpAr.TabIndex = 8;
            // 
            // btnBackAr
            // 
            btnBackAr.BackColor = Color.FromArgb(64, 68, 75);
            btnBackAr.FlatAppearance.BorderColor = Color.White;
            btnBackAr.FlatAppearance.BorderSize = 0;
            btnBackAr.FlatStyle = FlatStyle.Flat;
            btnBackAr.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackAr.ForeColor = Color.White;
            btnBackAr.Location = new Point(908, 8);
            btnBackAr.Name = "btnBackAr";
            btnBackAr.Size = new Size(146, 45);
            btnBackAr.TabIndex = 3;
            btnBackAr.Text = "Back";
            btnBackAr.UseVisualStyleBackColor = false;
            btnBackAr.Click += btnBackAr_Click;
            // 
            // lbRcAr
            // 
            lbRcAr.AutoSize = true;
            lbRcAr.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRcAr.ForeColor = Color.White;
            lbRcAr.Location = new Point(10, 8);
            lbRcAr.Name = "lbRcAr";
            lbRcAr.Size = new Size(228, 45);
            lbRcAr.TabIndex = 7;
            lbRcAr.Text = "Assault Rifles";
            // 
            // panelRcSet
            // 
            panelRcSet.BackColor = Color.FromArgb(32, 34, 37);
            panelRcSet.Controls.Add(btnRcLoad);
            panelRcSet.Controls.Add(btnRcSave);
            panelRcSet.Controls.Add(xBar);
            panelRcSet.Controls.Add(yBar);
            panelRcSet.Controls.Add(btnBackRcSet);
            panelRcSet.Controls.Add(lbPosX);
            panelRcSet.Controls.Add(lbPosY);
            panelRcSet.Controls.Add(lbRcWeponSet);
            panelRcSet.Location = new Point(217, 49);
            panelRcSet.Name = "panelRcSet";
            panelRcSet.Size = new Size(1080, 565);
            panelRcSet.TabIndex = 8;
            // 
            // btnRcLoad
            // 
            btnRcLoad.BackColor = Color.FromArgb(64, 68, 75);
            btnRcLoad.FlatAppearance.BorderColor = Color.White;
            btnRcLoad.FlatAppearance.BorderSize = 0;
            btnRcLoad.FlatStyle = FlatStyle.Flat;
            btnRcLoad.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRcLoad.ForeColor = Color.White;
            btnRcLoad.Location = new Point(452, 417);
            btnRcLoad.Name = "btnRcLoad";
            btnRcLoad.Size = new Size(146, 45);
            btnRcLoad.TabIndex = 11;
            btnRcLoad.Text = "Load";
            btnRcLoad.UseVisualStyleBackColor = false;
            btnRcLoad.Click += btnRcLoad_Click;
            // 
            // btnRcSave
            // 
            btnRcSave.BackColor = Color.FromArgb(64, 68, 75);
            btnRcSave.FlatAppearance.BorderColor = Color.White;
            btnRcSave.FlatAppearance.BorderSize = 0;
            btnRcSave.FlatStyle = FlatStyle.Flat;
            btnRcSave.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRcSave.ForeColor = Color.White;
            btnRcSave.Location = new Point(286, 417);
            btnRcSave.Name = "btnRcSave";
            btnRcSave.Size = new Size(146, 45);
            btnRcSave.TabIndex = 10;
            btnRcSave.Text = "Save";
            btnRcSave.UseVisualStyleBackColor = false;
            btnRcSave.Click += btnRcSave_Click;
            // 
            // xBar
            // 
            xBar.Location = new Point(230, 348);
            xBar.Maximum = 100;
            xBar.Minimum = -100;
            xBar.Name = "xBar";
            xBar.RightToLeftLayout = true;
            xBar.Size = new Size(441, 80);
            xBar.TabIndex = 9;
            xBar.TickFrequency = 5;
            xBar.Scroll += xBar_Scroll_1;
            // 
            // yBar
            // 
            yBar.Location = new Point(230, 181);
            yBar.Maximum = 100;
            yBar.Name = "yBar";
            yBar.RightToLeftLayout = true;
            yBar.Size = new Size(441, 80);
            yBar.TabIndex = 8;
            yBar.TickFrequency = 5;
            yBar.Scroll += yBar_Scroll;
            // 
            // btnBackRcSet
            // 
            btnBackRcSet.BackColor = Color.FromArgb(64, 68, 75);
            btnBackRcSet.FlatAppearance.BorderColor = Color.White;
            btnBackRcSet.FlatAppearance.BorderSize = 0;
            btnBackRcSet.FlatStyle = FlatStyle.Flat;
            btnBackRcSet.Font = new Font("Nirmala UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackRcSet.ForeColor = Color.White;
            btnBackRcSet.Location = new Point(911, 12);
            btnBackRcSet.Name = "btnBackRcSet";
            btnBackRcSet.Size = new Size(146, 45);
            btnBackRcSet.TabIndex = 3;
            btnBackRcSet.Text = "Back";
            btnBackRcSet.UseVisualStyleBackColor = false;
            btnBackRcSet.Click += btnBackRcSet_Click;
            // 
            // lbPosX
            // 
            lbPosX.AutoSize = true;
            lbPosX.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPosX.ForeColor = Color.White;
            lbPosX.Location = new Point(377, 284);
            lbPosX.Name = "lbPosX";
            lbPosX.Size = new Size(151, 45);
            lbPosX.TabIndex = 7;
            lbPosX.Text = "Pos X : 0";
            lbPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPosY
            // 
            lbPosY.AutoSize = true;
            lbPosY.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPosY.ForeColor = Color.White;
            lbPosY.Location = new Point(379, 110);
            lbPosY.Name = "lbPosY";
            lbPosY.Size = new Size(149, 45);
            lbPosY.TabIndex = 7;
            lbPosY.Text = "Pos Y : 0";
            lbPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbRcWeponSet
            // 
            lbRcWeponSet.AutoSize = true;
            lbRcWeponSet.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRcWeponSet.ForeColor = Color.White;
            lbRcWeponSet.Location = new Point(10, 8);
            lbRcWeponSet.Name = "lbRcWeponSet";
            lbRcWeponSet.Size = new Size(190, 45);
            lbRcWeponSet.TabIndex = 7;
            lbRcWeponSet.Text = "Calibration";
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.FromArgb(44, 47, 51);
            SettingsPanel.Controls.Add(SettingsTitle);
            SettingsPanel.Location = new Point(217, 40);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(1086, 617);
            SettingsPanel.TabIndex = 1;
            SettingsPanel.Paint += panel3_Paint;
            // 
            // SettingsTitle
            // 
            SettingsTitle.AutoSize = true;
            SettingsTitle.Font = new Font("Nirmala UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsTitle.ForeColor = Color.White;
            SettingsTitle.Location = new Point(13, 9);
            SettingsTitle.Name = "SettingsTitle";
            SettingsTitle.Size = new Size(147, 45);
            SettingsTitle.TabIndex = 0;
            SettingsTitle.Text = "Settings";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // recoilTimer
            // 
            recoilTimer.Interval = 1;
            recoilTimer.Tick += recoilTimer_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(32, 34, 37);
            ClientSize = new Size(1281, 642);
            Controls.Add(CloseBtn);
            Controls.Add(panel1);
            Controls.Add(GANDUSR6);
            Controls.Add(HomePanel);
            Controls.Add(SettingsPanel);
            Controls.Add(panelRcSet);
            Controls.Add(RecoilPanel);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            RecoilPanel.ResumeLayout(false);
            RecoilPanel.PerformLayout();
            panelRcSell.ResumeLayout(false);
            panelRcSmg.ResumeLayout(false);
            panelRcSmg.PerformLayout();
            panelMP.ResumeLayout(false);
            panelMP.PerformLayout();
            panelRcAr.ResumeLayout(false);
            panelRcAr.PerformLayout();
            panelRcSet.ResumeLayout(false);
            panelRcSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)xBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)yBar).EndInit();
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button HomeBtn;
        private Button SettingsBtn;
        private Button RecoilPageBtn;
        private Panel HomePanel;
        private Panel RecoilPanel;
        private Label RecoilTitle;
        private Label HomeTitle;
        private Panel SettingsPanel;
        private Label SettingsTitle;
        private Label LiveTime;
        private System.Windows.Forms.Timer timer1;
        private Label GANDUSR6;
        private Button CloseBtn;
        private Panel panelRcSell;
        private Button btnRcSellSmg;
        private Button btnRcSellMp;
        private Button btnRcSellAr;
        private Panel panelRcSmg;
        private Button btnSMGBack;
        private Label lbSubmachineGuns;
        private Button btnMp5;
        private Panel panelRcSet;
        private TrackBar yBar;
        private Button btnBackRcSet;
        private Label lbRcWeponSet;
        private Label lbPosY;
        private Label lbPosX;
        private TrackBar xBar;
        private CheckBox RecoilOn;
        private System.Windows.Forms.Timer recoilTimer;
        private Button btnVector45ACP;
        private Panel panelMP;
        private Button btnMPBack;
        private Label lbMP;
        private Button btnRcLoad;
        private Button btnRcSave;
        private FlowLayoutPanel panelWpSmg;
        private FlowLayoutPanel panelWpMp;
        private Panel panelRcAr;
        private FlowLayoutPanel panelWpAr;
        private Button btnBackAr;
        private Label lbRcAr;
        private Label lbGameStatus;
        private NotifyIcon notifyIcon1;
    }
}
