namespace Queue_Stack_Collection
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.btnEnQueue = new System.Windows.Forms.Button();
            this.btnEnqueueRandVal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnRemoveOdds = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnEnQueue2 = new System.Windows.Forms.Button();
            this.btnDequeue2 = new System.Windows.Forms.Button();
            this.btnMergeQueues = new System.Windows.Forms.Button();
            this.btnStack2Q = new System.Windows.Forms.Button();
            this.btnPopStack2 = new System.Windows.Forms.Button();
            this.btnPushStack2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnRemoveOddsStk1 = new System.Windows.Forms.Button();
            this.btnReverseStack2 = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnPushRandom = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtStackAddValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnQ2RandVal = new System.Windows.Forms.Button();
            this.btnStack2RandVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(62, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // txtAddValue
            // 
            this.txtAddValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtAddValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddValue.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAddValue.Location = new System.Drawing.Point(122, 128);
            this.txtAddValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(196, 26);
            this.txtAddValue.TabIndex = 1;
            // 
            // btnEnQueue
            // 
            this.btnEnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnQueue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnQueue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnQueue.Location = new System.Drawing.Point(327, 126);
            this.btnEnQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnQueue.Name = "btnEnQueue";
            this.btnEnQueue.Size = new System.Drawing.Size(122, 39);
            this.btnEnQueue.TabIndex = 2;
            this.btnEnQueue.Text = "EnQueue";
            this.btnEnQueue.UseVisualStyleBackColor = true;
            this.btnEnQueue.Click += new System.EventHandler(this.btnEnQueue_Click);
            // 
            // btnEnqueueRandVal
            // 
            this.btnEnqueueRandVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnqueueRandVal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueueRandVal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnqueueRandVal.Location = new System.Drawing.Point(66, 219);
            this.btnEnqueueRandVal.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnqueueRandVal.Name = "btnEnqueueRandVal";
            this.btnEnqueueRandVal.Size = new System.Drawing.Size(177, 39);
            this.btnEnqueueRandVal.TabIndex = 3;
            this.btnEnqueueRandVal.Text = "Q1 Random Value";
            this.btnEnqueueRandVal.UseVisualStyleBackColor = true;
            this.btnEnqueueRandVal.Click += new System.EventHandler(this.btnEnqueueRandVal_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(66, 322);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 224);
            this.listBox1.TabIndex = 4;
            // 
            // btnDequeue
            // 
            this.btnDequeue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDequeue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDequeue.Location = new System.Drawing.Point(327, 173);
            this.btnDequeue.Margin = new System.Windows.Forms.Padding(4);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(122, 39);
            this.btnDequeue.TabIndex = 5;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeek.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPeek.Location = new System.Drawing.Point(196, 173);
            this.btnPeek.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(122, 39);
            this.btnPeek.TabIndex = 6;
            this.btnPeek.Text = "Peek Q1";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnRemoveOdds
            // 
            this.btnRemoveOdds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOdds.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOdds.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemoveOdds.Location = new System.Drawing.Point(66, 173);
            this.btnRemoveOdds.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveOdds.Name = "btnRemoveOdds";
            this.btnRemoveOdds.Size = new System.Drawing.Size(122, 39);
            this.btnRemoveOdds.TabIndex = 7;
            this.btnRemoveOdds.Text = "Remove Odds Q1";
            this.btnRemoveOdds.UseVisualStyleBackColor = true;
            this.btnRemoveOdds.Click += new System.EventHandler(this.btnRemoveOdds_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(267, 322);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 224);
            this.listBox2.TabIndex = 8;
            // 
            // btnEnQueue2
            // 
            this.btnEnQueue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnQueue2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnQueue2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnQueue2.Location = new System.Drawing.Point(66, 266);
            this.btnEnQueue2.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnQueue2.Name = "btnEnQueue2";
            this.btnEnQueue2.Size = new System.Drawing.Size(122, 39);
            this.btnEnQueue2.TabIndex = 9;
            this.btnEnQueue2.Text = "EnQueue 2";
            this.btnEnQueue2.UseVisualStyleBackColor = true;
            this.btnEnQueue2.Click += new System.EventHandler(this.btnEnQueue2_Click);
            // 
            // btnDequeue2
            // 
            this.btnDequeue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDequeue2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDequeue2.Location = new System.Drawing.Point(196, 266);
            this.btnDequeue2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDequeue2.Name = "btnDequeue2";
            this.btnDequeue2.Size = new System.Drawing.Size(122, 39);
            this.btnDequeue2.TabIndex = 10;
            this.btnDequeue2.Text = "Dequeue 2";
            this.btnDequeue2.UseVisualStyleBackColor = true;
            this.btnDequeue2.Click += new System.EventHandler(this.btnDequeue2_Click);
            // 
            // btnMergeQueues
            // 
            this.btnMergeQueues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergeQueues.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeQueues.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMergeQueues.Location = new System.Drawing.Point(327, 266);
            this.btnMergeQueues.Margin = new System.Windows.Forms.Padding(4);
            this.btnMergeQueues.Name = "btnMergeQueues";
            this.btnMergeQueues.Size = new System.Drawing.Size(122, 39);
            this.btnMergeQueues.TabIndex = 11;
            this.btnMergeQueues.Text = "Merge Q\'s";
            this.btnMergeQueues.UseVisualStyleBackColor = true;
            this.btnMergeQueues.Click += new System.EventHandler(this.btnMergeQueues_Click);
            // 
            // btnStack2Q
            // 
            this.btnStack2Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStack2Q.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack2Q.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStack2Q.Location = new System.Drawing.Point(824, 266);
            this.btnStack2Q.Margin = new System.Windows.Forms.Padding(4);
            this.btnStack2Q.Name = "btnStack2Q";
            this.btnStack2Q.Size = new System.Drawing.Size(122, 39);
            this.btnStack2Q.TabIndex = 23;
            this.btnStack2Q.Text = "Stack to Q";
            this.btnStack2Q.UseVisualStyleBackColor = true;
            this.btnStack2Q.Click += new System.EventHandler(this.btnStack2Q_Click);
            // 
            // btnPopStack2
            // 
            this.btnPopStack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopStack2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopStack2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPopStack2.Location = new System.Drawing.Point(693, 266);
            this.btnPopStack2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPopStack2.Name = "btnPopStack2";
            this.btnPopStack2.Size = new System.Drawing.Size(122, 39);
            this.btnPopStack2.TabIndex = 22;
            this.btnPopStack2.Text = "Pop Stack 2";
            this.btnPopStack2.UseVisualStyleBackColor = true;
            this.btnPopStack2.Click += new System.EventHandler(this.btnPopStack2_Click);
            // 
            // btnPushStack2
            // 
            this.btnPushStack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushStack2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushStack2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPushStack2.Location = new System.Drawing.Point(563, 266);
            this.btnPushStack2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPushStack2.Name = "btnPushStack2";
            this.btnPushStack2.Size = new System.Drawing.Size(122, 39);
            this.btnPushStack2.TabIndex = 21;
            this.btnPushStack2.Text = "Push Stack2";
            this.btnPushStack2.UseVisualStyleBackColor = true;
            this.btnPushStack2.Click += new System.EventHandler(this.btnPushStack2_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(764, 322);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(182, 224);
            this.listBox3.TabIndex = 20;
            // 
            // btnRemoveOddsStk1
            // 
            this.btnRemoveOddsStk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOddsStk1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOddsStk1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemoveOddsStk1.Location = new System.Drawing.Point(563, 173);
            this.btnRemoveOddsStk1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveOddsStk1.Name = "btnRemoveOddsStk1";
            this.btnRemoveOddsStk1.Size = new System.Drawing.Size(122, 39);
            this.btnRemoveOddsStk1.TabIndex = 19;
            this.btnRemoveOddsStk1.Text = "Remove Odds Stk1";
            this.btnRemoveOddsStk1.UseVisualStyleBackColor = true;
            this.btnRemoveOddsStk1.Click += new System.EventHandler(this.btnRemoveOddsStk1_Click);
            // 
            // btnReverseStack2
            // 
            this.btnReverseStack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverseStack2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseStack2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReverseStack2.Location = new System.Drawing.Point(693, 173);
            this.btnReverseStack2.Margin = new System.Windows.Forms.Padding(4);
            this.btnReverseStack2.Name = "btnReverseStack2";
            this.btnReverseStack2.Size = new System.Drawing.Size(122, 39);
            this.btnReverseStack2.TabIndex = 18;
            this.btnReverseStack2.Text = "Reverse Stack 2";
            this.btnReverseStack2.UseVisualStyleBackColor = true;
            this.btnReverseStack2.Click += new System.EventHandler(this.btnReverseStack2_Click);
            // 
            // btnPop
            // 
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPop.Location = new System.Drawing.Point(824, 173);
            this.btnPop.Margin = new System.Windows.Forms.Padding(4);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(122, 39);
            this.btnPop.TabIndex = 17;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.SystemColors.WindowText;
            this.listBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(563, 322);
            this.listBox4.Margin = new System.Windows.Forms.Padding(4);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(177, 224);
            this.listBox4.TabIndex = 16;
            // 
            // btnPushRandom
            // 
            this.btnPushRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushRandom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushRandom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPushRandom.Location = new System.Drawing.Point(563, 219);
            this.btnPushRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnPushRandom.Name = "btnPushRandom";
            this.btnPushRandom.Size = new System.Drawing.Size(177, 39);
            this.btnPushRandom.TabIndex = 15;
            this.btnPushRandom.Text = "Push Random Value";
            this.btnPushRandom.UseVisualStyleBackColor = true;
            this.btnPushRandom.Click += new System.EventHandler(this.btnPushRandom_Click);
            // 
            // btnPush
            // 
            this.btnPush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPush.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPush.Location = new System.Drawing.Point(824, 126);
            this.btnPush.Margin = new System.Windows.Forms.Padding(4);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(122, 39);
            this.btnPush.TabIndex = 14;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtStackAddValue
            // 
            this.txtStackAddValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtStackAddValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStackAddValue.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStackAddValue.Location = new System.Drawing.Point(619, 128);
            this.txtStackAddValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtStackAddValue.Name = "txtStackAddValue";
            this.txtStackAddValue.Size = new System.Drawing.Size(196, 26);
            this.txtStackAddValue.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(559, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Value";
            // 
            // tbnQ2RandVal
            // 
            this.tbnQ2RandVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnQ2RandVal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnQ2RandVal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbnQ2RandVal.Location = new System.Drawing.Point(267, 219);
            this.tbnQ2RandVal.Margin = new System.Windows.Forms.Padding(4);
            this.tbnQ2RandVal.Name = "tbnQ2RandVal";
            this.tbnQ2RandVal.Size = new System.Drawing.Size(182, 39);
            this.tbnQ2RandVal.TabIndex = 24;
            this.tbnQ2RandVal.Text = "Q2 Random Value";
            this.tbnQ2RandVal.UseVisualStyleBackColor = true;
            this.tbnQ2RandVal.Click += new System.EventHandler(this.tbnQ2RandVal_Click);
            // 
            // btnStack2RandVal
            // 
            this.btnStack2RandVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStack2RandVal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack2RandVal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStack2RandVal.Location = new System.Drawing.Point(764, 219);
            this.btnStack2RandVal.Margin = new System.Windows.Forms.Padding(4);
            this.btnStack2RandVal.Name = "btnStack2RandVal";
            this.btnStack2RandVal.Size = new System.Drawing.Size(182, 39);
            this.btnStack2RandVal.TabIndex = 25;
            this.btnStack2RandVal.Text = "St2 Random Value";
            this.btnStack2RandVal.UseVisualStyleBackColor = true;
            this.btnStack2RandVal.Click += new System.EventHandler(this.btnStack2RandVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 636);
            this.Controls.Add(this.btnStack2RandVal);
            this.Controls.Add(this.tbnQ2RandVal);
            this.Controls.Add(this.btnStack2Q);
            this.Controls.Add(this.btnPopStack2);
            this.Controls.Add(this.btnPushStack2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnRemoveOddsStk1);
            this.Controls.Add(this.btnReverseStack2);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnPushRandom);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtStackAddValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMergeQueues);
            this.Controls.Add(this.btnDequeue2);
            this.Controls.Add(this.btnEnQueue2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnRemoveOdds);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnqueueRandVal);
            this.Controls.Add(this.btnEnQueue);
            this.Controls.Add(this.txtAddValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Queue | Stack Collection";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Button btnEnQueue;
        private System.Windows.Forms.Button btnEnqueueRandVal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnRemoveOdds;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnEnQueue2;
        private System.Windows.Forms.Button btnDequeue2;
        private System.Windows.Forms.Button btnMergeQueues;
        private System.Windows.Forms.Button btnStack2Q;
        private System.Windows.Forms.Button btnPopStack2;
        private System.Windows.Forms.Button btnPushStack2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnRemoveOddsStk1;
        private System.Windows.Forms.Button btnReverseStack2;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnPushRandom;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtStackAddValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbnQ2RandVal;
        private System.Windows.Forms.Button btnStack2RandVal;
    }
}

