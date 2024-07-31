namespace 스택과_큐_기본학습2
/*
  과제 2. 작업 일정 계산기
다음의 조건을 충족하는 작업 일정 계산기 프로그램을 구현하시오
하루에 8시간씩 일하는 회사가 있으며 남는시간 없이 주어진 일을 계속한다
각 작업이 몇시간이 걸리는 작업인지 포함하는 배열을 받을 때, 각각의 작업이 끝나는 날짜를 결과 배열로 출력하는 함수를 작성하자
예시
입력 : [4, 4, 12, 10, 2, 10]
출력 : [1, 1, 3, 4, 4, 6]
해석
1일차 : 0번째 작업의 4/4 완료 + 1번쨰 작업의 4/4 완료.
2일차 : 2번째 작업의 8/12 완료
3일차 : 2번째 작업의 4/12 완료 + 3번째 작업의 4/10 완료
4일차 : 3번째 작업의 6/10 완료 + 4번째 작업의 2/2 완료
5일차 : 5번째 작업의 8/10 완료
6일차 : 5번째 작업의 2/10 완료
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 4, 4, 12, 10, 2, 10 };
            List<int> endDays = EndDayCirculator(list);
            Console.WriteLine($"[{string.Join(", ", endDays)}]");


        }

        static List<int> EndDayCirculator(List<int> workHours)
        {
            List<int> endDays = new List<int>();
            Queue<int> queue = new Queue<int>(workHours);
            int day = 1;
            int currentWorkTime = 0;

            foreach(int workHour in workHours)
            {
                currentWorkTime += workHour;

                while (currentWorkTime > 8)
                {
                    currentWorkTime -= 8;
                    day++;
                }

                endDays.Add(day);
            }

            
            return endDays;
        }
    }
}
