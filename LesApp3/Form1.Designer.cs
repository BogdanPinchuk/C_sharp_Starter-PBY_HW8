namespace LesApp3
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
            this.components = new System.ComponentModel.Container();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tt1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(26, 67);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 34);
            this.tb1.TabIndex = 0;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt1.SetToolTip(this.tb1, "Введіть дійсне число");
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2.Location = new System.Drawing.Point(344, 67);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 34);
            this.tb2.TabIndex = 1;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt1.SetToolTip(this.tb2, "Введіть дійсне число");
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1.Location = new System.Drawing.Point(10, 64);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(118, 31);
            this.rb1.TabIndex = 2;
            this.rb1.Text = "^";
            this.tt1.SetToolTip(this.rb1, "Піднести в степінь");
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Checked = true;
            this.rb0.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb0.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb0.Location = new System.Drawing.Point(10, 33);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(118, 31);
            this.rb0.TabIndex = 3;
            this.rb0.TabStop = true;
            this.rb0.Text = "%";
            this.tt1.SetToolTip(this.rb0, "Залишок від ділення");
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.AutoSize = true;
            this.gb1.Controls.Add(this.rb2);
            this.gb1.Controls.Add(this.rb1);
            this.gb1.Controls.Add(this.rb0);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb1.Location = new System.Drawing.Point(166, 13);
            this.gb1.Margin = new System.Windows.Forms.Padding(10);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(10);
            this.gb1.Size = new System.Drawing.Size(138, 142);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Операція";
            this.tt1.SetToolTip(this.gb1, "Операція яка виконуватиметься над двома числами");
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb2.Location = new System.Drawing.Point(10, 95);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(118, 31);
            this.rb2.TabIndex = 4;
            this.rb2.Text = "/";
            this.tt1.SetToolTip(this.rb2, "Ділення");
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(599, 67);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(300, 34);
            this.tb3.TabIndex = 6;
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tt1.SetToolTip(this.tb3, "Результат розрахунку");
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt1.Location = new System.Drawing.Point(484, 67);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 35);
            this.bt1.TabIndex = 7;
            this.bt1.Text = "=";
            this.tt1.SetToolTip(this.bt1, "Виконати вибрану операцію");
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 169);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(917, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tssl1.ForeColor = System.Drawing.Color.Red;
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(917, 191);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "LesApp3";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.ToolTip tt1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
    }
}

