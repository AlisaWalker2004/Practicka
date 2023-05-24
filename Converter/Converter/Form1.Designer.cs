namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFioSotr = new System.Windows.Forms.TextBox();
            this.btnZapis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ниже фио сотрудника:\r\n";
            // 
            // tbFioSotr
            // 
            this.tbFioSotr.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFioSotr.Location = new System.Drawing.Point(12, 46);
            this.tbFioSotr.Name = "tbFioSotr";
            this.tbFioSotr.Size = new System.Drawing.Size(658, 33);
            this.tbFioSotr.TabIndex = 1;
            // 
            // btnZapis
            // 
            this.btnZapis.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZapis.Location = new System.Drawing.Point(12, 128);
            this.btnZapis.Name = "btnZapis";
            this.btnZapis.Size = new System.Drawing.Size(364, 34);
            this.btnZapis.TabIndex = 2;
            this.btnZapis.Text = "Сформировать учётную запись";
            this.btnZapis.UseVisualStyleBackColor = true;
            this.btnZapis.Click += new System.EventHandler(this.btnZapis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:\r\n";
            // 
            // tbRes
            // 
            this.tbRes.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRes.Location = new System.Drawing.Point(12, 244);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(399, 33);
            this.tbRes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 298);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZapis);
            this.Controls.Add(this.tbFioSotr);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFioSotr;
        private System.Windows.Forms.Button btnZapis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRes;
    }
}

