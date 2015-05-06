======================================
XAF Report Designer Script Editor v1.0
======================================
-----------------------------
Compatible with XAF versions:
-----------------------------
- **XAF WinForms only**
- 14.2.7+

-----------
Description
-----------
This is a feature for **DevExpress eXpressAppFramework (XAF)** that provides a custom Quantum Whale script editor with IntelliSense for End User Report Designer:

.. image:: https://raw.github.com/KrzysztofKielce/xaf-report-designer-script-editor/master/Screenshot1.png

and

.. image:: https://raw.github.com/KrzysztofKielce/xaf-report-designer-script-editor/master/Screenshot2.png

and

.. image:: https://raw.github.com/KrzysztofKielce/xaf-report-designer-script-editor/master/Screenshot3.png

and

.. image:: https://raw.github.com/KrzysztofKielce/xaf-report-designer-script-editor/master/Screenshot4.png


**Functionality**

- INTELLI-SENSE !!!
- works like a charm
- highlight matching brackets
- and much more...

**Example of use**

Create a report, click on a designer, go to Scripts tab.

**Significant files:**

+ SampleProject1.Module.Win\\Controllers\\ShowReportDesignerController.cs
+ SampleProject1.Module.Win\\ReportDesign\\CSharpClassParser.cs
+ SampleProject1.Module.Win\\ReportDesign\\QWhaleScriptEditor.cs
+ SampleProject1.Module.Win\\ReportDesign\\ScriptEditorService.cs
+ SampleProject1.Module.Win\\ReportDesign\\SimpleScriptEditor.cs

----
NOTE
----
Project contains Quantum Whale Editor.NET **Evaluation** assemblies as I got the information from Quantum Whale support that they can be redistributed. Thank you!

------------
Installation
------------
#. Install XAF_.
#. Get the source code for this plugin from github_, either using git_, or downloading directly:

   - To download using git, install git and then type an appropriate magic command
     at the command prompt (on Linux and Windows it is a bit different)
   - To download directly, go to the `project page`_ and click **Download**

#. Convert the sample project to your current version via project converter tool (it's located in your menu start/DevExpress XX.X/Project Converter XX.X).

#. If you don't want to use the sample project, create your own and add the significant files. Each file in the repository has a namespace that indicates which project it refers to (Module, Module.Win, Module.Web, Win or Web). You need to copy the files to corresponding places in your project.

.. _XAF: http://go.devexpress.com/DevExpressDownload_UniversalTrial.aspx
.. _git: http://git-scm.com/
.. _github:
.. _project page: https://github.com/KrzysztofKielce/xaf-report-designer-script-editor.git



----------
Disclaimer
----------
This is **beta** code.  It is probably okay for production environments, but may not work exactly as expected.  Refunds will not be given.  If it breaks, you have to keep both parts.

-------
License
-------
All code herein is under the Do What The Fuck You Want To Public License (WTFPL_).

.. _WTFPL: http://www.wtfpl.net/

---------
About XAF
---------
The eXpressApp Framework (XAF) is a modern and flexible application framework that allows you to create powerful line-of-business applications that simultaneously target Windows and the Web. XAF's scaffolding of the database and UI allows you to concentrate on business rules without the many distractions and tedious tasks normally associated with Windows and Web development. XAF's modular design facilitates a plug and play approach to common business requirements such as security and reporting.

XAF's advantages when compared with a more traditional approach to app development are profound. See for yourself and learn why XAF can radically increase productivity and help you bring solutions to market faster than you've ever thought possible.

For more information, visit:

http://www.devexpress.com/Products/NET/Application_Framework/