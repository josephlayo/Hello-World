Imports System.IO
Imports System.Text
Imports Starksoft.Cryptography.OpenPGP

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' load the registered OpenPGP keys in your local key ring to the GridView on the Windows Form
        LoadKeys()

        ' set some default data to encrypt
        tbUnencrypted.Text = "The Starksoft OpenPGP library provides classes that interface with the GPG.EXE command line tool.  The Starksoft OpenPGP libraries allows any .NET application to use GPG.EXE to encrypt or decypt data using .NET IO Streams.  No temporary files are required and everything is handled through streams.  Any .NET Stream object can be used as long as the source stream can be read and the destination stream can be written to.  But, in order for the Starksoft OpenPGP library to work you must first install the lastest version of GnuPG which includes GPG.EXE.  You can obtain the latest version at http://www.gnupg.org/.  See the GPG.EXE tool documentation for information on how to add keys to the GPG key ring and creating your public and private keys."
    End Sub

    ' this method will load the GnuPG OpenPGP keys that are in your local key ring
    ' into a GridView control on the Windows Form.
    Private Sub LoadKeys()
        Try
            Dim gpg As GnuPG = New GnuPG()

            ' optionally you can specify the path to the binary gpg.exe program.
            ' if the path is not specified the Starksoft OpenPGP library will locate the
            ' gpg.exe program using the Windows registry.
            'gpg.BinaryPath = @"C:\Program Files\gnu\GnuPG\gpg.exe";

            ' retrieve a collection of keys from the gpg.exe application and convert
            ' that collection to a DataTable so we can easily bind it to a GridView control
            gvKeys.DataSource = gpg.GetKeys().ToDataTable()
        Catch
            MessageBox.Show("An error occurred while trying access the OpenPGP security keys." & Constants.vbCrLf & Constants.vbCrLf & "Please make sure you have installed Gnu's OpenPGP application" & Constants.vbCrLf & "and that the OpenPGP settings are correctly entered." & Constants.vbCrLf & "Download GnuPG from http:\www.gnupg.org" & Constants.vbCrLf & Constants.vbCrLf & "Make sure that you have created a private key using the GPG.EXE application.", "Starksoft OpenPGP Library Sample")
        End Try
    End Sub

    ' retrieve the recipient key that is selected by the user in the GridView control named gvKeys
    Private Function GetRecipientKey() As String
        If gvKeys.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a recipient from your key ring.", "Encrypt")
            Return ""
        End If

        ' retrieve the recipient UserId text data that is currently selected in the gvKeys control
        Return gvKeys.SelectedRows(0).Cells("UserId").Value.ToString()
    End Function

    ' this method will encrypt any OpenPGP data found in the TextBox named tbUnencrypted to the TextBox control named tbEncrypted
    Private Sub btnEncrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Dim recipient As String = GetRecipientKey()
        ' if no recipient is specified then don't do the encryption
        If recipient.Length = 0 Then
            Return
        End If

        ' create two memory stream - one to hold the unencrypted data and the other 
        ' stream holds the encrypted data.  We can use any System.IO stream such as 
        ' FileStream but for this demo we will use a memory stream
        Dim unencrypted As MemoryStream = New MemoryStream(Encoding.ASCII.GetBytes(tbUnencrypted.Text))
        Dim encrypted As MemoryStream = New MemoryStream()

        ' create a new GnuPG object
        Dim gpg As GnuPG = New GnuPG()

        ' specify a recipient that is in your key ring
        gpg.Recipient = recipient

        Try
            ' encrypt the data using IO Streams - any type of input and output IO Stream can be used
            ' as long as the source (input) stream can be read and the destination (output) stream 
            ' can be written to
            gpg.Encrypt(unencrypted, encrypted)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Encryption Error")
            Return
        End Try

        ' create a stream reader so we can read all the data from the memory stream
        Dim reader As StreamReader = New StreamReader(encrypted)

        ' set the encrypted data stream to the starting position so we can read the entire contents
        encrypted.Position = 0

        ' read the text data from the memory stream.
        tbEncrypted.Text = reader.ReadToEnd()
    End Sub


    ' this method will decrypt any OpenPGP data found in the TextBox named tbEncrypted to the TextBox control named tbUnencrypted
    Private Sub btnDecrypt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        ' create two memory stream - one to hold the unencrypted data and the other 
        ' stream holds the encrypted data.  We can use any System.IO stream such as 
        ' FileStream but for this demo we will use a memory stream
        Dim unencrypted As MemoryStream = New MemoryStream()
        Dim encrypted As MemoryStream = New MemoryStream(Encoding.ASCII.GetBytes(tbEncrypted.Text))

        ' create a new GnuPG object
        Dim gpg As GnuPG = New GnuPG()

        ' specify our secret passphrase (if you have one)
        gpg.Passphrase = tbPassphrase.Text


        Try
            ' decrypt the data using IO Streams - any type of input and output IO Stream can be used
            ' as long as the source (input) stream can be read and the destination (output) stream 
            ' can be written to
            gpg.Decrypt(encrypted, unencrypted)
        Catch e1 As GnuPGBadPassphraseException
            MessageBox.Show("Please enter a valid passphrase.", "Passphrase Needed")
            tbPassphrase.Focus()
            Return
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Decryption Error")
            Return
        End Try

        ' create a stream reader so we can read all the data from the memory stream
        Dim reader As StreamReader = New StreamReader(unencrypted)

        ' set the encrypted data stream to the starting position so we can read the entire contents
        unencrypted.Position = 0

        ' read the text data from the memory stream.
        tbUnencrypted.Text = reader.ReadToEnd()
    End Sub

    Private Sub lnkClearUnencrypted_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClearUnencrypted.LinkClicked
        tbUnencrypted.Text = ""
    End Sub

    Private Sub lnkClearEncrypted_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClearEncrypted.LinkClicked
        tbEncrypted.Text = ""
    End Sub
End Class
