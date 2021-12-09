
namespace Screen
{
  partial class FenixSearch
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
      this.StartButton = new System.Windows.Forms.Button();
      this.CopyButton = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.textBoxValue = new System.Windows.Forms.TextBox();
      this.valueLavel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // StartButton
      // 
      this.StartButton.BackColor = System.Drawing.Color.Turquoise;
      this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.StartButton.Location = new System.Drawing.Point(184, 40);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(104, 41);
      this.StartButton.TabIndex = 0;
      this.StartButton.Text = "Старт";
      this.StartButton.UseVisualStyleBackColor = false;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // CopyButton
      // 
      this.CopyButton.BackColor = System.Drawing.Color.Turquoise;
      this.CopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.CopyButton.Location = new System.Drawing.Point(184, 87);
      this.CopyButton.Name = "CopyButton";
      this.CopyButton.Size = new System.Drawing.Size(104, 41);
      this.CopyButton.TabIndex = 1;
      this.CopyButton.Text = "Копия";
      this.CopyButton.UseVisualStyleBackColor = false;
      this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.BackColor = System.Drawing.Color.Turquoise;
      this.progressBar1.Location = new System.Drawing.Point(12, 134);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(276, 13);
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBar1.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.White;
      this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(54, 61);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(108, 25);
      this.textBox1.TabIndex = 5;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // button3
      // 
      this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button3.Location = new System.Drawing.Point(280, 0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(20, 20);
      this.button3.TabIndex = 6;
      this.button3.Text = "X";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(12, 87);
      this.trackBar1.Maximum = 20;
      this.trackBar1.Minimum = 3;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(150, 45);
      this.trackBar1.TabIndex = 7;
      this.trackBar1.Value = 6;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // textBoxValue
      // 
      this.textBoxValue.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxValue.Location = new System.Drawing.Point(113, 35);
      this.textBoxValue.Name = "textBoxValue";
      this.textBoxValue.Size = new System.Drawing.Size(49, 25);
      this.textBoxValue.TabIndex = 8;
      this.textBoxValue.Text = "70";
      this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
      this.textBoxValue.Leave += new System.EventHandler(this.textBoxValue_Leave);
      this.textBoxValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxValue_MouseDoubleClick);
      // 
      // valueLavel
      // 
      this.valueLavel.AutoSize = true;
      this.valueLavel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.valueLavel.Location = new System.Drawing.Point(51, 38);
      this.valueLavel.Name = "valueLavel";
      this.valueLavel.Size = new System.Drawing.Size(56, 18);
      this.valueLavel.TabIndex = 9;
      this.valueLavel.Text = "Count:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(9, 64);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 18);
      this.label1.TabIndex = 10;
      this.label1.Text = "Link:";
      // 
      // FenixSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.SandyBrown;
      this.ClientSize = new System.Drawing.Size(300, 150);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.valueLavel);
      this.Controls.Add(this.textBoxValue);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.CopyButton);
      this.Controls.Add(this.StartButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Location = new System.Drawing.Point(810, 930);
      this.Name = "FenixSearch";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FenixSearch";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.FenixSearch_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.Button CopyButton;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TextBox textBoxValue;
    private System.Windows.Forms.Label valueLavel;
    private System.Windows.Forms.Label label1;
  }
}

