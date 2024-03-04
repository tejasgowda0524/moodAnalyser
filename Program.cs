using System;
using System.Runtime.CompilerServices;

namespace uc4
{
    public class moodAnalyser
    {

        public string message;

        public moodAnalyser(string message)
        {
            this.message = message;
        }
        public moodAnalyser()
        {
            
            this.message = message;
        }
        public void analyseMood(string message)
        {

            try
            {
                
                if (message != null)
                {
                    string[] m = message.Split(' ');

                    if (m.Contains("sad"))
                    {
                        Console.WriteLine("SAD :(");
                    }
                    else
                    {
                        Console.WriteLine("HAPPY :)");
                    }
                }
                else
                {
                    throw new moodAnalysisException("Null reference exception occurred..");
                    //Console.WriteLine("Null reference exception occurred..");
                }
            }
            catch (moodAnalysisException e)
            {
                Console.WriteLine("exception occurred: " +e.Message);
            }

            Console.ReadLine();

        }


        internal class Program
        {
            static void Main(string[] args)
            {
               // moodAnalyser ma1 = new moodAnalyser("im happy");
               moodAnalyser ma = new moodAnalyser();
                // moodAnalyser ma = new moodAnalyser(null);


                Console.WriteLine("enter your current mood ..");
                string mood = Console.ReadLine();


                // string mood = null;
               // ma1.analyseMood();
                
                ma.analyseMood(mood);

            }
        }
    }
}
    
