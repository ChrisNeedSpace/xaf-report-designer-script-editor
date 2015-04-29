using System;
using System.Drawing;
using QWhale.Syntax;
using QWhale.Syntax.CodeCompletion;
using QWhale.Syntax.Parsers;

namespace SampleProject1.Module.Win.ReportDesign
{
  /// <summary>
  /// A specialised parser which is used to maintain method declarations only.
  /// </summary>
  public class CSharpClassParser : CsParser
  {
    #region ctor

    public CSharpClassParser() : this(CSharpClassParser.DefaultCustomNamespace, CSharpClassParser.DefaultCustomClass) { }

    public CSharpClassParser(string classNamespace, string className) : base()
    {
      this.ClassNamespace = classNamespace;
      this.ClassName = className;
    }

    #endregion

    #region ClassName

    public const string DefaultCustomClass = "CustomClass";
    private string _className = DefaultCustomClass;
    public string ClassName
    {
      get { return _className; }
      set { _className = value; }
    }

    #endregion

    #region ClassNamespace

    public const string DefaultCustomNamespace = "CustomNamespace";
    private string _classNamespace = DefaultCustomNamespace;
    public string ClassNamespace
    {
      get { return _classNamespace; }
      set { _classNamespace = value; }
    }

    #endregion

    protected override bool SkipToDeclarationStart(int nodeType)
    {
      if (nodeType == (int)NetNodeType.Class)
        return true;
      else
        return SkipTo((int)CsLexerToken.Open_brace);
    }

    protected bool ParseCustomClass()
    {
      bool result = true;

      ISyntaxNode node = new SyntaxNode(TokenPosition, this.ClassName, (int)NetNodeType.Class, SyntaxNodeOptions.BackIndentation);
      AddNode(node);
      SyntaxTree.Push(node);
      try
      {
        if (!ParseClassBody())
          result = false;
      }
      finally
      {
        SyntaxTree.Pop();
      }
      node.Range.EndPoint = prevPosition;

      return result;
    }

    protected bool ParseCustomNamespace()
    {
      bool result = true;

      ISyntaxNode node = new SyntaxNode(TokenPosition, this.ClassNamespace, (int)NetNodeType.Namespace, SyntaxNodeOptions.BackIndentation);
      AddNode(node);
      SyntaxTree.Push(node);
      try
      {
        if (!ParseCustomClass())
          result = false;
      }
      finally
      {
        SyntaxTree.Pop();
      }
      node.Range.EndPoint = prevPosition;

      return result;
    }

    protected override bool ParseUnit()
    {
      bool result = false;

      if (SyntaxTree != null)
      {
        ISyntaxNode node = SyntaxTree.Root;
        node.NodeType = (int)NetNodeType.Unit;
        node.Position = Point.Empty;
        result = ParseCustomNamespace();
        SyntaxTree.Root.Range.EndPoint = prevPosition;
        result = true;
      }

      return result;
    }
  }
}
