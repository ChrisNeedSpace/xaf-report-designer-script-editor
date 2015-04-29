using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;

namespace SampleProject1.Module.Win.ReportDesign
{
  public class QWhaleScriptEditor : QWhale.Editor.SyntaxEdit, IScriptEditor
  {
    private static Dictionary<string, CSharpClassParser> _classParsers = new Dictionary<string, CSharpClassParser>();
    public XRDesignMdiController DesignMdiController { get; set; }
    private string previousText;

    public QWhaleScriptEditor()
    {
      CSharpClassParser parser = null;
      string name = string.Concat(CSharpClassParser.DefaultCustomClass, "_", "ReportData");

      if (!_classParsers.TryGetValue(name, out parser))
      {
        parser = new CSharpClassParser(CSharpClassParser.DefaultCustomNamespace, name);
        parser.RegisterAllAssemblies();
        //parser.RegisterNamespace("System");
        _classParsers.Add(name, parser);
      }

      this.Lexer = parser;
      this.Outlining.AllowOutlining = true;
      this.Braces.BracesOptions = QWhale.Editor.TextSource.BracesOptions.Highlight;
      this.Braces.UseRoundRect = true;
      // We can't really show line numbers, as we add the using clause pre compile.
      // Show line numbers
      this.Gutter.Width = 35;
      this.Gutter.Options |= QWhale.Editor.GutterOptions.PaintLineNumbers;
      this.Gutter.LineNumbersStart = GetLineNumberStart();
      // Adjust the tabstops.
      if (this.Lines.TabStops.Length == 1)
        this.Lines.TabStops[0] = 2;
    }

    #region ISyntaxEditor Members

    bool IScriptEditor.Modified
    {
      get { return base.Modified; }
      set { base.Modified = value; }
    }

    string IScriptEditor.Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    void IScriptEditor.AppendText(string text)
    {
      this.Text += text;
    }

    int IScriptEditor.LinesCount
    {
      get { return Lines.Count; }
    }

    void IScriptEditor.SetCaretPosition(int line, int column)
    {
      SetCaretPositionCore(line, column);
    }

    void SetCaretPositionCore(int line, int column)
    {
      this.Focus();
      this.MoveTo(new System.Drawing.Point(column, line));
    }

    void IScriptEditor.HighlightErrors(System.CodeDom.Compiler.CompilerErrorCollection errors)
    {
      if (errors.Count == 0) return;
      int line = Math.Max(0, errors[0].Line - 1);
      int column = Math.Max(0, errors[0].Column - 1);
      BeginInvoke(new Action<int, int>(SetCaretPositionCore), line, column);
    }

    #endregion

    #region GetLineNumberStart

    private int GetLineNumberStart()
    {
      return 1;
    }

    #endregion

    #region OnTextChanged

    protected override void OnTextChanged(EventArgs e)
    {
      base.OnTextChanged(e);

      if (DesignMdiController != null && DesignMdiController.ActiveDesignPanel != null)
      {
        if (DesignMdiController.ActiveDesignPanel.ReportState != ReportState.Changed)
        {
          //DesignMdiController.ActiveDesignPanel.ReportState = ReportState.Changed; // does not work properly.

          // pretty dummy workaround:
          DesignMdiController.ActiveDesignPanel.SelectNextControl(this, true, true, false, false);
          this.Focus();
        }
      }
    }

    #endregion

  }
}
