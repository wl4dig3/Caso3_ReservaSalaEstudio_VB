' Importa DateTime, EventArgs y otros tipos fundamentales.
Imports System
' Importa Form, MessageBox y los tipos asociados a Windows Forms.
Imports System.Windows.Forms

' Espacio de nombres del Caso 3.
Namespace PRO205.Semana7.Caso3.ReservaSalaEstudio.VB
    ' Formulario que registra reservas simples de salas de estudio.
    Partial Public Class FrmReservaSalaEstudio
        ' Hereda las capacidades de una ventana Windows Forms.
        Inherits Form

        ' Constructor del formulario.
        Public Sub New()
            ' Crea y configura los controles definidos en el archivo Designer.
            InitializeComponent()
        End Sub

        ' Evento de sistema Load: se ejecuta cuando el formulario termina de cargarse.
        Private Sub FrmReservaSalaEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Agrega las salas disponibles, incluida la Sala 4.
            cboSala.Items.AddRange(New Object() {"Sala 1", "Sala 2", "Sala 3", "Sala 4"})
            ' Agrega los bloques horarios disponibles.
            cboBloque.Items.AddRange(New Object() {"09:00 - 10:00", "10:15 - 11:15", "11:30 - 12:30", "14:00 - 15:00", "15:15 - 16:15"})
            ' Impide seleccionar una fecha anterior a hoy.
            dtpFecha.MinDate = Date.Today
            ' Selecciona la fecha actual como valor inicial.
            dtpFecha.Value = Date.Today
            ' Define una persona como valor inicial.
            nudPersonas.Value = 1D
            ' Muestra una instrucción inicial.
            lblEstado.Text = "Complete los datos de la reserva."
            ' Actualiza el mensaje de capacidad.
            ActualizarCapacidad()
        End Sub

        ' Evento de usuario: ocurre al cambiar la sala seleccionada.
        Private Sub cboSala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSala.SelectedIndexChanged
            ' Recalcula el mensaje asociado a la capacidad.
            ActualizarCapacidad()
        End Sub

        ' Evento de usuario: ocurre al cambiar la cantidad de personas.
        Private Sub nudPersonas_ValueChanged(sender As Object, e As EventArgs) Handles nudPersonas.ValueChanged
            ' Compara nuevamente la cantidad con el máximo de la sala.
            ActualizarCapacidad()
        End Sub

        ' Función que obtiene la capacidad máxima de la sala seleccionada.
        Private Function ObtenerCapacidadSala() As Integer
            ' Convierte el elemento seleccionado a texto de forma segura.
            Dim sala As String = If(cboSala.SelectedItem?.ToString(), String.Empty)
            ' Evalúa qué sala fue seleccionada.
            Select Case sala
                ' La Sala 1 admite cuatro personas.
                Case "Sala 1"
                    ' Devuelve la capacidad de Sala 1.
                    Return 4
                ' La Sala 2 admite seis personas.
                Case "Sala 2"
                    ' Devuelve la capacidad de Sala 2.
                    Return 6
                ' La Sala 3 admite ocho personas.
                Case "Sala 3"
                    ' Devuelve la capacidad de Sala 3.
                    Return 8
                ' La Sala 4 admite hasta diez personas.
                Case "Sala 4"
                    ' Devuelve la capacidad de Sala 4.
                    Return 10
                    ' Cualquier otro valor significa que no existe una selección válida.
                Case Else
                    ' Cero identifica el estado sin sala.
                    Return 0
            End Select
        End Function

        ' Método que entrega retroalimentación inmediata sobre la capacidad.
        Private Sub ActualizarCapacidad()
            ' Obtiene la capacidad asociada a la sala actual.
            Dim capacidad As Integer = ObtenerCapacidadSala()
            ' Comprueba si todavía no se ha seleccionado una sala.
            If capacidad = 0 Then
                ' Solicita una selección antes de comparar cantidades.
                lblCapacidad.Text = "Capacidad: seleccione una sala."
                ' Termina el método porque no existe un máximo disponible.
                Return
            End If

            ' Comprueba si la cantidad ingresada supera la capacidad.
            Dim excedida As Boolean = nudPersonas.Value > capacidad
            ' Elige el mensaje según el resultado de la comparación.
            If excedida Then
                ' Advierte que el máximo fue superado.
                lblCapacidad.Text = $"Capacidad: {capacidad} personas · La cantidad ingresada excede el máximo."
            Else
                ' Informa el máximo permitido cuando no existe problema.
                lblCapacidad.Text = $"Capacidad: {capacidad} personas."
            End If
        End Sub

        ' Evento de usuario: ocurre al presionar Registrar reserva.
        Private Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
            ' Ejecuta todas las reglas de validación.
            If Not ValidarFormulario() Then
                ' Detiene el registro cuando se detecta una causa de error.
                Return
            End If

            ' Convierte el estado del CheckBox en texto.
            Dim proyectorTexto As String

            If chkProyector.Checked Then
                proyectorTexto = "Sí"
            Else
                proyectorTexto = "No"
            End If

            ' Obtiene el nombre del responsable y elimina espacios al inicio y al final.
            Dim responsable As String = txtResponsable.Text.Trim()

            ' Obtiene la sala seleccionada en el ComboBox y la convierte en texto.
            Dim sala As String = cboSala.SelectedItem.ToString()

            ' Obtiene la fecha seleccionada y la convierte al formato día-mes-año.
            Dim fecha As String = dtpFecha.Value.ToString("dd-MM-yyyy")

            ' Obtiene el bloque horario seleccionado y lo convierte en texto.
            Dim bloque As String = cboBloque.SelectedItem.ToString()

            ' Obtiene la cantidad de personas y la convierte en texto sin decimales.
            Dim personas As String = nudPersonas.Value.ToString("N0")

            ' Agrega una nueva fila al DataGridView con todos los datos de la reserva.
            dgvReservas.Rows.Add(responsable, sala, fecha, bloque, personas, proyectorTexto)

            ' Informa que el registro fue exitoso.
            lblEstado.Text = "Reserva registrada correctamente."

            ' Limpia solamente las entradas y conserva el historial.
            LimpiarEntrada()
        End Sub

        ' Función que identifica las causas que impiden registrar una reserva.
        Private Function ValidarFormulario() As Boolean
            ' Elimina los mensajes de una validación anterior.
            errorProvider.Clear()
            ' Presume inicialmente que la información es correcta.
            Dim esValido As Boolean = True

            ' Comprueba si el responsable está vacío o contiene solo espacios.
            If String.IsNullOrWhiteSpace(txtResponsable.Text) Then
                ' Informa la causa junto al TextBox.
                errorProvider.SetError(txtResponsable, "Ingrese el nombre de la persona responsable.")
                ' Marca el formulario como inválido.
                esValido = False
            End If

            ' Comprueba que exista una sala seleccionada.
            If cboSala.SelectedIndex < 0 Then
                ' Informa la causa junto al ComboBox.
                errorProvider.SetError(cboSala, "Seleccione una sala.")
                ' Marca el formulario como inválido.
                esValido = False
            End If

            ' Comprueba que exista un bloque horario seleccionado.
            If cboBloque.SelectedIndex < 0 Then
                ' Informa la causa junto al ComboBox.
                errorProvider.SetError(cboBloque, "Seleccione un bloque horario.")
                ' Marca el formulario como inválido.
                esValido = False
            End If

            ' Comprueba que la fecha no sea anterior a hoy.
            If dtpFecha.Value.Date < Date.Today Then
                ' Informa la causa junto al DateTimePicker.
                errorProvider.SetError(dtpFecha, "La fecha de reserva no puede ser anterior a hoy.")
                ' Marca el formulario como inválido.
                esValido = False
            End If

            ' Obtiene la capacidad de la sala seleccionada.
            Dim capacidad As Integer = ObtenerCapacidadSala()
            ' Valida la cantidad solo cuando existe una sala válida.
            If capacidad > 0 AndAlso nudPersonas.Value > capacidad Then
                ' Explica el máximo permitido para detectar la causa del problema.
                errorProvider.SetError(nudPersonas, $"La sala seleccionada admite como máximo {capacidad} personas.")
                ' Marca el formulario como inválido.
                esValido = False
            End If

            ' Comprueba si se detectó al menos un problema.
            If Not esValido Then
                ' Orienta al usuario a revisar los controles señalados.
                lblEstado.Text = "No se puede reservar: revise los campos marcados con error."
            End If

            ' Devuelve el resultado final de la validación.
            Return esValido
        End Function

        ' Evento de usuario: ocurre al presionar Limpiar.
        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            ' Restablece los controles de entrada.
            LimpiarEntrada()
            ' Informa que la limpieza se completó.
            lblEstado.Text = "Campos de entrada limpios."
        End Sub

        ' Método que limpia los campos sin borrar las reservas registradas.
        Private Sub LimpiarEntrada()
            ' Elimina mensajes de validación existentes.
            errorProvider.Clear()
            ' Vacía el nombre del responsable.
            txtResponsable.Clear()
            ' Quita la selección de sala.
            cboSala.SelectedIndex = -1
            ' Restablece la fecha al día actual.
            dtpFecha.Value = Date.Today
            ' Quita la selección del bloque.
            cboBloque.SelectedIndex = -1
            ' Restablece la cantidad a una persona.
            nudPersonas.Value = 1D
            ' Desmarca la solicitud de proyector.
            chkProyector.Checked = False
            ' Devuelve el foco al primer campo.
            txtResponsable.Focus()
            ' Refresca el mensaje de capacidad.
            ActualizarCapacidad()
        End Sub

        ' Evento de sistema FormClosing: ocurre antes de que la ventana se cierre.
        Private Sub FrmReservaSalaEstudio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            ' Comprueba si existen reservas cargadas solo en memoria.
            If dgvReservas.Rows.Count > 0 Then
                ' Solicita confirmación antes de perder los datos de demostración.
                Dim respuesta As DialogResult = MessageBox.Show(
                    "Las reservas de esta demostración existen solo en memoria. ¿Desea cerrar?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)

                ' Cancela el cierre cuando el usuario responde No.
                e.Cancel = respuesta = DialogResult.No
            End If
        End Sub
    End Class
End Namespace