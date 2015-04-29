using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;


namespace SampleProject1.Module
{
  public sealed partial class SampleProject1Module : ModuleBase
  {
    public SampleProject1Module()
    {
      InitializeComponent();
    }
    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
    {
      ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
      return new ModuleUpdater[] { updater };
    }
  }
}
