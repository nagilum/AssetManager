using System;

namespace AssetManager {
  partial class fmAssets {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAssets));
      this.lvAssets = new System.Windows.Forms.ListView();
      this.chAssetID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetLastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetIsStreamable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chAssetState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.msMain = new System.Windows.Forms.MenuStrip();
      this.muFile = new System.Windows.Forms.ToolStripMenuItem();
      this.miFileLogin = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.muAssets = new System.Windows.Forms.ToolStripMenuItem();
      this.miAssetsRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.scMain = new System.Windows.Forms.SplitContainer();
      this.lvFiles = new System.Windows.Forms.ListView();
      this.chFileID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileMimeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileLastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileIsEncrypted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFileIsPrimary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ssMain = new System.Windows.Forms.StatusStrip();
      this.slStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
      this.msMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
      this.scMain.Panel1.SuspendLayout();
      this.scMain.Panel2.SuspendLayout();
      this.scMain.SuspendLayout();
      this.ssMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // lvAssets
      // 
      this.lvAssets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAssetID,
            this.chAssetName,
            this.chAssetFiles,
            this.chAssetType,
            this.chAssetCreated,
            this.chAssetLastModified,
            this.chAssetIsStreamable,
            this.chAssetState});
      this.lvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvAssets.FullRowSelect = true;
      this.lvAssets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvAssets.Location = new System.Drawing.Point(0, 0);
      this.lvAssets.MultiSelect = false;
      this.lvAssets.Name = "lvAssets";
      this.lvAssets.Size = new System.Drawing.Size(1405, 386);
      this.lvAssets.TabIndex = 0;
      this.lvAssets.UseCompatibleStateImageBehavior = false;
      this.lvAssets.View = System.Windows.Forms.View.Details;
      this.lvAssets.SelectedIndexChanged += new System.EventHandler(this.lvAssets_SelectedIndexChanged);
      // 
      // chAssetID
      // 
      this.chAssetID.Text = "ID";
      this.chAssetID.Width = 300;
      // 
      // chAssetName
      // 
      this.chAssetName.Text = "Name";
      this.chAssetName.Width = 300;
      // 
      // chAssetFiles
      // 
      this.chAssetFiles.Text = "Files";
      // 
      // chAssetType
      // 
      this.chAssetType.Text = "Type";
      this.chAssetType.Width = 120;
      // 
      // chAssetCreated
      // 
      this.chAssetCreated.Text = "Created";
      this.chAssetCreated.Width = 150;
      // 
      // chAssetLastModified
      // 
      this.chAssetLastModified.Text = "Last Modified";
      this.chAssetLastModified.Width = 150;
      // 
      // chAssetIsStreamable
      // 
      this.chAssetIsStreamable.Text = "Is Streamable";
      this.chAssetIsStreamable.Width = 80;
      // 
      // chAssetState
      // 
      this.chAssetState.Text = "State";
      this.chAssetState.Width = 120;
      // 
      // msMain
      // 
      this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muFile,
            this.muAssets});
      this.msMain.Location = new System.Drawing.Point(0, 0);
      this.msMain.Name = "msMain";
      this.msMain.Size = new System.Drawing.Size(1405, 24);
      this.msMain.TabIndex = 1;
      this.msMain.Text = "menuStrip1";
      // 
      // muFile
      // 
      this.muFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileLogin,
            this.toolStripMenuItem1,
            this.miFileExit});
      this.muFile.Name = "muFile";
      this.muFile.Size = new System.Drawing.Size(37, 20);
      this.muFile.Text = "&File";
      // 
      // miFileLogin
      // 
      this.miFileLogin.Name = "miFileLogin";
      this.miFileLogin.Size = new System.Drawing.Size(104, 22);
      this.miFileLogin.Text = "&Login";
      this.miFileLogin.Click += new System.EventHandler(this.miFileLogin_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 6);
      // 
      // miFileExit
      // 
      this.miFileExit.Name = "miFileExit";
      this.miFileExit.Size = new System.Drawing.Size(104, 22);
      this.miFileExit.Text = "E&xit";
      this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
      // 
      // muAssets
      // 
      this.muAssets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAssetsRefresh});
      this.muAssets.Name = "muAssets";
      this.muAssets.Size = new System.Drawing.Size(52, 20);
      this.muAssets.Text = "&Assets";
      // 
      // miAssetsRefresh
      // 
      this.miAssetsRefresh.Name = "miAssetsRefresh";
      this.miAssetsRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
      this.miAssetsRefresh.Size = new System.Drawing.Size(132, 22);
      this.miAssetsRefresh.Text = "&Refresh";
      this.miAssetsRefresh.Click += new System.EventHandler(this.miAssetsRefresh_Click);
      // 
      // scMain
      // 
      this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scMain.Location = new System.Drawing.Point(0, 27);
      this.scMain.Name = "scMain";
      this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // scMain.Panel1
      // 
      this.scMain.Panel1.Controls.Add(this.lvAssets);
      // 
      // scMain.Panel2
      // 
      this.scMain.Panel2.Controls.Add(this.lvFiles);
      this.scMain.Size = new System.Drawing.Size(1405, 835);
      this.scMain.SplitterDistance = 386;
      this.scMain.TabIndex = 2;
      // 
      // lvFiles
      // 
      this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileID,
            this.chFileName,
            this.chFileSize,
            this.chFileMimeType,
            this.chFileCreated,
            this.chFileLastModified,
            this.chFileIsEncrypted,
            this.chFileIsPrimary});
      this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvFiles.FullRowSelect = true;
      this.lvFiles.Location = new System.Drawing.Point(0, 0);
      this.lvFiles.Name = "lvFiles";
      this.lvFiles.Size = new System.Drawing.Size(1405, 445);
      this.lvFiles.TabIndex = 0;
      this.lvFiles.UseCompatibleStateImageBehavior = false;
      this.lvFiles.View = System.Windows.Forms.View.Details;
      // 
      // chFileID
      // 
      this.chFileID.Text = "ID";
      this.chFileID.Width = 300;
      // 
      // chFileName
      // 
      this.chFileName.Text = "Name";
      this.chFileName.Width = 350;
      // 
      // chFileSize
      // 
      this.chFileSize.Text = "Size";
      // 
      // chFileMimeType
      // 
      this.chFileMimeType.Text = "Mime Type";
      this.chFileMimeType.Width = 200;
      // 
      // chFileCreated
      // 
      this.chFileCreated.Text = "Created";
      this.chFileCreated.Width = 150;
      // 
      // chFileLastModified
      // 
      this.chFileLastModified.Text = "Last Modified";
      this.chFileLastModified.Width = 150;
      // 
      // chFileIsEncrypted
      // 
      this.chFileIsEncrypted.Text = "Is Encrypted";
      this.chFileIsEncrypted.Width = 80;
      // 
      // chFileIsPrimary
      // 
      this.chFileIsPrimary.Text = "IsPrimary";
      this.chFileIsPrimary.Width = 80;
      // 
      // ssMain
      // 
      this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatus,
            this.pbStatus});
      this.ssMain.Location = new System.Drawing.Point(0, 865);
      this.ssMain.Name = "ssMain";
      this.ssMain.Size = new System.Drawing.Size(1405, 22);
      this.ssMain.TabIndex = 3;
      this.ssMain.Text = "statusStrip1";
      // 
      // slStatus
      // 
      this.slStatus.Name = "slStatus";
      this.slStatus.Size = new System.Drawing.Size(1390, 17);
      this.slStatus.Spring = true;
      this.slStatus.Text = "Ready...";
      this.slStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pbStatus
      // 
      this.pbStatus.Name = "pbStatus";
      this.pbStatus.Size = new System.Drawing.Size(100, 16);
      this.pbStatus.Visible = false;
      // 
      // fmAssets
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1405, 887);
      this.Controls.Add(this.ssMain);
      this.Controls.Add(this.msMain);
      this.Controls.Add(this.scMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.msMain;
      this.Name = "fmAssets";
      this.Text = "Asset Manager";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Shown += new System.EventHandler(this.fmAssets_Shown);
      this.msMain.ResumeLayout(false);
      this.msMain.PerformLayout();
      this.scMain.Panel1.ResumeLayout(false);
      this.scMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
      this.scMain.ResumeLayout(false);
      this.ssMain.ResumeLayout(false);
      this.ssMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lvAssets;
    private System.Windows.Forms.ColumnHeader chAssetID;
    private System.Windows.Forms.ColumnHeader chAssetName;
    private System.Windows.Forms.ColumnHeader chAssetFiles;
    private System.Windows.Forms.ColumnHeader chAssetType;
    private System.Windows.Forms.ColumnHeader chAssetCreated;
    private System.Windows.Forms.ColumnHeader chAssetLastModified;
    private System.Windows.Forms.ColumnHeader chAssetIsStreamable;
    private System.Windows.Forms.ColumnHeader chAssetState;
    private System.Windows.Forms.MenuStrip msMain;
    private System.Windows.Forms.ToolStripMenuItem muFile;
    private System.Windows.Forms.ToolStripMenuItem miFileLogin;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem miFileExit;
    private System.Windows.Forms.ToolStripMenuItem muAssets;
    private System.Windows.Forms.ToolStripMenuItem miAssetsRefresh;
    private System.Windows.Forms.SplitContainer scMain;
    private System.Windows.Forms.StatusStrip ssMain;
    private System.Windows.Forms.ToolStripStatusLabel slStatus;
    private System.Windows.Forms.ToolStripProgressBar pbStatus;
    private System.Windows.Forms.ListView lvFiles;
    private System.Windows.Forms.ColumnHeader chFileID;
    private System.Windows.Forms.ColumnHeader chFileName;
    private System.Windows.Forms.ColumnHeader chFileSize;
    private System.Windows.Forms.ColumnHeader chFileMimeType;
    private System.Windows.Forms.ColumnHeader chFileCreated;
    private System.Windows.Forms.ColumnHeader chFileLastModified;
    private System.Windows.Forms.ColumnHeader chFileIsEncrypted;
    private System.Windows.Forms.ColumnHeader chFileIsPrimary;
  }
}