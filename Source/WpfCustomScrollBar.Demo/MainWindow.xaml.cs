using System.Collections.Generic;
using System.Text;

namespace WpfCustomScrollBar.Demo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            AddDummyItems();
            DataContext = this;
        }

        public List<string> DummyItems { get; set; }

        private void AddDummyItems()
        {
            DummyItems = new List<string>();            

            for (var i = 0; i < 100; ++i)
            {
                var itemBuilder = new StringBuilder();

                for (var j = 0; j <= i; j++)
                {
                    itemBuilder
                        .Append((j + 1).ToString().PadLeft(3, '0'))
                        .Append("  ");
                }

                DummyItems.Add(itemBuilder.ToString());
            }
        }
    }
}
