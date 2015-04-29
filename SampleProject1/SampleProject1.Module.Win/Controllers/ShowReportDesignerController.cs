using DevExpress.ExpressApp;
using SampleProject1.Module.Win.ReportDesign;

namespace SampleProject1.Module.Win.Controllers
{
  public partial class ShowReportDesignerController : ViewController
  {
    public ShowReportDesignerController() { }

    protected override void OnActivated()
    {
      base.OnActivated();

      var reportsController = Frame.GetController<DevExpress.ExpressApp.Reports.Win.WinReportServiceController>();
      if (reportsController != null)
      {
        reportsController.DesignFormCreated -= reportsController_DesignFormCreated; // just in case
        reportsController.DesignFormCreated += reportsController_DesignFormCreated;
      }
    }

    private void reportsController_DesignFormCreated(object sender, DevExpress.ExpressApp.Reports.Win.DesignFormEventArgs e)
    {
      e.DesignForm.DesignMdiController.AddService(typeof(DevExpress.XtraReports.Design.IScriptEditorService), new ScriptEditorService { DesignMdiController = e.DesignForm.DesignMdiController });
    }

  }
}
