using System.Data;

namespace QLSV
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        DataTable tblKhoa = new DataTable("KHOA");
        DataTable tblSinhVien = new DataTable("SINHVIEN");
        DataTable tblKetQua = new DataTable("KETQUA");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tao_CauTrucBang();
            Moc_NoiQuanHeCacBang();
            Nhap_Lieu();
            Khoi_Tao_Combo_Khoa();
        }

        private void Khoi_Tao_Combo_Khoa()
        {
            comKhoa.DisplayMember = "TenKH";
            comKhoa.ValueMember = "MaKH";
            comKhoa.DataSource = tblKhoa;
        }

        private void Nhap_Lieu()
        {
            Nhap_Lieu_SinhVien();
            Nhap_Lieu_Khoa();
            Nhap_Lieu_KQ(); ;
        }

        private void Nhap_Lieu_KQ()
        {
            string[] Mang_KetQua = File.ReadAllLines(@"..\..\..\data\ketqua.txt");
            foreach (string Chuoi_KQ in Mang_KetQua)
            {
                string[] Mang_Thanh_Phan = Chuoi_KQ.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                DataRow rkq = tblKetQua.NewRow();
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                    rkq[i] = Mang_Thanh_Phan[i];
                tblKhoa.Rows.Add(rkq);
            }
        }

        private void Nhap_Lieu_Khoa()
        {
            string[] Mang_Khoa = File.ReadAllLines(@"..\..\..\data\khoa.txt");
            foreach (string Chuoi_khoa in Mang_Khoa)
            {
                string[] Mang_Thanh_Phan = Chuoi_khoa.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                DataRow rkh = tblKhoa.NewRow();
                rkh[0] = Mang_Thanh_Phan[0];
                rkh[1] = Mang_Thanh_Phan[1];
                tblKhoa.Rows.Add(rkh);
            }
        }

        private void Nhap_Lieu_SinhVien()
        {
            string[] Mang_SinhVien = File.ReadAllLines(@"..\..\..\data\sinhvien.txt");
            foreach (string Chuoi_SV in Mang_SinhVien)
            {
                string[] Mang_Thanh_Phan = Chuoi_SV.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                DataRow rsv = tblSinhVien.NewRow();
                for (int i = 0; i < Mang_Thanh_Phan.Length; i++)
                {
                    rsv[i] = Mang_Thanh_Phan[i];
                }
                tblKhoa.Rows.Add(rsv);
            }
        }

        private void Moc_NoiQuanHeCacBang()
        {
            ds.Relations.Add("FK_KH_SV", ds.Tables["KHOA"].Columns["MaKH"], ds.Tables["SINHVIEN"].Columns["MaKH"], true);
            ds.Relations.Add("FK_SV_KQ", ds.Tables["SINHVIEN"].Columns["MaSV"], ds.Tables["KETQUA"].Columns["MaSV"], true);
            ds.Relations["FK_KH_SV"].ChildKeyConstraint.DeleteRule = Rule.None;
            ds.Relations["FK_SV_KQ"].ChildKeyConstraint.DeleteRule = Rule.None;
        }

        private void Tao_CauTrucBang()
        {
            tblKhoa.Columns.Add("MaKH", typeof(string));
            tblKhoa.Columns.Add("TenKH", typeof(string));
            tblKhoa.PrimaryKey = new DataColumn[] { tblKhoa.Columns["MaKH"] };

            tblSinhVien.Columns.Add("MaSV", typeof(string));
            tblSinhVien.Columns.Add("HoSV", typeof(string));
            tblSinhVien.Columns.Add("TenSV", typeof(string));
            tblSinhVien.Columns.Add("Phai", typeof(Boolean));
            tblSinhVien.Columns.Add("NgaySinh", typeof(DateTime));
            tblSinhVien.Columns.Add("NoiSinh", typeof(string));
            tblSinhVien.Columns.Add("MaKH", typeof(string));
            tblSinhVien.Columns.Add("HocBong", typeof(double));
            tblSinhVien.PrimaryKey = new DataColumn[] { tblSinhVien.Columns["MaSV"] };

            tblKetQua.Columns.Add("MaSV", typeof(string));
            tblKetQua.Columns.Add("MaMH", typeof(String));
            tblKetQua.Columns.Add("Diem", typeof(double));
            tblKetQua.PrimaryKey = new DataColumn[] { tblKetQua.Columns["MaSV"], tblKetQua.Columns["MaMH"] };

            ds.Tables.AddRange(new DataTable[] { tblKhoa, tblSinhVien, tblKetQua });
        }
    }
}
