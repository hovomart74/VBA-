Public Class Form1
    Private Sub BikesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BikesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BikesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BikesDatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikesDatabaseDataSet.Versions' table. You can move, or remove it, as needed.
        Me.VersionsTableAdapter.Fill(Me.BikesDatabaseDataSet.Versions)
        'TODO: This line of code loads data into the 'BikesDatabaseDataSet.Models' table. You can move, or remove it, as needed.
        Me.ModelsTableAdapter.Fill(Me.BikesDatabaseDataSet.Models)
        'TODO: This line of code loads data into the 'BikesDatabaseDataSet.Bikes' table. You can move, or remove it, as needed.
        Me.BikesTableAdapter.Fill(Me.BikesDatabaseDataSet.Bikes)

    End Sub

    Private Sub GetAllToolStripButton_Click(sender As Object, e As EventArgs) Handles GetAllToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetAll(Me.BikesDatabaseDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetClassicsToolStripButton_Click(sender As Object, e As EventArgs) Handles GetClassicsToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetClassics(Me.BikesDatabaseDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetCruisersToolStripButton_Click(sender As Object, e As EventArgs) Handles GetCruisersToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetCruisers(Me.BikesDatabaseDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BikesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles BikesBindingSource.CurrentChanged

    End Sub
End Class
