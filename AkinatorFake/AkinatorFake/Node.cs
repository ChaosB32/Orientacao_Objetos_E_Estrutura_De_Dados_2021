using System;
using System.Collections.Generic;
using System.Text;

namespace AkinatorFake
{
    class Node
    {
        public Node(string content)
        {
            NodeYes = null;
            Content = content;
            NodeNo = null;
        }

        public Node NodeYes { get; set; }
        public string Content { get; set; }
        public Node NodeNo { get; set; }

        public void ProcessNode()
        {
            if (isQuestion())
            {
                Console.WriteLine(Content);
                Console.WriteLine("Type 'y' for yes or 'n' for no:");
                char answer = char.Parse(Console.ReadLine());
                if(answer == 'y')
                {
                    NodeYes.ProcessNode();
                }
                else
                {
                    NodeNo.ProcessNode();
                }
            }
            else
            {
                PresentAnswer();
            }
        }

        private bool isQuestion()
        {
            if(NodeYes!= null && NodeNo!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PresentAnswer()
        {
            Console.WriteLine($"Did you think of {Content}?");
            Console.WriteLine("Type 'y' for yes or 'n' for no:");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y')
            {
                Console.WriteLine("Oops, it looks like I got it right!");
            }
            else
            {
                Console.WriteLine("Oh, I couldn't get it right!");
                Console.WriteLine("But what were you thinking about?");
                string correctAnswer = Console.ReadLine();
                Console.WriteLine("To help me improve, what would be a good question to differ between " + 
                    $"{Content} and {correctAnswer}?");
                string newQuestion = Console.ReadLine();
                Console.WriteLine($"If you are thinking about {correctAnswer}, what would be the answer to that question?");
                char answerNewQuestion = char.Parse(Console.ReadLine());
                if(answerNewQuestion == 'y')
                {
                    NodeYes = new Node(correctAnswer);
                    NodeNo = new Node(Content);
                }
                else
                {
                    NodeYes = new Node(Content);
                    NodeNo = new Node(correctAnswer);
                }
                Content = newQuestion;
            }
        }
    }
}
