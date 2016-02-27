using System;

namespace DesignPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };

            var expression = new NonterminalExpression();
            expression.Interpret(context);
            Console.WriteLine(context.Result);
        }
    }
}