using System;

namespace Test
{
    class Cat
    {
        public string Name = null;

        // 속성은 반드시 초기화해야 하며 그렇지 않으면 경고 메세지가 출력 된다. 값이 없을 때는 null로 초기화 한다.
        public Cat(string name)
        {
            Name = name;
            Console.WriteLine("고양이 이름은 " + Name + "입니다.");

        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cat coco = new Cat("코코");
            Cat moly = new Cat("몰리");

            // 위 Cat(string name) 를 적었다 시피 Cat 뒤에 string 문자열이 코코와 몰리를 생성 하였기에 들어가는것
        }
    }
}