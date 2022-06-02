Module EstructuraArt
    Structure Estructurearticulos
        <VBFixedString(3)> Dim id As String
        <VBFixedString(20)> Dim Nombre As String
        <VBFixedString(20)> Dim Categoria As String
        <VBFixedString(20)> Dim ancho As String
        <VBFixedString(20)> Dim Largo As String
        <VBFixedString(20)> Dim Color As String
        Dim Precio As Single
        Dim Stock As Integer
        <VBFixedString(20)> Dim Proveedor As String
        <VBFixedString(20)> Dim RutaImagen As String
    End Structure

End Module
