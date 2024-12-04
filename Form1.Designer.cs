namespace back_propagation
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
            inputA = new TextBox();
            createBtn = new Button();
            trainBtn = new Button();
            testBtn = new Button();
            inputB = new TextBox();
            outputA = new TextBox();
            inputC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            inputD = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // inputA
            // 
            inputA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputA.Location = new Point(209, 151);
            inputA.Name = "inputA";
            inputA.Size = new Size(90, 33);
            inputA.TabIndex = 0;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(151, 53);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(89, 47);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // trainBtn
            // 
            trainBtn.Location = new Point(246, 53);
            trainBtn.Name = "trainBtn";
            trainBtn.Size = new Size(89, 47);
            trainBtn.TabIndex = 4;
            trainBtn.Text = "Train";
            trainBtn.UseVisualStyleBackColor = true;
            trainBtn.Click += trainBtn_Click;
            // 
            // testBtn
            // 
            testBtn.Location = new Point(341, 53);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(89, 47);
            testBtn.TabIndex = 5;
            testBtn.Text = "Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
            // 
            // inputB
            // 
            inputB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputB.Location = new Point(209, 190);
            inputB.Name = "inputB";
            inputB.Size = new Size(90, 33);
            inputB.TabIndex = 6;
            // 
            // outputA
            // 
            outputA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputA.Location = new Point(387, 151);
            outputA.Name = "outputA";
            outputA.Size = new Size(90, 33);
            outputA.TabIndex = 7;
            // 
            // inputC
            // 
            inputC.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputC.Location = new Point(209, 229);
            inputC.Name = "inputC";
            inputC.Size = new Size(90, 33);
            inputC.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 121);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Inputs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 121);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 11;
            label3.Text = "Output";
            // 
            // inputD
            // 
            inputD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputD.Location = new Point(209, 268);
            inputD.Name = "inputD";
            inputD.Size = new Size(90, 33);
            inputD.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(209, 331);
            label4.Name = "label4";
            label4.Size = new Size(225, 30);
            label4.TabIndex = 13;
            label4.Text = "Training yield = 16 sets";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 361);
            label5.Name = "label5";
            label5.Size = new Size(352, 30);
            label5.TabIndex = 14;
            label5.Text = "Min Number of Hidden Layers = 100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(209, 391);
            label6.Name = "label6";
            label6.Size = new Size(228, 30);
            label6.TabIndex = 15;
            label6.Text = "Training Epochs = 1000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(inputD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputC);
            Controls.Add(outputA);
            Controls.Add(inputB);
            Controls.Add(testBtn);
            Controls.Add(trainBtn);
            Controls.Add(createBtn);
            Controls.Add(inputA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputA;
        private Button createBtn;
        private Button trainBtn;
        private Button testBtn;
        private TextBox inputB;
        private TextBox outputA;
        private TextBox inputC;
        private Label label2;
        private Label label3;
        private TextBox inputD;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
