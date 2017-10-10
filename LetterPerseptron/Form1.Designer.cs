namespace LetterPerseptron
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
			this.buttonTransform = new System.Windows.Forms.Button();
			this.buttonAnswer = new System.Windows.Forms.Button();
			this.textBoxPicture = new System.Windows.Forms.MaskedTextBox();
			this.textBoxLetter = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelAnswer = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelGenerations = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonTransform
			// 
			this.buttonTransform.Location = new System.Drawing.Point(83, 34);
			this.buttonTransform.Name = "buttonTransform";
			this.buttonTransform.Size = new System.Drawing.Size(75, 23);
			this.buttonTransform.TabIndex = 1;
			this.buttonTransform.Text = "--->";
			this.buttonTransform.UseVisualStyleBackColor = true;
			this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
			// 
			// buttonAnswer
			// 
			this.buttonAnswer.Location = new System.Drawing.Point(58, 74);
			this.buttonAnswer.Name = "buttonAnswer";
			this.buttonAnswer.Size = new System.Drawing.Size(75, 23);
			this.buttonAnswer.TabIndex = 1;
			this.buttonAnswer.Text = "Ответ";
			this.buttonAnswer.UseVisualStyleBackColor = true;
			this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
			// 
			// textBoxPicture
			// 
			this.textBoxPicture.Location = new System.Drawing.Point(199, 36);
			this.textBoxPicture.Mask = "000 000 000 000";
			this.textBoxPicture.Name = "textBoxPicture";
			this.textBoxPicture.Size = new System.Drawing.Size(89, 20);
			this.textBoxPicture.TabIndex = 2;
			// 
			// textBoxLetter
			// 
			this.textBoxLetter.Location = new System.Drawing.Point(59, 34);
			this.textBoxLetter.Mask = "<L";
			this.textBoxLetter.Name = "textBoxLetter";
			this.textBoxLetter.Size = new System.Drawing.Size(18, 20);
			this.textBoxLetter.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Буква:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(164, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Код:";
			// 
			// labelAnswer
			// 
			this.labelAnswer.AutoSize = true;
			this.labelAnswer.Location = new System.Drawing.Point(195, 79);
			this.labelAnswer.Name = "labelAnswer";
			this.labelAnswer.Size = new System.Drawing.Size(37, 13);
			this.labelAnswer.TabIndex = 5;
			this.labelAnswer.Text = "Ответ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Обучение завершено, шагов";
			// 
			// labelGenerations
			// 
			this.labelGenerations.AutoSize = true;
			this.labelGenerations.Location = new System.Drawing.Point(169, 9);
			this.labelGenerations.Name = "labelGenerations";
			this.labelGenerations.Size = new System.Drawing.Size(13, 13);
			this.labelGenerations.TabIndex = 6;
			this.labelGenerations.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 139);
			this.Controls.Add(this.labelGenerations);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelAnswer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxLetter);
			this.Controls.Add(this.textBoxPicture);
			this.Controls.Add(this.buttonAnswer);
			this.Controls.Add(this.buttonTransform);
			this.Name = "Form1";
			this.Text = "Персептрон распознавания букв";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonTransform;
		private System.Windows.Forms.Button buttonAnswer;
		private System.Windows.Forms.MaskedTextBox textBoxPicture;
		private System.Windows.Forms.MaskedTextBox textBoxLetter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAnswer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelGenerations;
	}
}

