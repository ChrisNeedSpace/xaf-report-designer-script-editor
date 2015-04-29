using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace SampleProject1.Module.Win
{
  [ToolboxItemFilter("Xaf.Platform.Win")]
  public sealed partial class SampleProject1WindowsFormsModule : ModuleBase
  {
    public SampleProject1WindowsFormsModule()
    {
      InitializeComponent();
    }
    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
    {
      return ModuleUpdater.EmptyModuleUpdaters;
    }
  }
}
