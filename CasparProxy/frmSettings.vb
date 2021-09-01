Public Class frmSettings

   Private _Settings As Settings

   Public WriteOnly Property Settings As Settings
      Set(value As Settings)
         _Settings = value
      End Set
   End Property
   Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Loader.Load(Me, Loader.CreateDarkTheme)

      If _Settings IsNot Nothing Then

         bsMappings.DataSource = _Settings.ServerMappings

      End If

   End Sub

   Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

      If _Settings IsNot Nothing Then

         Dim map As ServerMapping = New ServerMapping

         _Settings.ServerMappings.Add(map)

         bsMappings.ResetBindings(False)
         bsMappings.Position = bsMappings.IndexOf(map)

      End If

   End Sub

   Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

      If _Settings IsNot Nothing Then

         Dim map As ServerMapping = CType(bsMappings.Current, ServerMapping)

         _Settings.ServerMappings.Remove(map)

         bsMappings.ResetBindings(False)
         bsMappings.MoveFirst()

      End If

   End Sub

   Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
      DialogResult = DialogResult.OK
      Close()
   End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      DialogResult = DialogResult.Cancel
      Close()
   End Sub

End Class