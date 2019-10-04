Public Class Form1
    Dim saldo As Integer = 10000

    Public Sub ingresarNumero(ByVal numero As Integer)
        If Panel_pin.Visible AndAlso txt_pin.Text.Length < 4 Then
            txt_pin.Text &= numero
        End If

        If panel_deposito.Visible Then
            txt_deposito.Text &= numero
        End If

        If Panel_extraccion2.Visible Then
            txt_extraccion.Text &= numero
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        ingresarNumero(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ingresarNumero(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ingresarNumero(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ingresarNumero(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ingresarNumero(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ingresarNumero(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ingresarNumero(6)
    End Sub

    Private Sub Button07_Click(sender As Object, e As EventArgs) Handles Button07.Click
        ingresarNumero(7)
    End Sub

    Private Sub Button08_Click(sender As Object, e As EventArgs) Handles Button08.Click
        ingresarNumero(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ingresarNumero(9)
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If Panel_pin.Visible Then
            txt_pin.Clear()
        End If
        If panel_deposito.Visible Then
            txt_deposito.Clear()
        End If
        If Panel_extraccion2.Visible Then
            txt_extraccion.Clear()
        End If
    End Sub

    Private Sub Btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Panel_pin.Visible And txt_pin.Text.Length = 4 Then
            Panel_pin.Visible = False
            Panel_principal.Visible = True
            txt_pin.Clear()
        End If

        If panel_deposito.Visible And txt_deposito.Text.Length > 0 Then
            saldo += txt_deposito.Text
            panel_deposito.Visible = False
            Panel_depositoRE.Visible = True
            txt_deposito.Clear()
        End If

        If Panel_extraccion2.Visible And txt_extraccion.Text.Length > 0 Then
            If saldo >= txt_extraccion.Text Then
                saldo -= txt_extraccion.Text
                Panel_extraccion2.Visible = False
                Panel_depositoRE.Visible = True
            Else
                Panel_extraccion2.Visible = False
                Panel_saldoInsuficiente.Visible = True
            End If
        End If
    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_pin.Clear()
        txt_deposito.Clear()
        txt_extraccion.Clear()
        Panel_pin.Visible = True
        Panel_principal.Visible = False
        panel_deposito.Visible = False
        Panel_depositoRE.Visible = False
        Panel_saldoActual.Visible = False
    End Sub

    Private Sub Btn_opcion1_Click(sender As Object, e As EventArgs) Handles btn_opcion1.Click
        If Panel_principal.Visible Then
            Panel_principal.Visible = False
            Panel_saldoActual.Visible = True
            txt_muestraSaldo.Text = saldo
            Exit Sub
        End If

        If panel_extraccion1.Visible Then
            If saldo >= 500 Then
                saldo -= 500
                panel_extraccion1.Visible = False
                Panel_depositoRE.Visible = True
                Exit Sub
            Else
                panel_extraccion1.Visible = False
                Panel_saldoInsuficiente.Visible = True
                Exit Sub
            End If

        End If
    End Sub

    Private Sub Btn_opcion3_Click(sender As Object, e As EventArgs) Handles btn_opcion3.Click
        If Panel_principal.Visible Then
            Panel_principal.Visible = False
            panel_deposito.Visible = True
            Exit Sub
        End If

        If Panel_saldoActual.Visible Then
            Panel_saldoActual.Visible = False
            Panel_principal.Visible = True
            Exit Sub
        End If

        If Panel_depositoRE.Visible Then
            Panel_depositoRE.Visible = False
            Panel_pin.Visible = True
            Exit Sub
        End If

        If Panel_saldoInsuficiente.Visible Then
            Panel_saldoInsuficiente.Visible = False
            Panel_principal.Visible = True
            Exit Sub
        End If

        If panel_extraccion1.Visible Then
            panel_extraccion1.Visible = False
            Panel_extraccion2.Visible = True
            txt_extraccion.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Btn_opcion2_Click(sender As Object, e As EventArgs) Handles btn_opcion2.Click
        If Panel_depositoRE.Visible Then
            Panel_depositoRE.Visible = False
            Panel_principal.Visible = True
            Exit Sub
        End If

        If Panel_principal.Visible Then
            Panel_principal.Visible = False
            panel_extraccion1.Visible = True
            Exit Sub
        End If

        If panel_extraccion1.Visible Then
            If saldo >= 1000 Then
                saldo -= 1000
                panel_extraccion1.Visible = False
                Panel_depositoRE.Visible = True
            Else
                panel_extraccion1.Visible = False
                Panel_saldoInsuficiente.Visible = True
            End If
            Exit Sub
        End If
    End Sub

End Class
