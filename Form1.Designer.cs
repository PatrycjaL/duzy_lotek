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
        lblWynik = new Label();
        lblWylosowaneText = new Label();
        SuspendLayout();
        // 
        // btnLosuj
        // 
        btnLosuj.Location = new Point(934, 112);
        btnLosuj.Name = "btnLosuj";
        btnLosuj.Size = new Size(277, 100);
        btnLosuj.TabIndex = 0;
        btnLosuj.Text = "Losuj";
        btnLosuj.UseVisualStyleBackColor = true;
        btnLosuj.Click += btnLosuj_Click;
        // 
        // lblWynik
        // 
        lblWynik.AutoSize = true;
        lblWynik.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWynik.Location = new Point(66, 112);
        lblWynik.Name = "lblWynik";
        lblWynik.Size = new Size(535, 100);
        lblWynik.TabIndex = 1;
        lblWynik.Text = "Brak losowania";
        // 
        // lblWylosowaneText
        // 
        lblWylosowaneText.AutoSize = true;
        lblWylosowaneText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lblWylosowaneText.Location = new Point(66, 55);
        lblWylosowaneText.Name = "lblWylosowaneText";
        lblWylosowaneText.Size = new Size(294, 45);
        lblWylosowaneText.TabIndex = 2;
        lblWylosowaneText.Text = "Wylosowane liczby:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1680, 1520);
        Controls.Add(lblWylosowaneText);
        Controls.Add(lblWynik);
        Controls.Add(btnLosuj);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnLosuj;
    private Label lblWynik;
    private Label lblWylosowaneText;
}
