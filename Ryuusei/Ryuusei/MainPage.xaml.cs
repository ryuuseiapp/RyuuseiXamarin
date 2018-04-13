using Naxam.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ryuusei
{
    class MainPage : BottomTabbedPage
    {
        public MainPage()
        {
            this.Title = "TabbedPage";

            this.ItemsSource = new NamedColor[] {
                new NamedColor ("远虑", Color.Red),
                new NamedColor ("近忧", Color.Yellow),
                new NamedColor ("焦虑一下", Color.Green),
            };

            this.ItemTemplate = new DataTemplate(() => {
                return new NamedColorPage();
            });
        }
    }

    // Data type:
    class NamedColor
    {
        public NamedColor(string name, Color color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name { private set; get; }

        public Color Color { private set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

    // Format page
    class NamedColorPage : ContentPage
    {
        public NamedColorPage()
        {
            // This binding is necessary to label the tabs in
            // the TabbedPage.
            this.SetBinding(ContentPage.TitleProperty, "Name");

            var layout = new StackLayout { Padding = new Thickness(5, 10) };
            this.Content = layout;
            var label = new Label { FontSize = 20 };
            var s = new FormattedString();
            s.Spans.Add(new Span { Text = "Check", FontAttributes = FontAttributes.Bold });
            label.FormattedText = s;
            layout.Children.Add(label);
            
        }
    }
}
