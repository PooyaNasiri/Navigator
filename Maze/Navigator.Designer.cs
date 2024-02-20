namespace Navigator
{
    partial class Navigator
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.buttons[i, j] = new System.Windows.Forms.Button();
                    this.buttons[i, j].DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.buttons[i, j].Location = new System.Drawing.Point(40 * j + 10, 40 * i + 10);
                    this.buttons[i, j].Name = "button" + (j + 1) + (i * n);
                    this.buttons[i, j].Size = new System.Drawing.Size(40, 40);
                    this.buttons[i, j].TabIndex = 0;
                    this.buttons[i, j].Text = j + "," + i;// + ((i * n) + (j + 1));
                    this.buttons[i, j].UseVisualStyleBackColor = true;
                    this.buttons[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    this.buttons[i, j].Click += new System.EventHandler(this.buttons_Click);
                    this.Controls.Add(this.buttons[i, j]);
                }

            }
            
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Xtextbox = new System.Windows.Forms.TextBox();
            this.Ytextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XtextboxEnd = new System.Windows.Forms.TextBox();
            this.YtextboxEnd = new System.Windows.Forms.TextBox();
            this.label3End = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();           
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(138, 40 * n + 18);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(40, 23);
            this.Start.TabIndex = 17;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(138, 40 * n + 43);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(40, 23);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40 * n + 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "            Ok";
            // 
            // Xtextbox
            // 
            this.Xtextbox.Location = new System.Drawing.Point(111, 40 * n + 20);
            this.Xtextbox.MaxLength = 1;
            this.Xtextbox.Name = "Xtextbox";
            this.Xtextbox.Size = new System.Drawing.Size(21, 20);
            this.Xtextbox.TabIndex = 19;
            this.Xtextbox.Text = "0";
            // 
            // Ytextbox
            // 
            this.Ytextbox.Location = new System.Drawing.Point(75, 40 * n + 20);
            this.Ytextbox.MaxLength = 1;
            this.Ytextbox.Name = "Ytextbox";
            this.Ytextbox.Size = new System.Drawing.Size(21, 20);
            this.Ytextbox.TabIndex = 20;
            this.Ytextbox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40 * n + 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Start pos.: X:         Y:  ";
            // 
            // XtextboxEnd
            // 
            this.XtextboxEnd.Location = new System.Drawing.Point(111, 40 * n + 45);
            this.XtextboxEnd.MaxLength = 1;
            this.XtextboxEnd.Name = "XtextboxEnd";
            this.XtextboxEnd.Size = new System.Drawing.Size(21, 20);
            this.XtextboxEnd.TabIndex = 19;
            this.XtextboxEnd.Text = "0";
            // 
            // YtextboxEnd
            // 
            this.YtextboxEnd.Location = new System.Drawing.Point(75, 40 * n + 45);
            this.YtextboxEnd.MaxLength = 1;
            this.YtextboxEnd.Name = "YtextboxEnd";
            this.YtextboxEnd.Size = new System.Drawing.Size(21, 20);
            this.YtextboxEnd.TabIndex = 20;
            this.YtextboxEnd.Text = "0";
            // 
            // label3End
            // 
            this.label3End.AutoSize = true;
            this.label3End.Location = new System.Drawing.Point(9, 40 * n + 48);
            this.label3End.Name = "label3End";
            this.label3End.Size = new System.Drawing.Size(120, 13);
            this.label3End.TabIndex = 21;
            this.label3End.Text = "End pos.:  X:         Y:  ";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 40 * n + 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "status: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 40 * n + 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "way: ";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40 * n + 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = " ...";
            this.label1.Visible = false;
            
            // 
            // Navigator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(40 * n + 20, 40 * n + 120);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ytextbox);
            this.Controls.Add(this.Xtextbox);
            this.Controls.Add(this.YtextboxEnd);
            this.Controls.Add(this.XtextboxEnd);
            this.Controls.Add(this.label3End);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Navigator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private const int n = Program.n;
        private System.Windows.Forms.Button[,] buttons = new System.Windows.Forms.Button[n, n];
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Xtextbox;
        private System.Windows.Forms.TextBox Ytextbox;
        private System.Windows.Forms.TextBox XtextboxEnd;
        private System.Windows.Forms.TextBox YtextboxEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label3End;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
    }
}

