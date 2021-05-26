using System;
using System.Collections.Generic;
using System.Text;

namespace AkinatorFake
{
    class Tree
    {
        public Tree(string question, string answerYes, string answerNo)
        {
            Root = new Node(question);
            Root.NodeYes = new Node(answerYes);
            Root.NodeNo = new Node(answerNo);
        }

        public Node Root { get; set; }

        public void ProcessTree()
        {
            Root.ProcessNode();
        }
    }
}
