using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bai_tap_hinh_hoc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            HinhTron[] hinhtrons = new HinhTron[5];
            int[] banKinh = { 3, 5, 2, 3, 5 };
            for (int i = 0; i < hinhtrons.Length; i++)
                hinhtrons[i] = new HinhTron(banKinh[i]);
            for (int i = 0; i < hinhtrons.Length; i++)
            {
                hinhtrons[i].ChuVi();
                hinhtrons[i].DienTich();

                lstHinhTron.Items.Add((i + 1).ToString() + "\t\t" + hinhtrons[i].R.ToString() + "\t\t" +
                    hinhtrons[i].chuvi.ToString() + "\t\t" + hinhtrons[i].dientich.ToString());
                lb1.Content = "STT" + "\t\t" + "Ban Kinh" + "\t\t" + "Chu Vi" + "\t\t" + "Dien Tich";
            }

            HinhVuong[] hinhVuongs = new HinhVuong[5];
            int[] canh = { 3, 5, 2, 3, 5 };

            for (int i = 0; i < hinhVuongs.Length; i++)
                hinhVuongs[i] = new HinhVuong(canh[i]);


            for (int i = 0; i < hinhVuongs.Length; i++)
            {
                hinhVuongs[i].ChuVi();
                hinhVuongs[i].DienTich();

                lstHinhVuong.Items.Add((i + 1).ToString() + "\t\t" + hinhVuongs[i].Canh.ToString() + "\t\t" +
                    hinhVuongs[i].chuvi.ToString() + "\t\t" + hinhVuongs[i].dientich.ToString());
                lb1_Copy.Content = "STT" + "\t\t" + "Canh" + "\t\t" + "Chu Vi" + "\t\t" + "Dien Tich";
            }

        }
    }
}
