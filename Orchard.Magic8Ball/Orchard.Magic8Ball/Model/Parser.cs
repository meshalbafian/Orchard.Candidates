using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Orchard.Magic8Ball.Model
{
    public class Parser
    {
        public string Parse(string question)
        {
            var result = "Not a question";

            var validPattern = "[a-zA-Z]+";

            Regex rgx2 = new Regex("[^a-zA-Z \\?]+");
            question = rgx2.Replace(question, "");

            question = question.ToLower().Split('?')[0];

            if (Regex.IsMatch(question,validPattern))
                return question;
            
            return result;
        }
    }
}
