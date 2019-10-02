using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_hinh_hoc
{
    class HinhVuong: HinhCN
    {
        public float chuvi;
        public float dientich;

        private float canh;

        public HinhVuong() { }

        public HinhVuong(float canh)
        {
           this.canh = canh;
        }

        public float Canh { get => canh; set => canh = value; }

        public void ChuVi()
        {
            chuvi = Canh * 4;
        }
        public void DienTich()
        {
            dientich = Canh * Canh;
        }
    }
}
