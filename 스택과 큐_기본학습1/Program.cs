namespace 스택과_큐_기본학습1
/*
과제 1. 괄호 검사기
다음의 조건을 충족하는 괄호 검사기 프로그램을 구현하시오
괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻이다
텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 프로그램을 작성하자
검사할 괄호 : [], {}, ()
예시 : () 완성, (() 미완성, [[(){}]] 완성, [(})] 미완성
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("검사할 문자열을 입력하세요: ");
            string input = Console.ReadLine();
            bool answer = isCorrect(input);
            if (answer == true)
            {
                Console.WriteLine("짝이 지어졌습니다.");
            }
            else
            {
                Console.WriteLine("짝이 지어지지 않았습니다.");
            }

        }

        static bool isPair(char open, char close)
        {
            return open == '(' && close == ')' || open == '{' && close == '}' || open == '[' && close == ']';
        }

        static bool isCorrect(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || !isPair(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
