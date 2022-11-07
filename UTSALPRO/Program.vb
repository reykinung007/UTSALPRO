Imports System.Console
Imports System.IO

Module Program
    Dim kelJabatan As String
    Dim input As String
    Dim statusPewai As String
    Dim gajipokok As Integer
    Dim namapegawai As String
    Dim jeniskelamin As String
    Dim Statuskawinp As String
    Dim jmlAnak As String
    Dim jmlTunjanganIstri As Integer
    Dim golonganGajiPokok As Integer
    Dim jmlTunjanganAnak As Integer
    Dim GajiTotal As Integer
    Dim jmlpotongankoperasi As Integer
    Dim jmlBiayaJabatan As Integer
    Dim jmlBiayapensiun As Integer
    Dim gajiBersih As Integer

    Sub Main(args As String())
        Nama()
        jenisKelaminP()
        statuskawin()
        JumlahAnak()
        jabatan()
        stspegawai()
        Gaji()
        HitungTunjanganIstri()
        tunjanganAnak()
        gajiBruto()
        potonganKoperasi()
        biayaJabatan()
        danaPensiun()
        gajiBersihPegawai()
        tampil()
        printSlipGaji()
    End Sub
    Sub jabatan()
        WriteLine("Kelompok Jabatan")
        WriteLine("A. Kepala")
        WriteLine("B. Manager")
        WriteLine("C. Umum")
        Write("Masukan Kode : ")
        input = UCase(ReadLine())

        Select Case input
            Case "A"
                kelJabatan = "Kepala"
            Case "B"
                kelJabatan = "Manager"
            Case "C"
                kelJabatan = "Umum"
        End Select

        WriteLine("Jabatan Terpilih " & kelJabatan)

    End Sub

    Sub stspegawai()
        WriteLine("Kelompok Pegawai")
        WriteLine("A. Tetap")
        WriteLine("B. Honorer")
        Write("Masukan Kode : ")
        input = UCase(ReadLine())

        Select Case input
            Case "A"
                statusPewai = "Tetap"
            Case "B"
                statusPewai = "Honorer"
        End Select

        WriteLine("Kelompok Pegawai " & statusPewai)
    End Sub
    Sub Gaji()
        WriteLine("Kelompok Gaji")
        WriteLine("A.Golongan 1 = 1.500.000")
        WriteLine("B.Golongan 2 = 2.500.000")
        WriteLine("C.Golongan 3 = 3.500.000")
        Write("Masukan Kode : ")
        input = UCase(ReadLine())

        Select Case input
            Case "A"
                gajipokok = 1500000
            Case "B"
                gajipokok = 2500000
            Case "C"
                gajipokok = 3500000
        End Select

        Select Case input
            Case "A"
                golonganGajiPokok = 1
            Case "B"
                golonganGajiPokok = 2
            Case "C"
                golonganGajiPokok = 3
        End Select

        WriteLine("Golongan Gaji Terpilih " & golonganGajiPokok)
        WriteLine("Gaji Pokok Terpilih " & gajipokok)
    End Sub
    Sub Nama()
        Write("Masukkan Nama: ")
        namapegawai = ReadLine()

            WriteLine("Nama Tersimpan: " & namapegawai)
    End Sub
    Sub jenisKelaminP()
        WriteLine("jenis Kelamin")
        WriteLine("A. Laki - Laki")
        WriteLine("B. Perempuan")
        Write("Masukan Kode : ")
        input = UCase(ReadLine())

        Select Case input
            Case "A"
                jeniskelamin = "Laki - Laki"
            Case "B"
                jeniskelamin = "Perempuan"
        End Select

        WriteLine("Jenis Kelamin Terpilih : " & jeniskelamin)
    End Sub
    Sub statuskawin()
        WriteLine("Status Kawin")
        WriteLine("A. Belum Kawin")
        WriteLine("B. kawin")
        Write("Masukan Kode : ")
        input = UCase(ReadLine())

        Select Case input
            Case "A"
                Statuskawinp = " Belum Kawin"
            Case "B"
                Statuskawinp = "kawin"
        End Select

        WriteLine("Jenis Kelamin Terpilih : " & Statuskawinp)
    End Sub
    Sub JumlahAnak()
        Write("Masukkan Jumlah Anak: ")
        jmlAnak = ReadLine()
        WriteLine("Jumlah Anak: " & jmlAnak)
    End Sub
    Sub HitungTunjanganIstri()
        jmlTunjanganIstri = 0
        If jeniskelamin = "Laki - Laki" Then
            If Statuskawinp = "kawin" Then
                If golonganGajiPokok = 1 Then
                    jmlTunjanganIstri = 0.01 * gajipokok
                ElseIf golonganGajiPokok = 2 Then
                    jmlTunjanganIstri = 0.03 * gajipokok
                End If
            Else
                jmlTunjanganIstri = 0.05 * gajipokok
            End If
        End If
    End Sub
    Sub tunjanganAnak()
        jmlAnak = 0
        If Statuskawinp = "kawin" Then
            If jmlAnak = 1 Then
                jmlTunjanganAnak = 0.01 * gajipokok * jmlAnak
            Else
                jmlTunjanganAnak = 0.01 * gajipokok * 2
            End If
        End If
    End Sub
    Sub gajiBruto()
        GajiTotal = gajipokok + jmlTunjanganIstri + jmlTunjanganAnak
    End Sub
    Sub potonganKoperasi()
        jmlpotongankoperasi = 0
        If statusPewai = "Tetap" Then
            jmlpotongankoperasi = 5000
        End If
    End Sub
    Sub biayaJabatan()
        If kelJabatan = "Kepala" Then
            jmlBiayaJabatan = 0.005 * gajipokok
        Else
            jmlBiayaJabatan = 0.003 * gajipokok
        End If
    End Sub
    Sub danaPensiun()
        jmlBiayapensiun = 0
        If statusPewai = "Tetap" Then
            If kelJabatan = "Kepala" Then
                jmlBiayapensiun = 0.005 * gajipokok
            Else
                jmlBiayapensiun = 0.003 * gajipokok
            End If
        End If
    End Sub
    Sub gajiBersihPegawai()
        gajiBersih = GajiTotal - jmlpotongankoperasi - jmlBiayaJabatan - jmlBiayapensiun
    End Sub
    Sub tampil()
        WriteLine("SLIP GAJI: " & namapegawai)
        WriteLine("--------------------------------------------------------------")
        WriteLine("1.  Golongan                     = " & golonganGajiPokok)
        WriteLine("2.  Jabatan                      = " & kelJabatan)
        WriteLine("3.  Status Pegawai               = " & statusPewai)
        WriteLine("4.  Jenis Kelamin                = " & jeniskelamin)
        WriteLine("5.  Status Kawin                 = " & Statuskawinp)
        WriteLine("6.  Jumlah Anak                  = " & jmlAnak)
        WriteLine("7.  Gaji Pokok                   = " & FormatNumber(Convert.ToInt32(gajipokok)), 0, TriState.True, 0)
        WriteLine("8.  Tunjangan Istri              = " & FormatNumber(Convert.ToInt32(jmlTunjanganIstri)), 0, TriState.True, 0)
        WriteLine("9.  Tunjangan Anak               = " & FormatNumber(Convert.ToInt32(jmlTunjanganAnak)), 0, TriState.True, 0)
        WriteLine("==============================================================")
        WriteLine("             Total Gaji Bruto    = " & FormatNumber(Convert.ToInt32(GajiTotal)), 0, TriState.True, 0)
        WriteLine("10. Potongan Koperasi            = " & FormatNumber(Convert.ToInt32(jmlpotongankoperasi)), 0, TriState.True, 0)
        WriteLine("11. Biaya Jabatan                = " & FormatNumber(Convert.ToInt32(jmlBiayaJabatan)), 0, TriState.True, 0)
        WriteLine("12. Dana Pensiun                 = " & FormatNumber(Convert.ToInt32(jmlBiayapensiun)), 0, TriState.True, 0)
        WriteLine("==============================================================")
        WriteLine("	           Total Gaji Bersih/Netto     = " & FormatNumber(Convert.ToInt32(gajiBersih)), 0, TriState.True, 0)
    End Sub
    Sub printSlipGaji()
        Dim mydate As String = DateTime.Now.ToString("dd'-'MM'-'yyyy-HH-mm-ss")
        Dim tgkWaktu As String = DateTime.Now.ToString("dd'/'MM'/'yyyy-HH:mm:ss")
        Dim filename As String
        filename = "Slip Gaji " & namapegawai & mydate & ".txt"
        Dim saveops As SaveOptions
        If File.Exists(filename) = True Then
            Dim writer As New StreamWriter(filename)
            saveops = True
            writer.WriteLine("--------------------------------------------------------------")
            writer.WriteLine("SLIP GAJI: " & namapegawai)
            writer.WriteLine("--------------------------------------------------------------")
            writer.WriteLine("1.  Golongan                     = " & golonganGajiPokok)
            writer.WriteLine("2.  Jabatan                      = " & kelJabatan)
            writer.WriteLine("3.  Status Pegawai               = " & statusPewai)
            writer.WriteLine("4.  Jenis Kelamin                = " & jeniskelamin)
            writer.WriteLine("5.  Status Kawin                 = " & Statuskawinp)
            writer.WriteLine("6.  Jumlah Anak                  = " & jmlAnak)
            writer.WriteLine("7.  Gaji Pokok                   = " & FormatNumber(Convert.ToInt32(gajipokok)), 0, TriState.True, 0)
            writer.WriteLine("8.  Tunjangan Istri              = " & FormatNumber(Convert.ToInt32(jmlTunjanganIstri)), 0, TriState.True, 0)
            writer.WriteLine("9.  Tunjangan Anak               = " & FormatNumber(Convert.ToInt32(jmlTunjanganAnak)), 0, TriState.True, 0)
            writer.WriteLine("==============================================================")
            writer.WriteLine("             Total Gaji Bruto    = " & FormatNumber(Convert.ToInt32(GajiTotal)), 0, TriState.True, 0)
            writer.WriteLine("10. Potongan Koperasi            = " & FormatNumber(Convert.ToInt32(jmlpotongankoperasi)), 0, TriState.True, 0)
            writer.WriteLine("11. Biaya Jabatan                = " & FormatNumber(Convert.ToInt32(jmlBiayaJabatan)), 0, TriState.True, 0)
            writer.WriteLine("12. Dana Pensiun                 = " & FormatNumber(Convert.ToInt32(jmlBiayapensiun)), 0, TriState.True, 0)
            writer.WriteLine("==============================================================")
            writer.WriteLine("	           Total Gaji Bersih/Netto     = " & FormatNumber(Convert.ToInt32(gajiBersih)), 0, TriState.True, 0)
            writer.WriteLine("")
            writer.WriteLine("--------------------------------------------------------------")
            writer.WriteLine("                                PRINT: " & tgkWaktu)
            writer.WriteLine("--------------------------------------------------------------")
            writer.Close()
        End If

        WriteLine("File tersimpan => " & filename)
    End Sub
End Module
