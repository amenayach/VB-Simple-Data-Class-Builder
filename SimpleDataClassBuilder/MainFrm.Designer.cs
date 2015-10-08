namespace SimpleDataClassBuilder
{
    partial class MainFrm
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
            this.lblClassName = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.grd = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FCustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(0, 15);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(92, 20);
            this.lblClassName.TabIndex = 0;
            this.lblClassName.Text = "Class name";
            // 
            // tbClassName
            // 
            this.tbClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClassName.Location = new System.Drawing.Point(98, 12);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(384, 26);
            this.tbClassName.TabIndex = 1;
            // 
            // grd
            // 
            this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.FType,
            this.FCustom});
            this.grd.Location = new System.Drawing.Point(-1, 45);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(493, 376);
            this.grd.TabIndex = 2;
            // 
            // FName
            // 
            this.FName.HeaderText = "Property name";
            this.FName.Name = "FName";
            this.FName.Width = 180;
            // 
            // FType
            // 
            this.FType.HeaderText = "Type";
            this.FType.Name = "FType";
            this.FType.Width = 130;
            // 
            // FCustom
            // 
            this.FCustom.HeaderText = "Custom Type";
            this.FCustom.Name = "FCustom";
            this.FCustom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FCustom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnGen
            // 
            this.btnGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.ForeColor = System.Drawing.Color.White;
            this.btnGen.Location = new System.Drawing.Point(319, 434);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(160, 36);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "&Generate Class";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 482);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.tbClassName);
            this.Controls.Add(this.lblClassName);
            this.Icon = global::SimpleDataClassBuilder.Properties.Resources.code;
            this.Name = "MainFrm";
            this.Text = "Simple Data Class Builder";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCustom;
    }
}

