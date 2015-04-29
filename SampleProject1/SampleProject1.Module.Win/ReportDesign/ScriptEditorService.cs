using System;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;

namespace SampleProject1.Module.Win.ReportDesign
{
  public class ScriptEditorService : IScriptEditorService
  {
    public XRDesignMdiController DesignMdiController { get; set; }

    IScriptEditor IScriptEditorService.CreateEditor(IServiceProvider serviceProvider)
    {
      //return new SimpleScriptEditor();
      return new QWhaleScriptEditor() { DesignMdiController = DesignMdiController };
    }
  }
}
