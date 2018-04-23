Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("HowToChangeEditorStyleInBarEditItem")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("DevExpress")>
<Assembly: AssemblyProduct("HowToChangeEditorStyleInBarEditItem")>
<Assembly: AssemblyCopyright("Copyright © DevExpress 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

#If Not SILVERLIGHT Then
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly), assembly: Guid("a4f1e08b-5e17-42fa-ba84-75fe161a63f1"), assembly: AssemblyVersion("1.0.0.0"), assembly: AssemblyFileVersion("1.0.0.0")> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
    '(used if a resource is not found in the page, 
    ' or application resource dictionaries)
    '(used if a resource is not found in the page, 
    ' app, or any theme specific resource dictionaries)
#Else
<Assembly: Guid("a4f1e08b-5e17-42fa-ba84-75fe161a63f1"), assembly: AssemblyVersion("1.0.0.0"), assembly: AssemblyFileVersion("1.0.0.0")>
#End If

#If SILVERLIGHT Then
#End If

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below: