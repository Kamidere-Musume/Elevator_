namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            elevatorInterior = new PictureBox();
            leftDoorUp = new PictureBox();
            rightDoorUp = new PictureBox();
            rightDoorDown = new PictureBox();
            leftDoorDown = new PictureBox();
            floorDownBtn = new Button();
            floorUpBtn = new Button();
            pictureBox1 = new PictureBox();
            doorOpenUp = new Button();
            doorCloseUp = new Button();
            floorGroundUp = new Button();
            floorOneUp = new Button();
            floorTxtUp = new TextBox();
            elevatorDoorOpen = new System.Windows.Forms.Timer(components);
            closeDoor = new System.Windows.Forms.Timer(components);
            groundFloor = new System.Windows.Forms.Timer(components);
            floorOne = new System.Windows.Forms.Timer(components);
            elevatorLog = new DataGridView();
            dataRefresh = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)elevatorInterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elevatorLog).BeginInit();
            SuspendLayout();
            // 
            // elevatorInterior
            // 
            elevatorInterior.Image = (Image)resources.GetObject("elevatorInterior.Image");
            elevatorInterior.Location = new Point(74, 26);
            elevatorInterior.Name = "elevatorInterior";
            elevatorInterior.Size = new Size(300, 380);
            elevatorInterior.TabIndex = 0;
            elevatorInterior.TabStop = false;
            // 
            // leftDoorUp
            // 
            leftDoorUp.Image = (Image)resources.GetObject("leftDoorUp.Image");
            leftDoorUp.Location = new Point(74, 26);
            leftDoorUp.Name = "leftDoorUp";
            leftDoorUp.Size = new Size(148, 380);
            leftDoorUp.TabIndex = 1;
            leftDoorUp.TabStop = false;
            // 
            // rightDoorUp
            // 
            rightDoorUp.Image = (Image)resources.GetObject("rightDoorUp.Image");
            rightDoorUp.Location = new Point(219, 26);
            rightDoorUp.Name = "rightDoorUp";
            rightDoorUp.Size = new Size(155, 380);
            rightDoorUp.TabIndex = 2;
            rightDoorUp.TabStop = false;
            // 
            // rightDoorDown
            // 
            rightDoorDown.Image = (Image)resources.GetObject("rightDoorDown.Image");
            rightDoorDown.Location = new Point(219, 528);
            rightDoorDown.Name = "rightDoorDown";
            rightDoorDown.Size = new Size(155, 380);
            rightDoorDown.TabIndex = 5;
            rightDoorDown.TabStop = false;
            // 
            // leftDoorDown
            // 
            leftDoorDown.Image = (Image)resources.GetObject("leftDoorDown.Image");
            leftDoorDown.Location = new Point(74, 528);
            leftDoorDown.Name = "leftDoorDown";
            leftDoorDown.Size = new Size(148, 380);
            leftDoorDown.TabIndex = 4;
            leftDoorDown.TabStop = false;
            // 
            // floorDownBtn
            // 
            floorDownBtn.Image = (Image)resources.GetObject("floorDownBtn.Image");
            floorDownBtn.Location = new Point(403, 221);
            floorDownBtn.Name = "floorDownBtn";
            floorDownBtn.Size = new Size(34, 30);
            floorDownBtn.TabIndex = 6;
            floorDownBtn.UseVisualStyleBackColor = true;
            floorDownBtn.Click += floorDownBtn_Click;
            // 
            // floorUpBtn
            // 
            floorUpBtn.Image = (Image)resources.GetObject("floorUpBtn.Image");
            floorUpBtn.Location = new Point(392, 703);
            floorUpBtn.Name = "floorUpBtn";
            floorUpBtn.Size = new Size(34, 30);
            floorUpBtn.TabIndex = 7;
            floorUpBtn.UseVisualStyleBackColor = true;
            floorUpBtn.Click += floorUpBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 412);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // doorOpenUp
            // 
            doorOpenUp.Image = (Image)resources.GetObject("doorOpenUp.Image");
            doorOpenUp.Location = new Point(497, 528);
            doorOpenUp.Name = "doorOpenUp";
            doorOpenUp.Size = new Size(53, 41);
            doorOpenUp.TabIndex = 9;
            doorOpenUp.UseVisualStyleBackColor = true;
            doorOpenUp.Click += doorOpenUp_Click;
            // 
            // doorCloseUp
            // 
            doorCloseUp.Image = (Image)resources.GetObject("doorCloseUp.Image");
            doorCloseUp.Location = new Point(646, 528);
            doorCloseUp.Name = "doorCloseUp";
            doorCloseUp.Size = new Size(49, 41);
            doorCloseUp.TabIndex = 10;
            doorCloseUp.UseVisualStyleBackColor = true;
            doorCloseUp.Click += doorCloseUp_Click;
            // 
            // floorGroundUp
            // 
            floorGroundUp.Image = (Image)resources.GetObject("floorGroundUp.Image");
            floorGroundUp.Location = new Point(497, 418);
            floorGroundUp.Name = "floorGroundUp";
            floorGroundUp.Size = new Size(53, 55);
            floorGroundUp.TabIndex = 12;
            floorGroundUp.UseVisualStyleBackColor = true;
            floorGroundUp.Click += floorGroundUp_Click;
            // 
            // floorOneUp
            // 
            floorOneUp.Image = (Image)resources.GetObject("floorOneUp.Image");
            floorOneUp.Location = new Point(497, 331);
            floorOneUp.Name = "floorOneUp";
            floorOneUp.Size = new Size(53, 60);
            floorOneUp.TabIndex = 13;
            floorOneUp.UseVisualStyleBackColor = true;
            floorOneUp.Click += floorOneUp_Click;
            // 
            // floorTxtUp
            // 
            floorTxtUp.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            floorTxtUp.Location = new Point(550, 203);
            floorTxtUp.Multiline = true;
            floorTxtUp.Name = "floorTxtUp";
            floorTxtUp.ReadOnly = true;
            floorTxtUp.Size = new Size(100, 106);
            floorTxtUp.TabIndex = 14;
            floorTxtUp.TextAlign = HorizontalAlignment.Center;
            floorTxtUp.TextChanged += floorTxtUp_TextChanged;
            // 
            // elevatorDoorOpen
            // 
            elevatorDoorOpen.Interval = 20;
            elevatorDoorOpen.Tick += elevatorDoorOpen_Tick;
            // 
            // closeDoor
            // 
            closeDoor.Interval = 20;
            closeDoor.Tick += closeDoor_Tick;
            // 
            // groundFloor
            // 
            groundFloor.Interval = 20;
            groundFloor.Tick += groundFloor_Tick;
            // 
            // floorOne
            // 
            floorOne.Interval = 20;
            floorOne.Tick += floorOne_Tick;
            // 
            // elevatorLog
            // 
            elevatorLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            elevatorLog.Location = new Point(789, 26);
            elevatorLog.Name = "elevatorLog";
            elevatorLog.RowTemplate.Height = 25;
            elevatorLog.Size = new Size(508, 481);
            elevatorLog.TabIndex = 15;
            // 
            // dataRefresh
            // 
            dataRefresh.Enabled = true;
            dataRefresh.Interval = 1000;
            dataRefresh.Tick += dataRefresh_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 981);
            Controls.Add(elevatorLog);
            Controls.Add(floorTxtUp);
            Controls.Add(floorOneUp);
            Controls.Add(floorGroundUp);
            Controls.Add(doorCloseUp);
            Controls.Add(doorOpenUp);
            Controls.Add(pictureBox1);
            Controls.Add(floorUpBtn);
            Controls.Add(floorDownBtn);
            Controls.Add(rightDoorDown);
            Controls.Add(leftDoorDown);
            Controls.Add(rightDoorUp);
            Controls.Add(leftDoorUp);
            Controls.Add(elevatorInterior);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)elevatorInterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoorDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoorDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)elevatorLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox elevatorInterior;
        private PictureBox leftDoorUp;
        private PictureBox rightDoorUp;
        private PictureBox rightDoorDown;
        private PictureBox leftDoorDown;
        private Button floorDownBtn;
        private Button floorUpBtn;
        private PictureBox pictureBox1;
        private Button doorOpenUp;
        private Button doorCloseUp;
        private Button floorGroundUp;
        private Button floorOneUp;
        private TextBox floorTxtUp;
        private System.Windows.Forms.Timer elevatorDoorOpen;
        private System.Windows.Forms.Timer closeDoor;
        private System.Windows.Forms.Timer groundFloor;
        private System.Windows.Forms.Timer floorOne;
        private DataGridView elevatorLog;
        private System.Windows.Forms.Timer dataRefresh;
    }
}