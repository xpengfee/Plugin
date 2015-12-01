using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Svr.Plugin.SyncData.SMS
{
    public class ComboBoxItem
    {
        private String _ItemText = null;
        private Int32 _ItemValue = -1;

        public String Text
        {
            get
            {
                return _ItemText;
            }
            set
            {
                _ItemText = value;
            }
        }
        public Int32 Value
        {
            get
            {
                return _ItemValue;
            }
            set
            {
                _ItemValue = value;
            }
        }
        public override String ToString()
        {
            return _ItemText;
        }
        public ComboBoxItem()
        {
        }
        public ComboBoxItem(String cText)
        {
            _ItemText = cText;
        }
        public ComboBoxItem(Int32 iValue, String cText)
        {
            _ItemValue = iValue;
            _ItemText = cText;
        }

    }
}
