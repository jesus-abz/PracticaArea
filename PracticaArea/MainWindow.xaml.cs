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

namespace PracticaArea
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnButtonRec(object sender, RoutedEventArgs e)
        {
            float BaseRec =
            float.Parse(txtBaseRec.Text);

            float AlturaRec =
            float.Parse(txtAlturaRec.Text);

            float AreaRec = BaseRec * AlturaRec;
            txtAreaRec.Text = AreaRec.ToString();
        }

        private void btnButtonTri(object sender, RoutedEventArgs e)
        {
            float BaseTri =
            float.Parse(txtBaseTri.Text);

            float AlturaTri =
            float.Parse(txtAlturaTri.Text);

            float AreaTri = (BaseTri * AlturaTri) /2;
            txtAreaTri.Text = AreaTri.ToString();
        }

        private void btnButtonCir(object sender, RoutedEventArgs e)
        {
            float Radio =
            float.Parse(txtRadio.Text);

            float AreaCir = 3.14f * (Radio * Radio);
            txtAreaCir.Text = AreaCir.ToString();
        }

        private void btnButtonTra(object sender, RoutedEventArgs e)
        {
            float BaseMay =
            float.Parse(txtBaseMay.Text);

            float BaseMen =
            float.Parse(txtBaseMen.Text);

            float AlturaTra =
            float.Parse(txtAlturaTra.Text);

            float AreaTra = ((BaseMay + BaseMen) *AlturaTra) / 2;
            txtAreaTra.Text = AreaTra.ToString();
        }
    }
}
