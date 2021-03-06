﻿using SampleApp.Helpers;

namespace SampleApp.ViewModels
{
    public class XamlIslandViewModel : Observable
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { Set(ref _text, value); }
        }

        public XamlIslandViewModel()
        {
        }
    }
}
