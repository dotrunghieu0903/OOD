using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaraDATA.Info
{
    //Class lấy giá trị và cài đặt giá trị cho báo cáo doanh số
    public class BaoCaoDoanhSo
    {
        public string MaDS { set; get; }
        public int Thang { set; get; }
        public int Nam { set; get; }
        public double TongDoanhSo { set; get; }
    }
}
