
namespace logic_engineering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSideBarBtns = new System.Windows.Forms.Panel();
            this.btCredits = new System.Windows.Forms.Button();
            this.btFormulas = new System.Windows.Forms.Button();
            this.btTruthTable = new System.Windows.Forms.Button();
            this.btTableSimplified = new System.Windows.Forms.Button();
            this.btTree = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbPropError = new System.Windows.Forms.Label();
            this.tbProposition = new System.Windows.Forms.TextBox();
            this.lbProposition = new System.Windows.Forms.Label();
            this.btParse = new System.Windows.Forms.Button();
            this.linkLbLogoMakr = new System.Windows.Forms.LinkLabel();
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.lbOperators = new System.Windows.Forms.Label();
            this.tbOperators = new System.Windows.Forms.TextBox();
            this.lbVariables = new System.Windows.Forms.Label();
            this.lbInfixProp = new System.Windows.Forms.Label();
            this.tbVariables = new System.Windows.Forms.TextBox();
            this.tbInfixProp = new System.Windows.Forms.TextBox();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.truthTable = new System.Windows.Forms.DataGridView();
            this.tbHashValue = new System.Windows.Forms.TextBox();
            this.lbHashValue = new System.Windows.Forms.Label();
            this.panelFormulas = new System.Windows.Forms.Panel();
            this.lbHashSimplified = new System.Windows.Forms.Label();
            this.tbHashSimplified = new System.Windows.Forms.TextBox();
            this.lbBinarySimplified = new System.Windows.Forms.Label();
            this.tbBinarySimplified = new System.Windows.Forms.TextBox();
            this.lbNand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDNF = new System.Windows.Forms.Label();
            this.tbNand = new System.Windows.Forms.TextBox();
            this.tbDNFSimplified = new System.Windows.Forms.TextBox();
            this.tbDNF = new System.Windows.Forms.TextBox();
            this.lbBinary = new System.Windows.Forms.Label();
            this.tbBinary = new System.Windows.Forms.TextBox();
            this.truthTableSimplified = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            this.panelSideBarBtns.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTopbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truthTable)).BeginInit();
            this.panelFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truthTableSimplified)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(20)))));
            this.panelSidebar.Controls.Add(this.panelSideBarBtns);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(262, 627);
            this.panelSidebar.TabIndex = 2;
            // 
            // panelSideBarBtns
            // 
            this.panelSideBarBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(20)))));
            this.panelSideBarBtns.Controls.Add(this.btCredits);
            this.panelSideBarBtns.Controls.Add(this.btFormulas);
            this.panelSideBarBtns.Controls.Add(this.btTruthTable);
            this.panelSideBarBtns.Controls.Add(this.btTableSimplified);
            this.panelSideBarBtns.Controls.Add(this.btTree);
            this.panelSideBarBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideBarBtns.Location = new System.Drawing.Point(0, 164);
            this.panelSideBarBtns.Name = "panelSideBarBtns";
            this.panelSideBarBtns.Size = new System.Drawing.Size(262, 344);
            this.panelSideBarBtns.TabIndex = 1;
            // 
            // btCredits
            // 
            this.btCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.btCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCredits.FlatAppearance.BorderSize = 0;
            this.btCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCredits.ForeColor = System.Drawing.Color.White;
            this.btCredits.Location = new System.Drawing.Point(0, 264);
            this.btCredits.Name = "btCredits";
            this.btCredits.Size = new System.Drawing.Size(262, 51);
            this.btCredits.TabIndex = 5;
            this.btCredits.Text = "Show / Hide Credits";
            this.btCredits.UseVisualStyleBackColor = false;
            this.btCredits.Click += new System.EventHandler(this.btCredits_Click);
            // 
            // btFormulas
            // 
            this.btFormulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.btFormulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFormulas.FlatAppearance.BorderSize = 0;
            this.btFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFormulas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFormulas.ForeColor = System.Drawing.Color.White;
            this.btFormulas.Location = new System.Drawing.Point(-6, 96);
            this.btFormulas.Name = "btFormulas";
            this.btFormulas.Size = new System.Drawing.Size(267, 51);
            this.btFormulas.TabIndex = 0;
            this.btFormulas.Text = "Formulas";
            this.btFormulas.UseVisualStyleBackColor = false;
            this.btFormulas.Click += new System.EventHandler(this.btFormulas_Click);
            // 
            // btTruthTable
            // 
            this.btTruthTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.btTruthTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTruthTable.FlatAppearance.BorderSize = 0;
            this.btTruthTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTruthTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTruthTable.ForeColor = System.Drawing.Color.White;
            this.btTruthTable.Location = new System.Drawing.Point(0, 152);
            this.btTruthTable.Name = "btTruthTable";
            this.btTruthTable.Size = new System.Drawing.Size(262, 51);
            this.btTruthTable.TabIndex = 4;
            this.btTruthTable.Text = "Truth table";
            this.btTruthTable.UseVisualStyleBackColor = false;
            this.btTruthTable.Click += new System.EventHandler(this.btTruthTable_Click);
            // 
            // btTableSimplified
            // 
            this.btTableSimplified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.btTableSimplified.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTableSimplified.FlatAppearance.BorderSize = 0;
            this.btTableSimplified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTableSimplified.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTableSimplified.ForeColor = System.Drawing.Color.White;
            this.btTableSimplified.Location = new System.Drawing.Point(0, 208);
            this.btTableSimplified.Name = "btTableSimplified";
            this.btTableSimplified.Size = new System.Drawing.Size(262, 51);
            this.btTableSimplified.TabIndex = 5;
            this.btTableSimplified.Text = "Table Simplified";
            this.btTableSimplified.UseVisualStyleBackColor = false;
            this.btTableSimplified.Click += new System.EventHandler(this.btTableSimplified_Click);
            // 
            // btTree
            // 
            this.btTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.btTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTree.FlatAppearance.BorderSize = 0;
            this.btTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTree.ForeColor = System.Drawing.Color.White;
            this.btTree.Location = new System.Drawing.Point(0, 40);
            this.btTree.Name = "btTree";
            this.btTree.Size = new System.Drawing.Size(262, 51);
            this.btTree.TabIndex = 4;
            this.btTree.Text = "Tree";
            this.btTree.UseVisualStyleBackColor = false;
            this.btTree.Click += new System.EventHandler(this.btTree_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(262, 164);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.Location = new System.Drawing.Point(76, 60);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(102, 98);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.panelTopbar.Controls.Add(this.btMinimize);
            this.panelTopbar.Controls.Add(this.btClose);
            this.panelTopbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(958, 41);
            this.panelTopbar.TabIndex = 3;
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMinimize.ForeColor = System.Drawing.Color.White;
            this.btMinimize.Location = new System.Drawing.Point(903, 4);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(22, 29);
            this.btMinimize.TabIndex = 27;
            this.btMinimize.Text = "-";
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(925, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(25, 31);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbPropError
            // 
            this.lbPropError.AutoSize = true;
            this.lbPropError.BackColor = System.Drawing.Color.White;
            this.lbPropError.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPropError.ForeColor = System.Drawing.Color.White;
            this.lbPropError.Location = new System.Drawing.Point(395, 44);
            this.lbPropError.Name = "lbPropError";
            this.lbPropError.Size = new System.Drawing.Size(0, 20);
            this.lbPropError.TabIndex = 14;
            // 
            // tbProposition
            // 
            this.tbProposition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProposition.Location = new System.Drawing.Point(397, 67);
            this.tbProposition.Name = "tbProposition";
            this.tbProposition.Size = new System.Drawing.Size(405, 27);
            this.tbProposition.TabIndex = 5;
            // 
            // lbProposition
            // 
            this.lbProposition.AutoSize = true;
            this.lbProposition.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProposition.ForeColor = System.Drawing.Color.Black;
            this.lbProposition.Location = new System.Drawing.Point(298, 67);
            this.lbProposition.Name = "lbProposition";
            this.lbProposition.Size = new System.Drawing.Size(97, 23);
            this.lbProposition.TabIndex = 7;
            this.lbProposition.Text = "Proposition";
            // 
            // btParse
            // 
            this.btParse.BackColor = System.Drawing.Color.DarkGreen;
            this.btParse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btParse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btParse.FlatAppearance.BorderSize = 0;
            this.btParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btParse.ForeColor = System.Drawing.Color.White;
            this.btParse.Location = new System.Drawing.Point(807, 65);
            this.btParse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btParse.Name = "btParse";
            this.btParse.Size = new System.Drawing.Size(143, 32);
            this.btParse.TabIndex = 6;
            this.btParse.Text = "Parse";
            this.btParse.UseVisualStyleBackColor = false;
            this.btParse.Click += new System.EventHandler(this.btParse_Click);
            // 
            // linkLbLogoMakr
            // 
            this.linkLbLogoMakr.AutoSize = true;
            this.linkLbLogoMakr.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLbLogoMakr.Location = new System.Drawing.Point(704, 595);
            this.linkLbLogoMakr.Name = "linkLbLogoMakr";
            this.linkLbLogoMakr.Size = new System.Drawing.Size(270, 20);
            this.linkLbLogoMakr.TabIndex = 4;
            this.linkLbLogoMakr.TabStop = true;
            this.linkLbLogoMakr.Text = "Created my free logo at LogoMakr.com";
            this.linkLbLogoMakr.Visible = false;
            this.linkLbLogoMakr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbLogoMakr_LinkClicked);
            // 
            // pbTree
            // 
            this.pbTree.BackColor = System.Drawing.Color.White;
            this.pbTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbTree.Location = new System.Drawing.Point(277, 99);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(642, 493);
            this.pbTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTree.TabIndex = 17;
            this.pbTree.TabStop = false;
            // 
            // lbOperators
            // 
            this.lbOperators.AutoSize = true;
            this.lbOperators.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOperators.ForeColor = System.Drawing.Color.Black;
            this.lbOperators.Location = new System.Drawing.Point(33, 101);
            this.lbOperators.Name = "lbOperators";
            this.lbOperators.Size = new System.Drawing.Size(86, 23);
            this.lbOperators.TabIndex = 13;
            this.lbOperators.Text = "Operators";
            // 
            // tbOperators
            // 
            this.tbOperators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOperators.Location = new System.Drawing.Point(119, 101);
            this.tbOperators.Name = "tbOperators";
            this.tbOperators.ReadOnly = true;
            this.tbOperators.Size = new System.Drawing.Size(554, 27);
            this.tbOperators.TabIndex = 12;
            // 
            // lbVariables
            // 
            this.lbVariables.AutoSize = true;
            this.lbVariables.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVariables.ForeColor = System.Drawing.Color.Black;
            this.lbVariables.Location = new System.Drawing.Point(42, 68);
            this.lbVariables.Name = "lbVariables";
            this.lbVariables.Size = new System.Drawing.Size(78, 23);
            this.lbVariables.TabIndex = 10;
            this.lbVariables.Text = "Variables";
            // 
            // lbInfixProp
            // 
            this.lbInfixProp.AutoSize = true;
            this.lbInfixProp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfixProp.ForeColor = System.Drawing.Color.Black;
            this.lbInfixProp.Location = new System.Drawing.Point(75, 37);
            this.lbInfixProp.Name = "lbInfixProp";
            this.lbInfixProp.Size = new System.Drawing.Size(42, 23);
            this.lbInfixProp.TabIndex = 16;
            this.lbInfixProp.Text = "Infix";
            // 
            // tbVariables
            // 
            this.tbVariables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVariables.Location = new System.Drawing.Point(119, 68);
            this.tbVariables.Name = "tbVariables";
            this.tbVariables.ReadOnly = true;
            this.tbVariables.Size = new System.Drawing.Size(554, 27);
            this.tbVariables.TabIndex = 9;
            // 
            // tbInfixProp
            // 
            this.tbInfixProp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInfixProp.Location = new System.Drawing.Point(119, 36);
            this.tbInfixProp.Name = "tbInfixProp";
            this.tbInfixProp.ReadOnly = true;
            this.tbInfixProp.Size = new System.Drawing.Size(554, 27);
            this.tbInfixProp.TabIndex = 15;
            // 
            // tbPrefix
            // 
            this.tbPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrefix.Location = new System.Drawing.Point(119, 0);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.ReadOnly = true;
            this.tbPrefix.Size = new System.Drawing.Size(554, 27);
            this.tbPrefix.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prefix";
            // 
            // truthTable
            // 
            this.truthTable.AllowUserToAddRows = false;
            this.truthTable.AllowUserToDeleteRows = false;
            this.truthTable.AllowUserToResizeColumns = false;
            this.truthTable.AllowUserToResizeRows = false;
            this.truthTable.BackgroundColor = System.Drawing.Color.White;
            this.truthTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truthTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.truthTable.Location = new System.Drawing.Point(277, 99);
            this.truthTable.Name = "truthTable";
            this.truthTable.ReadOnly = true;
            this.truthTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.truthTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.truthTable.RowTemplate.Height = 29;
            this.truthTable.ShowEditingIcon = false;
            this.truthTable.Size = new System.Drawing.Size(639, 493);
            this.truthTable.TabIndex = 21;
            // 
            // tbHashValue
            // 
            this.tbHashValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHashValue.Location = new System.Drawing.Point(119, 167);
            this.tbHashValue.Name = "tbHashValue";
            this.tbHashValue.ReadOnly = true;
            this.tbHashValue.Size = new System.Drawing.Size(555, 27);
            this.tbHashValue.TabIndex = 22;
            // 
            // lbHashValue
            // 
            this.lbHashValue.AutoSize = true;
            this.lbHashValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHashValue.ForeColor = System.Drawing.Color.Black;
            this.lbHashValue.Location = new System.Drawing.Point(69, 168);
            this.lbHashValue.Name = "lbHashValue";
            this.lbHashValue.Size = new System.Drawing.Size(48, 23);
            this.lbHashValue.TabIndex = 23;
            this.lbHashValue.Text = "Hash";
            // 
            // panelFormulas
            // 
            this.panelFormulas.Controls.Add(this.lbHashSimplified);
            this.panelFormulas.Controls.Add(this.tbHashSimplified);
            this.panelFormulas.Controls.Add(this.lbBinarySimplified);
            this.panelFormulas.Controls.Add(this.tbBinarySimplified);
            this.panelFormulas.Controls.Add(this.lbNand);
            this.panelFormulas.Controls.Add(this.label2);
            this.panelFormulas.Controls.Add(this.lbDNF);
            this.panelFormulas.Controls.Add(this.tbNand);
            this.panelFormulas.Controls.Add(this.tbDNFSimplified);
            this.panelFormulas.Controls.Add(this.tbDNF);
            this.panelFormulas.Controls.Add(this.lbBinary);
            this.panelFormulas.Controls.Add(this.tbBinary);
            this.panelFormulas.Controls.Add(this.tbHashValue);
            this.panelFormulas.Controls.Add(this.lbHashValue);
            this.panelFormulas.Controls.Add(this.tbInfixProp);
            this.panelFormulas.Controls.Add(this.tbVariables);
            this.panelFormulas.Controls.Add(this.lbInfixProp);
            this.panelFormulas.Controls.Add(this.tbPrefix);
            this.panelFormulas.Controls.Add(this.lbVariables);
            this.panelFormulas.Controls.Add(this.label1);
            this.panelFormulas.Controls.Add(this.tbOperators);
            this.panelFormulas.Controls.Add(this.lbOperators);
            this.panelFormulas.Location = new System.Drawing.Point(277, 103);
            this.panelFormulas.Name = "panelFormulas";
            this.panelFormulas.Size = new System.Drawing.Size(674, 493);
            this.panelFormulas.TabIndex = 24;
            // 
            // lbHashSimplified
            // 
            this.lbHashSimplified.AutoSize = true;
            this.lbHashSimplified.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHashSimplified.ForeColor = System.Drawing.Color.Black;
            this.lbHashSimplified.Location = new System.Drawing.Point(0, 240);
            this.lbHashSimplified.Name = "lbHashSimplified";
            this.lbHashSimplified.Size = new System.Drawing.Size(127, 23);
            this.lbHashSimplified.TabIndex = 34;
            this.lbHashSimplified.Text = "Hash Simplified";
            // 
            // tbHashSimplified
            // 
            this.tbHashSimplified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHashSimplified.Location = new System.Drawing.Point(119, 239);
            this.tbHashSimplified.Name = "tbHashSimplified";
            this.tbHashSimplified.ReadOnly = true;
            this.tbHashSimplified.Size = new System.Drawing.Size(555, 27);
            this.tbHashSimplified.TabIndex = 33;
            // 
            // lbBinarySimplified
            // 
            this.lbBinarySimplified.AutoSize = true;
            this.lbBinarySimplified.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBinarySimplified.ForeColor = System.Drawing.Color.Black;
            this.lbBinarySimplified.Location = new System.Drawing.Point(-6, 204);
            this.lbBinarySimplified.Name = "lbBinarySimplified";
            this.lbBinarySimplified.Size = new System.Drawing.Size(136, 23);
            this.lbBinarySimplified.TabIndex = 33;
            this.lbBinarySimplified.Text = "Binary Simplified";
            // 
            // tbBinarySimplified
            // 
            this.tbBinarySimplified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBinarySimplified.Location = new System.Drawing.Point(119, 203);
            this.tbBinarySimplified.Name = "tbBinarySimplified";
            this.tbBinarySimplified.ReadOnly = true;
            this.tbBinarySimplified.Size = new System.Drawing.Size(555, 27);
            this.tbBinarySimplified.TabIndex = 32;
            // 
            // lbNand
            // 
            this.lbNand.AutoSize = true;
            this.lbNand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNand.ForeColor = System.Drawing.Color.Black;
            this.lbNand.Location = new System.Drawing.Point(66, 344);
            this.lbNand.Name = "lbNand";
            this.lbNand.Size = new System.Drawing.Size(52, 23);
            this.lbNand.TabIndex = 31;
            this.lbNand.Text = "Nand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "DNF Simplified";
            // 
            // lbDNF
            // 
            this.lbDNF.AutoSize = true;
            this.lbDNF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDNF.ForeColor = System.Drawing.Color.Black;
            this.lbDNF.Location = new System.Drawing.Point(73, 277);
            this.lbDNF.Name = "lbDNF";
            this.lbDNF.Size = new System.Drawing.Size(43, 23);
            this.lbDNF.TabIndex = 30;
            this.lbDNF.Text = "DNF";
            // 
            // tbNand
            // 
            this.tbNand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNand.Location = new System.Drawing.Point(119, 344);
            this.tbNand.Name = "tbNand";
            this.tbNand.ReadOnly = true;
            this.tbNand.Size = new System.Drawing.Size(555, 27);
            this.tbNand.TabIndex = 28;
            // 
            // tbDNFSimplified
            // 
            this.tbDNFSimplified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDNFSimplified.Location = new System.Drawing.Point(119, 308);
            this.tbDNFSimplified.Name = "tbDNFSimplified";
            this.tbDNFSimplified.ReadOnly = true;
            this.tbDNFSimplified.Size = new System.Drawing.Size(555, 27);
            this.tbDNFSimplified.TabIndex = 27;
            // 
            // tbDNF
            // 
            this.tbDNF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDNF.Location = new System.Drawing.Point(119, 275);
            this.tbDNF.Name = "tbDNF";
            this.tbDNF.ReadOnly = true;
            this.tbDNF.Size = new System.Drawing.Size(555, 27);
            this.tbDNF.TabIndex = 26;
            // 
            // lbBinary
            // 
            this.lbBinary.AutoSize = true;
            this.lbBinary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBinary.ForeColor = System.Drawing.Color.Black;
            this.lbBinary.Location = new System.Drawing.Point(61, 136);
            this.lbBinary.Name = "lbBinary";
            this.lbBinary.Size = new System.Drawing.Size(57, 23);
            this.lbBinary.TabIndex = 25;
            this.lbBinary.Text = "Binary";
            // 
            // tbBinary
            // 
            this.tbBinary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBinary.Location = new System.Drawing.Point(119, 133);
            this.tbBinary.Name = "tbBinary";
            this.tbBinary.ReadOnly = true;
            this.tbBinary.Size = new System.Drawing.Size(555, 27);
            this.tbBinary.TabIndex = 24;
            // 
            // truthTableSimplified
            // 
            this.truthTableSimplified.AllowUserToAddRows = false;
            this.truthTableSimplified.AllowUserToDeleteRows = false;
            this.truthTableSimplified.AllowUserToResizeColumns = false;
            this.truthTableSimplified.AllowUserToResizeRows = false;
            this.truthTableSimplified.BackgroundColor = System.Drawing.Color.White;
            this.truthTableSimplified.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truthTableSimplified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truthTableSimplified.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(21)))));
            this.truthTableSimplified.Location = new System.Drawing.Point(277, 99);
            this.truthTableSimplified.Name = "truthTableSimplified";
            this.truthTableSimplified.ReadOnly = true;
            this.truthTableSimplified.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.truthTableSimplified.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.truthTableSimplified.RowTemplate.Height = 29;
            this.truthTableSimplified.ShowEditingIcon = false;
            this.truthTableSimplified.Size = new System.Drawing.Size(642, 493);
            this.truthTableSimplified.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 619);
            this.Controls.Add(this.panelFormulas);
            this.Controls.Add(this.truthTableSimplified);
            this.Controls.Add(this.truthTable);
            this.Controls.Add(this.lbPropError);
            this.Controls.Add(this.btParse);
            this.Controls.Add(this.lbProposition);
            this.Controls.Add(this.tbProposition);
            this.Controls.Add(this.linkLbLogoMakr);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopbar);
            this.Controls.Add(this.pbTree);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSidebar.ResumeLayout(false);
            this.panelSideBarBtns.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTopbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truthTable)).EndInit();
            this.panelFormulas.ResumeLayout(false);
            this.panelFormulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truthTableSimplified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Panel panelSideBarBtns;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btFormulas;
        private System.Windows.Forms.Button btTableSimplified;
        private System.Windows.Forms.Button btTruthTable;
        private System.Windows.Forms.Button btTree;
        private System.Windows.Forms.Button btCredits;
        private System.Windows.Forms.LinkLabel linkLbLogoMakr;
        private System.Windows.Forms.TextBox tbProposition;
        private System.Windows.Forms.Button btParse;
        private System.Windows.Forms.Label lbProposition;
        private System.Windows.Forms.Label lbPropError;
        private System.Windows.Forms.PictureBox pbTree;
        private System.Windows.Forms.Label lbOperators;
        private System.Windows.Forms.TextBox tbOperators;
        private System.Windows.Forms.Label lbVariables;
        private System.Windows.Forms.Label lbInfixProp;
        private System.Windows.Forms.TextBox tbVariables;
        private System.Windows.Forms.TextBox tbInfixProp;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView truthTable;
        private System.Windows.Forms.TextBox tbHashValue;
        private System.Windows.Forms.Label lbHashValue;
        private System.Windows.Forms.Panel panelFormulas;
        private System.Windows.Forms.DataGridView truthTableSimplified;
        private System.Windows.Forms.Label lbBinary;
        private System.Windows.Forms.TextBox tbBinary;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbNand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDNF;
        private System.Windows.Forms.TextBox tbNand;
        private System.Windows.Forms.TextBox tbDNFSimplified;
        private System.Windows.Forms.TextBox tbDNF;
        private System.Windows.Forms.TextBox tbHashSimplified;
        private System.Windows.Forms.Label lbBinarySimplified;
        private System.Windows.Forms.TextBox tbBinarySimplified;
        private System.Windows.Forms.Label lbHashSimplified;
    }
}

