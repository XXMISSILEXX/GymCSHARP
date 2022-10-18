namespace GymManagement
{
    partial class AddCoach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCoach));
            this.Gendecb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MemberPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Gendecb
            // 
            this.Gendecb.BackColor = System.Drawing.Color.Transparent;
            this.Gendecb.BorderColor = System.Drawing.Color.Crimson;
            this.Gendecb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Gendecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gendecb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gendecb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gendecb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Gendecb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Gendecb.ItemHeight = 30;
            this.Gendecb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gendecb.Location = new System.Drawing.Point(47, 206);
            this.Gendecb.Name = "Gendecb";
            this.Gendecb.Size = new System.Drawing.Size(140, 36);
            this.Gendecb.TabIndex = 52;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 40;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.Name = null;
            this.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(47, 381);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1383, 419);
            this.DataGridView1.TabIndex = 50;
            this.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // MemberPicture
            // 
            this.MemberPicture.AllowFocused = false;
            this.MemberPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MemberPicture.BorderRadius = 0;
            this.MemberPicture.Image = ((System.Drawing.Image)(resources.GetObject("MemberPicture.Image")));
            this.MemberPicture.IsCircle = false;
            this.MemberPicture.Location = new System.Drawing.Point(1046, 32);
            this.MemberPicture.Name = "MemberPicture";
            this.MemberPicture.Size = new System.Drawing.Size(222, 222);
            this.MemberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MemberPicture.TabIndex = 49;
            this.MemberPicture.TabStop = false;
            this.MemberPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(703, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 54);
            this.button4.TabIndex = 48;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1001, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 54);
            this.button3.TabIndex = 47;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(379, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 54);
            this.button2.TabIndex = 46;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 54);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AgeTb
            // 
            this.AgeTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AgeTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AgeTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AgeTb.ForeColor = System.Drawing.Color.Crimson;
            this.AgeTb.HintForeColor = System.Drawing.Color.Empty;
            this.AgeTb.HintText = "";
            this.AgeTb.isPassword = false;
            this.AgeTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.AgeTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.AgeTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.AgeTb.LineThickness = 3;
            this.AgeTb.Location = new System.Drawing.Point(691, 70);
            this.AgeTb.Margin = new System.Windows.Forms.Padding(4);
            this.AgeTb.MaxLength = 32767;
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(227, 39);
            this.AgeTb.TabIndex = 43;
            this.AgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(41, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 34);
            this.label6.TabIndex = 42;
            this.label6.Text = "Gender";
            // 
            // PhoneTb
            // 
            this.PhoneTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhoneTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhoneTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PhoneTb.ForeColor = System.Drawing.Color.Crimson;
            this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneTb.HintText = "";
            this.PhoneTb.isPassword = false;
            this.PhoneTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PhoneTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PhoneTb.LineThickness = 3;
            this.PhoneTb.Location = new System.Drawing.Point(370, 70);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTb.MaxLength = 32767;
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(227, 39);
            this.PhoneTb.TabIndex = 41;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(364, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 34);
            this.label5.TabIndex = 40;
            this.label5.Text = "Phone";
            // 
            // NameTb
            // 
            this.NameTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTb.ForeColor = System.Drawing.Color.Crimson;
            this.NameTb.HintForeColor = System.Drawing.Color.Empty;
            this.NameTb.HintText = "";
            this.NameTb.isPassword = false;
            this.NameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.NameTb.LineIdleColor = System.Drawing.Color.Crimson;
            this.NameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NameTb.LineThickness = 3;
            this.NameTb.Location = new System.Drawing.Point(48, 70);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4);
            this.NameTb.MaxLength = 32767;
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(227, 39);
            this.NameTb.TabIndex = 39;
            this.NameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 34);
            this.label4.TabIndex = 38;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1189, -138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 47);
            this.label3.TabIndex = 37;
            this.label3.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(695, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 34);
            this.label7.TabIndex = 44;
            this.label7.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(327, -90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 49);
            this.label2.TabIndex = 36;
            this.label2.Text = "Add New Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(348, -147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = " FITNESS CENTER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(364, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 34);
            this.label10.TabIndex = 54;
            this.label10.Text = "YearsOfExperience";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Crimson;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(370, 206);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(227, 29);
            this.bunifuMaterialTextbox1.TabIndex = 55;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(1373, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 47);
            this.label8.TabIndex = 56;
            this.label8.Text = "X";
            // 
            // AddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 885);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Gendecb);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.MemberPicture);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCoach";
            this.Text = "AddCoach";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox Gendecb;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridView1;
        private Bunifu.UI.WinForms.BunifuPictureBox MemberPicture;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AgeTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label8;
    }
}