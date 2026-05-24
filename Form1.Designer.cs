namespace duzy_lotek;

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
        btnLosuj = new Button();
        lblWynikMaszyna1 = new Label();
        lblMaszyna1 = new Label();
        lblGlowneLiczby = new Label();
        lblGlowneLiczbyWyswietl = new Label();
        lblMaszyna2 = new Label();
        lblWynikMaszyna2 = new Label();
        lblWylosowane3 = new Label();
        lblIlosc3 = new Label();
        lblIlosc4 = new Label();
        lblWylosowane4 = new Label();
        lblIlosc5 = new Label();
        lblWylosowane5 = new Label();
        btnStop = new Button();
        SuspendLayout();
        // 
        // btnLosuj
        // 
        btnLosuj.Location = new Point(830, 1191);
        btnLosuj.Name = "btnLosuj";
        btnLosuj.Size = new Size(317, 177);
        btnLosuj.TabIndex = 0;
        btnLosuj.Text = "Losuj";
        btnLosuj.UseVisualStyleBackColor = true;
        btnLosuj.Click += btnLosuj_Click;
        // 
        // lblWynikMaszyna1
        // 
        lblWynikMaszyna1.AutoSize = true;
        lblWynikMaszyna1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWynikMaszyna1.Location = new Point(69, 402);
        lblWynikMaszyna1.Name = "lblWynikMaszyna1";
        lblWynikMaszyna1.Size = new Size(535, 100);
        lblWynikMaszyna1.TabIndex = 1;
        lblWynikMaszyna1.Text = "Brak losowania";
        // 
        // lblMaszyna1
        // 
        lblMaszyna1.AutoSize = true;
        lblMaszyna1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblMaszyna1.Location = new Point(69, 345);
        lblMaszyna1.Name = "lblMaszyna1";
        lblMaszyna1.Size = new Size(471, 45);
        lblMaszyna1.TabIndex = 2;
        lblMaszyna1.Text = "Wylosowane liczby (Maszyna 1):";
        // 
        // lblGlowneLiczby
        // 
        lblGlowneLiczby.AutoSize = true;
        lblGlowneLiczby.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblGlowneLiczby.Location = new Point(69, 85);
        lblGlowneLiczby.Name = "lblGlowneLiczby";
        lblGlowneLiczby.Size = new Size(223, 45);
        lblGlowneLiczby.TabIndex = 4;
        lblGlowneLiczby.Text = "Główne liczby:";
        // 
        // lblGlowneLiczbyWyswietl
        // 
        lblGlowneLiczbyWyswietl.AutoSize = true;
        lblGlowneLiczbyWyswietl.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblGlowneLiczbyWyswietl.Location = new Point(69, 142);
        lblGlowneLiczbyWyswietl.Name = "lblGlowneLiczbyWyswietl";
        lblGlowneLiczbyWyswietl.Size = new Size(535, 100);
        lblGlowneLiczbyWyswietl.TabIndex = 3;
        lblGlowneLiczbyWyswietl.Text = "Brak losowania";
        // 
        // lblMaszyna2
        // 
        lblMaszyna2.AutoSize = true;
        lblMaszyna2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblMaszyna2.Location = new Point(69, 576);
        lblMaszyna2.Name = "lblMaszyna2";
        lblMaszyna2.Size = new Size(471, 45);
        lblMaszyna2.TabIndex = 7;
        lblMaszyna2.Text = "Wylosowane liczby (Maszyna 2):";
        // 
        // lblWynikMaszyna2
        // 
        lblWynikMaszyna2.AutoSize = true;
        lblWynikMaszyna2.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWynikMaszyna2.Location = new Point(69, 633);
        lblWynikMaszyna2.Name = "lblWynikMaszyna2";
        lblWynikMaszyna2.Size = new Size(535, 100);
        lblWynikMaszyna2.TabIndex = 6;
        lblWynikMaszyna2.Text = "Brak losowania";
        // 
        // lblWylosowane3
        // 
        lblWylosowane3.AutoSize = true;
        lblWylosowane3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWylosowane3.Location = new Point(69, 851);
        lblWylosowane3.Name = "lblWylosowane3";
        lblWylosowane3.Size = new Size(330, 45);
        lblWylosowane3.TabIndex = 8;
        lblWylosowane3.Text = "Ilość wylosowanych 3:";
        // 
        // lblIlosc3
        // 
        lblIlosc3.AutoSize = true;
        lblIlosc3.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblIlosc3.Location = new Point(424, 815);
        lblIlosc3.Name = "lblIlosc3";
        lblIlosc3.Size = new Size(82, 100);
        lblIlosc3.TabIndex = 9;
        lblIlosc3.Text = "0";
        // 
        // lblIlosc4
        // 
        lblIlosc4.AutoSize = true;
        lblIlosc4.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblIlosc4.Location = new Point(424, 937);
        lblIlosc4.Name = "lblIlosc4";
        lblIlosc4.Size = new Size(82, 100);
        lblIlosc4.TabIndex = 11;
        lblIlosc4.Text = "0";
        // 
        // lblWylosowane4
        // 
        lblWylosowane4.AutoSize = true;
        lblWylosowane4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWylosowane4.Location = new Point(69, 973);
        lblWylosowane4.Name = "lblWylosowane4";
        lblWylosowane4.Size = new Size(330, 45);
        lblWylosowane4.TabIndex = 10;
        lblWylosowane4.Text = "Ilość wylosowanych 4:";
        // 
        // lblIlosc5
        // 
        lblIlosc5.AutoSize = true;
        lblIlosc5.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblIlosc5.Location = new Point(424, 1056);
        lblIlosc5.Name = "lblIlosc5";
        lblIlosc5.Size = new Size(82, 100);
        lblIlosc5.TabIndex = 13;
        lblIlosc5.Text = "0";
        // 
        // lblWylosowane5
        // 
        lblWylosowane5.AutoSize = true;
        lblWylosowane5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWylosowane5.Location = new Point(69, 1092);
        lblWylosowane5.Name = "lblWylosowane5";
        lblWylosowane5.Size = new Size(330, 45);
        lblWylosowane5.TabIndex = 12;
        lblWylosowane5.Text = "Ilość wylosowanych 5:";
        // 
        // btnStop
        // 
        btnStop.Location = new Point(1290, 1191);
        btnStop.Name = "btnStop";
        btnStop.Size = new Size(317, 177);
        btnStop.TabIndex = 14;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = true;
        btnStop.Click += btnStop_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1680, 1520);
        Controls.Add(btnStop);
        Controls.Add(lblIlosc5);
        Controls.Add(lblWylosowane5);
        Controls.Add(lblIlosc4);
        Controls.Add(lblWylosowane4);
        Controls.Add(lblIlosc3);
        Controls.Add(lblWylosowane3);
        Controls.Add(lblMaszyna2);
        Controls.Add(lblWynikMaszyna2);
        Controls.Add(lblGlowneLiczby);
        Controls.Add(lblGlowneLiczbyWyswietl);
        Controls.Add(lblMaszyna1);
        Controls.Add(lblWynikMaszyna1);
        Controls.Add(btnLosuj);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLosuj;
    private Label lblWynikMaszyna1;
    private Label lblMaszyna1;
    private Label lblGlowneLiczby;
    private Label lblGlowneLiczbyWyswietl;
    private Label lblMaszyna2;
    private Label lblWynikMaszyna2;
    private Label lblWylosowane3;
    private Label lblIlosc3;
    private Label lblIlosc4;
    private Label lblWylosowane4;
    private Label lblIlosc5;
    private Label lblWylosowane5;
    private Button btnStop;
}
