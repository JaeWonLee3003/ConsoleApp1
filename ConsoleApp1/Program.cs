using System;

namespace Test
{
    class Cat
    {
        public string Name = null;

        // 속성은 반드시 초기화해야 하며 그렇지 않으면 경고 메세지가 출력 된다. 값이 없을 때는 null로 초기화 한다.
        public Cat()
        {
            Console.WriteLine("생성자가 호출되었습니다.");

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cat MyCat = new Cat();
        }
    }
}