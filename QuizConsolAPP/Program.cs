using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsolAPP
{
    internal class Program
    {
        static void Main(string[] args)

        {

            var questions = new Question[]

            {
                new Question("What is the capital of France?",new string[] { "Paris", "London", "Berlin", "Madrid" } ,0),

                new Question("What is 2 + 2?",new string[] { "3", "4", "5", "6" },1),

                new Question("What is the color of the sky?", new string[] { "Blue", "Green", "Red", "Yellow" },0),

                new Question("Who wrote 'To Kill a Mockingbird'?",new string[] { "Harper Lee", "Mark Twain", "Ernest Hemingway", "Jane Austen" },0),

                new Question("What is the boiling point of water?",new string[] { "90°C", "100°C", "110°C", "120°C" },1)
            };

            var quiz = new Quiz(questions);
            quiz.Start();
        }
    }
}
