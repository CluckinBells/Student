namespace StudentPerformanceApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button filterButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.sortButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();

            // studentsDataGridView
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(600, 300);
            this.studentsDataGridView.TabIndex = 0;

            // sortButton
            this.sortButton.Location = new System.Drawing.Point(12, 330);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(150, 30);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Сортировать по среднему баллу";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);

            // filterButton
            this.filterButton.Location = new System.Drawing.Point(180, 330);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(150, 30);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Фильтр по отличникам";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 371);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.studentsDataGridView);
            this.Name = "Form1";
            this.Text = "Учет успеваемости студентов";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}