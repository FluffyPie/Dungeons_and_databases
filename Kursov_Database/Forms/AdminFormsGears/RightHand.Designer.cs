﻿namespace Kursov_Database.Forms.AdminFormsGears
{
    partial class RightHand
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RightHand));
            this.AllGearsTable = new System.Windows.Forms.DataGridView();
            this.MainFormElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberTextbox = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.AddGearButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ChangeButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.AllGearsTable)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllGearsTable
            // 
            this.AllGearsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllGearsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllGearsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AllGearsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllGearsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.AllGearsTable.Location = new System.Drawing.Point(12, 41);
            this.AllGearsTable.Name = "AllGearsTable";
            this.AllGearsTable.ReadOnly = true;
            this.AllGearsTable.Size = new System.Drawing.Size(586, 169);
            this.AllGearsTable.TabIndex = 59;
            this.AllGearsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.TargetControl = this;
            // 
            // CollapseButton
            // 
            this.CollapseButton.AnimationHoverSpeed = 0.07F;
            this.CollapseButton.AnimationSpeed = 0.03F;
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BaseColor = System.Drawing.Color.Gold;
            this.CollapseButton.BorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CollapseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CollapseButton.CheckedImage = null;
            this.CollapseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CollapseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CollapseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CollapseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollapseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CollapseButton.Image = null;
            this.CollapseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CollapseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.Location = new System.Drawing.Point(556, 12);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CollapseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CollapseButton.OnHoverImage = null;
            this.CollapseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CollapseButton.Radius = 10;
            this.CollapseButton.Size = new System.Drawing.Size(18, 17);
            this.CollapseButton.TabIndex = 24;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BaseColor = System.Drawing.Color.Red;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(580, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Radius = 10;
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 23;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TopPanel.Controls.Add(this.CollapseButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(610, 35);
            this.TopPanel.TabIndex = 60;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(432, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Gearscore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "Классы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Название";
            // 
            // NumberTextbox
            // 
            this.NumberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberTextbox.Location = new System.Drawing.Point(436, 281);
            this.NumberTextbox.Multiline = true;
            this.NumberTextbox.Name = "NumberTextbox";
            this.NumberTextbox.Size = new System.Drawing.Size(166, 109);
            this.NumberTextbox.TabIndex = 65;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(238, 281);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.ScrollAlwaysVisible = true;
            this.checkedListBox2.Size = new System.Drawing.Size(192, 109);
            this.checkedListBox2.TabIndex = 64;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Щит",
            "Манускрипт",
            "Тотем",
            "Печать"});
            this.checkedListBox1.Location = new System.Drawing.Point(8, 281);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(224, 109);
            this.checkedListBox1.TabIndex = 63;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemCheck);
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextbox.Location = new System.Drawing.Point(124, 216);
            this.NameTextbox.Multiline = true;
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(474, 36);
            this.NameTextbox.TabIndex = 62;
            // 
            // AddGearButton
            // 
            this.AddGearButton.AnimationHoverSpeed = 0.07F;
            this.AddGearButton.AnimationSpeed = 0.03F;
            this.AddGearButton.BaseColor = System.Drawing.Color.Silver;
            this.AddGearButton.BorderColor = System.Drawing.Color.Black;
            this.AddGearButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddGearButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddGearButton.CheckedForeColor = System.Drawing.Color.White;
            this.AddGearButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("AddGearButton.CheckedImage")));
            this.AddGearButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddGearButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddGearButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddGearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddGearButton.ForeColor = System.Drawing.Color.Black;
            this.AddGearButton.Image = null;
            this.AddGearButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AddGearButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddGearButton.Location = new System.Drawing.Point(8, 398);
            this.AddGearButton.Name = "AddGearButton";
            this.AddGearButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddGearButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddGearButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddGearButton.OnHoverImage = null;
            this.AddGearButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.AddGearButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddGearButton.Size = new System.Drawing.Size(594, 58);
            this.AddGearButton.TabIndex = 61;
            this.AddGearButton.Text = "Добавить снаряжение";
            this.AddGearButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddGearButton.Click += new System.EventHandler(this.AddGearButton_Click_1);
            // 
            // ChangeButton
            // 
            this.ChangeButton.AnimationHoverSpeed = 0.07F;
            this.ChangeButton.AnimationSpeed = 0.03F;
            this.ChangeButton.BaseColor = System.Drawing.Color.Silver;
            this.ChangeButton.BorderColor = System.Drawing.Color.Black;
            this.ChangeButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ChangeButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.ChangeButton.CheckedForeColor = System.Drawing.Color.White;
            this.ChangeButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("ChangeButton.CheckedImage")));
            this.ChangeButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ChangeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeButton.FocusedColor = System.Drawing.Color.Empty;
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeButton.ForeColor = System.Drawing.Color.Black;
            this.ChangeButton.Image = null;
            this.ChangeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ChangeButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.Location = new System.Drawing.Point(8, 462);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ChangeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChangeButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ChangeButton.OnHoverImage = null;
            this.ChangeButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ChangeButton.OnPressedColor = System.Drawing.Color.Black;
            this.ChangeButton.Size = new System.Drawing.Size(594, 58);
            this.ChangeButton.TabIndex = 73;
            this.ChangeButton.Text = "Изменить выбранную запись";
            this.ChangeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // RightHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 529);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AllGearsTable);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberTextbox);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.AddGearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RightHand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RightHand";
            ((System.ComponentModel.ISupportInitialize)(this.AllGearsTable)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllGearsTable;
        private Guna.UI.WinForms.GunaElipse MainFormElipse;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberTextbox;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox NameTextbox;
        private Guna.UI.WinForms.GunaAdvenceButton AddGearButton;
        private Guna.UI.WinForms.GunaAdvenceButton ChangeButton;
    }
}