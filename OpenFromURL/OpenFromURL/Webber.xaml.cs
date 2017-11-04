using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OpenFromURL
{
    public partial class Webber : ContentPage
    {
        public Webber(string url) : base()
        {
            InitializeComponent();
            var webview = new WebView
            {
                Source = url
            };
            Content = webview;
        }
    }
}
