namespace ExperimentFour
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_MS = new System.Windows.Forms.Button();
            this.btn_Mplus = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_rec = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_7 = new CCWin.SkinControl.SkinButton();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_9 = new CCWin.SkinControl.SkinButton();
            this.btn_8 = new CCWin.SkinControl.SkinButton();
            this.btn_4 = new CCWin.SkinControl.SkinButton();
            this.btn_5 = new CCWin.SkinControl.SkinButton();
            this.btn_6 = new CCWin.SkinControl.SkinButton();
            this.btn_1 = new CCWin.SkinControl.SkinButton();
            this.btn_2 = new CCWin.SkinControl.SkinButton();
            this.btn_3 = new CCWin.SkinControl.SkinButton();
            this.btn_0 = new CCWin.SkinControl.SkinButton();
            this.btn_neg = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.screen = new CCWin.SkinControl.RtfRichTextBox();
            this.btn_close = new CCWin.SkinControl.SkinButton();
            this.btn_help = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.isM = new CCWin.SkinControl.SkinCheckBox();
            this.sign = new CCWin.SkinControl.SkinWaterTextBox();
            this.label = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_div.Location = new System.Drawing.Point(216, 157);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(44, 37);
            this.btn_div.TabIndex = 4;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sub.Location = new System.Drawing.Point(216, 243);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(44, 37);
            this.btn_sub.TabIndex = 2;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mul.Location = new System.Drawing.Point(216, 200);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(44, 37);
            this.btn_mul.TabIndex = 3;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(216, 286);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(44, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_MC
            // 
            this.btn_MC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MC.Location = new System.Drawing.Point(13, 157);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(44, 37);
            this.btn_MC.TabIndex = 16;
            this.btn_MC.TabStop = false;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.Btn_MC_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MR.Location = new System.Drawing.Point(13, 200);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(44, 37);
            this.btn_MR.TabIndex = 17;
            this.btn_MR.TabStop = false;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.Btn_MR_Click);
            // 
            // btn_MS
            // 
            this.btn_MS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MS.Location = new System.Drawing.Point(13, 243);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(44, 37);
            this.btn_MS.TabIndex = 18;
            this.btn_MS.TabStop = false;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = true;
            this.btn_MS.Click += new System.EventHandler(this.Btn_MS_Click);
            // 
            // btn_Mplus
            // 
            this.btn_Mplus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Mplus.Location = new System.Drawing.Point(13, 286);
            this.btn_Mplus.Name = "btn_Mplus";
            this.btn_Mplus.Size = new System.Drawing.Size(44, 37);
            this.btn_Mplus.TabIndex = 19;
            this.btn_Mplus.TabStop = false;
            this.btn_Mplus.Text = "M+";
            this.btn_Mplus.UseVisualStyleBackColor = true;
            this.btn_Mplus.Click += new System.EventHandler(this.Btn_Mplus_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sqrt.Location = new System.Drawing.Point(266, 157);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(44, 37);
            this.btn_sqrt.TabIndex = 19;
            this.btn_sqrt.TabStop = false;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.Btn_sqrt_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mod.Location = new System.Drawing.Point(266, 200);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(44, 37);
            this.btn_mod.TabIndex = 5;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.Btn_mod_Click);
            // 
            // btn_rec
            // 
            this.btn_rec.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rec.Location = new System.Drawing.Point(266, 243);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(44, 37);
            this.btn_rec.TabIndex = 17;
            this.btn_rec.TabStop = false;
            this.btn_rec.Text = "1/x";
            this.btn_rec.UseVisualStyleBackColor = true;
            this.btn_rec.Click += new System.EventHandler(this.Btn_rec_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_equal.Location = new System.Drawing.Point(266, 286);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(44, 37);
            this.btn_equal.TabIndex = 6;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.Btn_equal_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Transparent;
            this.btn_7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_7.DownBack = null;
            this.btn_7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_7.Location = new System.Drawing.Point(63, 157);
            this.btn_7.MouseBack = null;
            this.btn_7.Name = "btn_7";
            this.btn_7.NormlBack = null;
            this.btn_7.Size = new System.Drawing.Size(44, 37);
            this.btn_7.TabIndex = 7;
            this.btn_7.TabStop = false;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_backspace.Location = new System.Drawing.Point(77, 108);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(72, 43);
            this.btn_backspace.TabIndex = 20;
            this.btn_backspace.TabStop = false;
            this.btn_backspace.Text = "Backspace";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.Btn_backspace_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CE.Location = new System.Drawing.Point(160, 108);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(72, 43);
            this.btn_CE.TabIndex = 21;
            this.btn_CE.TabStop = false;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.Btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_C.Location = new System.Drawing.Point(238, 108);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(72, 43);
            this.btn_C.TabIndex = 22;
            this.btn_C.TabStop = false;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Transparent;
            this.btn_9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_9.DownBack = null;
            this.btn_9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_9.Location = new System.Drawing.Point(166, 157);
            this.btn_9.MouseBack = null;
            this.btn_9.Name = "btn_9";
            this.btn_9.NormlBack = null;
            this.btn_9.Size = new System.Drawing.Size(44, 37);
            this.btn_9.TabIndex = 9;
            this.btn_9.TabStop = false;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Transparent;
            this.btn_8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_8.DownBack = null;
            this.btn_8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_8.Location = new System.Drawing.Point(113, 157);
            this.btn_8.MouseBack = null;
            this.btn_8.Name = "btn_8";
            this.btn_8.NormlBack = null;
            this.btn_8.Size = new System.Drawing.Size(44, 37);
            this.btn_8.TabIndex = 8;
            this.btn_8.TabStop = false;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Transparent;
            this.btn_4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_4.DownBack = null;
            this.btn_4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_4.Location = new System.Drawing.Point(63, 200);
            this.btn_4.MouseBack = null;
            this.btn_4.Name = "btn_4";
            this.btn_4.NormlBack = null;
            this.btn_4.Size = new System.Drawing.Size(44, 37);
            this.btn_4.TabIndex = 4;
            this.btn_4.TabStop = false;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Transparent;
            this.btn_5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_5.DownBack = null;
            this.btn_5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_5.Location = new System.Drawing.Point(113, 200);
            this.btn_5.MouseBack = null;
            this.btn_5.Name = "btn_5";
            this.btn_5.NormlBack = null;
            this.btn_5.Size = new System.Drawing.Size(44, 37);
            this.btn_5.TabIndex = 5;
            this.btn_5.TabStop = false;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Transparent;
            this.btn_6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_6.DownBack = null;
            this.btn_6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_6.Location = new System.Drawing.Point(166, 200);
            this.btn_6.MouseBack = null;
            this.btn_6.Name = "btn_6";
            this.btn_6.NormlBack = null;
            this.btn_6.Size = new System.Drawing.Size(44, 37);
            this.btn_6.TabIndex = 6;
            this.btn_6.TabStop = false;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Transparent;
            this.btn_1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_1.DownBack = null;
            this.btn_1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_1.Location = new System.Drawing.Point(63, 243);
            this.btn_1.MouseBack = null;
            this.btn_1.Name = "btn_1";
            this.btn_1.NormlBack = null;
            this.btn_1.Size = new System.Drawing.Size(44, 37);
            this.btn_1.TabIndex = 1;
            this.btn_1.TabStop = false;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Transparent;
            this.btn_2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_2.DownBack = null;
            this.btn_2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_2.Location = new System.Drawing.Point(113, 243);
            this.btn_2.MouseBack = null;
            this.btn_2.Name = "btn_2";
            this.btn_2.NormlBack = null;
            this.btn_2.Size = new System.Drawing.Size(44, 37);
            this.btn_2.TabIndex = 2;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Transparent;
            this.btn_3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_3.DownBack = null;
            this.btn_3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_3.Location = new System.Drawing.Point(166, 243);
            this.btn_3.MouseBack = null;
            this.btn_3.Name = "btn_3";
            this.btn_3.NormlBack = null;
            this.btn_3.Size = new System.Drawing.Size(44, 37);
            this.btn_3.TabIndex = 3;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.SkinButton2_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Transparent;
            this.btn_0.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_0.DownBack = null;
            this.btn_0.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_0.Location = new System.Drawing.Point(113, 286);
            this.btn_0.MouseBack = null;
            this.btn_0.Name = "btn_0";
            this.btn_0.NormlBack = null;
            this.btn_0.Size = new System.Drawing.Size(44, 37);
            this.btn_0.TabIndex = 0;
            this.btn_0.TabStop = false;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Btn_0_Click);
            // 
            // btn_neg
            // 
            this.btn_neg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_neg.Location = new System.Drawing.Point(63, 286);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(44, 37);
            this.btn_neg.TabIndex = 10;
            this.btn_neg.TabStop = false;
            this.btn_neg.Text = "+/-";
            this.btn_neg.UseVisualStyleBackColor = true;
            this.btn_neg.Click += new System.EventHandler(this.Btn_neg_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dot.Location = new System.Drawing.Point(166, 286);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(44, 37);
            this.btn_dot.TabIndex = 11;
            this.btn_dot.TabStop = false;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.Btn_dot_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.screen.Cursor = System.Windows.Forms.Cursors.Default;
            this.screen.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.screen.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.screen.Location = new System.Drawing.Point(14, 39);
            this.screen.MaxLength = 10;
            this.screen.Multiline = false;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.screen.Size = new System.Drawing.Size(293, 54);
            this.screen.TabIndex = 41;
            this.screen.TabStop = false;
            this.screen.Text = "0";
            this.screen.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            this.screen.TextChanged += new System.EventHandler(this.Screen_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BaseColor = System.Drawing.Color.Silver;
            this.btn_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DownBack = null;
            this.btn_close.DownBaseColor = System.Drawing.Color.DimGray;
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(90, 1);
            this.btn_close.MouseBack = null;
            this.btn_close.MouseBaseColor = System.Drawing.Color.LightGray;
            this.btn_close.Name = "btn_close";
            this.btn_close.NormlBack = null;
            this.btn_close.Size = new System.Drawing.Size(72, 32);
            this.btn_close.TabIndex = 24;
            this.btn_close.Text = "关闭(C)";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Transparent;
            this.btn_help.BaseColor = System.Drawing.Color.Silver;
            this.btn_help.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_help.DownBack = null;
            this.btn_help.DownBaseColor = System.Drawing.Color.DimGray;
            this.btn_help.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_help.Location = new System.Drawing.Point(12, 1);
            this.btn_help.MouseBack = null;
            this.btn_help.MouseBaseColor = System.Drawing.Color.LightGray;
            this.btn_help.Name = "btn_help";
            this.btn_help.NormlBack = null;
            this.btn_help.Size = new System.Drawing.Size(72, 32);
            this.btn_help.TabIndex = 23;
            this.btn_help.Text = "说明(H)";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.Btn_help_Click);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinPictureBox1.Image = global::ExperimentFour.Properties.Resources.photo;
            this.skinPictureBox1.Location = new System.Drawing.Point(0, 108);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(63, 43);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 44;
            this.skinPictureBox1.TabStop = false;
            // 
            // isM
            // 
            this.isM.AutoCheck = false;
            this.isM.AutoSize = true;
            this.isM.BackColor = System.Drawing.Color.Transparent;
            this.isM.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.isM.DownBack = null;
            this.isM.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isM.Location = new System.Drawing.Point(271, 10);
            this.isM.MouseBack = null;
            this.isM.Name = "isM";
            this.isM.NormlBack = null;
            this.isM.SelectedDownBack = null;
            this.isM.SelectedMouseBack = null;
            this.isM.SelectedNormlBack = null;
            this.isM.Size = new System.Drawing.Size(39, 21);
            this.isM.TabIndex = 45;
            this.isM.TabStop = false;
            this.isM.Text = "M";
            this.isM.UseVisualStyleBackColor = false;
            this.isM.CheckedChanged += new System.EventHandler(this.SkinCheckBox1_CheckedChanged);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(210, 10);
            this.sign.Name = "sign";
            this.sign.ReadOnly = true;
            this.sign.Size = new System.Drawing.Size(22, 21);
            this.sign.TabIndex = 46;
            this.sign.TabStop = false;
            this.sign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sign.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sign.WaterText = "";
            this.sign.TextChanged += new System.EventHandler(this.SkinWaterTextBox1_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.BorderColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(166, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 17);
            this.label.TabIndex = 25;
            this.label.Text = "运算符";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(319, 341);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.isM);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_Mplus);
            this.Controls.Add(this.btn_MS);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DAO_Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_press);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_MS;
        private System.Windows.Forms.Button btn_Mplus;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.Button btn_equal;
        private CCWin.SkinControl.SkinButton btn_7;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private CCWin.SkinControl.SkinButton btn_9;
        private CCWin.SkinControl.SkinButton btn_8;
        private CCWin.SkinControl.SkinButton btn_4;
        private CCWin.SkinControl.SkinButton btn_5;
        private CCWin.SkinControl.SkinButton btn_6;
        private CCWin.SkinControl.SkinButton btn_1;
        private CCWin.SkinControl.SkinButton btn_2;
        private CCWin.SkinControl.SkinButton btn_3;
        private CCWin.SkinControl.SkinButton btn_0;
        private System.Windows.Forms.Button btn_neg;
        private System.Windows.Forms.Button btn_dot;
        private CCWin.SkinControl.RtfRichTextBox screen;
        private CCWin.SkinControl.SkinButton btn_close;
        private CCWin.SkinControl.SkinButton btn_help;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinCheckBox isM;
        private CCWin.SkinControl.SkinWaterTextBox sign;
        private CCWin.SkinControl.SkinLabel label;

    }
}

