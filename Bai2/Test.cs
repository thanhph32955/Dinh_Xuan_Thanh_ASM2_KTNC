namespace Bai2
{
    public class Tests
    {
        private SinhVienpoly _sinhVienpoly;
        [SetUp]
        public void Setup()
        {
            _sinhVienpoly = new SinhVienpoly();           
        }

        #region TestAdd_SinhVien
        [TestCase("SV01", "Nguyen Van A", "IT01", "CNTT@", "CNTT1")]
        [TestCase("SV02", "Nguyen Van B", "IT01", "CNTT$", "CNTT2")]
        [TestCase("SV03", "Nguyen Van C", "IT01", "CNTT%", "CNTT3")]
        [TestCase("SV04", "Nguyen Van D", "IT02", "CNTT4", "CNTT4")]
        [TestCase("SV05", "Nguyen Van E", "IT02", "CNTT5", "CNTT5")]
        [TestCase("SV06", "Nguyen Van F", "IT02", "CNTT6", "CNTT6")]
        [TestCase("SV07", "Nguyen Van G", "IT03", "CNTT7", "CNTT7")]
        [TestCase("SV08", "Nguyen Van H", "IT03", "CNTT8", "CNTT8")]
        [TestCase("SV09", "Nguyen Van I", "IT03", "CNTT9", "CNTT9")]
        [TestCase("SV10", "Nguyen Van K", "IT04", "CNTT10", "CNTT10")]
        public void TestAdd_SinhVien(string id, string hoten, string malop, string tenlop, string masv)
        {
            var sv = new SinhVien(id, hoten, malop, tenlop, masv);
            _sinhVienpoly.ThemSinhVien(sv);
            Assert.AreEqual(sv.Masv,_sinhVienpoly.TimKiemTheoMaSV(masv));
        }
        #endregion

        #region TestTimKiem_SinhVien
        [TestCase("IT01")]
        [TestCase("CNTT1")]
       
        public void TestTimKiem_ExistingMasv(string masv)
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", "IT01", "CNTT1", "CNTT1");
            _sinhVienpoly.ThemSinhVien(sv);
            Assert.AreEqual(sv.Masv, _sinhVienpoly.TimKiemTheoMaSV(masv));
        }

        [TestCase("CNTT5")]
        [TestCase("CNTT6")]
        public void TestTimKiem_NotExistingMasv(string masv)
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", "IT01", "CNTT1", "CNTT1");
            _sinhVienpoly.ThemSinhVien(sv);
            Assert.AreEqual(sv.Masv,_sinhVienpoly.TimKiemTheoMaSV(masv));
        }

        [TestCase("")]
        [TestCase(null)]
        public void TimKiemTheoMasv_EmptyOrNullMasv(string masv)
        {
            var sv = new SinhVien("SV01", "Nguyen Van A", "IT01", "CNTT1", "CNTT1");
            _sinhVienpoly.ThemSinhVien(sv);
            Assert.AreEqual(sv.Masv, _sinhVienpoly.TimKiemTheoMaSV(masv));
        }
        #endregion

    }
}