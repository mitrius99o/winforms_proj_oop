namespace FormApp
{
    public interface IInputForm
    {
        void InitializeComponent(InputForm inputForm);
    }
    public class RecComponent : IInputForm 
    {
        public void InitializeComponent(InputForm inputForm)
        {
            inputForm.button1 = new System.Windows.Forms.Button();
            inputForm.label1 = new System.Windows.Forms.Label();
            inputForm.textBox1 = new System.Windows.Forms.TextBox();
            inputForm.label2 = new System.Windows.Forms.Label();
            inputForm.textBox2 = new System.Windows.Forms.TextBox();
            inputForm.SuspendLayout();
            // 
            // button1
            // 
            inputForm.button1.Location = new System.Drawing.Point(67, 174);
            inputForm.button1.Name = "button1";
            inputForm.button1.Size = new System.Drawing.Size(155, 36);
            inputForm.button1.TabIndex = 0;
            inputForm.button1.Text = "Результат";
            inputForm.button1.UseVisualStyleBackColor = true;
            inputForm.button1.Click += new System.EventHandler(inputForm.button1_Click);
            // 
            // label1
            // 
            inputForm.label1.AutoSize = true;
            inputForm.label1.Location = new System.Drawing.Point(37, 51);
            inputForm.label1.Name = "label1";
            inputForm.label1.Size = new System.Drawing.Size(81, 13);
            inputForm.label1.TabIndex = 1;
            inputForm.label1.Text = "Введите длину";
            // 
            // textBox1
            // 
            inputForm.textBox1.Location = new System.Drawing.Point(155, 48);
            inputForm.textBox1.Name = "textBox1";
            inputForm.textBox1.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            inputForm.label2.AutoSize = true;
            inputForm.label2.Location = new System.Drawing.Point(37, 94);
            inputForm.label2.Name = "label2";
            inputForm.label2.Size = new System.Drawing.Size(89, 13);
            inputForm.label2.TabIndex = 1;
            inputForm.label2.Text = "Введите ширину";
            // 
            // textBox2
            // 
            inputForm.textBox2.Location = new System.Drawing.Point(155, 91);
            inputForm.textBox2.Name = "textBox2";
            inputForm.textBox2.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox2.TabIndex = 2;
            // 
            // PRInputForm
            // 
            inputForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            inputForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            inputForm.ClientSize = new System.Drawing.Size(285, 244);
            inputForm.Controls.Add(inputForm.textBox2);
            inputForm.Controls.Add(inputForm.label2);
            inputForm.Controls.Add(inputForm.textBox1);
            inputForm.Controls.Add(inputForm.label1);
            inputForm.Controls.Add(inputForm.button1);
            inputForm.Name = "InputForm";
            inputForm.Text = "Данные о фигуре";
            inputForm.ResumeLayout(false);
            inputForm.PerformLayout();
        }
    }
    public class CirComponent : IInputForm
    {
        
        public void InitializeComponent(InputForm inputForm)
        {
            inputForm.button1 = new System.Windows.Forms.Button();
            inputForm.label1 = new System.Windows.Forms.Label();
            inputForm.textBox1 = new System.Windows.Forms.TextBox();
            inputForm.SuspendLayout();
            // 
            // button1
            // 
            inputForm.button1.Location = new System.Drawing.Point(67, 174);
            inputForm.button1.Name = "button1";
            inputForm.button1.Size = new System.Drawing.Size(155, 36);
            inputForm.button1.TabIndex = 0;
            inputForm.button1.Text = "Результат";
            inputForm.button1.UseVisualStyleBackColor = true;
            inputForm.button1.Click += new System.EventHandler(inputForm.button1_Click);
            // 
            // label1
            // 
            inputForm.label1.AutoSize = true;
            inputForm.label1.Location = new System.Drawing.Point(37, 51);
            inputForm.label1.Name = "label1";
            inputForm.label1.Size = new System.Drawing.Size(81, 13);
            inputForm.label1.TabIndex = 1;
            inputForm.label1.Text = "Введите радиус";
            // 
            // textBox1
            // 
            inputForm.textBox1.Location = new System.Drawing.Point(155, 48);
            inputForm.textBox1.Name = "textBox1";
            inputForm.textBox1.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox1.TabIndex = 2;
            // 
            // PRInputForm
            // 
            inputForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            inputForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            inputForm.ClientSize = new System.Drawing.Size(285, 244);
            inputForm.Controls.Add(inputForm.textBox1);
            inputForm.Controls.Add(inputForm.label1);
            inputForm.Controls.Add(inputForm.button1);
            inputForm.Name = "InputForm";
            inputForm.Text = "Данные о фигуре";
            inputForm.ResumeLayout(false);
            inputForm.PerformLayout();
        }
    }
    public class TriComponent : IInputForm
    {
        public void InitializeComponent(InputForm inputForm)
        {
            inputForm.button1 = new System.Windows.Forms.Button();
            inputForm.label1 = new System.Windows.Forms.Label();
            inputForm.textBox1 = new System.Windows.Forms.TextBox();
            inputForm.label2 = new System.Windows.Forms.Label();
            inputForm.textBox2 = new System.Windows.Forms.TextBox();
            inputForm.label3 = new System.Windows.Forms.Label();
            inputForm.textBox3 = new System.Windows.Forms.TextBox();
            inputForm.SuspendLayout();
            // 
            // button1
            // 
            inputForm.button1.Location = new System.Drawing.Point(67, 217);
            inputForm.button1.Name = "button1";
            inputForm.button1.Size = new System.Drawing.Size(155, 36);
            inputForm.button1.TabIndex = 0;
            inputForm.button1.Text = "Результат";
            inputForm.button1.UseVisualStyleBackColor = true;
            inputForm.button1.Click += new System.EventHandler(inputForm.button1_Click);
            // 
            // label1
            // 
            inputForm.label1.AutoSize = true;
            inputForm.label1.Location = new System.Drawing.Point(37, 51);
            inputForm.label1.Name = "label1";
            inputForm.label1.Size = new System.Drawing.Size(81, 13);
            inputForm.label1.TabIndex = 1;
            inputForm.label1.Text = "Введите длину";
            // 
            // textBox1
            // 
            inputForm.textBox1.Location = new System.Drawing.Point(155, 48);
            inputForm.textBox1.Name = "textBox1";
            inputForm.textBox1.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            inputForm.label2.AutoSize = true;
            inputForm.label2.Location = new System.Drawing.Point(37, 94);
            inputForm.label2.Name = "label2";
            inputForm.label2.Size = new System.Drawing.Size(89, 13);
            inputForm.label2.TabIndex = 1;
            inputForm.label2.Text = "Введите высоту";
            // 
            // textBox2
            // 
            inputForm.textBox2.Location = new System.Drawing.Point(155, 91);
            inputForm.textBox2.Name = "textBox2";
            inputForm.textBox2.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            inputForm.label3.AutoSize = true;
            inputForm.label3.Location = new System.Drawing.Point(37, 137);
            inputForm.label3.Name = "label3";
            inputForm.label3.Size = new System.Drawing.Size(89, 13);
            inputForm.label3.TabIndex = 1;
            inputForm.label3.Text = "Введите partA";
            // 
            // textBox3
            // 
            inputForm.textBox3.Location = new System.Drawing.Point(155, 134);
            inputForm.textBox3.Name = "textBox3";
            inputForm.textBox3.Size = new System.Drawing.Size(100, 20);
            inputForm.textBox3.TabIndex = 2;
            // 
            // PRInputForm
            // 
            inputForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            inputForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            inputForm.ClientSize = new System.Drawing.Size(285, 283);
            inputForm.Controls.Add(inputForm.textBox3);
            inputForm.Controls.Add(inputForm.label3);
            inputForm.Controls.Add(inputForm.textBox2);
            inputForm.Controls.Add(inputForm.label2);
            inputForm.Controls.Add(inputForm.textBox1);
            inputForm.Controls.Add(inputForm.label1);
            inputForm.Controls.Add(inputForm.button1);
            inputForm.Name = "PRInputForm";
            inputForm.Text = "Данные о фигуре";
            inputForm.ResumeLayout(false);
            inputForm.PerformLayout();
        }
    }
    partial class InputForm
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

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox3;
    }
}