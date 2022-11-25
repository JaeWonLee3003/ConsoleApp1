using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LadderPosition
    {

        public LadderPosition(int x, int y)
        {

        }
    }

    public class StartBox
    {
        public int StartB = 0;
    }
    public class EndBox
    {
        public int EndB = 0;

    }



    public class mainClass
    {
        public static int StartB { get; private set; }
        public static int EndB { get; private set; }


        public static void Main(string[] args)
        {
            int EndInBox = 0; // 마지막에 담길 박스 개수
            int inputBoxNum = 0; // 입력된 박스 개수
            int StartInBox = 0; // 처음에 담길 박스 개수
            bool a = true; // a 에 true 값을 주고 처음부터 while 문을 활성화 해줌.



            while (a) // 바로 활성화
            {
                Console.WriteLine("몇 개를 입력 하시겠습니까?");
                inputBoxNum = int.Parse(Console.ReadLine()); // inputBoxNum 안에 횟수를 입력
                StartB = inputBoxNum; // StartB 변수 안에 횟수를 할당
                Console.WriteLine("입력 받은 시작 박스 의 개수는 " + StartB + " 개 입니다.\n");

                switch (StartB) // 입력 된 횟수를 케이스로 찾아감
                {

                    case 5:
                        StartInBox = StartB; // 처음 들어갈 박스 박스안에 할당
                        EndInBox = StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 5개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false; // 강제종료 break; 가 안먹힘 이유는 모름
                        break;
                    case 4:
                        StartInBox = StartB;
                        EndInBox = StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 4개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false;
                        break;
                    case 3:
                        StartInBox = StartB;
                        EndInBox = StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 3개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false;
                        break;
                    case 2:
                        StartInBox = StartB;
                        EndInBox = StartB; // 마지막 들어갈 박스안에 할당
                        Console.WriteLine("입력할 텍스트 2개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다.\n ");
                        a = false;
                        break;
                    case 1:
                        StartInBox = StartB;
                        Console.WriteLine("2개 이상 선택 해 주세요.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        break;
                    default:
                        Console.WriteLine("다시 입력해주세요. ^^ ( 최대 5개 )\n");
                        break;
                }
            }
            // Console.WriteLine("사다리에서 내려올 내용을 " + StartInBox + "개 적어주세요.\n");
            string[] StartArr = new string[StartInBox]; // StartArr 배열 안에 입력할 횟수인 StartInBox
            Console.WriteLine("TEST : StartArr 배열 안에 들어간 길이는 " + StartArr.Length + "입니다.");
            Console.WriteLine("입력 가능한 횟수는 :" + StartArr.Length + "회 입니다.");
            for (int i = 0; i < StartArr.Length; i++)
            {

                StartArr[i] = Console.ReadLine();
                Console.WriteLine(StartArr[i]);
            }




            /*switch (StartInBox)
            {
                case 1:
                    Console.WriteLine("1개로는 시작 b할 수 없습니다.");
                    break;
                case 2:
                    
                    Console.WriteLine("입력한 내용은"+ StartArr[StartInBox] + " 입니다. ");
                    break;
            }*/



        }
    }
}

