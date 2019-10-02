Public Class EnterPO_No
    Inherits System.Windows.Forms.Form


    Private Supplier_ID As Integer
    Public PO_NO As String

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal pSupplier_ID As Integer)
        MyBase.New()

        InitializeComponent()

        Supplier_ID = pSupplier_ID

        With New BusinessRules.SupplierBusRules.SupplierBusLogic
            .Load(Supplier_ID)
            Me.SupplierName_Label.Text = .Supplier_Name
        End With

        'This call is required by the Windows Form Designer.
        
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PONO_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SupplierName_Label As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.PONO_TextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SupplierName_Label = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PO #:"
        '
        'PONO_TextBox
        '
        Me.PONO_TextBox.Location = New System.Drawing.Point(82, 48)
        Me.PONO_TextBox.Name = "PONO_TextBox"
        Me.PONO_TextBox.Size = New System.Drawing.Size(240, 20)
        Me.PONO_TextBox.TabIndex = 1
        Me.PONO_TextBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(248, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ok"
        '
        'SupplierName_Label
        '
        Me.SupplierName_Label.Location = New System.Drawing.Point(28, 12)
        Me.SupplierName_Label.Name = "SupplierName_Label"
        Me.SupplierName_Label.Size = New System.Drawing.Size(294, 23)
        Me.SupplierName_Label.TabIndex = 3
        Me.SupplierName_Label.Text = "Supplier Name"
        Me.SupplierName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnterPO_No
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(356, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.SupplierName_Label)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PONO_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterPO_No"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter a PO Number"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Check for duplicate po no
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .RecordExists(Me.PONO_TextBox.Text) Then
                MessageBox.Show("PO NO has already been used! Try another PO NO", "Duplicate PO NO!")
            Else
                Me.PO_NO = Me.PONO_TextBox.Text
                Me.Close()
            End If
        End With

        
    End Sub
End Class
