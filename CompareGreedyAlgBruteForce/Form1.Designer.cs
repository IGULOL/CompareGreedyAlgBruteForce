namespace CompareGreedyAlgBruteForce
{
    partial class MainForm
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
            this.listViewCompare = new System.Windows.Forms.ListView();
            this.clmnNameN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnBruteForceTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnGreedyAlgTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSizes = new System.Windows.Forms.Label();
            this.textBoxSizes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.clmnRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewCompare
            // 
            this.listViewCompare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnNameN,
            this.clmnBruteForceTime,
            this.clmnGreedyAlgTime,
            this.clmnRes});
            this.listViewCompare.Location = new System.Drawing.Point(23, 194);
            this.listViewCompare.Name = "listViewCompare";
            this.listViewCompare.Size = new System.Drawing.Size(584, 190);
            this.listViewCompare.TabIndex = 0;
            this.listViewCompare.UseCompatibleStateImageBehavior = false;
            this.listViewCompare.View = System.Windows.Forms.View.Details;
            // 
            // clmnNameN
            // 
            this.clmnNameN.Text = "Количество дискет";
            this.clmnNameN.Width = 115;
            // 
            // clmnBruteForceTime
            // 
            this.clmnBruteForceTime.Text = "Время перебора";
            this.clmnBruteForceTime.Width = 100;
            // 
            // clmnGreedyAlgTime
            // 
            this.clmnGreedyAlgTime.Text = "Время жадного алгоритма";
            this.clmnGreedyAlgTime.Width = 155;
            // 
            // labelSizes
            // 
            this.labelSizes.AutoSize = true;
            this.labelSizes.Location = new System.Drawing.Point(20, 68);
            this.labelSizes.Name = "labelSizes";
            this.labelSizes.Size = new System.Drawing.Size(120, 17);
            this.labelSizes.TabIndex = 1;
            this.labelSizes.Text = "Размеры дискет:";
            // 
            // textBoxSizes
            // 
            this.textBoxSizes.Location = new System.Drawing.Point(23, 88);
            this.textBoxSizes.Name = "textBoxSizes";
            this.textBoxSizes.Size = new System.Drawing.Size(584, 22);
            this.textBoxSizes.TabIndex = 2;
            this.textBoxSizes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задача укладки по дискетам.";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(428, 116);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(179, 27);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // clmnRes
            // 
            this.clmnRes.Text = "Результат";
            this.clmnRes.Width = 70;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 407);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSizes);
            this.Controls.Add(this.labelSizes);
            this.Controls.Add(this.listViewCompare);
            this.Name = "MainForm";
            this.Text = "Сравнение жадного алгоритма с перебором";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCompare;
        private System.Windows.Forms.ColumnHeader clmnNameN;
        private System.Windows.Forms.ColumnHeader clmnBruteForceTime;
        private System.Windows.Forms.ColumnHeader clmnGreedyAlgTime;
        private System.Windows.Forms.Label labelSizes;
        private System.Windows.Forms.TextBox textBoxSizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader clmnRes;
        private System.Windows.Forms.Button btnRun;
    }
}

