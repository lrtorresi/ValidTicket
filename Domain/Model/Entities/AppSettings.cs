using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Entities
{
    public class AppSettings
    {
        public string StringSetting { get; set; }

        public int IntegerSetting { get; set; }

        public bool BooleanSetting { get; set; }

        public string Uri { get; set; }
    }
}
