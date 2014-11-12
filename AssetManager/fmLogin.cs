using System;
using System.Windows.Forms;

namespace AssetManager {
  public partial class fmLogin : Form {
    public fmLogin() {
      InitializeComponent();
    }

    /// <summary>
    /// Account name from the textbox.
    /// </summary>
    public string AccountName {
      get { return this.tbAccountName.Text.Trim(); }
    }

    /// <summary>
    /// Account key from the textbox.
    /// </summary>
    public string AccountKey {
      get { return this.tbAccountKey.Text.Trim(); }
    }

    /// <summary>
    /// Load saved credentials.
    /// </summary>
    private void fmLogin_Load(object sender, EventArgs e) {
      this.tbAccountName.Text = Properties.Settings.Default.AccountName;
      this.tbAccountKey.Text = Properties.Settings.Default.AccountKey;

      if (this.tbAccountName.Text.Trim() != "" ||
          this.tbAccountKey.Text.Trim() != "")
        this.cbRememberCredentials.Checked = true;
    }

    /// <summary>
    /// Validate textboxes and ok the dialog.
    /// </summary>
    private void btLogin_Click(object sender, EventArgs e) {
      if (this.tbAccountName.Text.Trim() == "" ||
          this.tbAccountKey.Text.Trim() == "") {
        MessageBox.Show(
          @"You must enter both an account name and key to continue.",
          @"Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);

        return;
      }

      if (this.cbRememberCredentials.Checked) {
        Properties.Settings.Default.AccountName = this.tbAccountName.Text.Trim();
        Properties.Settings.Default.AccountKey = this.tbAccountKey.Text.Trim();
      }
      else {
        Properties.Settings.Default.AccountName = null;
        Properties.Settings.Default.AccountKey = null;
      }

      Properties.Settings.Default.Save();

      this.DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Cancel the dialog.
    /// </summary>
    private void btClose_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
    }
  }
}
