namespace Mini
{
    partial class Tabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabel));
            this.SaveButton = new System.Windows.Forms.Button();
            this.StatesView = new System.Windows.Forms.DataGridView();
            this.TableMin = new System.Windows.Forms.RichTextBox();
            this.GenTableButton = new System.Windows.Forms.Button();
            this.NewTableButton = new System.Windows.Forms.Button();
            this.EchivClassesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StatesView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SaveButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(42, 329);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(302, 106);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Minimize";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StatesView
            // 
            this.StatesView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatesView.Location = new System.Drawing.Point(12, 12);
            this.StatesView.Name = "StatesView";
            this.StatesView.Size = new System.Drawing.Size(364, 261);
            this.StatesView.TabIndex = 2;
            this.StatesView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.StatesView_RowPostPaint);
            // 
            // TableMin
            // 
            this.TableMin.Location = new System.Drawing.Point(488, 12);
            this.TableMin.Name = "TableMin";
            this.TableMin.Size = new System.Drawing.Size(384, 261);
            this.TableMin.TabIndex = 3;
            this.TableMin.Text = "";
            // 
            // GenTableButton
            // 
            this.GenTableButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GenTableButton.Location = new System.Drawing.Point(488, 329);
            this.GenTableButton.Name = "GenTableButton";
            this.GenTableButton.Size = new System.Drawing.Size(102, 42);
            this.GenTableButton.TabIndex = 4;
            this.GenTableButton.Text = "Generate Table";
            this.GenTableButton.UseVisualStyleBackColor = false;
            this.GenTableButton.Click += new System.EventHandler(this.GenTableButton_Click);
            // 
            // NewTableButton
            // 
            this.NewTableButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewTableButton.Location = new System.Drawing.Point(770, 329);
            this.NewTableButton.Name = "NewTableButton";
            this.NewTableButton.Size = new System.Drawing.Size(102, 42);
            this.NewTableButton.TabIndex = 5;
            this.NewTableButton.Text = "New Table";
            this.NewTableButton.UseVisualStyleBackColor = false;
            this.NewTableButton.Click += new System.EventHandler(this.NewTableButton_Click);
            // 
            // EchivClassesButton
            // 
            this.EchivClassesButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EchivClassesButton.Location = new System.Drawing.Point(630, 329);
            this.EchivClassesButton.Name = "EchivClassesButton";
            this.EchivClassesButton.Size = new System.Drawing.Size(102, 42);
            this.EchivClassesButton.TabIndex = 6;
            this.EchivClassesButton.Text = "Echivalent Classes";
            this.EchivClassesButton.UseVisualStyleBackColor = false;
            this.EchivClassesButton.Click += new System.EventHandler(this.EchivClassesButton_Click);
            // 
            // Tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(931, 521);
            this.Controls.Add(this.EchivClassesButton);
            this.Controls.Add(this.NewTableButton);
            this.Controls.Add(this.GenTableButton);
            this.Controls.Add(this.TableMin);
            this.Controls.Add(this.StatesView);
            this.Controls.Add(this.SaveButton);
            this.DoubleBuffered = true;
            this.Name = "Tabel";
            this.Text = "Minimize";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tabel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.StatesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView StatesView;
        private System.Windows.Forms.RichTextBox TableMin;
        private System.Windows.Forms.Button GenTableButton;
        private System.Windows.Forms.Button NewTableButton;
        private System.Windows.Forms.Button EchivClassesButton;
    }
}