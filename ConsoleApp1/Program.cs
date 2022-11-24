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
            int EndInBox = 0;
            int inputBoxNum = 0;
            int StartInBox = 0;
            bool a = true;

            string[] StartInBoxInfo = new string[] { };
            Console.WriteLine(StartInBoxInfo);

            while (a)
            {
                Console.WriteLine("몇 개를 입력 하시겠습니까?");
                inputBoxNum = int.Parse(Console.ReadLine());
                StartB = inputBoxNum;
                Console.WriteLine("입력 받은 Start Box 의 개수는 " + StartB + " 개 입니다.\n");

                switch (StartB) //StartB 가 5보다 적으면
                {

                    case 5:
                        StartInBox = StartB;
                        EndInBox = StartB;
                        Console.WriteLine("입력할 텍스트 5개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false;
                        break;
                    case 4:
                        StartInBox = StartB;
                        Console.WriteLine("입력할 텍스트 4개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false;
                        break;
                    case 3:
                        StartInBox = StartB;
                        Console.WriteLine("입력할 텍스트 3개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        a = false;
                        break;
                    case 2:
                        StartInBox = StartB;
                        Console.WriteLine("입력할 텍스트 2개가 생성 되었습니다.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다.\n ");
                        a = false;
                        break;
                    case 1:
                        StartInBox = StartB;
                        Console.WriteLine("2개 이상 선택 해 주세요.\n");
                        Console.WriteLine("TEST : 생성 된 텍스트" + StartInBox + "개 입니다. \n");
                        break;
                    default: Console.WriteLine("다시 입력해주세요. ^^ ( 최대 5개 )\n");
                        break;
                }
            }
            Console.WriteLine("사다리에서 내려올 내용을 "+ StartInBox + "개 적어주세요.\n");
            
            String[] StartArr String[StartInBox];
            Console.WriteLine(StartArr);
            inputBoxNum = int.Parse(Console.ReadLine());

        }
    }
}

