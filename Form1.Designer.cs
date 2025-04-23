namespace _3DPrintCost
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
            this.MainLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PlasticCost = new System.Windows.Forms.TextBox();
            this.PrintLength = new System.Windows.Forms.TextBox();
            this.PrintTime = new System.Windows.Forms.TextBox();
            this.E_Eat = new System.Windows.Forms.TextBox();
            this.E_Cost = new System.Windows.Forms.TextBox();
            this.Profit = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.TranslateBtn = new System.Windows.Forms.Button();
            this.GetCostBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainLength
            // 
            this.MainLength.Location = new System.Drawing.Point(301, 9);
            this.MainLength.Name = "MainLength";
            this.MainLength.Size = new System.Drawing.Size(153, 20);
            this.MainLength.TabIndex = 0;
            this.MainLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Потребление эл-ва (кВт/ч)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена материала (при покупке)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество материала при покупке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Затраченный материал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Время печати";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена эл-ва (кВт/ч)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(234, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 45);
            this.label7.TabIndex = 7;
            this.label7.Text = "Цена печати:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(14, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Прибыль:";
            // 
            // PlasticCost
            // 
            this.PlasticCost.Location = new System.Drawing.Point(301, 35);
            this.PlasticCost.Name = "PlasticCost";
            this.PlasticCost.Size = new System.Drawing.Size(153, 20);
            this.PlasticCost.TabIndex = 9;
            this.PlasticCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // PrintLength
            // 
            this.PrintLength.Location = new System.Drawing.Point(301, 61);
            this.PrintLength.Name = "PrintLength";
            this.PrintLength.Size = new System.Drawing.Size(153, 20);
            this.PrintLength.TabIndex = 10;
            this.PrintLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // PrintTime
            // 
            this.PrintTime.Location = new System.Drawing.Point(300, 115);
            this.PrintTime.Name = "PrintTime";
            this.PrintTime.Size = new System.Drawing.Size(153, 20);
            this.PrintTime.TabIndex = 11;
            this.PrintTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // E_Eat
            // 
            this.E_Eat.Location = new System.Drawing.Point(301, 141);
            this.E_Eat.Name = "E_Eat";
            this.E_Eat.Size = new System.Drawing.Size(153, 20);
            this.E_Eat.TabIndex = 12;
            this.E_Eat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // E_Cost
            // 
            this.E_Cost.Location = new System.Drawing.Point(301, 167);
            this.E_Cost.Name = "E_Cost";
            this.E_Cost.Size = new System.Drawing.Size(153, 20);
            this.E_Cost.TabIndex = 13;
            this.E_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // Profit
            // 
            this.Profit.Location = new System.Drawing.Point(300, 222);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(153, 20);
            this.Profit.TabIndex = 14;
            this.Profit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressCondition);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.24F);
            this.Result.Location = new System.Drawing.Point(488, 391);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(266, 45);
            this.Result.TabIndex = 15;
            // 
            // TranslateBtn
            // 
            this.TranslateBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateBtn.Location = new System.Drawing.Point(460, 135);
            this.TranslateBtn.Name = "TranslateBtn";
            this.TranslateBtn.Size = new System.Drawing.Size(193, 27);
            this.TranslateBtn.TabIndex = 16;
            this.TranslateBtn.Text = "Перевести Вт в кВт";
            this.TranslateBtn.UseVisualStyleBackColor = true;
            this.TranslateBtn.Click += new System.EventHandler(this.TranslateBtn_Click);
            // 
            // GetCostBtn
            // 
            this.GetCostBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetCostBtn.Location = new System.Drawing.Point(12, 391);
            this.GetCostBtn.Name = "GetCostBtn";
            this.GetCostBtn.Size = new System.Drawing.Size(217, 55);
            this.GetCostBtn.TabIndex = 17;
            this.GetCostBtn.Text = "Рассчитать стоимость";
            this.GetCostBtn.UseVisualStyleBackColor = true;
            this.GetCostBtn.Click += new System.EventHandler(this.GetCostBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(12, 294);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(193, 27);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Сохранить пресет";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(13, 327);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(193, 27);
            this.LoadButton.TabIndex = 19;
            this.LoadButton.Text = "Загрузить пресет";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(764, 458);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GetCostBtn);
            this.Controls.Add(this.TranslateBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.E_Cost);
            this.Controls.Add(this.E_Eat);
            this.Controls.Add(this.PrintTime);
            this.Controls.Add(this.PrintLength);
            this.Controls.Add(this.PlasticCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainLength);
            this.Name = "Form1";
            this.Text = "3D Print Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PlasticCost;
        private System.Windows.Forms.TextBox PrintLength;
        private System.Windows.Forms.TextBox PrintTime;
        private System.Windows.Forms.TextBox E_Eat;
        private System.Windows.Forms.TextBox E_Cost;
        private System.Windows.Forms.TextBox Profit;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button TranslateBtn;
        private System.Windows.Forms.Button GetCostBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

