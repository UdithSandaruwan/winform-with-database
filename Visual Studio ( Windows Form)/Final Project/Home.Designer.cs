namespace Final_Project
{
    partial class frm_Home
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
            this.datag1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Add = new ePOSOne.btnProduct.Button_WOC();
            this.btn_Delete = new ePOSOne.btnProduct.Button_WOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datag1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datag1
            // 
            this.datag1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag1.Location = new System.Drawing.Point(32, 149);
            this.datag1.Name = "datag1";
            this.datag1.Size = new System.Drawing.Size(768, 275);
            this.datag1.TabIndex = 0;
            this.datag1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 130);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(745, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(59, 43);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BorderColor = System.Drawing.Color.Silver;
            this.btn_Add.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(20, 60);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_Add.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Add.Size = new System.Drawing.Size(92, 44);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BorderColor = System.Drawing.Color.Silver;
            this.btn_Delete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(132, 60);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btn_Delete.OnHoverButtonColor = System.Drawing.Color.Silver;
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btn_Delete.Size = new System.Drawing.Size(92, 44);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 291);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel3.Location = new System.Drawing.Point(806, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 291);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.panel4.Location = new System.Drawing.Point(28, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 10);
            this.panel4.TabIndex = 8;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.datag1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datag1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datag1;
        private ePOSOne.btnProduct.Button_WOC btn_Add;
        private ePOSOne.btnProduct.Button_WOC btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Exit;
    }
}