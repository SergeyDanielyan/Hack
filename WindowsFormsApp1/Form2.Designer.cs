namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.question = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question.Font = new System.Drawing.Font("Arial", 11F);
            this.question.ForeColor = System.Drawing.SystemColors.Window;
            this.question.Location = new System.Drawing.Point(2, 0);
            this.question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(212, 170);
            this.question.TabIndex = 0;
            this.question.Text = resources.GetString("question.Text");
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(123, 250);
            this.input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(56, 19);
            this.input.TabIndex = 1;
            this.input.Text = "Ввести";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(70, 228);
            this.answer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(168, 20);
            this.answer.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.question);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 10F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 179);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.darkFon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 327);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(319, 366);
            this.MinimumSize = new System.Drawing.Size(319, 366);
            this.Name = "Form2";
            this.Text = "Вопрос";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}