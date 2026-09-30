' Importa las clases de Windows Forms usadas para iniciar la aplicación.
Imports System.Windows.Forms

' Define el espacio de nombres del Caso 3.
Namespace PRO205.Semana7.Caso3.ReservaSalaEstudio.VB
    ' Module entrega un punto de entrada compartido, equivalente a una clase estática.
    Friend Module Program
        ' STAThread es necesario para varias características de interfaz de Windows.
        ' Main es el primer procedimiento que se ejecuta.
        Friend Sub Main()
            ' Activa los estilos visuales actuales de Windows para los controles.
            Application.EnableVisualStyles()
            ' Mantiene el comportamiento moderno de representación de texto.
            Application.SetCompatibleTextRenderingDefault(False)
            ' Crea y muestra el formulario principal, iniciando el ciclo de mensajes.
            Application.Run(New FrmReservaSalaEstudio())
        End Sub
    End Module
End Namespace
