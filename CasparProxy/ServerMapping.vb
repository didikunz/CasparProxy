Imports CasparObjects.CasparCG

<Serializable>
Public Class ServerMapping

   Public Property Name As String = "(New Mapping)"
   Public Property Channels As String = ""
   Public Property ServerAdress As String = "localhost"
   Public Property Port As Integer = 5250
   Public Property CasparExePath As String = ""

   Public Sub New()
   End Sub

   Public Sub New(mappingName As String)
      Name = mappingName
      Channels = "1"
   End Sub

   Public Sub New(mappingName As String, channelList As String)
      Name = mappingName
      Channels = channelList
   End Sub

End Class
