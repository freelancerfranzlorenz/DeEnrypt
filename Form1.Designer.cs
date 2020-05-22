namespace DeEnrypt
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.labelFile = new System.Windows.Forms.Label();
         this.buttonSelectFile = new System.Windows.Forms.Button();
         this.buttonStart = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.buttonSelectFile);
         this.groupBox1.Controls.Add(this.labelFile);
         this.groupBox1.Location = new System.Drawing.Point(16, 16);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(784, 104);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "File to decrypt/encrypt";
         // 
         // labelFile
         // 
         this.labelFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelFile.Location = new System.Drawing.Point(8, 48);
         this.labelFile.Name = "labelFile";
         this.labelFile.Size = new System.Drawing.Size(640, 48);
         this.labelFile.TabIndex = 0;
         this.labelFile.Text = "<>";
         this.labelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // buttonSelectFile
         // 
         this.buttonSelectFile.Location = new System.Drawing.Point(664, 48);
         this.buttonSelectFile.Name = "buttonSelectFile";
         this.buttonSelectFile.Size = new System.Drawing.Size(104, 48);
         this.buttonSelectFile.TabIndex = 1;
         this.buttonSelectFile.Text = "&Select";
         this.buttonSelectFile.UseVisualStyleBackColor = true;
         this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
         // 
         // buttonStart
         // 
         this.buttonStart.Location = new System.Drawing.Point(24, 128);
         this.buttonStart.Name = "buttonStart";
         this.buttonStart.Size = new System.Drawing.Size(640, 40);
         this.buttonStart.TabIndex = 1;
         this.buttonStart.Text = "Start";
         this.buttonStart.UseVisualStyleBackColor = true;
         this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(815, 193);
         this.Controls.Add(this.buttonStart);
         this.Controls.Add(this.groupBox1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Form1";
         this.Text = "De-/Encrypt (c) Franz Lorenz";
         this.groupBox1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button buttonSelectFile;
      private System.Windows.Forms.Label labelFile;
      private System.Windows.Forms.Button buttonStart;
   }
}

