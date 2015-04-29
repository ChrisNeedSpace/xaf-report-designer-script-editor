namespace SampleProject1.Win
{
  partial class SampleProject1WindowsFormsApplication
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
      this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
      this.module3 = new SampleProject1.Module.SampleProject1Module();
      this.module4 = new SampleProject1.Module.Win.SampleProject1WindowsFormsModule();

      this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // sqlConnection1
      // 
      this.sqlConnection1.ConnectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=SampleProject1";
      this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
      // 
      // SampleProject1WindowsFormsApplication
      // 
      this.ApplicationName = "SampleProject1";
      this.Connection = this.sqlConnection1;
      this.Modules.Add(this.module1);
      this.Modules.Add(this.module2);
      this.Modules.Add(this.module3);
      this.Modules.Add(this.module4);
      this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.SampleProject1WindowsFormsApplication_DatabaseVersionMismatch);
      this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.SampleProject1WindowsFormsApplication_CustomizeLanguagesList);

      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.ExpressApp.SystemModule.SystemModule module1;
    private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
    private SampleProject1.Module.SampleProject1Module module3;
    private SampleProject1.Module.Win.SampleProject1WindowsFormsModule module4;
    private System.Data.SqlClient.SqlConnection sqlConnection1;
  }
}
