using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace markupExtension_
{
    internal class randomPasswordExtension : MarkupExtension
    {
        public int Length { get; set; }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Random rand = new Random();
            string chars = "qwertyuiopasdfghjklzxcvbnm1234567890";
            StringBuilder b = new();
            for (int i = 0; i < Length; i++)
            {
                b.Append(chars[rand.Next(chars.Length)]);
            }
            return b.ToString();
        }


    }
}
