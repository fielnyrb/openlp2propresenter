using System.Collections.Generic;
using System.Windows;


namespace OpenLP2ProPresenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IOpenLPDataImporter openLPImporter = new OpenLPSQLiteImporter();

            TextGeneratorEffectComposite effectComposite = new();
            EffectAddTitles effectAddTitles = new();
            EffectRemoveSeparator effectRemoveSeparator = new();

            effectComposite.AddComponent(effectAddTitles);
            effectComposite.AddComponent(effectRemoveSeparator);

            TextGenerator textGenerator = new(effectComposite);
            IItemConverter itemConverter = new XMLConverter(textGenerator);

            List<ProPresenterItem> structConvertedItems = itemConverter.convert(openLPImporter.getData());

            IExporter proPresenterExporter = new ProPresenterFilesExporter();
            proPresenterExporter.export(structConvertedItems);
        }
    }
}
