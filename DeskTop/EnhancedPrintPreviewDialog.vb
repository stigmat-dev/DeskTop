﻿Public Class EnhancedPrintPreviewDialog

    Inherits System.Windows.Forms.PrintPreviewDialog

    Dim ShowCounter As Boolean = True

    Private Sub myPrintPreview_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        If ShowCounter = True Then

            'Get the toolstrip from the base control
            Dim ts As ToolStrip = CType(Me.Controls(1), ToolStrip)

            'Get the print button from the toolstrip
            Dim printItem As ToolStripItem = ts.Items("printToolStripButton")

            'Add a new button (our own) to the toolstrip by copying properties from the orginal
            With printItem

                Dim myPrintItem As ToolStripItem
                myPrintItem = ts.Items.Add(.Text, .Image, New EventHandler(AddressOf MyPrintItemClicked))

                'Alter as many other personalized stuff here
                myPrintItem.DisplayStyle = ToolStripItemDisplayStyle.Image

                'Relocate the item to the beginning of the toolstrip
                ts.Items.Insert(0, myPrintItem)

            End With

            'Remove the orginal button
            ts.Items.Remove(printItem)

            ShowCounter = False

        End If

    End Sub

    Private Sub MyPrintItemClicked(ByVal sender As Object, ByVal e As EventArgs)

        'Allow the user to choose a printer and specify other settings.
        Dim dlgPrint As New PrintDialog

        With dlgPrint
            .Document = Me.Document
            '.UseEXDialog = True
            .AllowSelection = False
            .ShowNetwork = False
            .AllowCurrentPage = True
            .AllowSomePages = True
        End With

        'If the user clicked OK, print the document.
        If dlgPrint.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Document.Print()
        End If

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'EnhancedPrintPreviewDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(400, 390)
        Me.Name = "EnhancedPrintPreviewDialog"
        Me.ShowIcon = False
        Me.UseAntiAlias = True
        Me.ResumeLayout(False)

    End Sub


End Class
