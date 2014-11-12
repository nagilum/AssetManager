using Microsoft.WindowsAzure.MediaServices.Client;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace AssetManager {
  public partial class fmAssets : Form {
    public fmAssets() {
      InitializeComponent();
    }

    /// <summary>
    /// The main cloud context.
    /// </summary>
    private CloudMediaContext context;

    /// <summary>
    /// Display the login form and fetch all the assets.
    /// </summary>
    private void fmAssets_Shown(object sender, EventArgs e) {
      if (!this.loginToAzure())
        return;

      this.loadAssets();
      this.loadSelectedAsset();
    }

    /// <summary>
    /// Load all files related to the selected asset.
    /// </summary>
    private void lvAssets_SelectedIndexChanged(object sender, EventArgs e) {
      this.loadSelectedAsset();
    }

    /// <summary>
    /// Login to a new account.
    /// </summary>
    private void miFileLogin_Click(object sender, EventArgs e) {
      if (!this.loginToAzure())
        return;

      this.loadAssets();
      this.loadSelectedAsset();
    }

    /// <summary>
    /// Close and exit the application.
    /// </summary>
    private void miFileExit_Click(object sender, EventArgs e) {
      this.Close();
    }

    /// <summary>
    /// Refresh the list of assets from the cloud.
    /// </summary>
    private void miAssetsRefresh_Click(object sender, EventArgs e) {
      this.loadAssets();
      this.loadSelectedAsset();
    }

    /// <summary>
    /// Formats file size into human readable text.
    /// </summary>
    /// <param name="bytes">Amount of bytes to format.</param>
    /// <returns>Formatted text.</returns>
    private static string formatFileSize(long bytes) {
      var ext = "";

      string[] exts = {
        " KB",
        " MB",
        " GB",
        " TB",
        " PB",
        " EB"
      };

      for (var i = 6; i > 0; i--) {
        if (!(bytes > Math.Pow(1024, i)))
          continue;

        bytes /= (long) Math.Pow(1024, i);
        ext = exts[i - 1];
        break;
      }

      return bytes.ToString(CultureInfo.CurrentCulture) + ext;
    }

    /// <summary>
    /// Load and display a list of all assets.
    /// </summary>
    private void loadAssets() {
      this.Cursor = Cursors.WaitCursor;
      this.lvAssets.Items.Clear();

      this.pbStatus.Value = 0;
      this.pbStatus.Maximum = this.context.Assets.Count();
      this.pbStatus.Visible = true;

      Application.DoEvents();

      foreach (var asset in this.context.Assets) {
        var listItem = new ListViewItem(asset.Id) {
          Tag = asset.Id
        };

        listItem.SubItems.AddRange(
          new[] {
            asset.Name,
            asset.AssetFiles.Count().ToString(CultureInfo.CurrentCulture),
            asset.AssetType.ToString(),
            asset.Created.ToString(CultureInfo.CurrentCulture),
            asset.LastModified.ToString(CultureInfo.CurrentCulture),
            asset.IsStreamable.ToString(),
            asset.State.ToString()
          });

        this.lvAssets.Items.Add(listItem);
        this.pbStatus.Value += 1;

        Application.DoEvents();
      }

      this.Cursor = Cursors.Default;
      this.pbStatus.Visible = false;
    }

    /// <summary>
    /// Load and display all files under the selected asset.
    /// </summary>
    private void loadSelectedAsset() {
      if (this.lvAssets.SelectedItems.Count == 0)
        return;

      var id = this.lvAssets.SelectedItems[0].Text;
      var asset = this.context.Assets.ToList().SingleOrDefault(a => a.Id == id);

      if (asset == null)
        return;

      this.Cursor = Cursors.WaitCursor;
      this.lvFiles.Items.Clear();

      this.pbStatus.Value = 0;
      this.pbStatus.Maximum = asset.AssetFiles.Count();
      this.pbStatus.Visible = true;

      Application.DoEvents();

      foreach (var assetFile in asset.AssetFiles) {
        var listItem = new ListViewItem(assetFile.Id) {
          Tag = assetFile.Id
        };

        listItem.SubItems.AddRange(
          new[] {
            assetFile.Name,
            formatFileSize(assetFile.ContentFileSize),
            assetFile.MimeType,
            assetFile.Created.ToString(CultureInfo.CurrentCulture),
            assetFile.LastModified.ToString(CultureInfo.CurrentCulture),
            assetFile.IsEncrypted.ToString(),
            assetFile.IsPrimary.ToString()
          });

        this.lvFiles.Items.Add(listItem);
        this.pbStatus.Value += 1;

        Application.DoEvents();
      }

      this.Cursor = Cursors.Default;
      this.pbStatus.Visible = false;
    }

    /// <summary>
    /// Displays the login form to the user and attempt to connect to the Azure cloud.
    /// </summary>
    /// <returns>Success</returns>
    private bool loginToAzure() {
      var loginForm = new fmLogin();

      if (loginForm.ShowDialog(this) != DialogResult.OK)
        return false;

      var accountName = loginForm.AccountName;
      var accountKey = loginForm.AccountKey;

      try {
        this.context = new CloudMediaContext(
          new MediaServicesCredentials(
            accountName,
            accountKey));
      }
      catch (Exception ex) {
        MessageBox.Show(
          ex.Message,
          @"Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);

        return false;
      }

      return true;
    }
  }
}
