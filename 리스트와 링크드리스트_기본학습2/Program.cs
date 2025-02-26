﻿using System.Collections.Generic;

namespace 리스트와_링크드리스트_기본학습2
/*과제 2. 요세푸스 순열
아래의 요세푸스 순열에 대한 설명을 보고 N와 K 가 주어지면 결과를 출력하는 프로그램으로 구현하시오.

-1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다. 
이제 순서대로 K번째 사람을 제거한다. 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 
이 과정은 N명의 사람이 모두 제거될 때까지 계속된다. 원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다. 
예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고 순서대로 K번째 사람을 제거하는 요세푸스 순열입니다.");
            Console.Write("N번 숫자를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.Write("K번 숫자를 입력해주세요: ");
            int.TryParse(Console.ReadLine(), out int k);

            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 1; i <= n; i++)
            {
                linkedList.AddLast(i);
            }


            while (linkedList.Count > 0)
            {
                for (int i = 1; i <= k; i++)
                {
                    LinkedListNode<int> node = linkedList.First;

                    if (i == k)
                    {
                        Console.Write($"{node.Value},");
                        linkedList.RemoveFirst() ;
                    }
                    else
                    {
                        linkedList.RemoveFirst();
                        linkedList.AddLast(node);
                    }
                }

            }
        }
    }
}

