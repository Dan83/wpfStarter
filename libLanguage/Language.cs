using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.localize
{
    public enum Language
    {
        English = 0x0009,
        Italiano = 0x0010,
    }

    public class Language_Helper
    {
        public static Language Parse(String nameLangage)
        {
            switch (nameLangage)
            {
                case "English": return Language.English;
                case "Italiano": return Language.Italiano;
            }

            return Language.English;
        }
    }
}
