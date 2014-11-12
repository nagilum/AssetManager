namespace AssetManager {
  partial class fmLogin {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
      this.label1 = new System.Windows.Forms.Label();
      this.tbAccountName = new System.Windows.Forms.TextBox();
      this.tbAccountKey = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btLogin = new System.Windows.Forms.Button();
      this.btClose = new System.Windows.Forms.Button();
      this.cbRememberCredentials = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(81, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Account Name:";
      // 
      // tbAccountName
      // 
      this.tbAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbAccountName.Location = new System.Drawing.Point(15, 25);
      this.tbAccountName.Name = "tbAccountName";
      this.tbAccountName.Size = new System.Drawing.Size(337, 20);
      this.tbAccountName.TabIndex = 1;
      // 
      // tbAccountKey
      // 
      this.tbAccountKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbAccountKey.Location = new System.Drawing.Point(15, 68);
      this.tbAccountKey.Name = "tbAccountKey";
      this.tbAccountKey.PasswordChar = '*';
      this.tbAccountKey.Size = new System.Drawing.Size(337, 20);
      this.tbAccountKey.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Account Key:";
      // 
      // btLogin
      // 
      this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btLogin.Location = new System.Drawing.Point(164, 133);
      this.btLogin.Name = "btLogin";
      this.btLogin.Size = new System.Drawing.Size(91, 31);
      this.btLogin.TabIndex = 4;
      this.btLogin.Text = "Login";
      this.btLogin.UseVisualStyleBackColor = true;
      this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
      // 
      // btClose
      // 
      this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btClose.Location = new System.Drawing.Point(261, 133);
      this.btClose.Name = "btClose";
      this.btClose.Size = new System.Drawing.Size(91, 31);
      this.btClose.TabIndex = 5;
      this.btClose.Text = "Close";
      this.btClose.UseVisualStyleBackColor = true;
      this.btClose.Click += new System.EventHandler(this.btClose_Click);
      // 
      // cbRememberCredentials
      // 
      this.cbRememberCredentials.AutoSize = true;
      this.cbRememberCredentials.Location = new System.Drawing.Point(15, 94);
      this.cbRememberCredentials.Name = "cbRememberCredentials";
      this.cbRememberCredentials.Size = new System.Drawing.Size(132, 17);
      this.cbRememberCredentials.TabIndex = 6;
      this.cbRememberCredentials.Text = "Remember Credentials";
      this.cbRememberCredentials.UseVisualStyleBackColor = true;
      // 
      // fmLogin
      // 
      this.AcceptButton = this.btLogin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btClose;
      this.ClientSize = new System.Drawing.Size(364, 176);
      this.ControlBox = false;
      this.Controls.Add(this.cbRememberCredentials);
      this.Controls.Add(this.btClose);
      this.Controls.Add(this.btLogin);
      this.Controls.Add(this.tbAccountKey);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbAccountName);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "fmLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new System.EventHandler(this.fmLogin_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbAccountName;
    private System.Windows.Forms.TextBox tbAccountKey;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btLogin;
    private System.Windows.Forms.Button btClose;
    private System.Windows.Forms.CheckBox cbRememberCredentials;
  }
}