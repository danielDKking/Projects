
namespace ChessMotion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Letter = new System.Windows.Forms.ComboBox();
            this.cb_Number = new System.Windows.Forms.ComboBox();
            this.btn_ShowAvailableCells = new System.Windows.Forms.Button();
            this.tb_ListAvailableCells = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальное полодение:";
            // 
            // cb_Letter
            // 
            this.cb_Letter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Letter.FormattingEnabled = true;
            this.cb_Letter.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cb_Letter.Location = new System.Drawing.Point(15, 25);
            this.cb_Letter.Name = "cb_Letter";
            this.cb_Letter.Size = new System.Drawing.Size(47, 21);
            this.cb_Letter.TabIndex = 1;
            // 
            // cb_Number
            // 
            this.cb_Number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Number.FormattingEnabled = true;
            this.cb_Number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_Number.Location = new System.Drawing.Point(68, 25);
            this.cb_Number.Name = "cb_Number";
            this.cb_Number.Size = new System.Drawing.Size(47, 21);
            this.cb_Number.TabIndex = 2;
            // 
            // btn_ShowAvailableCells
            // 
            this.btn_ShowAvailableCells.Location = new System.Drawing.Point(15, 63);
            this.btn_ShowAvailableCells.Name = "btn_ShowAvailableCells";
            this.btn_ShowAvailableCells.Size = new System.Drawing.Size(119, 23);
            this.btn_ShowAvailableCells.TabIndex = 3;
            this.btn_ShowAvailableCells.Text = "Доступные ходы";
            this.btn_ShowAvailableCells.UseVisualStyleBackColor = true;
            this.btn_ShowAvailableCells.Click += new System.EventHandler(this.btn_ShowAvailableCells_Click);
            // 
            // tb_ListAvailableCells
            // 
            this.tb_ListAvailableCells.Location = new System.Drawing.Point(15, 92);
            this.tb_ListAvailableCells.Multiline = true;
            this.tb_ListAvailableCells.Name = "tb_ListAvailableCells";
            this.tb_ListAvailableCells.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ListAvailableCells.Size = new System.Drawing.Size(119, 346);
            this.tb_ListAvailableCells.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 450);
            this.Controls.Add(this.tb_ListAvailableCells);
            this.Controls.Add(this.btn_ShowAvailableCells);
            this.Controls.Add(this.cb_Number);
            this.Controls.Add(this.cb_Letter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Letter;
        private System.Windows.Forms.ComboBox cb_Number;
        private System.Windows.Forms.Button btn_ShowAvailableCells;
        private System.Windows.Forms.TextBox tb_ListAvailableCells;
    }
}

