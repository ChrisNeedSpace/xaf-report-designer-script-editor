using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace SampleProject1.Module.BusinessObjects
{
  [DefaultClassOptions]
  public class Store : BaseObject
  {
    public Store(Session session) : base(session) { }

    public string Name { get; set; }
    public string Description { get; set; }
  }
}
