namespace Path_Calculator
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
            this.EnemyCountLabel = new System.Windows.Forms.Label();
            this.EnemyMoveSpeedLabel = new System.Windows.Forms.Label();
            this.TimeBetweenSpawnsLabel = new System.Windows.Forms.Label();
            this.SpawnTimeRandomFactorLabel = new System.Windows.Forms.Label();
            this.LoopDelayLabel = new System.Windows.Forms.Label();
            this.LoopCountLabel = new System.Windows.Forms.Label();
            this.InitialDelayLabel = new System.Windows.Forms.Label();
            this.NeedAllDestroyedLabel = new System.Windows.Forms.Label();
            this.NeedAllDestroyedCheckbox = new System.Windows.Forms.CheckBox();
            this.EnemyCountTextBox = new System.Windows.Forms.TextBox();
            this.EnemyMoveSpeedTextBox = new System.Windows.Forms.TextBox();
            this.TimeBetweenSpawnsTextBox = new System.Windows.Forms.TextBox();
            this.SpawnTimeRandomTextBox = new System.Windows.Forms.TextBox();
            this.LoopDelayTextBox = new System.Windows.Forms.TextBox();
            this.LoopCountTextBox = new System.Windows.Forms.TextBox();
            this.InitialDelayTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.WaypointsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WaypointXYTextbox = new System.Windows.Forms.TextBox();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.EmptyListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnemyCountLabel
            // 
            this.EnemyCountLabel.AutoSize = true;
            this.EnemyCountLabel.Location = new System.Drawing.Point(57, 28);
            this.EnemyCountLabel.Name = "EnemyCountLabel";
            this.EnemyCountLabel.Size = new System.Drawing.Size(70, 13);
            this.EnemyCountLabel.TabIndex = 0;
            this.EnemyCountLabel.Text = "Enemy Count";
            // 
            // EnemyMoveSpeedLabel
            // 
            this.EnemyMoveSpeedLabel.AutoSize = true;
            this.EnemyMoveSpeedLabel.Location = new System.Drawing.Point(57, 54);
            this.EnemyMoveSpeedLabel.Name = "EnemyMoveSpeedLabel";
            this.EnemyMoveSpeedLabel.Size = new System.Drawing.Size(144, 13);
            this.EnemyMoveSpeedLabel.TabIndex = 1;
            this.EnemyMoveSpeedLabel.Text = "Enemy Move Speed (units/s)";
            // 
            // TimeBetweenSpawnsLabel
            // 
            this.TimeBetweenSpawnsLabel.AutoSize = true;
            this.TimeBetweenSpawnsLabel.Location = new System.Drawing.Point(57, 80);
            this.TimeBetweenSpawnsLabel.Name = "TimeBetweenSpawnsLabel";
            this.TimeBetweenSpawnsLabel.Size = new System.Drawing.Size(130, 13);
            this.TimeBetweenSpawnsLabel.TabIndex = 2;
            this.TimeBetweenSpawnsLabel.Text = "Time Between Spawns (s)";
            // 
            // SpawnTimeRandomFactorLabel
            // 
            this.SpawnTimeRandomFactorLabel.AutoSize = true;
            this.SpawnTimeRandomFactorLabel.Location = new System.Drawing.Point(57, 106);
            this.SpawnTimeRandomFactorLabel.Name = "SpawnTimeRandomFactorLabel";
            this.SpawnTimeRandomFactorLabel.Size = new System.Drawing.Size(156, 13);
            this.SpawnTimeRandomFactorLabel.TabIndex = 3;
            this.SpawnTimeRandomFactorLabel.Text = "Spawn Time Random Factor (s)";
            // 
            // LoopDelayLabel
            // 
            this.LoopDelayLabel.AutoSize = true;
            this.LoopDelayLabel.Location = new System.Drawing.Point(57, 132);
            this.LoopDelayLabel.Name = "LoopDelayLabel";
            this.LoopDelayLabel.Size = new System.Drawing.Size(75, 13);
            this.LoopDelayLabel.TabIndex = 4;
            this.LoopDelayLabel.Text = "Loop Delay (s)";
            // 
            // LoopCountLabel
            // 
            this.LoopCountLabel.AutoSize = true;
            this.LoopCountLabel.Location = new System.Drawing.Point(57, 158);
            this.LoopCountLabel.Name = "LoopCountLabel";
            this.LoopCountLabel.Size = new System.Drawing.Size(62, 13);
            this.LoopCountLabel.TabIndex = 5;
            this.LoopCountLabel.Text = "Loop Count";
            // 
            // InitialDelayLabel
            // 
            this.InitialDelayLabel.AutoSize = true;
            this.InitialDelayLabel.Location = new System.Drawing.Point(57, 184);
            this.InitialDelayLabel.Name = "InitialDelayLabel";
            this.InitialDelayLabel.Size = new System.Drawing.Size(75, 13);
            this.InitialDelayLabel.TabIndex = 6;
            this.InitialDelayLabel.Text = "Initial Delay (s)";
            // 
            // NeedAllDestroyedLabel
            // 
            this.NeedAllDestroyedLabel.AutoSize = true;
            this.NeedAllDestroyedLabel.Location = new System.Drawing.Point(57, 207);
            this.NeedAllDestroyedLabel.Name = "NeedAllDestroyedLabel";
            this.NeedAllDestroyedLabel.Size = new System.Drawing.Size(98, 13);
            this.NeedAllDestroyedLabel.TabIndex = 7;
            this.NeedAllDestroyedLabel.Text = "Need All Destroyed";
            // 
            // NeedAllDestroyedCheckbox
            // 
            this.NeedAllDestroyedCheckbox.AutoSize = true;
            this.NeedAllDestroyedCheckbox.Location = new System.Drawing.Point(219, 207);
            this.NeedAllDestroyedCheckbox.Name = "NeedAllDestroyedCheckbox";
            this.NeedAllDestroyedCheckbox.Size = new System.Drawing.Size(15, 14);
            this.NeedAllDestroyedCheckbox.TabIndex = 8;
            this.NeedAllDestroyedCheckbox.UseVisualStyleBackColor = true;
            this.NeedAllDestroyedCheckbox.CheckStateChanged += new System.EventHandler(this.NeedAllDestroyedCheckbox_CheckStateChanged);
            // 
            // EnemyCountTextBox
            // 
            this.EnemyCountTextBox.Location = new System.Drawing.Point(219, 25);
            this.EnemyCountTextBox.Name = "EnemyCountTextBox";
            this.EnemyCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnemyCountTextBox.TabIndex = 9;
            // 
            // EnemyMoveSpeedTextBox
            // 
            this.EnemyMoveSpeedTextBox.Location = new System.Drawing.Point(219, 51);
            this.EnemyMoveSpeedTextBox.Name = "EnemyMoveSpeedTextBox";
            this.EnemyMoveSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.EnemyMoveSpeedTextBox.TabIndex = 10;
            // 
            // TimeBetweenSpawnsTextBox
            // 
            this.TimeBetweenSpawnsTextBox.Location = new System.Drawing.Point(219, 77);
            this.TimeBetweenSpawnsTextBox.Name = "TimeBetweenSpawnsTextBox";
            this.TimeBetweenSpawnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBetweenSpawnsTextBox.TabIndex = 11;
            // 
            // SpawnTimeRandomTextBox
            // 
            this.SpawnTimeRandomTextBox.Location = new System.Drawing.Point(219, 103);
            this.SpawnTimeRandomTextBox.Name = "SpawnTimeRandomTextBox";
            this.SpawnTimeRandomTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpawnTimeRandomTextBox.TabIndex = 12;
            // 
            // LoopDelayTextBox
            // 
            this.LoopDelayTextBox.Location = new System.Drawing.Point(219, 129);
            this.LoopDelayTextBox.Name = "LoopDelayTextBox";
            this.LoopDelayTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoopDelayTextBox.TabIndex = 13;
            // 
            // LoopCountTextBox
            // 
            this.LoopCountTextBox.Location = new System.Drawing.Point(219, 155);
            this.LoopCountTextBox.Name = "LoopCountTextBox";
            this.LoopCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoopCountTextBox.TabIndex = 14;
            // 
            // InitialDelayTextBox
            // 
            this.InitialDelayTextBox.Location = new System.Drawing.Point(219, 181);
            this.InitialDelayTextBox.Name = "InitialDelayTextBox";
            this.InitialDelayTextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialDelayTextBox.TabIndex = 15;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(244, 207);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(37, 250);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(282, 188);
            this.ResultTextBox.TabIndex = 17;
            // 
            // WaypointsListBox
            // 
            this.WaypointsListBox.FormattingEnabled = true;
            this.WaypointsListBox.Location = new System.Drawing.Point(373, 70);
            this.WaypointsListBox.Name = "WaypointsListBox";
            this.WaypointsListBox.Size = new System.Drawing.Size(119, 368);
            this.WaypointsListBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "X,Y of waypoint";
            // 
            // WaypointXYTextbox
            // 
            this.WaypointXYTextbox.Location = new System.Drawing.Point(373, 34);
            this.WaypointXYTextbox.Name = "WaypointXYTextbox";
            this.WaypointXYTextbox.Size = new System.Drawing.Size(119, 20);
            this.WaypointXYTextbox.TabIndex = 20;
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(498, 32);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(75, 23);
            this.AddToListButton.TabIndex = 21;
            this.AddToListButton.Text = "Add To List";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(498, 70);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(75, 38);
            this.RemoveSelectedButton.TabIndex = 22;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // EmptyListButton
            // 
            this.EmptyListButton.Location = new System.Drawing.Point(498, 114);
            this.EmptyListButton.Name = "EmptyListButton";
            this.EmptyListButton.Size = new System.Drawing.Size(75, 38);
            this.EmptyListButton.TabIndex = 23;
            this.EmptyListButton.Text = "Empty List";
            this.EmptyListButton.UseVisualStyleBackColor = true;
            this.EmptyListButton.Click += new System.EventHandler(this.EmptyListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 505);
            this.Controls.Add(this.EmptyListButton);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.WaypointXYTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaypointsListBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InitialDelayTextBox);
            this.Controls.Add(this.LoopCountTextBox);
            this.Controls.Add(this.LoopDelayTextBox);
            this.Controls.Add(this.SpawnTimeRandomTextBox);
            this.Controls.Add(this.TimeBetweenSpawnsTextBox);
            this.Controls.Add(this.EnemyMoveSpeedTextBox);
            this.Controls.Add(this.EnemyCountTextBox);
            this.Controls.Add(this.NeedAllDestroyedCheckbox);
            this.Controls.Add(this.NeedAllDestroyedLabel);
            this.Controls.Add(this.InitialDelayLabel);
            this.Controls.Add(this.LoopCountLabel);
            this.Controls.Add(this.LoopDelayLabel);
            this.Controls.Add(this.SpawnTimeRandomFactorLabel);
            this.Controls.Add(this.TimeBetweenSpawnsLabel);
            this.Controls.Add(this.EnemyMoveSpeedLabel);
            this.Controls.Add(this.EnemyCountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnemyCountLabel;
        private System.Windows.Forms.Label EnemyMoveSpeedLabel;
        private System.Windows.Forms.Label TimeBetweenSpawnsLabel;
        private System.Windows.Forms.Label SpawnTimeRandomFactorLabel;
        private System.Windows.Forms.Label LoopDelayLabel;
        private System.Windows.Forms.Label LoopCountLabel;
        private System.Windows.Forms.Label InitialDelayLabel;
        private System.Windows.Forms.Label NeedAllDestroyedLabel;
        private System.Windows.Forms.CheckBox NeedAllDestroyedCheckbox;
        private System.Windows.Forms.TextBox EnemyCountTextBox;
        private System.Windows.Forms.TextBox EnemyMoveSpeedTextBox;
        private System.Windows.Forms.TextBox TimeBetweenSpawnsTextBox;
        private System.Windows.Forms.TextBox SpawnTimeRandomTextBox;
        private System.Windows.Forms.TextBox LoopDelayTextBox;
        private System.Windows.Forms.TextBox LoopCountTextBox;
        private System.Windows.Forms.TextBox InitialDelayTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ListBox WaypointsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WaypointXYTextbox;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Button EmptyListButton;
    }
}

