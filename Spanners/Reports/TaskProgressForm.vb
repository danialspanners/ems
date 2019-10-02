Public Class TaskProgressForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal pTitle As String, ByVal pTaskMsg As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.Text = pTitle
        Me.Taskmsg.Text = pTaskMsg

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Taskmsg As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Msg1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Msg2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Taskmsg = New System.Windows.Forms.Label
        Me.Msg2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.CancelButton = New System.Windows.Forms.Button
        Me.Msg1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Taskmsg
        '
        Me.Taskmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Taskmsg.Location = New System.Drawing.Point(46, 63)
        Me.Taskmsg.Name = "Taskmsg"
        Me.Taskmsg.Size = New System.Drawing.Size(334, 23)
        Me.Taskmsg.TabIndex = 0
        Me.Taskmsg.Text = "Generating report..."
        Me.Taskmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Msg2
        '
        Me.Msg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Msg2.Location = New System.Drawing.Point(67, 98)
        Me.Msg2.Name = "Msg2"
        Me.Msg2.Size = New System.Drawing.Size(288, 23)
        Me.Msg2.TabIndex = 1
        Me.Msg2.Text = "Please wait"
        Me.Msg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(58, 63)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(307, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CancelButton.Location = New System.Drawing.Point(174, 152)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        Me.CancelButton.Visible = False
        '
        'Msg1
        '
        Me.Msg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Msg1.Location = New System.Drawing.Point(58, 37)
        Me.Msg1.Name = "Msg1"
        Me.Msg1.Size = New System.Drawing.Size(307, 23)
        Me.Msg1.TabIndex = 4
        Me.Msg1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'TaskProgressForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(422, 197)
        Me.ControlBox = False
        Me.Controls.Add(Me.Msg1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Msg2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Taskmsg)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TaskProgressForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In progress ..."
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private counter As Integer

    Public Property ShowProgressBar() As Boolean
        Get
            Return Me.ProgressBar1.Visible
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.Taskmsg.Visible = False

                If ProgressBar1.Visible = False Then
                    counter = 0 'reset
                End If

                Me.ProgressBar1.Visible = True

            Else

                If ProgressBar1.Visible = True Then
                    counter = 0 'reset
                End If

            End If
        End Set
    End Property

    Public Property ShowCancelButton() As Boolean
        Get
            Return Me.CancelButton.Visible
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.CancelButton.Visible = True
            End If
        End Set
    End Property

    Public Property Message1() As String
        Get
            Return Msg1.Text
        End Get
        Set(ByVal value As String)
            Msg1.Text = value
        End Set
    End Property

    Public Property TaskMessage() As String
        Get
            Return Me.Taskmsg.Text
        End Get
        Set(ByVal value As String)
            Taskmsg.Text = value
        End Set
    End Property

    Public Property PercentageProgress() As Integer
        Get
            Return Me.ProgressBar1.Value
        End Get
        Set(ByVal value As Integer)
            Me.ProgressBar1.Value = value
        End Set
    End Property
    'IMPORTANT!!!!!...For some reason. Marquee is not working in this instance...
    'So Alternatively,  Timer is used to simulate blocks moving....
    Public Property ProgressMarquee() As Boolean
        Get
            If ProgressBar1.Style = ProgressBarStyle.Marquee Then
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.ProgressBar1.Style = ProgressBarStyle.Marquee
                Timer1.Enabled = True
            Else
                Me.ProgressBar1.Style = ProgressBarStyle.Blocks
                Timer1.Enabled = False
            End If
        End Set
    End Property

    Public Property ProgressBlocks() As Boolean
        Get
            If ProgressBar1.Style = ProgressBarStyle.Blocks Then
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            Me.ProgressBar1.Style = ProgressBarStyle.Blocks
        End Set
    End Property

    Public Property Message2() As String
        Get
            Return Msg2.Text
        End Get
        Set(ByVal value As String)
            Msg2.Text = value
        End Set
    End Property

    Public Event CancelButtonPressed(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Event PauseOperation(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event ProceedOperation(ByVal sender As System.Object, ByVal e As System.EventArgs)


    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Dim Result As DialogResult
        RaiseEvent PauseOperation(sender, e)
        If ProgressMarquee = True Then
            Timer1.Enabled = False
        End If

        Result = MessageBox.Show("Are you sure you want abort this operation?", "Abort?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Result = DialogResult.Yes Then
            RaiseEvent CancelButtonPressed(sender, e)
        Else
            RaiseEvent ProceedOperation(sender, e)

            If ProgressMarquee = True Then
                Timer1.Enabled = True
            End If

        End If

    End Sub

    Private Sub TaskProgressForm_MaximizedBoundsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MaximizedBoundsChanged

    End Sub

    Private Sub TaskProgressForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter = counter + 10
        If counter > 100 Then
            counter = 0 'reset
        End If
        ProgressBar1.Value = counter
    End Sub

    Private Sub TaskProgressForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Enabled = False
    End Sub
End Class
