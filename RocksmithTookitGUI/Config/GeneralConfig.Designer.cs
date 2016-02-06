﻿namespace RocksmithToolkitGUI.Config
{
    partial class GeneralConfig
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.general_usebeta = new System.Windows.Forms.CheckBox();
            this.gbCreator = new System.Windows.Forms.GroupBox();
            this.btnTonePath = new System.Windows.Forms.Button();
            this.creator_defaulttone = new RocksmithToolkitGUI.CueTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnProjectDir = new System.Windows.Forms.Button();
            this.creator_defaultproject = new RocksmithToolkitGUI.CueTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.creator_usedefaultauthor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creator_scrollspeed = new RocksmithToolkitGUI.DLCPackageCreator.NumericUpDownFixed();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creator_useacronyms = new System.Windows.Forms.CheckBox();
            this.general_defaultgameversion = new System.Windows.Forms.ComboBox();
            this.creator_structured = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.general_defaultappid_RS2012 = new System.Windows.Forms.ComboBox();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.btnWwisePath = new System.Windows.Forms.Button();
            this.general_wwisepath = new RocksmithToolkitGUI.CueTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbAutoUpdate = new System.Windows.Forms.GroupBox();
            this.general_replacerepo = new System.Windows.Forms.CheckBox();
            this.btnRs2014Path = new System.Windows.Forms.Button();
            this.btnRs1Path = new System.Windows.Forms.Button();
            this.general_rs2014path = new RocksmithToolkitGUI.CueTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.general_rs1path = new RocksmithToolkitGUI.CueTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.general_defaultauthor = new RocksmithToolkitGUI.CueTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.general_defaultappid_RS2014 = new System.Windows.Forms.ComboBox();
            this.gbDDC = new System.Windows.Forms.GroupBox();
            this.general_firstrun = new System.Windows.Forms.CheckBox();
            this.ddc_phraselength = new RocksmithToolkitGUI.DLCPackageCreator.NumericUpDownFixed();
            this.ddc_removesustain = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddc_config = new System.Windows.Forms.ComboBox();
            this.ddc_rampup = new System.Windows.Forms.ComboBox();
            this.gbConverter = new System.Windows.Forms.GroupBox();
            this.converter_target = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.converter_source = new System.Windows.Forms.ComboBox();
            this.closeConfigButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbCreator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creator_scrollspeed)).BeginInit();
            this.gbGeneral.SuspendLayout();
            this.gbAutoUpdate.SuspendLayout();
            this.gbDDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddc_phraselength)).BeginInit();
            this.gbConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // general_usebeta
            // 
            this.general_usebeta.AutoSize = true;
            this.general_usebeta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_usebeta.Location = new System.Drawing.Point(12, 19);
            this.general_usebeta.Name = "general_usebeta";
            this.general_usebeta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.general_usebeta.Size = new System.Drawing.Size(111, 17);
            this.general_usebeta.TabIndex = 8;
            this.general_usebeta.Text = "Use beta releases";
            this.general_usebeta.UseVisualStyleBackColor = true;
            this.general_usebeta.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // gbCreator
            // 
            this.gbCreator.Controls.Add(this.btnTonePath);
            this.gbCreator.Controls.Add(this.creator_defaulttone);
            this.gbCreator.Controls.Add(this.label16);
            this.gbCreator.Controls.Add(this.btnProjectDir);
            this.gbCreator.Controls.Add(this.creator_defaultproject);
            this.gbCreator.Controls.Add(this.label15);
            this.gbCreator.Controls.Add(this.creator_usedefaultauthor);
            this.gbCreator.Controls.Add(this.groupBox1);
            this.gbCreator.Controls.Add(this.label3);
            this.gbCreator.Controls.Add(this.creator_useacronyms);
            this.gbCreator.Controls.Add(this.general_defaultgameversion);
            this.gbCreator.Controls.Add(this.creator_structured);
            this.gbCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbCreator.Location = new System.Drawing.Point(4, 192);
            this.gbCreator.Margin = new System.Windows.Forms.Padding(2);
            this.gbCreator.Name = "gbCreator";
            this.gbCreator.Padding = new System.Windows.Forms.Padding(2);
            this.gbCreator.Size = new System.Drawing.Size(516, 144);
            this.gbCreator.TabIndex = 0;
            this.gbCreator.TabStop = false;
            this.gbCreator.Text = "CDLC Creator";
            // 
            // btnTonePath
            // 
            this.btnTonePath.Location = new System.Drawing.Point(471, 65);
            this.btnTonePath.Name = "btnTonePath";
            this.btnTonePath.Size = new System.Drawing.Size(34, 23);
            this.btnTonePath.TabIndex = 53;
            this.btnTonePath.Text = "...";
            this.btnTonePath.UseVisualStyleBackColor = true;
            this.btnTonePath.Click += new System.EventHandler(this.btnTonePath_Click);
            // 
            // creator_defaulttone
            // 
            this.creator_defaulttone.Cue = "Default tone used for new projects";
            this.creator_defaulttone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.creator_defaulttone.ForeColor = System.Drawing.Color.Gray;
            this.creator_defaulttone.Location = new System.Drawing.Point(122, 67);
            this.creator_defaulttone.Multiline = true;
            this.creator_defaulttone.Name = "creator_defaulttone";
            this.creator_defaulttone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.creator_defaulttone.Size = new System.Drawing.Size(342, 20);
            this.creator_defaulttone.TabIndex = 52;
            this.toolTip.SetToolTip(this.creator_defaulttone, "Set a default tone used in new projects");
            this.creator_defaulttone.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(26, 70);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "Default Tone File:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProjectDir
            // 
            this.btnProjectDir.Location = new System.Drawing.Point(471, 39);
            this.btnProjectDir.Name = "btnProjectDir";
            this.btnProjectDir.Size = new System.Drawing.Size(34, 23);
            this.btnProjectDir.TabIndex = 50;
            this.btnProjectDir.Text = "...";
            this.btnProjectDir.UseVisualStyleBackColor = true;
            this.btnProjectDir.Click += new System.EventHandler(this.btnProjectDir_Click);
            // 
            // creator_defaultproject
            // 
            this.creator_defaultproject.Cue = "Default (root) folder used to hold new project files";
            this.creator_defaultproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.creator_defaultproject.ForeColor = System.Drawing.Color.Gray;
            this.creator_defaultproject.Location = new System.Drawing.Point(122, 41);
            this.creator_defaultproject.Multiline = true;
            this.creator_defaultproject.Name = "creator_defaultproject";
            this.creator_defaultproject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.creator_defaultproject.Size = new System.Drawing.Size(343, 20);
            this.creator_defaultproject.TabIndex = 49;
            this.toolTip.SetToolTip(this.creator_defaultproject, "Set a default CDLC project folder");
            this.creator_defaultproject.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(5, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Default Project Folder:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // creator_usedefaultauthor
            // 
            this.creator_usedefaultauthor.AutoSize = true;
            this.creator_usedefaultauthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.creator_usedefaultauthor.Location = new System.Drawing.Point(295, 118);
            this.creator_usedefaultauthor.Name = "creator_usedefaultauthor";
            this.creator_usedefaultauthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creator_usedefaultauthor.Size = new System.Drawing.Size(209, 17);
            this.creator_usedefaultauthor.TabIndex = 46;
            this.creator_usedefaultauthor.Text = "Album Sort defaults to Package Author";
            this.toolTip.SetToolTip(this.creator_usedefaultauthor, "If check the configuration Package Author\r\nwill be used by default for the Album " +
                    "Sort\r\ntextbox field in the Creator GUI.");
            this.creator_usedefaultauthor.UseVisualStyleBackColor = true;
            this.creator_usedefaultauthor.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creator_scrollspeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 42);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrangement";
            // 
            // creator_scrollspeed
            // 
            this.creator_scrollspeed.DecimalPlaces = 1;
            this.creator_scrollspeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.creator_scrollspeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.creator_scrollspeed.Location = new System.Drawing.Point(118, 15);
            this.creator_scrollspeed.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.creator_scrollspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creator_scrollspeed.Name = "creator_scrollspeed";
            this.creator_scrollspeed.Size = new System.Drawing.Size(48, 20);
            this.creator_scrollspeed.TabIndex = 11;
            this.creator_scrollspeed.Value = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.creator_scrollspeed.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Default Scroll Speed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(43, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Game Version:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // creator_useacronyms
            // 
            this.creator_useacronyms.AutoSize = true;
            this.creator_useacronyms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.creator_useacronyms.Location = new System.Drawing.Point(275, 95);
            this.creator_useacronyms.Name = "creator_useacronyms";
            this.creator_useacronyms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creator_useacronyms.Size = new System.Drawing.Size(229, 17);
            this.creator_useacronyms.TabIndex = 13;
            this.creator_useacronyms.Text = "Use artist name acronym when naming files";
            this.creator_useacronyms.UseVisualStyleBackColor = true;
            this.creator_useacronyms.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // general_defaultgameversion
            // 
            this.general_defaultgameversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.general_defaultgameversion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_defaultgameversion.Location = new System.Drawing.Point(122, 15);
            this.general_defaultgameversion.Margin = new System.Windows.Forms.Padding(2);
            this.general_defaultgameversion.Name = "general_defaultgameversion";
            this.general_defaultgameversion.Size = new System.Drawing.Size(120, 21);
            this.general_defaultgameversion.TabIndex = 10;
            this.general_defaultgameversion.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // creator_structured
            // 
            this.creator_structured.AutoSize = true;
            this.creator_structured.ForeColor = System.Drawing.SystemColors.ControlText;
            this.creator_structured.Location = new System.Drawing.Point(346, 17);
            this.creator_structured.Name = "creator_structured";
            this.creator_structured.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.creator_structured.Size = new System.Drawing.Size(158, 17);
            this.creator_structured.TabIndex = 12;
            this.creator_structured.Text = "Import Structured Packages";
            this.toolTip.SetToolTip(this.creator_structured, "If checked creates user friendly\r\nEOF and Toolkit artifact folders.");
            this.creator_structured.UseVisualStyleBackColor = true;
            this.creator_structured.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(46, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "App ID (RS1):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // general_defaultappid_RS2012
            // 
            this.general_defaultappid_RS2012.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.general_defaultappid_RS2012.DropDownWidth = 320;
            this.general_defaultappid_RS2012.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_defaultappid_RS2012.Location = new System.Drawing.Point(122, 16);
            this.general_defaultappid_RS2012.Margin = new System.Windows.Forms.Padding(2);
            this.general_defaultappid_RS2012.Name = "general_defaultappid_RS2012";
            this.general_defaultappid_RS2012.Size = new System.Drawing.Size(249, 21);
            this.general_defaultappid_RS2012.TabIndex = 1;
            this.general_defaultappid_RS2012.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.btnWwisePath);
            this.gbGeneral.Controls.Add(this.general_wwisepath);
            this.gbGeneral.Controls.Add(this.label14);
            this.gbGeneral.Controls.Add(this.label12);
            this.gbGeneral.Controls.Add(this.gbAutoUpdate);
            this.gbGeneral.Controls.Add(this.btnRs2014Path);
            this.gbGeneral.Controls.Add(this.btnRs1Path);
            this.gbGeneral.Controls.Add(this.general_rs2014path);
            this.gbGeneral.Controls.Add(this.label11);
            this.gbGeneral.Controls.Add(this.general_rs1path);
            this.gbGeneral.Controls.Add(this.label10);
            this.gbGeneral.Controls.Add(this.label9);
            this.gbGeneral.Controls.Add(this.general_defaultauthor);
            this.gbGeneral.Controls.Add(this.label4);
            this.gbGeneral.Controls.Add(this.general_defaultappid_RS2014);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.general_defaultappid_RS2012);
            this.gbGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbGeneral.Location = new System.Drawing.Point(2, 2);
            this.gbGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Padding = new System.Windows.Forms.Padding(2);
            this.gbGeneral.Size = new System.Drawing.Size(516, 186);
            this.gbGeneral.TabIndex = 14;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General";
            // 
            // btnWwisePath
            // 
            this.btnWwisePath.Location = new System.Drawing.Point(473, 158);
            this.btnWwisePath.Name = "btnWwisePath";
            this.btnWwisePath.Size = new System.Drawing.Size(34, 23);
            this.btnWwisePath.TabIndex = 102;
            this.btnWwisePath.Text = "...";
            this.btnWwisePath.UseVisualStyleBackColor = true;
            this.btnWwisePath.Click += new System.EventHandler(this.btnWwisePath_Click);
            // 
            // general_wwisepath
            // 
            this.general_wwisepath.Cue = "Wwise v2013.2.x v2014.1.x or 2015.1.x build series";
            this.general_wwisepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.general_wwisepath.ForeColor = System.Drawing.Color.Gray;
            this.general_wwisepath.Location = new System.Drawing.Point(122, 160);
            this.general_wwisepath.Multiline = true;
            this.general_wwisepath.Name = "general_wwisepath";
            this.general_wwisepath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.general_wwisepath.Size = new System.Drawing.Size(345, 20);
            this.general_wwisepath.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(53, 163);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 103;
            this.label14.Text = "Wwise path:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(119, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Will be written inside the package.";
            // 
            // gbAutoUpdate
            // 
            this.gbAutoUpdate.Controls.Add(this.general_replacerepo);
            this.gbAutoUpdate.Controls.Add(this.general_usebeta);
            this.gbAutoUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbAutoUpdate.Location = new System.Drawing.Point(377, 10);
            this.gbAutoUpdate.Name = "gbAutoUpdate";
            this.gbAutoUpdate.Size = new System.Drawing.Size(129, 77);
            this.gbAutoUpdate.TabIndex = 99;
            this.gbAutoUpdate.TabStop = false;
            this.gbAutoUpdate.Text = "Auto-update";
            // 
            // general_replacerepo
            // 
            this.general_replacerepo.AutoSize = true;
            this.general_replacerepo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_replacerepo.Location = new System.Drawing.Point(13, 42);
            this.general_replacerepo.Name = "general_replacerepo";
            this.general_replacerepo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.general_replacerepo.Size = new System.Drawing.Size(110, 17);
            this.general_replacerepo.TabIndex = 9;
            this.general_replacerepo.Text = "Reset repositories";
            this.general_replacerepo.UseVisualStyleBackColor = true;
            // 
            // btnRs2014Path
            // 
            this.btnRs2014Path.Location = new System.Drawing.Point(473, 134);
            this.btnRs2014Path.Name = "btnRs2014Path";
            this.btnRs2014Path.Size = new System.Drawing.Size(34, 23);
            this.btnRs2014Path.TabIndex = 7;
            this.btnRs2014Path.Text = "...";
            this.btnRs2014Path.UseVisualStyleBackColor = true;
            this.btnRs2014Path.Click += new System.EventHandler(this.btnRs2014Path_Click);
            // 
            // btnRs1Path
            // 
            this.btnRs1Path.Location = new System.Drawing.Point(473, 108);
            this.btnRs1Path.Name = "btnRs1Path";
            this.btnRs1Path.Size = new System.Drawing.Size(34, 23);
            this.btnRs1Path.TabIndex = 5;
            this.btnRs1Path.Text = "...";
            this.btnRs1Path.UseVisualStyleBackColor = true;
            this.btnRs1Path.Click += new System.EventHandler(this.btnRs1Path_Click);
            // 
            // general_rs2014path
            // 
            this.general_rs2014path.Cue = "Rocksmith 2014 Path";
            this.general_rs2014path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.general_rs2014path.ForeColor = System.Drawing.Color.Gray;
            this.general_rs2014path.Location = new System.Drawing.Point(122, 136);
            this.general_rs2014path.Multiline = true;
            this.general_rs2014path.Name = "general_rs2014path";
            this.general_rs2014path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.general_rs2014path.Size = new System.Drawing.Size(345, 20);
            this.general_rs2014path.TabIndex = 6;
            this.general_rs2014path.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(7, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Rocksmith 2014 Path:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // general_rs1path
            // 
            this.general_rs1path.Cue = "Rocksmith Path";
            this.general_rs1path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.general_rs1path.ForeColor = System.Drawing.Color.Gray;
            this.general_rs1path.Location = new System.Drawing.Point(122, 110);
            this.general_rs1path.Multiline = true;
            this.general_rs1path.Name = "general_rs1path";
            this.general_rs1path.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.general_rs1path.Size = new System.Drawing.Size(345, 20);
            this.general_rs1path.TabIndex = 4;
            this.general_rs1path.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(34, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Rocksmith Path:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(32, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Package Author:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // general_defaultauthor
            // 
            this.general_defaultauthor.Cue = "Package Author (Charter)";
            this.general_defaultauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.general_defaultauthor.ForeColor = System.Drawing.Color.Gray;
            this.general_defaultauthor.Location = new System.Drawing.Point(122, 67);
            this.general_defaultauthor.Name = "general_defaultauthor";
            this.general_defaultauthor.Size = new System.Drawing.Size(249, 20);
            this.general_defaultauthor.TabIndex = 3;
            this.general_defaultauthor.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "App ID (RS2014):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // general_defaultappid_RS2014
            // 
            this.general_defaultappid_RS2014.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.general_defaultappid_RS2014.DropDownWidth = 320;
            this.general_defaultappid_RS2014.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_defaultappid_RS2014.Location = new System.Drawing.Point(122, 41);
            this.general_defaultappid_RS2014.Margin = new System.Windows.Forms.Padding(2);
            this.general_defaultappid_RS2014.Name = "general_defaultappid_RS2014";
            this.general_defaultappid_RS2014.Size = new System.Drawing.Size(249, 21);
            this.general_defaultappid_RS2014.TabIndex = 2;
            this.general_defaultappid_RS2014.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // gbDDC
            // 
            this.gbDDC.Controls.Add(this.general_firstrun);
            this.gbDDC.Controls.Add(this.ddc_phraselength);
            this.gbDDC.Controls.Add(this.ddc_removesustain);
            this.gbDDC.Controls.Add(this.label6);
            this.gbDDC.Controls.Add(this.label13);
            this.gbDDC.Controls.Add(this.label5);
            this.gbDDC.Controls.Add(this.ddc_config);
            this.gbDDC.Controls.Add(this.ddc_rampup);
            this.gbDDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbDDC.Location = new System.Drawing.Point(4, 392);
            this.gbDDC.Name = "gbDDC";
            this.gbDDC.Size = new System.Drawing.Size(516, 98);
            this.gbDDC.TabIndex = 15;
            this.gbDDC.TabStop = false;
            this.gbDDC.Text = "DDC";
            // 
            // general_firstrun
            // 
            this.general_firstrun.AutoSize = true;
            this.general_firstrun.Checked = true;
            this.general_firstrun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.general_firstrun.Enabled = false;
            this.general_firstrun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.general_firstrun.Location = new System.Drawing.Point(436, 68);
            this.general_firstrun.Name = "general_firstrun";
            this.general_firstrun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.general_firstrun.Size = new System.Drawing.Size(68, 17);
            this.general_firstrun.TabIndex = 51;
            this.general_firstrun.Text = "First Run";
            this.general_firstrun.UseVisualStyleBackColor = true;
            this.general_firstrun.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // ddc_phraselength
            // 
            this.ddc_phraselength.Location = new System.Drawing.Point(123, 70);
            this.ddc_phraselength.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.ddc_phraselength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ddc_phraselength.Name = "ddc_phraselength";
            this.ddc_phraselength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddc_phraselength.Size = new System.Drawing.Size(52, 20);
            this.ddc_phraselength.TabIndex = 16;
            this.ddc_phraselength.ThousandsSeparator = true;
            this.ddc_phraselength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ddc_phraselength.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // ddc_removesustain
            // 
            this.ddc_removesustain.AutoSize = true;
            this.ddc_removesustain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ddc_removesustain.Location = new System.Drawing.Point(397, 18);
            this.ddc_removesustain.Name = "ddc_removesustain";
            this.ddc_removesustain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddc_removesustain.Size = new System.Drawing.Size(107, 17);
            this.ddc_removesustain.TabIndex = 17;
            this.ddc_removesustain.Text = "Remove sustains";
            this.ddc_removesustain.UseVisualStyleBackColor = true;
            this.ddc_removesustain.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Phrase length:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(58, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Config File:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(61, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Rampage:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddc_config
            // 
            this.ddc_config.AllowDrop = true;
            this.ddc_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddc_config.FormattingEnabled = true;
            this.ddc_config.Location = new System.Drawing.Point(122, 43);
            this.ddc_config.MinimumSize = new System.Drawing.Size(20, 0);
            this.ddc_config.Name = "ddc_config";
            this.ddc_config.Size = new System.Drawing.Size(171, 21);
            this.ddc_config.Sorted = true;
            this.ddc_config.TabIndex = 15;
            this.ddc_config.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // ddc_rampup
            // 
            this.ddc_rampup.AllowDrop = true;
            this.ddc_rampup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddc_rampup.FormattingEnabled = true;
            this.ddc_rampup.Location = new System.Drawing.Point(122, 16);
            this.ddc_rampup.MinimumSize = new System.Drawing.Size(20, 0);
            this.ddc_rampup.Name = "ddc_rampup";
            this.ddc_rampup.Size = new System.Drawing.Size(171, 21);
            this.ddc_rampup.Sorted = true;
            this.ddc_rampup.TabIndex = 14;
            this.ddc_rampup.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // gbConverter
            // 
            this.gbConverter.Controls.Add(this.converter_target);
            this.gbConverter.Controls.Add(this.label7);
            this.gbConverter.Controls.Add(this.label8);
            this.gbConverter.Controls.Add(this.converter_source);
            this.gbConverter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbConverter.Location = new System.Drawing.Point(4, 341);
            this.gbConverter.Name = "gbConverter";
            this.gbConverter.Size = new System.Drawing.Size(516, 45);
            this.gbConverter.TabIndex = 50;
            this.gbConverter.TabStop = false;
            this.gbConverter.Text = "Converter";
            // 
            // converter_target
            // 
            this.converter_target.AllowDrop = true;
            this.converter_target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.converter_target.FormattingEnabled = true;
            this.converter_target.Location = new System.Drawing.Point(363, 15);
            this.converter_target.MinimumSize = new System.Drawing.Size(20, 0);
            this.converter_target.Name = "converter_target";
            this.converter_target.Size = new System.Drawing.Size(120, 21);
            this.converter_target.Sorted = true;
            this.converter_target.TabIndex = 19;
            this.converter_target.SelectedIndexChanged += new System.EventHandler(this.ConfigurationChanged);
            this.converter_target.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(275, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Target Platform:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(34, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Source Platform:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // converter_source
            // 
            this.converter_source.AllowDrop = true;
            this.converter_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.converter_source.FormattingEnabled = true;
            this.converter_source.Location = new System.Drawing.Point(122, 15);
            this.converter_source.MinimumSize = new System.Drawing.Size(20, 0);
            this.converter_source.Name = "converter_source";
            this.converter_source.Size = new System.Drawing.Size(120, 21);
            this.converter_source.Sorted = true;
            this.converter_source.TabIndex = 18;
            this.converter_source.Leave += new System.EventHandler(this.ConfigurationChanged);
            // 
            // closeConfigButton
            // 
            this.closeConfigButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.closeConfigButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeConfigButton.Location = new System.Drawing.Point(395, 505);
            this.closeConfigButton.Name = "closeConfigButton";
            this.closeConfigButton.Size = new System.Drawing.Size(116, 29);
            this.closeConfigButton.TabIndex = 0;
            this.closeConfigButton.Text = "Close";
            this.closeConfigButton.UseVisualStyleBackColor = false;
            this.closeConfigButton.Click += new System.EventHandler(this.closeConfigButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 8000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 100;
            // 
            // GeneralConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.closeConfigButton);
            this.Controls.Add(this.gbConverter);
            this.Controls.Add(this.gbDDC);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.gbCreator);
            this.Name = "GeneralConfig";
            this.Size = new System.Drawing.Size(522, 560);
            this.gbCreator.ResumeLayout(false);
            this.gbCreator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creator_scrollspeed)).EndInit();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.gbAutoUpdate.ResumeLayout(false);
            this.gbAutoUpdate.PerformLayout();
            this.gbDDC.ResumeLayout(false);
            this.gbDDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddc_phraselength)).EndInit();
            this.gbConverter.ResumeLayout(false);
            this.gbConverter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox general_usebeta;
        private System.Windows.Forms.GroupBox gbCreator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox general_defaultappid_RS2012;
        private System.Windows.Forms.CheckBox creator_structured;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox general_defaultgameversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox general_defaultappid_RS2014;
        private DLCPackageCreator.NumericUpDownFixed creator_scrollspeed;
        private System.Windows.Forms.GroupBox gbDDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddc_rampup;
        private DLCPackageCreator.NumericUpDownFixed ddc_phraselength;
        private System.Windows.Forms.CheckBox ddc_removesustain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbConverter;
        private System.Windows.Forms.ComboBox converter_target;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox converter_source;
        private System.Windows.Forms.CheckBox creator_useacronyms;
        private System.Windows.Forms.Button closeConfigButton;
        private System.Windows.Forms.Label label9;
        private CueTextBox general_defaultauthor;
        private CueTextBox general_rs1path;
        private System.Windows.Forms.Label label10;
        private CueTextBox general_rs2014path;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRs2014Path;
        private System.Windows.Forms.Button btnRs1Path;
        private System.Windows.Forms.CheckBox general_replacerepo;
        private System.Windows.Forms.GroupBox gbAutoUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddc_config;
        private System.Windows.Forms.Button btnWwisePath;
        private CueTextBox general_wwisepath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox creator_usedefaultauthor;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnTonePath;
        private CueTextBox creator_defaulttone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnProjectDir;
        private CueTextBox creator_defaultproject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox general_firstrun;
    }
}
