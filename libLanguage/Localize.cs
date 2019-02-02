using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace it.localize
{
    public class Localize
    {
        private Language _language;
        private const string PATH = @"Language\Resources.";
        private System.Globalization.CultureInfo _culture = null;
        private static Localize _instance = null;

        public static Localize Instance
        {
            get
            {
                if (_instance == null) _instance = new Localize();
                return _instance;
            }
        }
        public Localize()
        {
            _culture = new System.Globalization.CultureInfo((Int32)Language.English);
        }
        public Language Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public string getString(string code)
        {
            string cultureName = _culture.Name;
            return ReadResourceValue(PATH + cultureName, code);
        }

        public string ReadResourceValue(string file, string key)
        {
            //value for our return value
            string resourceValue = string.Empty;
            try
            {
                // specify your resource file name 
                string resourceFile = file;
                // get the path of your file
                string filePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
                // create a resource manager for reading from
                //the resx file
                ResourceManager resourceManager = ResourceManager.CreateFileBasedResourceManager(resourceFile, filePath, null);
                // retrieve the value of the specified key
                resourceValue = resourceManager.GetString(key);

                if (resourceValue == null || resourceValue == String.Empty) resourceValue = key;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                resourceValue = key;
            }
            return resourceValue;
        }

        public Language Change
        {
            set
            {
                _culture = new System.Globalization.CultureInfo((int)value);
            }

            get
            {
                return Language_Helper.Parse(_culture.DisplayName);
            }
        }

        public List<Language> LanguageSupported
        {
            get
            {
                return new List<Language>() { Language.English, Language.Italiano };
            }
        }
    }
}
