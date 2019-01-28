﻿//[?] Stack 클래스: LIFO(Last In First Out) 형태의 데이터 보관
using System;
using System.Collections;

class StackDemo
{
    static void Main()
    {
        Stack stack = new Stack();

        // Push()로 데이터 저장
        stack.Push("닷넷노트");
        stack.Push("닷넷코리아");
        stack.Push("비주얼아카데미");

        //[a] Peek()로 제일 상단(마지막)의 데이터 반환
        Console.WriteLine($"{stack.Peek()}, {stack.Count}");

        //[b] Pop()로 현재 스택의 가장 마지막 데이터 제거
        stack.Pop();

        //[c] 스택의 마지막 데이터 반환: 만약 스택이 비어있을 때에는 에러 발생
        Console.WriteLine($"{stack.Peek()}, {stack.Count}");

        // Count로 스택의 데이터 개수를 확인
        if (stack.Count > 0)
        {
            stack.Pop(); // 가장 마지막 데이터 제거 
            Console.WriteLine($"{stack.Peek()}, {stack.Count}");
        }

        // Clear()로 스택 비우기
        stack.Clear(); // 비우기
        Console.WriteLine($"{stack.Count}");
    }
}
