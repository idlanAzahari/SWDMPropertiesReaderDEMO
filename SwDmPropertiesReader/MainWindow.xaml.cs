using PropertiesReader;
using PropertiesReader.ViewModels;
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
using Xarial.XCad.SwDocumentManager;

namespace SwDmPropertiesReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PropertiesReaderService m_PrpsReader;
        public MainWindow()
        {
            InitializeComponent();

            ISwDmApplication app = SwDmApplicationFactory.Create("IMETechnologySdnBhd:swdocmgr_general-11785-02051-00064-50177-08660-34307-00007-07656-23155-22615-56948-13727-16359-32307-28672-42284-20312-57117-54207-35530-01399-24476-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-8,swdocmgr_previews-11785-02051-00064-50177-08660-34307-00007-26976-36946-44340-42110-19511-05289-20001-32769-18951-36459-02681-11125-38731-17573-24414-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-8,swdocmgr_dimxpert-11785-02051-00064-50177-08660-34307-00007-20288-53865-05888-06454-43794-02625-60711-04097-52922-20754-37564-30964-26743-47207-23267-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-7,swdocmgr_geometry-11785-02051-00064-50177-08660-34307-00007-54416-02941-32776-07223-51104-53139-40130-36865-36175-51721-26806-31729-42179-29277-22917-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-4,swdocmgr_xml-11785-02051-00064-50177-08660-34307-00007-02544-31149-46810-40860-18612-17247-60156-47105-16340-20642-42315-59485-62964-08209-24194-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-2,swdocmgr_tessellation-11785-02051-00064-50177-08660-34307-00007-63768-36539-21912-56129-55903-64835-46241-02051-28323-20637-35511-50386-55686-33280-23469-13604-20757-36245-47521-45501-40381-19941-47505-41225-00401-24632-23140-57052-23276-24676-25188-8");
            m_PrpsReader = new PropertiesReaderService(app);
            PropertiesTableVM vm = new PropertiesTableVM(m_PrpsReader);
            DataContext = vm;

        }

        protected override void OnClosed(EventArgs e)
        {
            m_PrpsReader.Dispose();
        }
    }
}
