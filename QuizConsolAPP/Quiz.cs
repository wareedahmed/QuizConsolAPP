using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsolAPP

{
    public class Quiz

    {

        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)

        {
            _questions = questions;
            _score = 0;
        }

        public void Start()
        {
            int questionIndex = 0;

            while (questionIndex < _questions.Length)
            {
                Console.Clear();
                DisplayQuestion(_questions[questionIndex]);
                int selectedOption = GetUserChoice();

                if (_questions[questionIndex].CheckAnswer(selectedOption))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                questionIndex++;
            }

            DisplayScore();
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.Text);
            for (int i = 0; i < question.Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Options[i]}");
            }
        }

        private int GetUserChoice()
        {
            int selectedOption;
            string input;

            Console.Write("Select an option (1-4): ");
            input = Console.ReadLine();

            while (!int.TryParse(input, out selectedOption) || selectedOption < 1 || selectedOption > 4)
            {
                Console.Write("Invalid option. Please select a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return selectedOption;
        }

        private void DisplayScore()
        {
            Console.Clear();
            Console.WriteLine($"Quiz finished! Your score is {_score}/{_questions.Length}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
