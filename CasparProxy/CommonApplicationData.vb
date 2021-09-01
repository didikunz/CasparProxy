Imports System.IO
Imports System.Security.AccessControl
Imports System.Security.Principal

''' <summary>
''' Simplifies the creation of folders in the CommonApplicationData folder
''' and setting of permissions for all users.
''' </summary>
Public Class CommonApplicationData

   Private applicationFolder As String
   Private companyFolder As String
   Private Shared ReadOnly directory As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

   ''' <summary>
   ''' Creates a new instance of this class creating the specified company and application folders
   ''' if they don't already exist and optionally allows write/modify to all users.
   ''' </summary>
   ''' <param name="companyFolder">The name of the company's folder (normally the company name).</param>
   ''' <param name="applicationFolder">The name of the application's folder (normally the application name).</param>
   ''' <remarks>If the application folder already exists then permissions if requested are NOT altered.</remarks>
   Public Sub New(companyFolder As String, applicationFolder As String)
      Me.New(companyFolder, applicationFolder, False)
   End Sub

   ''' <summary>
   ''' Creates a new instance of this class creating the specified company and application folders
   ''' if they don't already exist and optionally allows write/modify to all users.
   ''' </summary>
   ''' <param name="companyFolder">The name of the company's folder (normally the company name).</param>
   ''' <param name="applicationFolder">The name of the application's folder (normally the application name).</param>
   ''' <param name="allUsers">true to allow write/modify to all users; otherwise, false.</param>
   ''' <remarks>If the application folder already exists then permissions if requested are NOT altered.</remarks>
   Public Sub New(companyFolder As String, applicationFolder As String, allUsers As Boolean)
      Me.applicationFolder = applicationFolder
      Me.companyFolder = companyFolder
      CreateFolders(allUsers)
   End Sub

   ''' <summary>
   ''' Gets the path of the application's data folder.
   ''' </summary>
   Public ReadOnly Property ApplicationFolderPath() As String
      Get
         Return Path.Combine(CompanyFolderPath, applicationFolder)
      End Get
   End Property

   ''' <summary>
   ''' Gets the path of the company's data folder.
   ''' </summary>
   Public ReadOnly Property CompanyFolderPath() As String
      Get
         Return Path.Combine(directory, companyFolder)
      End Get
   End Property

   Private Sub CreateFolders(allUsers As Boolean)
      Dim directoryInfo As DirectoryInfo
      Dim directorySecurity As DirectorySecurity
      Dim rule As AccessRule
      Dim securityIdentifier As New SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, Nothing)
      If Not IO.Directory.Exists(CompanyFolderPath) Then
         directoryInfo = IO.Directory.CreateDirectory(CompanyFolderPath)
         Dim modified As Boolean
         directorySecurity = directoryInfo.GetAccessControl()
         rule = New FileSystemAccessRule(securityIdentifier, FileSystemRights.Write Or FileSystemRights.ReadAndExecute Or FileSystemRights.Modify, AccessControlType.Allow)
         directorySecurity.ModifyAccessRule(AccessControlModification.Add, rule, modified)
         directoryInfo.SetAccessControl(directorySecurity)
      End If
      If Not IO.Directory.Exists(ApplicationFolderPath) Then
         directoryInfo = IO.Directory.CreateDirectory(ApplicationFolderPath)
         If allUsers Then
            Dim modified As Boolean
            directorySecurity = directoryInfo.GetAccessControl()
            rule = New FileSystemAccessRule(securityIdentifier, FileSystemRights.Write Or FileSystemRights.ReadAndExecute Or FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow)
            directorySecurity.ModifyAccessRule(AccessControlModification.Add, rule, modified)
            directoryInfo.SetAccessControl(directorySecurity)
         End If
      End If
   End Sub

   ''' <summary>
   ''' Returns the path of the application's data folder.
   ''' </summary>
   ''' <returns>The path of the application's data folder.</returns>
   Public Overrides Function ToString() As String
      Return ApplicationFolderPath
   End Function

End Class
