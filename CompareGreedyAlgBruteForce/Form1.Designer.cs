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
            this.clmnRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSizes = new System.Windows.Forms.Label();
            this.textBoxSizes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDiskette = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCompare
            // 
            this.listViewCompare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnNameN,
            this.clmnBruteForceTime,
            this.clmnGreedyAlgTime,
            this.clmnRes});
            this.listViewCompare.Location = new System.Drawing.Point(23, 158);
            this.listViewCompare.Name = "listViewCompare";
            this.listViewCompare.Size = new System.Drawing.Size(630, 226);
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
            // clmnRes
            // 
            this.clmnRes.Text = "Результат";
            this.clmnRes.Width = 70;
            // 
            // labelSizes
            // 
            this.labelSizes.AutoSize = true;
            this.labelSizes.Location = new System.Drawing.Point(160, 54);
            this.labelSizes.Name = "labelSizes";
            this.labelSizes.Size = new System.Drawing.Size(125, 17);
            this.labelSizes.TabIndex = 1;
            this.labelSizes.Text = "Размеры файлов:";
            // 
            // textBoxSizes
            // 
            this.textBoxSizes.Location = new System.Drawing.Point(163, 74);
            this.textBoxSizes.Name = "textBoxSizes";
            this.textBoxSizes.Size = new System.Drawing.Size(490, 22);
            this.textBoxSizes.TabIndex = 2;
            this.textBoxSizes.Text = "9 8 6 5 4 2 ";
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
            this.btnRun.Location = new System.Drawing.Point(474, 102);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(179, 27);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер дискеты:";
            // 
            // textBoxDiskette
            // 
            this.textBoxDiskette.Location = new System.Drawing.Point(23, 74);
            this.textBoxDiskette.Name = "textBoxDiskette";
            this.textBoxDiskette.Size = new System.Drawing.Size(117, 22);
            this.textBoxDiskette.TabIndex = 6;
            this.textBoxDiskette.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время - количество тактов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDiskette);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiskette;
        private System.Windows.Forms.Label label3;
    }
}

