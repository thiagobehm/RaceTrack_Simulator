namespace Race_Track_Simulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrackPicture = new System.Windows.Forms.PictureBox();
            this.dogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            this.labelBucksOnDog = new System.Windows.Forms.Label();
            this.numericUpDownBet = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrackPicture
            // 
            this.raceTrackPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raceTrackPicture.BackgroundImage")));
            this.raceTrackPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raceTrackPicture.Location = new System.Drawing.Point(12, 12);
            this.raceTrackPicture.Name = "raceTrackPicture";
            this.raceTrackPicture.Size = new System.Drawing.Size(606, 251);
            this.raceTrackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raceTrackPicture.TabIndex = 0;
            this.raceTrackPicture.TabStop = false;
            // 
            // dogPictureBox1
            // 
            this.dogPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dogPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox1.Image")));
            this.dogPictureBox1.Location = new System.Drawing.Point(25, 21);
            this.dogPictureBox1.Name = "dogPictureBox1";
            this.dogPictureBox1.Size = new System.Drawing.Size(98, 23);
            this.dogPictureBox1.TabIndex = 1;
            this.dogPictureBox1.TabStop = false;
            // 
            // dogPictureBox2
            // 
            this.dogPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox2.Image")));
            this.dogPictureBox2.Location = new System.Drawing.Point(25, 76);
            this.dogPictureBox2.Name = "dogPictureBox2";
            this.dogPictureBox2.Size = new System.Drawing.Size(98, 22);
            this.dogPictureBox2.TabIndex = 2;
            this.dogPictureBox2.TabStop = false;
            // 
            // dogPictureBox3
            // 
            this.dogPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox3.Image")));
            this.dogPictureBox3.Location = new System.Drawing.Point(25, 137);
            this.dogPictureBox3.Name = "dogPictureBox3";
            this.dogPictureBox3.Size = new System.Drawing.Size(98, 25);
            this.dogPictureBox3.TabIndex = 3;
            this.dogPictureBox3.TabStop = false;
            // 
            // dogPictureBox4
            // 
            this.dogPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox4.Image")));
            this.dogPictureBox4.Location = new System.Drawing.Point(22, 211);
            this.dogPictureBox4.Name = "dogPictureBox4";
            this.dogPictureBox4.Size = new System.Drawing.Size(101, 23);
            this.dogPictureBox4.TabIndex = 4;
            this.dogPictureBox4.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.alBetLabel);
            this.groupBox.Controls.Add(this.bobBetLabel);
            this.groupBox.Controls.Add(this.joeBetLabel);
            this.groupBox.Controls.Add(this.raceButton);
            this.groupBox.Controls.Add(this.numericUpDownDog);
            this.groupBox.Controls.Add(this.labelBucksOnDog);
            this.groupBox.Controls.Add(this.numericUpDownBet);
            this.groupBox.Controls.Add(this.betsButton);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.alRadioButton);
            this.groupBox.Controls.Add(this.bobRadioButton);
            this.groupBox.Controls.Add(this.joeRadioButton);
            this.groupBox.Controls.Add(this.minimumBetLabel);
            this.groupBox.Location = new System.Drawing.Point(12, 329);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(807, 200);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Betting Parlor";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(180, 108);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(75, 17);
            this.alBetLabel.TabIndex = 12;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(180, 80);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(88, 17);
            this.bobBetLabel.TabIndex = 11;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(180, 52);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(83, 17);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(462, 89);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(233, 78);
            this.raceButton.TabIndex = 9;
            this.raceButton.Text = "Race...";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // numericUpDownDog
            // 
            this.numericUpDownDog.Location = new System.Drawing.Point(328, 145);
            this.numericUpDownDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDog.Name = "numericUpDownDog";
            this.numericUpDownDog.Size = new System.Drawing.Size(57, 22);
            this.numericUpDownDog.TabIndex = 8;
            this.numericUpDownDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelBucksOnDog
            // 
            this.labelBucksOnDog.AutoSize = true;
            this.labelBucksOnDog.Location = new System.Drawing.Point(177, 147);
            this.labelBucksOnDog.Name = "labelBucksOnDog";
            this.labelBucksOnDog.Size = new System.Drawing.Size(145, 17);
            this.labelBucksOnDog.TabIndex = 7;
            this.labelBucksOnDog.Text = "bucks on dog number";
            // 
            // numericUpDownBet
            // 
            this.numericUpDownBet.Location = new System.Drawing.Point(109, 145);
            this.numericUpDownBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBet.Name = "numericUpDownBet";
            this.numericUpDownBet.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownBet.TabIndex = 6;
            this.numericUpDownBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(56, 144);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(47, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 147);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(7, 108);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(118, 21);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(7, 80);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(131, 21);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.joeRadioButton.Location = new System.Drawing.Point(7, 52);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(126, 21);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 22);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(94, 17);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBet";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.dogPictureBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dogPictureBox4);
            this.Controls.Add(this.dogPictureBox3);
            this.Controls.Add(this.dogPictureBox2);
            this.Controls.Add(this.raceTrackPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at The Races";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPicture;
        private System.Windows.Forms.PictureBox dogPictureBox1;
        private System.Windows.Forms.PictureBox dogPictureBox2;
        private System.Windows.Forms.PictureBox dogPictureBox3;
        private System.Windows.Forms.PictureBox dogPictureBox4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.NumericUpDown numericUpDownDog;
        private System.Windows.Forms.Label labelBucksOnDog;
        private System.Windows.Forms.NumericUpDown numericUpDownBet;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

