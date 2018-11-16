Public Class Form1
    Public box(2) As Integer            ' BOX STATE INDICATION VALUE 5 IS OPEN AND 1 IS CLOSE STATE OF EACH BOX.
    Public boxpara(2, 3) As Integer     'BOXPARAMETER HOLDING ( NO OF BOX (HERE 3 BOXES), FOUR PARAMETER (X,Y,W,H) )
    Public cmnH As Integer = 30         'COMMON HEIGHT OF BOX AT CLOSE STATE

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'INITIAL PARAMETER FOR ALL BOX
        box(0) = 5      ' BOX STATE OPEN
        box(1) = 1      ' BOX STATE CLOSE 
        box(2) = 1
        'BOX 1 PARAM
        boxpara(0, 0) = 6       ' LOCATION VALUE X 
        boxpara(0, 1) = 30      ' LOCATION VALUE Y
        boxpara(0, 2) = 240     ' WIDTH OF BOX
        boxpara(0, 3) = 120     ' HEIGHT OF BOX
        'BOX 2 PARAM
        boxpara(1, 0) = 6
        boxpara(1, 1) = 62
        boxpara(1, 2) = 240
        boxpara(1, 3) = 115
        'BOX 3 PARAM
        boxpara(2, 0) = 6
        boxpara(2, 1) = 92
        boxpara(2, 2) = 240
        boxpara(2, 3) = 230

        btnGb1Op.Hide()
        btnGb1Close.Show()
        btnGb2Close.Hide()
        btnGb3Close.Hide()
        CloseOpen()
    End Sub

    Private Sub btnGb1Op_Click(sender As Object, e As EventArgs) Handles btnGb1Op.Click
        box(0) = 5
        btnGb1Op.Hide()
        btnGb1Close.Show()
        CloseOpen()
    End Sub
    Private Sub btnGb1Close_Click(sender As Object, e As EventArgs) Handles btnGb1Close.Click
        box(0) = 1
        btnGb1Op.Show()
        btnGb1Close.Hide()
        CloseOpen()
    End Sub

    Private Sub btnGb2Op_Click(sender As Object, e As EventArgs) Handles btnGb2Op.Click
        box(1) = 5
        btnGb2Op.Hide()
        btnGb2Close.Show()
        CloseOpen()
    End Sub

    Private Sub btnGb2Close_Click(sender As Object, e As EventArgs) Handles btnGb2Close.Click
        box(1) = 1
        btnGb2Op.Show()
        btnGb2Close.Hide()
        CloseOpen()
    End Sub

    Private Sub btnGb3Op_Click(sender As Object, e As EventArgs) Handles btnGb3Op.Click
        box(2) = 5
        btnGb3Op.Hide()
        btnGb3Close.Show()
        CloseOpen()
    End Sub

    Private Sub btnGb3Close_Click(sender As Object, e As EventArgs) Handles btnGb3Close.Click
        box(2) = 1
        btnGb3Op.Show()
        btnGb3Close.Hide()
        CloseOpen()
    End Sub

    Private Sub CloseOpen()
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim x As Integer
        Dim y As Integer
        Dim w As Integer
        Dim h As Integer

        Dim t As Integer = 0
        Dim ty As Integer = 0
        Dim th As Integer = 0

        For i = 0 To 2
            x = 0
            y = 0
            w = 0
            h = 0
            For j = 0 To 3
                t = boxpara(i, j)
                If j = 0 Then
                    x = t
                End If
                If j = 1 Then
                    y = t
                End If
                If j = 2 Then
                    w = t
                End If
                If j = 3 Then
                    h = t
                End If
            Next
            'BOX 1
            If i = 0 Then
                If box(i) > 1 Then
                    ty = y
                    th = h
                    gb1.SetBounds(x, ty, w, th)
                Else
                    ty = y
                    th = cmnH
                    gb1.SetBounds(x, ty, w, th)
                End If
            End If
            'BOX 2
            If i = 1 Then
                y = ty + th + 2
                If box(i) > 1 Then
                    ty = y
                    th = h
                    gb2.SetBounds(x, ty, w, th)
                Else
                    ty = y
                    th = cmnH
                    gb2.SetBounds(x, ty, w, th)
                End If
            End If
            'BOX 3
            If i = 2 Then
                y = ty + th + 2
                If box(i) > 1 Then
                    ty = y
                    th = h
                    gb3.SetBounds(x, ty, w, th)
                Else
                    ty = y
                    th = cmnH
                    gb3.SetBounds(x, ty, w, th)
                End If
            End If
        Next

    End Sub
End Class
