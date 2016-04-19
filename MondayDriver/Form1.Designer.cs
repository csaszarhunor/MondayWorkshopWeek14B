namespace MondayDriver
{
    partial class Editing
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
            this.drive_lbl = new System.Windows.Forms.Label();
            this.path_lbl = new System.Windows.Forms.Label();
            this.path_box = new System.Windows.Forms.TextBox();
            this.drive_box = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.open_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drive_lbl
            // 
            this.drive_lbl.AutoSize = true;
            this.drive_lbl.Location = new System.Drawing.Point(24, 15);
            this.drive_lbl.Name = "drive_lbl";
            this.drive_lbl.Size = new System.Drawing.Size(32, 13);
            this.drive_lbl.TabIndex = 0;
            this.drive_lbl.Text = "Drive";
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.Location = new System.Drawing.Point(23, 42);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(29, 13);
            this.path_lbl.TabIndex = 1;
            this.path_lbl.Text = "Path";
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(65, 39);
            this.path_box.Name = "path_box";
            this.path_box.Size = new System.Drawing.Size(218, 20);
            this.path_box.TabIndex = 2;
            // 
            // drive_box
            // 
            this.drive_box.FormattingEnabled = true;
            this.drive_box.Location = new System.Drawing.Point(65, 12);
            this.drive_box.Name = "drive_box";
            this.drive_box.Size = new System.Drawing.Size(218, 21);
            this.drive_box.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 160);
            this.listBox1.TabIndex = 4;
            // 
            // open_bttn
            // 
            this.open_bttn.Location = new System.Drawing.Point(61, 237);
            this.open_bttn.Name = "open_bttn";
            this.open_bttn.Size = new System.Drawing.Size(75, 23);
            this.open_bttn.TabIndex = 5;
            this.open_bttn.Text = "Open";
            this.open_bttn.UseVisualStyleBackColor = true;
            // 
            // delete_bttn
            // 
            this.delete_bttn.Location = new System.Drawing.Point(142, 237);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(75, 23);
            this.delete_bttn.TabIndex = 6;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = true;
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 278);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.open_bttn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.drive_box);
            this.Controls.Add(this.path_box);
            this.Controls.Add(this.path_lbl);
            this.Controls.Add(this.drive_lbl);
            this.Name = "Editing";
            this.Text = "Editing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drive_lbl;
        private System.Windows.Forms.Label path_lbl;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.ComboBox drive_box;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button open_bttn;
        private System.Windows.Forms.Button delete_bttn;
    }
}

