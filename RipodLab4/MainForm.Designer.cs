namespace RipodLab4
{
    partial class MainForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mulTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.planButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.tasksTrackBar = new System.Windows.Forms.TrackBar();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.stepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAddColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMulColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.timeStepTextBox = new System.Windows.Forms.TextBox();
            this.operationTimeGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTimeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Матричное представление графа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Кол-во процессоров типа  *";
            // 
            // mulTextBox
            // 
            this.mulTextBox.Location = new System.Drawing.Point(462, 137);
            this.mulTextBox.Name = "mulTextBox";
            this.mulTextBox.Size = new System.Drawing.Size(63, 20);
            this.mulTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Кол-во процессоров типа  +";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(462, 111);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(63, 20);
            this.addTextBox.TabIndex = 21;
            // 
            // planButton
            // 
            this.planButton.Location = new System.Drawing.Point(450, 426);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(75, 23);
            this.planButton.TabIndex = 20;
            this.planButton.Text = "План";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.PlanButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Типы задач";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(507, 9);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(0, 13);
            this.taskLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Количество вершин";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(359, 59);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(166, 20);
            this.typeTextBox.TabIndex = 16;
            // 
            // tasksTrackBar
            // 
            this.tasksTrackBar.LargeChange = 1;
            this.tasksTrackBar.Location = new System.Drawing.Point(397, 8);
            this.tasksTrackBar.Maximum = 16;
            this.tasksTrackBar.Minimum = 12;
            this.tasksTrackBar.Name = "tasksTrackBar";
            this.tasksTrackBar.Size = new System.Drawing.Size(104, 45);
            this.tasksTrackBar.TabIndex = 15;
            this.tasksTrackBar.Value = 12;
            this.tasksTrackBar.Scroll += new System.EventHandler(this.TasksTrackBar_Scroll);
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepColumn,
            this.taskColumn,
            this.typeAddColumn,
            this.typeMulColumn});
            this.resultGridView.Location = new System.Drawing.Point(12, 296);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.Size = new System.Drawing.Size(265, 153);
            this.resultGridView.TabIndex = 14;
            // 
            // stepColumn
            // 
            this.stepColumn.HeaderText = "Шаг";
            this.stepColumn.Name = "stepColumn";
            this.stepColumn.ReadOnly = true;
            this.stepColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stepColumn.Width = 50;
            // 
            // taskColumn
            // 
            this.taskColumn.HeaderText = "Операции";
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            this.taskColumn.Width = 112;
            // 
            // typeAddColumn
            // 
            this.typeAddColumn.HeaderText = "Тип +";
            this.typeAddColumn.Name = "typeAddColumn";
            this.typeAddColumn.ReadOnly = true;
            this.typeAddColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeAddColumn.Width = 50;
            // 
            // typeMulColumn
            // 
            this.typeMulColumn.HeaderText = "Тип *";
            this.typeMulColumn.Name = "typeMulColumn";
            this.typeMulColumn.ReadOnly = true;
            this.typeMulColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeMulColumn.Width = 50;
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.AllowUserToResizeColumns = false;
            this.matrixGridView.AllowUserToResizeRows = false;
            this.matrixGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixGridView.ColumnHeadersHeight = 15;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixGridView.ColumnHeadersVisible = false;
            this.matrixGridView.Location = new System.Drawing.Point(12, 25);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersVisible = false;
            this.matrixGridView.RowHeadersWidth = 15;
            this.matrixGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixGridView.RowTemplate.Height = 15;
            this.matrixGridView.Size = new System.Drawing.Size(265, 265);
            this.matrixGridView.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Время выполнения одного шага";
            // 
            // timeStepTextBox
            // 
            this.timeStepTextBox.Location = new System.Drawing.Point(462, 85);
            this.timeStepTextBox.Name = "timeStepTextBox";
            this.timeStepTextBox.Size = new System.Drawing.Size(63, 20);
            this.timeStepTextBox.TabIndex = 26;
            this.timeStepTextBox.Text = "1,00";
            // 
            // operationTimeGridView
            // 
            this.operationTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationTimeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.operationTimeGridView.Location = new System.Drawing.Point(290, 163);
            this.operationTimeGridView.Name = "operationTimeGridView";
            this.operationTimeGridView.RowHeadersVisible = false;
            this.operationTimeGridView.Size = new System.Drawing.Size(235, 257);
            this.operationTimeGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Операция";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Время выполнения";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 462);
            this.Controls.Add(this.operationTimeGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeStepTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mulTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.tasksTrackBar);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.matrixGridView);
            this.Name = "MainForm";
            this.Text = "Лаб. №4, гр. 10701116, Руслан";
            ((System.ComponentModel.ISupportInitialize)(this.tasksTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationTimeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mulTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TrackBar tasksTrackBar;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAddColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMulColumn;
        private System.Windows.Forms.DataGridView matrixGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeStepTextBox;
        private System.Windows.Forms.DataGridView operationTimeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

