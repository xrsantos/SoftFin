﻿using MvvmCross.Platform;
using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftFin.Mobile.Core.Resources
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        private readonly CultureInfo _cultureInfo;

        public TranslateExtension()
        {
            _cultureInfo = Mvx.Resolve<Services.ILocalizeService>().GetCurrentCultureInfo();

            /*if (Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS)
            {
                _cultureInfo = Mvx.Resolve<Services.ILocalizeService>().GetCurrentCultureInfo();
            }*/
        }

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
            {
                return null;
            }

            var translation = AppResources.ResourceManager.GetString(Text, _cultureInfo);

#if DEBUG
            if (translation == null)
            {
                throw new ArgumentException(string.Format("Key {0} was not found for culture {1}.", Text, _cultureInfo));
            }
#endif
            return translation;
        }
    }
}
