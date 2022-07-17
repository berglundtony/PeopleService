namespace PeoplesXMLGenerator
{
    partial class GenerateXML
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
            this.btnGenerateXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateXML
            // 
            this.btnGenerateXML.Location = new System.Drawing.Point(24, 54);
            this.btnGenerateXML.Name = "GenerateXML";
            this.btnGenerateXML.Size = new System.Drawing.Size(292, 99);
            this.btnGenerateXML.TabIndex = 0;
            this.btnGenerateXML.Text = "GenerateXML";
            this.btnGenerateXML.UseVisualStyleBackColor = true;
            this.btnGenerateXML.Click += new System.EventHandler(this.generateXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateXML);
            this.Name = "FormGenerateXML";
            this.Text = "FormGenerateXML";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateXML;
    }
}

