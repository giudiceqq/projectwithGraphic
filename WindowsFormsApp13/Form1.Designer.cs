namespace WindowsFormsApp13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.LeftLeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DownDownButton = new System.Windows.Forms.Button();
            this.RightRightButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.UpUpButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.changeAngleToRightButton = new System.Windows.Forms.Button();
            this.changeAngleToLeftButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.currentObjectsComboBox = new System.Windows.Forms.ComboBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.hidebutton = new System.Windows.Forms.Button();
            this.createbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.LeftButton);
            this.groupBox1.Controls.Add(this.LeftLeftButton);
            this.groupBox1.Controls.Add(this.DownButton);
            this.groupBox1.Controls.Add(this.DownDownButton);
            this.groupBox1.Controls.Add(this.RightRightButton);
            this.groupBox1.Controls.Add(this.RightButton);
            this.groupBox1.Controls.Add(this.UpUpButton);
            this.groupBox1.Controls.Add(this.upButton);
            this.groupBox1.Controls.Add(this.changeAngleToRightButton);
            this.groupBox1.Controls.Add(this.changeAngleToLeftButton);
            this.groupBox1.Controls.Add(this.minusButton);
            this.groupBox1.Controls.Add(this.plusButton);
            this.groupBox1.Controls.Add(this.currentObjectsComboBox);
            this.groupBox1.Controls.Add(this.showbutton);
            this.groupBox1.Controls.Add(this.hidebutton);
            this.groupBox1.Controls.Add(this.createbutton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(628, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 633);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.LeftButton.Location = new System.Drawing.Point(66, 397);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(53, 45);
            this.LeftButton.TabIndex = 15;
            this.LeftButton.Text = "⬅️";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // LeftLeftButton
            // 
            this.LeftLeftButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.LeftLeftButton.Location = new System.Drawing.Point(7, 378);
            this.LeftLeftButton.Name = "LeftLeftButton";
            this.LeftLeftButton.Size = new System.Drawing.Size(53, 87);
            this.LeftLeftButton.TabIndex = 14;
            this.LeftLeftButton.Text = "⬅️\r\n⬅️\r\n\r\n";
            this.LeftLeftButton.UseVisualStyleBackColor = true;
            this.LeftLeftButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // DownButton
            // 
            this.DownButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.DownButton.Location = new System.Drawing.Point(154, 471);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(53, 45);
            this.DownButton.TabIndex = 13;
            this.DownButton.Text = "⬇️";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // DownDownButton
            // 
            this.DownDownButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.DownDownButton.Location = new System.Drawing.Point(139, 522);
            this.DownDownButton.Name = "DownDownButton";
            this.DownDownButton.Size = new System.Drawing.Size(83, 45);
            this.DownDownButton.TabIndex = 12;
            this.DownDownButton.Text = "⬇️⬇️";
            this.DownDownButton.UseVisualStyleBackColor = true;
            this.DownDownButton.Click += new System.EventHandler(this.button12_Click);
            // 
            // RightRightButton
            // 
            this.RightRightButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.RightRightButton.Location = new System.Drawing.Point(302, 377);
            this.RightRightButton.Name = "RightRightButton";
            this.RightRightButton.Size = new System.Drawing.Size(53, 84);
            this.RightRightButton.TabIndex = 11;
            this.RightRightButton.Text = "➡️\r\n➡️\r\n\r\n";
            this.RightRightButton.UseVisualStyleBackColor = true;
            this.RightRightButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.RightButton.Location = new System.Drawing.Point(243, 397);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(53, 45);
            this.RightButton.TabIndex = 10;
            this.RightButton.Text = "➡️";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // UpUpButton
            // 
            this.UpUpButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.UpUpButton.Location = new System.Drawing.Point(139, 267);
            this.UpUpButton.Name = "UpUpButton";
            this.UpUpButton.Size = new System.Drawing.Size(83, 45);
            this.UpUpButton.TabIndex = 9;
            this.UpUpButton.Text = "⬆️⬆️";
            this.UpUpButton.UseVisualStyleBackColor = true;
            this.UpUpButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.upButton.Location = new System.Drawing.Point(154, 318);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(53, 45);
            this.upButton.TabIndex = 8;
            this.upButton.Text = "⬆️";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // changeAngleToRightButton
            // 
            this.changeAngleToRightButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.changeAngleToRightButton.Location = new System.Drawing.Point(125, 420);
            this.changeAngleToRightButton.Name = "changeAngleToRightButton";
            this.changeAngleToRightButton.Size = new System.Drawing.Size(53, 45);
            this.changeAngleToRightButton.TabIndex = 7;
            this.changeAngleToRightButton.Text = "↪️";
            this.changeAngleToRightButton.UseVisualStyleBackColor = true;
            this.changeAngleToRightButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // changeAngleToLeftButton
            // 
            this.changeAngleToLeftButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.changeAngleToLeftButton.Location = new System.Drawing.Point(184, 420);
            this.changeAngleToLeftButton.Name = "changeAngleToLeftButton";
            this.changeAngleToLeftButton.Size = new System.Drawing.Size(53, 45);
            this.changeAngleToLeftButton.TabIndex = 6;
            this.changeAngleToLeftButton.Text = "↩️";
            this.changeAngleToLeftButton.UseVisualStyleBackColor = true;
            this.changeAngleToLeftButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.minusButton.Location = new System.Drawing.Point(125, 369);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(53, 45);
            this.minusButton.TabIndex = 5;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.plusButton.Location = new System.Drawing.Point(184, 369);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(53, 45);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // currentObjectsComboBox
            // 
            this.currentObjectsComboBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.currentObjectsComboBox.FormattingEnabled = true;
            this.currentObjectsComboBox.Location = new System.Drawing.Point(115, 38);
            this.currentObjectsComboBox.Name = "currentObjectsComboBox";
            this.currentObjectsComboBox.Size = new System.Drawing.Size(140, 28);
            this.currentObjectsComboBox.TabIndex = 3;
            this.currentObjectsComboBox.Text = "объекты";
            this.currentObjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // showbutton
            // 
            this.showbutton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showbutton.Location = new System.Drawing.Point(115, 208);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(147, 45);
            this.showbutton.TabIndex = 2;
            this.showbutton.Text = "показать объект";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // hidebutton
            // 
            this.hidebutton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hidebutton.Location = new System.Drawing.Point(115, 162);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(147, 45);
            this.hidebutton.TabIndex = 1;
            this.hidebutton.Text = "спрятать объект";
            this.hidebutton.UseVisualStyleBackColor = true;
            this.hidebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createbutton
            // 
            this.createbutton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createbutton.Location = new System.Drawing.Point(115, 116);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(147, 45);
            this.createbutton.TabIndex = 0;
            this.createbutton.Text = "создать объект";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1, 633);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1, 614);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(1, 632);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 1);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 633);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.ComboBox currentObjectsComboBox;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button hidebutton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button changeAngleToRightButton;
        private System.Windows.Forms.Button changeAngleToLeftButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button LeftLeftButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button DownDownButton;
        private System.Windows.Forms.Button RightRightButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button UpUpButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

