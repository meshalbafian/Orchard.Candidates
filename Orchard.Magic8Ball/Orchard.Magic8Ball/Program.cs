using Orchard.Magic8Ball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Magic8Ball
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type your question with question mark in the end and ESC to exit");
            #region Initialize
            var answerObj = new Answers();
            var questionObj = new Questions();
            var parserObj = new Parser();
            #endregion

            do
            {
                var question = Console.ReadLine();
                question = parserObj.Parse(question);
                //Console.WriteLine("Parsed Question is : "+parserObj.Parse(question));

                var randomAnswer = answerObj.GetAnswer();
                
                questionObj.SetKeyValuePair(question, randomAnswer);

                Console.WriteLine("Answer is : " + questionObj.GetValueOfAKey(question));

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
