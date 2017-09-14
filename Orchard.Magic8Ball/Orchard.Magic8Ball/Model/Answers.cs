using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Magic8Ball.Model
{
    public class Answers
    {
        public Dictionary<int,string> AnswerDict { get; set; }
        public Answers()
        {
            AnswerDict = new Dictionary<int, string>()
            {
                { 1, "It is certain" },
                { 2, "It is decidedly so" },
                { 3, "Without a doubt"} ,
                { 4, "Yes – definitely"} ,
                { 5, "You may rely on it"} ,
                { 6, "As I see it"} ,
                { 7, "Yes"} ,
                { 8, "Most Likely"} ,
                { 9, "Outlook good"} ,
                {10, "Yes" },
                {11, "Signs point to yes" }
            };
        }
        public string GetAnswer()
        {
            Random rnd = new Random();
            var index = rnd.Next(1, 12);

            var randomValue = "";

            AnswerDict.TryGetValue(index, out randomValue);
            return randomValue;
        }
    }
}
