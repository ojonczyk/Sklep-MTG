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
using System.Windows.Shapes;
using System.Xml;

namespace Sklep_MTG
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(XmlNode node)
        {
            InitializeComponent();
            for(var i = 0; i < node.ChildNodes.Count - 1; ++i)
            {
                label1.Content += node.ChildNodes[i].Name.First().ToString().ToUpper()+node.ChildNodes[i].Name.Substring(1)+": ";
                if (node.ChildNodes[i].InnerText.Length != 0)
                {
                    label1.Content += node.ChildNodes[i].InnerText + "\n\n";
                } else
                {
                    label1.Content += node.ChildNodes[i].Attributes[0].Value+"\n\n";
                }
            }
            image1.Source = new BitmapImage( new Uri(node.ChildNodes[4].InnerText, UriKind.RelativeOrAbsolute));
        }
    }
}
