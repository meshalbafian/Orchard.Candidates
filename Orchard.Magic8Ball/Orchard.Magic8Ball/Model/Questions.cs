using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Magic8Ball.Model
{
    public class Questions
    {
        private Dictionary<string, string> QuestionsDict { get; set; } 
        public Questions()
        {
            QuestionsDict = new Dictionary<string, string>();
        }
        public Questions(string Key, string Value):base()
        {
            SetKeyValuePair(Key, Value);
        }
        public void SetKeyValuePair(string Key, string Value)
        {
            if (!QuestionsDict.ContainsKey(Key))
                QuestionsDict.Add(Key, Value);
        }
        public string GetValueOfAKey(string Key)
        {
            if(QuestionsDict.ContainsKey(Key))
            {
                var value = "";
                QuestionsDict.TryGetValue(Key, out value);
                return value;
            }
            return "";
        }
    }
}
