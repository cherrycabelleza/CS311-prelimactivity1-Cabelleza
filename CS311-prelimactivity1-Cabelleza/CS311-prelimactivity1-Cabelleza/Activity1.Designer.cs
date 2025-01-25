namespace CS311_prelimactivity1_Cabelleza
{
    partial class Activity1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtsidea = new TextBox();
            txtsideb = new TextBox();
            txtsidec = new TextBox();
            txtheight = new TextBox();
            txtarea = new TextBox();
            txtperimeter = new TextBox();
            btnarea = new Button();
            btnperimeter = new Button();
            btnclear = new Button();
            btncomputeall = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 56);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Side A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 96);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Side B:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 135);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Side C:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 173);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Height:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 338);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "Area:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 410);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 5;
            label6.Text = "Perimeter:";
            // 
            // txtsidea
            // 
            txtsidea.Cursor = Cursors.Hand;
            txtsidea.Location = new Point(100, 48);
            txtsidea.Name = "txtsidea";
            txtsidea.Size = new Size(168, 23);
            txtsidea.TabIndex = 6;
            txtsidea.KeyPress += txtsidea_KeyPress;
            // 
            // txtsideb
            // 
            txtsideb.Cursor = Cursors.Hand;
            txtsideb.Location = new Point(100, 88);
            txtsideb.Name = "txtsideb";
            txtsideb.Size = new Size(168, 23);
            txtsideb.TabIndex = 7;
            txtsideb.KeyPress += txtsideb_KeyPress;
            // 
            // txtsidec
            // 
            txtsidec.Cursor = Cursors.Hand;
            txtsidec.Location = new Point(100, 127);
            txtsidec.Name = "txtsidec";
            txtsidec.Size = new Size(168, 23);
            txtsidec.TabIndex = 8;
            txtsidec.KeyPress += txtsidec_KeyPress;
            // 
            // txtheight
            // 
            txtheight.Cursor = Cursors.Hand;
            txtheight.Location = new Point(100, 165);
            txtheight.Name = "txtheight";
            txtheight.Size = new Size(168, 23);
            txtheight.TabIndex = 9;
            txtheight.KeyPress += txtheight_KeyPress;
            // 
            // txtarea
            // 
            txtarea.BackColor = SystemColors.InactiveCaption;
            txtarea.BorderStyle = BorderStyle.None;
            txtarea.Cursor = Cursors.Hand;
            txtarea.Enabled = false;
            txtarea.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtarea.Location = new Point(51, 356);
            txtarea.Multiline = true;
            txtarea.Name = "txtarea";
            txtarea.Size = new Size(217, 40);
            txtarea.TabIndex = 10;
            // 
            // txtperimeter
            // 
            txtperimeter.BackColor = SystemColors.InactiveCaption;
            txtperimeter.BorderStyle = BorderStyle.None;
            txtperimeter.Cursor = Cursors.Hand;
            txtperimeter.Enabled = false;
            txtperimeter.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtperimeter.Location = new Point(51, 428);
            txtperimeter.Multiline = true;
            txtperimeter.Name = "txtperimeter";
            txtperimeter.Size = new Size(217, 40);
            txtperimeter.TabIndex = 11;
            // 
            // btnarea
            // 
            btnarea.Cursor = Cursors.Hand;
            btnarea.Location = new Point(51, 223);
            btnarea.Name = "btnarea";
            btnarea.Size = new Size(75, 33);
            btnarea.TabIndex = 12;
            btnarea.Text = "&Area";
            btnarea.UseVisualStyleBackColor = true;
            btnarea.Click += btnarea_Click;
            // 
            // btnperimeter
            // 
            btnperimeter.Cursor = Cursors.Hand;
            btnperimeter.Location = new Point(193, 223);
            btnperimeter.Name = "btnperimeter";
            btnperimeter.Size = new Size(75, 33);
            btnperimeter.TabIndex = 13;
            btnperimeter.Text = "&Perimeter";
            btnperimeter.UseVisualStyleBackColor = true;
            btnperimeter.Click += btnperimeter_Click;
            // 
            // btnclear
            // 
            btnclear.Cursor = Cursors.Hand;
            btnclear.Location = new Point(100, 498);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(108, 24);
            btnclear.TabIndex = 14;
            btnclear.Text = "Clear &Results";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btncomputeall
            // 
            btncomputeall.Cursor = Cursors.Hand;
            btncomputeall.Location = new Point(107, 276);
            btncomputeall.Name = "btncomputeall";
            btncomputeall.Size = new Size(101, 33);
            btncomputeall.TabIndex = 15;
            btncomputeall.Text = "Compute &All";
            btncomputeall.UseVisualStyleBackColor = true;
            btncomputeall.Click += btncomputeall_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Activity1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(320, 554);
            Controls.Add(btncomputeall);
            Controls.Add(btnclear);
            Controls.Add(btnperimeter);
            Controls.Add(btnarea);
            Controls.Add(txtperimeter);
            Controls.Add(txtarea);
            Controls.Add(txtheight);
            Controls.Add(txtsidec);
            Controls.Add(txtsideb);
            Controls.Add(txtsidea);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Activity1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Area and Perimeter of a Triangle";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtsidea;
        private TextBox txtsideb;
        private TextBox txtsidec;
        private TextBox txtheight;
        private TextBox txtarea;
        private TextBox txtperimeter;
        private Button btnarea;
        private Button btnperimeter;
        private Button btnclear;
        private Button btncomputeall;
        private ErrorProvider errorProvider1;
    }
}