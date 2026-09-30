' Este archivo define la interfaz visual del Caso 3 y normalmente es administrado por Visual Studio.
Namespace PRO205.Semana7.Caso3.ReservaSalaEstudio.VB
    ' Indica que la clase contiene código asociado al diseñador visual.
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmReservaSalaEstudio
        ' Contenedor de componentes no visuales.
        Private components As System.ComponentModel.IContainer

        ' Libera los recursos usados por el formulario.
        Protected Overrides Sub Dispose(disposing As Boolean)
            ' Comprueba si corresponde liberar componentes administrados.
            If disposing AndAlso components IsNot Nothing Then
                ' Libera los componentes contenidos.
                components.Dispose()
            End If
            ' Solicita a Form liberar sus propios recursos.
            MyBase.Dispose(disposing)
        End Sub

        ' Crea controles y configura la interfaz.
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            layoutRoot = New System.Windows.Forms.TableLayoutPanel()
            layoutForm = New System.Windows.Forms.TableLayoutPanel()
            lblTitulo = New System.Windows.Forms.Label()
            lblResponsable = New System.Windows.Forms.Label()
            txtResponsable = New System.Windows.Forms.TextBox()
            lblSala = New System.Windows.Forms.Label()
            cboSala = New System.Windows.Forms.ComboBox()
            lblCapacidad = New System.Windows.Forms.Label()
            lblFecha = New System.Windows.Forms.Label()
            dtpFecha = New System.Windows.Forms.DateTimePicker()
            lblBloque = New System.Windows.Forms.Label()
            cboBloque = New System.Windows.Forms.ComboBox()
            lblPersonas = New System.Windows.Forms.Label()
            nudPersonas = New System.Windows.Forms.NumericUpDown()
            chkProyector = New System.Windows.Forms.CheckBox()
            panelBotones = New System.Windows.Forms.FlowLayoutPanel()
            btnReservar = New System.Windows.Forms.Button()
            btnLimpiar = New System.Windows.Forms.Button()
            dgvReservas = New System.Windows.Forms.DataGridView()
            colResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colSala = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colBloque = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colPersonas = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colProyector = New System.Windows.Forms.DataGridViewTextBoxColumn()
            lblEstado = New System.Windows.Forms.Label()
            errorProvider = New System.Windows.Forms.ErrorProvider(components)
            layoutRoot.SuspendLayout()
            layoutForm.SuspendLayout()
            CType(nudPersonas, ComponentModel.ISupportInitialize).BeginInit()
            panelBotones.SuspendLayout()
            CType(dgvReservas, ComponentModel.ISupportInitialize).BeginInit()
            CType(errorProvider, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' layoutRoot
            ' 
            layoutRoot.ColumnCount = 1
            layoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            layoutRoot.Controls.Add(layoutForm, 0, 0)
            layoutRoot.Controls.Add(panelBotones, 0, 1)
            layoutRoot.Controls.Add(dgvReservas, 0, 2)
            layoutRoot.Controls.Add(lblEstado, 0, 3)
            layoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
            layoutRoot.Location = New System.Drawing.Point(0, 0)
            layoutRoot.Name = "layoutRoot"
            layoutRoot.Padding = New System.Windows.Forms.Padding(18)
            layoutRoot.RowCount = 4
            layoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            layoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutRoot.Size = New System.Drawing.Size(900, 650)
            layoutRoot.TabIndex = 0
            ' 
            ' layoutForm
            ' 
            layoutForm.AutoSize = True
            layoutForm.ColumnCount = 2
            layoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F))
            layoutForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            layoutForm.Controls.Add(lblTitulo, 0, 0)
            layoutForm.Controls.Add(lblResponsable, 0, 1)
            layoutForm.Controls.Add(txtResponsable, 1, 1)
            layoutForm.Controls.Add(lblSala, 0, 2)
            layoutForm.Controls.Add(cboSala, 1, 2)
            layoutForm.Controls.Add(lblCapacidad, 1, 3)
            layoutForm.Controls.Add(lblFecha, 0, 4)
            layoutForm.Controls.Add(dtpFecha, 1, 4)
            layoutForm.Controls.Add(lblBloque, 0, 5)
            layoutForm.Controls.Add(cboBloque, 1, 5)
            layoutForm.Controls.Add(lblPersonas, 0, 6)
            layoutForm.Controls.Add(nudPersonas, 1, 6)
            layoutForm.Controls.Add(chkProyector, 1, 7)
            layoutForm.Dock = System.Windows.Forms.DockStyle.Top
            layoutForm.Location = New System.Drawing.Point(21, 21)
            layoutForm.Name = "layoutForm"
            layoutForm.RowCount = 8
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutForm.Size = New System.Drawing.Size(858, 259)
            layoutForm.TabIndex = 0
            ' 
            ' lblTitulo
            ' 
            lblTitulo.AutoSize = True
            layoutForm.SetColumnSpan(lblTitulo, 2)
            lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16F, Drawing.FontStyle.Bold)
            lblTitulo.Location = New System.Drawing.Point(3, 3)
            lblTitulo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 14)
            lblTitulo.Name = "lblTitulo"
            lblTitulo.Size = New System.Drawing.Size(376, 30)
            lblTitulo.TabIndex = 0
            lblTitulo.Text = "Caso 3 - Reserva de sala de estudio"
            ' 
            ' lblResponsable
            ' 
            lblResponsable.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblResponsable.AutoSize = True
            lblResponsable.Location = New System.Drawing.Point(3, 53)
            lblResponsable.Name = "lblResponsable"
            lblResponsable.Size = New System.Drawing.Size(88, 19)
            lblResponsable.TabIndex = 1
            lblResponsable.Text = "Responsable:"
            ' 
            ' txtResponsable
            ' 
            txtResponsable.Dock = System.Windows.Forms.DockStyle.Fill
            txtResponsable.Location = New System.Drawing.Point(183, 50)
            txtResponsable.MaxLength = 60
            txtResponsable.Name = "txtResponsable"
            txtResponsable.Size = New System.Drawing.Size(672, 25)
            txtResponsable.TabIndex = 2
            ' 
            ' lblSala
            ' 
            lblSala.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblSala.AutoSize = True
            lblSala.Location = New System.Drawing.Point(3, 84)
            lblSala.Name = "lblSala"
            lblSala.Size = New System.Drawing.Size(36, 19)
            lblSala.TabIndex = 3
            lblSala.Text = "Sala:"
            ' 
            ' cboSala
            ' 
            cboSala.Dock = System.Windows.Forms.DockStyle.Fill
            cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboSala.Location = New System.Drawing.Point(183, 81)
            cboSala.Name = "cboSala"
            cboSala.Size = New System.Drawing.Size(672, 25)
            cboSala.TabIndex = 4
            ' 
            ' lblCapacidad
            ' 
            lblCapacidad.AutoSize = True
            lblCapacidad.Location = New System.Drawing.Point(183, 109)
            lblCapacidad.Name = "lblCapacidad"
            lblCapacidad.Padding = New System.Windows.Forms.Padding(0, 3, 0, 6)
            lblCapacidad.Size = New System.Drawing.Size(197, 28)
            lblCapacidad.TabIndex = 5
            lblCapacidad.Text = "Capacidad: seleccione una sala."
            ' 
            ' lblFecha
            ' 
            lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblFecha.AutoSize = True
            lblFecha.Location = New System.Drawing.Point(3, 143)
            lblFecha.Name = "lblFecha"
            lblFecha.Size = New System.Drawing.Size(47, 19)
            lblFecha.TabIndex = 6
            lblFecha.Text = "Fecha:"
            ' 
            ' dtpFecha
            ' 
            dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
            dtpFecha.Location = New System.Drawing.Point(183, 140)
            dtpFecha.Name = "dtpFecha"
            dtpFecha.Size = New System.Drawing.Size(200, 25)
            dtpFecha.TabIndex = 7
            ' 
            ' lblBloque
            ' 
            lblBloque.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblBloque.AutoSize = True
            lblBloque.Location = New System.Drawing.Point(3, 174)
            lblBloque.Name = "lblBloque"
            lblBloque.Size = New System.Drawing.Size(102, 19)
            lblBloque.TabIndex = 8
            lblBloque.Text = "Bloque horario:"
            ' 
            ' cboBloque
            ' 
            cboBloque.Dock = System.Windows.Forms.DockStyle.Fill
            cboBloque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboBloque.Location = New System.Drawing.Point(183, 171)
            cboBloque.Name = "cboBloque"
            cboBloque.Size = New System.Drawing.Size(672, 25)
            cboBloque.TabIndex = 9
            ' 
            ' lblPersonas
            ' 
            lblPersonas.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblPersonas.AutoSize = True
            lblPersonas.Location = New System.Drawing.Point(3, 205)
            lblPersonas.Name = "lblPersonas"
            lblPersonas.Size = New System.Drawing.Size(145, 19)
            lblPersonas.TabIndex = 10
            lblPersonas.Text = "Cantidad de personas:"
            ' 
            ' nudPersonas
            ' 
            nudPersonas.Location = New System.Drawing.Point(183, 202)
            nudPersonas.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            nudPersonas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudPersonas.Name = "nudPersonas"
            nudPersonas.Size = New System.Drawing.Size(100, 25)
            nudPersonas.TabIndex = 11
            nudPersonas.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' chkProyector
            ' 
            chkProyector.AutoSize = True
            chkProyector.Location = New System.Drawing.Point(183, 233)
            chkProyector.Name = "chkProyector"
            chkProyector.Size = New System.Drawing.Size(138, 23)
            chkProyector.TabIndex = 12
            chkProyector.Text = "Solicitar proyector"
            ' 
            ' panelBotones
            ' 
            panelBotones.AutoSize = True
            panelBotones.Controls.Add(btnReservar)
            panelBotones.Controls.Add(btnLimpiar)
            panelBotones.Location = New System.Drawing.Point(18, 293)
            panelBotones.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
            panelBotones.Name = "panelBotones"
            panelBotones.Size = New System.Drawing.Size(208, 35)
            panelBotones.TabIndex = 1
            ' 
            ' btnReservar
            ' 
            btnReservar.AutoSize = True
            btnReservar.Location = New System.Drawing.Point(3, 3)
            btnReservar.Name = "btnReservar"
            btnReservar.Size = New System.Drawing.Size(121, 29)
            btnReservar.TabIndex = 0
            btnReservar.Text = "Registrar reserva"
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.AutoSize = True
            btnLimpiar.Location = New System.Drawing.Point(130, 3)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New System.Drawing.Size(75, 29)
            btnLimpiar.TabIndex = 1
            btnLimpiar.Text = "Limpiar"
            ' 
            ' dgvReservas
            ' 
            dgvReservas.AllowUserToAddRows = False
            dgvReservas.AllowUserToDeleteRows = False
            dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            dgvReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {colResponsable, colSala, colFecha, colBloque, colPersonas, colProyector})
            dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill
            dgvReservas.Location = New System.Drawing.Point(21, 341)
            dgvReservas.Name = "dgvReservas"
            dgvReservas.ReadOnly = True
            dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            dgvReservas.Size = New System.Drawing.Size(858, 261)
            dgvReservas.TabIndex = 2
            ' 
            ' colResponsable
            ' 
            colResponsable.HeaderText = "Responsable"
            colResponsable.Name = "colResponsable"
            colResponsable.ReadOnly = True
            ' 
            ' colSala
            ' 
            colSala.HeaderText = "Sala"
            colSala.Name = "colSala"
            colSala.ReadOnly = True
            ' 
            ' colFecha
            ' 
            colFecha.HeaderText = "Fecha"
            colFecha.Name = "colFecha"
            colFecha.ReadOnly = True
            ' 
            ' colBloque
            ' 
            colBloque.HeaderText = "Bloque"
            colBloque.Name = "colBloque"
            colBloque.ReadOnly = True
            ' 
            ' colPersonas
            ' 
            colPersonas.HeaderText = "Personas"
            colPersonas.Name = "colPersonas"
            colPersonas.ReadOnly = True
            ' 
            ' colProyector
            ' 
            colProyector.HeaderText = "Proyector"
            colProyector.Name = "colProyector"
            colProyector.ReadOnly = True
            ' 
            ' lblEstado
            ' 
            lblEstado.AutoSize = True
            lblEstado.Location = New System.Drawing.Point(21, 605)
            lblEstado.Name = "lblEstado"
            lblEstado.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
            lblEstado.Size = New System.Drawing.Size(211, 27)
            lblEstado.TabIndex = 3
            lblEstado.Text = "Complete los datos de la reserva."
            ' 
            ' errorProvider
            ' 
            errorProvider.ContainerControl = Me
            ' 
            ' FrmReservaSalaEstudio
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(7F, 17F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(900, 650)
            Controls.Add(layoutRoot)
            Font = New System.Drawing.Font("Segoe UI", 10F)
            MinimumSize = New System.Drawing.Size(820, 600)
            Name = "FrmReservaSalaEstudio"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "[PRO205] Caso 3: Reserva de sala de estudio"
            layoutRoot.ResumeLayout(False)
            layoutRoot.PerformLayout()
            layoutForm.ResumeLayout(False)
            layoutForm.PerformLayout()
            CType(nudPersonas, ComponentModel.ISupportInitialize).EndInit()
            panelBotones.ResumeLayout(False)
            panelBotones.PerformLayout()
            CType(dgvReservas, ComponentModel.ISupportInitialize).EndInit()
            CType(errorProvider, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        ' Declara el layout raíz.
        Private layoutRoot As System.Windows.Forms.TableLayoutPanel
        ' Declara el layout de campos.
        Private layoutForm As System.Windows.Forms.TableLayoutPanel
        ' Declara el título.
        Private lblTitulo As System.Windows.Forms.Label
        ' Declara la etiqueta Responsable.
        Private lblResponsable As System.Windows.Forms.Label
        ' Declara el TextBox del responsable.
        Private txtResponsable As System.Windows.Forms.TextBox
        ' Declara la etiqueta Sala.
        Private lblSala As System.Windows.Forms.Label
        ' WithEvents permite que Handles capture SelectedIndexChanged.
        Private WithEvents cboSala As System.Windows.Forms.ComboBox
        ' Declara la etiqueta de capacidad.
        Private lblCapacidad As System.Windows.Forms.Label
        ' Declara la etiqueta Fecha.
        Private lblFecha As System.Windows.Forms.Label
        ' Declara el selector de fecha.
        Private dtpFecha As System.Windows.Forms.DateTimePicker
        ' Declara la etiqueta Bloque.
        Private lblBloque As System.Windows.Forms.Label
        ' Declara el ComboBox de bloque.
        Private cboBloque As System.Windows.Forms.ComboBox
        ' Declara la etiqueta Personas.
        Private lblPersonas As System.Windows.Forms.Label
        ' WithEvents permite capturar ValueChanged.
        Private WithEvents nudPersonas As System.Windows.Forms.NumericUpDown
        ' Declara la casilla de proyector.
        Private chkProyector As System.Windows.Forms.CheckBox
        ' Declara el panel de botones.
        Private panelBotones As System.Windows.Forms.FlowLayoutPanel
        ' WithEvents permite capturar Click de Registrar.
        Private WithEvents btnReservar As System.Windows.Forms.Button
        ' WithEvents permite capturar Click de Limpiar.
        Private WithEvents btnLimpiar As System.Windows.Forms.Button
        ' Declara el DataGridView.
        Private dgvReservas As System.Windows.Forms.DataGridView
        ' Declara columna Responsable.
        Private colResponsable As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara columna Sala.
        Private colSala As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara columna Fecha.
        Private colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara columna Bloque.
        Private colBloque As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara columna Personas.
        Private colPersonas As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara columna Proyector.
        Private colProyector As System.Windows.Forms.DataGridViewTextBoxColumn
        ' Declara etiqueta de estado.
        Private lblEstado As System.Windows.Forms.Label
        ' Declara ErrorProvider.
        Private errorProvider As System.Windows.Forms.ErrorProvider
    End Class
End Namespace
