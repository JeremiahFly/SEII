namespace SuperPoker.Views
{
    partial class MainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserInput = new System.Windows.Forms.GroupBox();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.nudCard1 = new System.Windows.Forms.NumericUpDown();
            this.nudCard2 = new System.Windows.Forms.NumericUpDown();
            this.nudCard3 = new System.Windows.Forms.NumericUpDown();
            this.nudCard4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bManualSubmit = new System.Windows.Forms.Button();
            this.bServerSubmit = new System.Windows.Forms.Button();
            this.gbUserInput.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard4)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUserInput
            // 
            this.gbUserInput.Controls.Add(this.bManualSubmit);
            this.gbUserInput.Controls.Add(this.label1);
            this.gbUserInput.Controls.Add(this.nudCard4);
            this.gbUserInput.Controls.Add(this.nudCard3);
            this.gbUserInput.Controls.Add(this.nudCard2);
            this.gbUserInput.Controls.Add(this.nudCard1);
            this.gbUserInput.Location = new System.Drawing.Point(3, 2);
            this.gbUserInput.Name = "gbUserInput";
            this.gbUserInput.Size = new System.Drawing.Size(573, 298);
            this.gbUserInput.TabIndex = 0;
            this.gbUserInput.TabStop = false;
            this.gbUserInput.Text = "Manual Input";
            // 
            // gbServer
            // 
            this.gbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbServer.Controls.Add(this.bServerSubmit);
            this.gbServer.Location = new System.Drawing.Point(582, 3);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(489, 297);
            this.gbServer.TabIndex = 1;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server Input";
            // 
            // gbOutput
            // 
            this.gbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOutput.Controls.Add(this.tbOutput);
            this.gbOutput.Location = new System.Drawing.Point(3, 308);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(1068, 330);
            this.gbOutput.TabIndex = 2;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(6, 95);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(1056, 116);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCard1
            // 
            this.nudCard1.Location = new System.Drawing.Point(6, 83);
            this.nudCard1.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudCard1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCard1.Name = "nudCard1";
            this.nudCard1.Size = new System.Drawing.Size(105, 20);
            this.nudCard1.TabIndex = 0;
            this.nudCard1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCard2
            // 
            this.nudCard2.Location = new System.Drawing.Point(140, 83);
            this.nudCard2.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudCard2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCard2.Name = "nudCard2";
            this.nudCard2.Size = new System.Drawing.Size(108, 20);
            this.nudCard2.TabIndex = 1;
            this.nudCard2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCard3
            // 
            this.nudCard3.Location = new System.Drawing.Point(272, 83);
            this.nudCard3.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudCard3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCard3.Name = "nudCard3";
            this.nudCard3.Size = new System.Drawing.Size(108, 20);
            this.nudCard3.TabIndex = 2;
            this.nudCard3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCard4
            // 
            this.nudCard4.Location = new System.Drawing.Point(407, 83);
            this.nudCard4.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudCard4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCard4.Name = "nudCard4";
            this.nudCard4.Size = new System.Drawing.Size(104, 20);
            this.nudCard4.TabIndex = 3;
            this.nudCard4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Card Value";
            // 
            // bManualSubmit
            // 
            this.bManualSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bManualSubmit.Location = new System.Drawing.Point(172, 172);
            this.bManualSubmit.Name = "bManualSubmit";
            this.bManualSubmit.Size = new System.Drawing.Size(125, 45);
            this.bManualSubmit.TabIndex = 5;
            this.bManualSubmit.Text = "Submit";
            this.bManualSubmit.UseVisualStyleBackColor = true;
            this.bManualSubmit.Click += new System.EventHandler(this.bManualSubmit_Click);
            // 
            // bServerSubmit
            // 
            this.bServerSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bServerSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bServerSubmit.Location = new System.Drawing.Point(130, 82);
            this.bServerSubmit.Name = "bServerSubmit";
            this.bServerSubmit.Size = new System.Drawing.Size(268, 88);
            this.bServerSubmit.TabIndex = 0;
            this.bServerSubmit.Text = "Get Cards From Server";
            this.bServerSubmit.UseVisualStyleBackColor = true;
            this.bServerSubmit.Click += new System.EventHandler(this.bServerSubmit_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.gbUserInput);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1079, 646);
            this.gbUserInput.ResumeLayout(false);
            this.gbUserInput.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCard4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCard4;
        private System.Windows.Forms.NumericUpDown nudCard3;
        private System.Windows.Forms.NumericUpDown nudCard2;
        private System.Windows.Forms.NumericUpDown nudCard1;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button bManualSubmit;
        private System.Windows.Forms.Button bServerSubmit;
    }
}
