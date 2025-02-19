namespace SequentialFiles
{
    partial class Menu
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
            btnSequentialFiles = new Button();
            btnSequentialIndexed = new Button();
            btnDirect = new Button();
            SuspendLayout();
            // 
            // btnSequentialFiles
            // 
            btnSequentialFiles.Font = new Font("Yu Gothic UI", 11.25F);
            btnSequentialFiles.Location = new Point(170, 77);
            btnSequentialFiles.Name = "btnSequentialFiles";
            btnSequentialFiles.Size = new Size(159, 40);
            btnSequentialFiles.TabIndex = 0;
            btnSequentialFiles.Text = "Sequential";
            btnSequentialFiles.UseVisualStyleBackColor = true;
            btnSequentialFiles.Click += btnSequentialFiles_Click;
            // 
            // btnSequentialIndexed
            // 
            btnSequentialIndexed.Font = new Font("Yu Gothic UI", 11.25F);
            btnSequentialIndexed.Location = new Point(170, 132);
            btnSequentialIndexed.Name = "btnSequentialIndexed";
            btnSequentialIndexed.Size = new Size(159, 40);
            btnSequentialIndexed.TabIndex = 1;
            btnSequentialIndexed.Text = "Sequential Indexed";
            btnSequentialIndexed.UseVisualStyleBackColor = true;
            btnSequentialIndexed.Click += btnSequentialIndexed_Click;
            // 
            // btnDirect
            // 
            btnDirect.Font = new Font("Yu Gothic UI", 11.25F);
            btnDirect.Location = new Point(170, 192);
            btnDirect.Name = "btnDirect";
            btnDirect.Size = new Size(159, 40);
            btnDirect.TabIndex = 2;
            btnDirect.Text = "Direct";
            btnDirect.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 305);
            Controls.Add(btnDirect);
            Controls.Add(btnSequentialIndexed);
            Controls.Add(btnSequentialFiles);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSequentialFiles;
        private Button btnSequentialIndexed;
        private Button btnDirect;
    }
}