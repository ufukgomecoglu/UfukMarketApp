using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStrTest);
            cmd = con.CreateCommand();
        }
        #region Kullanıcı Metotları
        public KullaniciLoginModel KullaniciGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                KullaniciLoginModel k = new KullaniciLoginModel();
                cmd.CommandText = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi != 0)
                {
                    cmd.CommandText = "SELECT ID,Isim,Soyisim,KullaniciAdi,Durum FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        k.ID = reader.GetInt32(0);
                        k.Isim = reader.GetString(1);
                        k.Soyisim = reader.GetString(2);
                        k.KullaniciAdi = reader.GetString(3);
                        k.Durum = reader.GetBoolean(4);
                    }
                }
                return k;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Tedarikçi Metotları
        public List<Tedarikci> TedarikciListeleReader()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            try
            {
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.Silinmis = 0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tedarikciler.Add(new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    });

                }
                return tedarikciler;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool TedarikciEkle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Tedarikciler(FirmaAdi, Yetkili, FirmaTelefon, Email, Sehir_ID, Ilce_ID, Adres, Durum, Silinmis) VALUES(@firmaAdi, @yetkili, @firmaTelefon, @email, @sehir_ID, @ilce_ID, @adres, @durum, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firmaAdi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmaTelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Tedarikci TedarikciGetir(int id)
        {
            try
            {
                Tedarikci t = new Tedarikci();
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t = new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    };
                }
                return t;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool TedarikciSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool TedarikciGuncelle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET FirmaAdi=@firmaadi, Yetkili =@yetkili, FirmaTelefon = @firmatelefon, Email=@email, Sehir_ID=@sehir_ID, Ilce_ID=@ilce_ID, Adres=@adres, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@firmaadi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmatelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Şehir İlçe Metotları
        public List<Sehir> SehirleriListele()
        {
            List<Sehir> Sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT * FROM Sehirler";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehirler.Add(new Sehir()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return Sehirler;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Ilce> IlceleriListele(int sehirID)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ilceler WHERE SehirID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", sehirID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ilceler.Add(new Ilce()
                    {
                        ID = reader.GetInt32(0),
                        Sehir_ID = reader.GetInt32(1),
                        Isim = reader.GetString(2)
                    });
                }
                return ilceler;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Kategori Metotları
        public bool KategoriEkle(Kategori k)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler(UstKategori_ID,Isim,Durum,Silinmis) VALUES(@ustKategori_ID,@isim,@durum,0) ";
                cmd.Parameters.Clear();
                if (k.UstKategori_ID == 0)
                {
                    cmd.Parameters.AddWithValue("@ustKategori_ID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ustKategori_ID", k.UstKategori_ID);
                }
                cmd.Parameters.AddWithValue("@isim", k.Isim);
                cmd.Parameters.AddWithValue("@durum", k.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Kategori> KategoriListeleReader()
        {
            try
            {
                List<Kategori> kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT * FROM Kategoriler WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        k.UstKategori_ID = reader.GetInt32(1);
                    }
                    k.Isim = reader.GetString(2);
                    k.Durum = reader.GetBoolean(3);
                    k.Silinmis = reader.GetBoolean(4);
                    kategoriler.Add(k);
                }
                return kategoriler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Kategori KategoriGetir(int id)
        {
            try
            {
                Kategori k = new Kategori();
                cmd.CommandText = "SELECT * FROM Kategoriler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    k.ID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        k.UstKategori_ID = reader.GetInt32(1);
                    }
                    k.Isim = reader.GetString(2);
                    k.Durum = reader.GetBoolean(3);
                    k.Silinmis = reader.GetBoolean(4);
                }
                return k;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool KategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Kategoriler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool KategoriGuncelle(Kategori model)
        {
            try
            {
                cmd.CommandText = "UPDATE Kategoriler SET Isim=@isim, UstKategori_ID =@ustKategori_ID, Durum = @durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                if (model.UstKategori_ID == 0)
                {
                    cmd.Parameters.AddWithValue("@ustKategori_ID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ustKategori_ID", model.UstKategori_ID);
                }
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Marka Metotları 
        public List<Marka> MarkaListeleReader()
        {
            List<Marka> markalar = new List<Marka>();
            try
            {
                cmd.CommandText = "SELECT ID,Isim,Durum FROM Markalar WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    markalar.Add(new Marka()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1),
                        Durum = reader.GetBoolean(2)
                    });
                }
                return markalar;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool MarkaEkle(Marka m)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Markalar(Isim,Durum,Silinmis) VALUES(@isim,@durum,0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", m.Isim);
                cmd.Parameters.AddWithValue("@durum", m.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Marka MarkaGetir(int id)
        {
            try
            {
                Marka m = new Marka();
                cmd.CommandText = "SELECT ID,Isim,Durum FROM Markalar WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    m = new Marka()
                    {
                        ID = reader.GetInt32(0),
                        Isim= reader.GetString(1),
                        Durum = reader.GetBoolean(2)
                    };
                }
                return m;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool MarkaSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Markalar SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool MarkaGuncelle(Marka model)
        {
            try
            {
                cmd.CommandText = "UPDATE Markalar SET Isim=@isim, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Birim Metotları
        public List<Birim> BirimListeleReader()
        {
            List<Birim> birimler = new List<Birim>();
            try
            {
                cmd.CommandText = "SELECT ID,Isim,Durum FROM Birimler WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    birimler.Add(new Birim()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1),
                        Durum = reader.GetBoolean(2)
                    });
                }
                return birimler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool BirimEkle(Birim b)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Birimler(Isim,Durum,Silinmis) VALUES(@isim,@durum,0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isim", b.Isim);
                cmd.Parameters.AddWithValue("@durum", b.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Birim BirimGetir(int id)
        {
            try
            {
                Birim b = new Birim();
                cmd.CommandText = "SELECT ID,Isim,Durum FROM Birimler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    b = new Birim()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1),
                        Durum = reader.GetBoolean(2)
                    };
                }
                return b;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool BirimSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Birimler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool BirimGuncelle(Birim model)
        {
            try
            {
                cmd.CommandText = "UPDATE Birimler SET Isim=@isim, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Urun Metotları
        public List<Urun> UrunListeleReader()
        {
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT U.ID, U.BarkodNo, U.Kategori_ID, K.Isim, U.Marka_ID, M.Isim, U.Birim_ID, B.Isim, U.KDVOrani, U.Isim, U.Stok, U.Aciklama, U.BirimFiyat, U.Durum FROM Urunler AS U JOIN Kategoriler AS K ON U.Kategori_ID=K.ID JOIN Markalar AS M ON U.Marka_ID=M.ID JOIN Birimler AS B ON U.Birim_ID=B.ID WHERE U.Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    urunler.Add(new Urun()
                    {
                        ID = reader.GetInt32(0),
                        BarkodNo = reader.GetString(1),
                        Kategori_ID= reader.GetInt32(2),
                        KategoriIsmi = reader.GetString(3),
                        Marka_ID = reader.GetInt32(4),
                        MarkaIsmi=reader.GetString(5),
                        Birim_ID = reader.GetInt32(6),
                        BirimIsmi = reader.GetString(7),
                        KDVOrani = reader.GetInt32(8),
                        Isim = reader.GetString(9),
                        Stok = reader.GetDecimal(10),
                        Aciklama = reader.GetString(11),
                        BirimFiyat = reader.GetDecimal(12),
                        Durum = reader.GetBoolean(13),
                    }); 
                }
                return urunler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UrunEkle(Urun u)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Urunler(BarkodNo, Kategori_ID, Marka_ID, Birim_ID, KDVOrani, Isim, Stok, Aciklama, BirimFiyat, Durum, Silinmis) VALUES(@barkodno, @kategori_id, @marka_id, @birim_id, @kdvorani, @isim, @stok, @aciklama, @birimfiyat, @durum, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@barkodno", u.BarkodNo);
                cmd.Parameters.AddWithValue("@kategori_id", u.Kategori_ID);
                cmd.Parameters.AddWithValue("@marka_id", u.Marka_ID);
                cmd.Parameters.AddWithValue("@birim_id", u.Birim_ID);
                cmd.Parameters.AddWithValue("@kdvorani", u.KDVOrani);
                cmd.Parameters.AddWithValue("@isim", u.Isim);
                cmd.Parameters.AddWithValue("@stok", u.Stok);
                cmd.Parameters.AddWithValue("@aciklama", u.Aciklama);
                cmd.Parameters.AddWithValue("@birimfiyat", u.BirimFiyat);
                cmd.Parameters.AddWithValue("@durum", u.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public Urun UrunGetir(int id)
        {
            try
            {
                Urun u = new Urun();
                cmd.CommandText = "SELECT U.ID, U.BarkodNo, U.Kategori_ID, K.Isim, U.Marka_ID, M.Isim, U.Birim_ID, B.Isim, U.KDVOrani, U.Isim, U.Stok, U.Aciklama, U.BirimFiyat, U.Durum FROM Urunler AS U JOIN Kategoriler AS K ON U.Kategori_ID=K.ID JOIN Markalar AS M ON U.Marka_ID=M.ID JOIN Birimler AS B ON U.Birim_ID=B.ID WHERE U.ID=@id";
                cmd.Parameters.Clear();
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    u=new Urun()
                    {
                        ID = reader.GetInt32(0),
                        BarkodNo = reader.GetString(1),
                        Kategori_ID = reader.GetInt32(2),
                        KategoriIsmi = reader.GetString(3),
                        Marka_ID = reader.GetInt32(4),
                        MarkaIsmi = reader.GetString(5),
                        Birim_ID = reader.GetInt32(6),
                        BirimIsmi = reader.GetString(7),
                        KDVOrani = reader.GetInt32(8),
                        Isim = reader.GetString(9),
                        Stok = reader.GetDecimal(10),
                        Aciklama = reader.GetString(11),
                        BirimFiyat = reader.GetDecimal(12),
                        Durum = reader.GetBoolean(13),
                    };
                }
                return u;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UrunSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Urunler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UrunGuncelle(Urun model)
        {
            try
            {
                cmd.CommandText = "UPDATE Urunler SET BarkodNo=@barkodno, Kategori_ID =@kategori_id, Marka_ID = @marka_id, Birim_ID=@birim_id, KDVOrani=@kdvorani, Isim=@isim, Stok=@stok, Aciklama=@aciklama, BirimFiyat=@birimfiyat, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@barkodno", model.BarkodNo);
                cmd.Parameters.AddWithValue("@kategori_id", model.Kategori_ID);
                cmd.Parameters.AddWithValue("@marka_id", model.Marka_ID);
                cmd.Parameters.AddWithValue("@birim_id", model.Birim_ID);
                cmd.Parameters.AddWithValue("@kdvorani", model.KDVOrani);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("@stok", model.Stok);
                cmd.Parameters.AddWithValue("@aciklama", model.Aciklama);
                cmd.Parameters.AddWithValue("@birimfiyat", model.BirimFiyat);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Satın Alma Metotları
        public List<SatinAlma> SatinAlmaListeleReader()
        {
            List<SatinAlma> alimlar = new List<SatinAlma>();
            try
            {
                cmd.CommandText = "SELECT A.ID, A.Urun_ID, U.Isim, A.Tedarikci_ID, T.FirmaAdi, A.BirimAdet, U.Birim_ID, B.Isim, A.AlisFiyat, A.AlisTarihi FROM Alimlar AS A JOIN Urunler AS U ON A.Urun_ID=U.ID JOIN Tedarikciler AS T ON A.Tedarikci_ID=T.ID JOIN Birimler AS B ON U.Birim_ID=B.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    alimlar.Add(new SatinAlma()
                    {
                        ID=reader.GetInt32(0),
                        Urun_ID=reader.GetInt32(1),
                        UrunIsmi = reader.GetString(2),
                        Tedarikci_ID = reader.GetInt32(3),
                        TedarikciIsmi = reader.GetString(4),
                        BirimAdet = reader.GetDecimal(5),
                        Birim_ID = reader.GetInt32(6),
                        BirimIsmi = reader.GetString(7),
                        AlisFiyati = reader.GetDecimal(8),
                        AlisTarihi = reader.GetDateTime(9),
                    });
                }
                return alimlar;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool SatinAlmaEkle(SatinAlma s)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Alimlar(Urun_ID,Tedarikci_ID,BirimAdet,AlisFiyat,AlisTarihi) VALUES(@urun_id,@tedarikci_id,@birimadet,@alisfiyat,@alistarihi)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@urun_id", s.Urun_ID);
                cmd.Parameters.AddWithValue("@tedarikci_id", s.Tedarikci_ID);
                cmd.Parameters.AddWithValue("@birimadet", s.BirimAdet);
                cmd.Parameters.AddWithValue("@alisfiyat", s.AlisFiyati);
                cmd.Parameters.AddWithValue("@alistarihi", s.AlisTarihi);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public SatinAlma SatinAlmaGetir(int id)
        {
            try
            {
                SatinAlma s = new SatinAlma();
                cmd.CommandText = "SELECT A.ID, A.Urun_ID, U.Isim, A.Tedarikci_ID, T.FirmaAdi, A.BirimAdet, U.Birim_ID, B.Isim, A.AlisFiyat, A.AlisTarihi FROM Alimlar AS A JOIN Urunler AS U ON A.Urun_ID=U.ID JOIN Tedarikciler AS T ON A.Tedarikci_ID=T.ID JOIN Birimler AS B ON U.Birim_ID=B.ID WHERE A.ID = @id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    s = new SatinAlma()
                    {
                        ID = reader.GetInt32(0),
                        Urun_ID = reader.GetInt32(1),
                        UrunIsmi = reader.GetString(2),
                        Tedarikci_ID = reader.GetInt32(3),
                        TedarikciIsmi = reader.GetString(4),
                        BirimAdet = reader.GetDecimal(5),
                        Birim_ID = reader.GetInt32(6),
                        BirimIsmi = reader.GetString(7),
                        AlisFiyati = reader.GetDecimal(8),
                        AlisTarihi = reader.GetDateTime(9),
                    };
                }
                return s;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool SatinAlmaSil(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Alimlar WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool SatinAlmaGüncelle(SatinAlma model)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET Urun_ID=@urun_id, Tedarikci_ID =@tedarikci_id, BirimAdet = @birimadet, AlisFiyat=@alisfiyat, AlisTarihi=@alistarihi WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@urun_id", model.Urun_ID);
                cmd.Parameters.AddWithValue("@tedarikci_id", model.Tedarikci_ID);
                cmd.Parameters.AddWithValue("@birimadet", model.BirimAdet);
                cmd.Parameters.AddWithValue("@alisfiyat", model.AlisFiyati);
                cmd.Parameters.AddWithValue("@alistarihi", model.AlisTarihi);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
