using System;
using System.Windows.Markup;
using it.localize;

namespace it.gui.localize
{
    public class LocalizeMackup : MarkupExtension
    {
        [ConstructorArgument("key")]
        public string Key { get; set; }

        public LocalizeMackup(string key)
        {
            Key = key;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            try
            {
                Localize l = Localize.Instance;
                return l.getString(Key);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
