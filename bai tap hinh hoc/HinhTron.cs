using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_hinh_hoc
{
    class HinhTron: HinhHoc
    {
        private const float pi = 3.14f;
        private float r;

        public float chuvi;
        public float dientich;

        public float BanKinh
        {
            get { return R; }
            set { R = value; }
        }

        public float R { get => r; set => r = value; }

        public HinhTron() { }
        public HinhTron(float r)
        {
            this.R = r;
        }
        public void ChuVi()
        {
            chuvi = R * 2 * pi;
        }

        public void DienTich()
        {
            dientich = 2 * pi * (R * R);
        }
    }
}
