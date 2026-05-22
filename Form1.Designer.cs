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
        button1 = new Button();
        SuspendLayout();
        // 
        // btnLosuj
        // 
        btnLosuj.Location = new Point(937, 568);
        btnLosuj.Name = "btnLosuj";
        btnLosuj.Size = new Size(277, 100);
        btnLosuj.TabIndex = 0;
        btnLosuj.Text = "Losuj";
        btnLosuj.UseVisualStyleBackColor = true;
        btnLosuj.Click += btnLosuj_Click;
        // 
        // lblWynikMaszyna1
        // 
        lblWynikMaszyna1.AutoSize = true;
        lblWynikMaszyna1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWynikMaszyna1.Location = new Point(69, 568);
        lblWynikMaszyna1.Name = "lblWynikMaszyna1";
        lblWynikMaszyna1.Size = new Size(535, 100);
        lblWynikMaszyna1.TabIndex = 1;
        lblWynikMaszyna1.Text = "Brak losowania";
        // 
        // lblMaszyna1
        // 
        lblMaszyna1.AutoSize = true;
        lblMaszyna1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblMaszyna1.Location = new Point(69, 511);
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
        lblMaszyna2.Location = new Point(69, 742);
        lblMaszyna2.Name = "lblMaszyna2";
        lblMaszyna2.Size = new Size(471, 45);
        lblMaszyna2.TabIndex = 7;
        lblMaszyna2.Text = "Wylosowane liczby (Maszyna 2):";
        // 
        // lblWynikMaszyna2
        // 
        lblWynikMaszyna2.AutoSize = true;
        lblWynikMaszyna2.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWynikMaszyna2.Location = new Point(69, 799);
        lblWynikMaszyna2.Name = "lblWynikMaszyna2";
        lblWynikMaszyna2.Size = new Size(535, 100);
        lblWynikMaszyna2.TabIndex = 6;
        lblWynikMaszyna2.Text = "Brak losowania";
        // 
        // button1
        // 
        button1.Location = new Point(937, 799);
        button1.Name = "button1";
        button1.Size = new Size(277, 100);
        button1.TabIndex = 5;
        button1.Text = "Losuj";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1680, 1520);
        Controls.Add(lblMaszyna2);
        Controls.Add(lblWynikMaszyna2);
        Controls.Add(button1);
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
    private Button button1;
}
