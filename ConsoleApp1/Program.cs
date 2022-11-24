using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class LadderPosition
    {
        public LadderPosition()
        {
        }

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

            Console.WriteLine("몇 개를 입력 하시겠습니까?");

            int inputBoxNum = 0;

            inputBoxNum = int.Parse(Console.ReadLine());

            StartB = inputBoxNum;
            Console.WriteLine("입력 받은 Start Box 의 개수는 " + StartB + " 개 입니다.");

            int StartInBox = 0;

            switch ( StartB ) //StartB 가 5보다 적으면
            {
                case 5:
                    StartB = StartInBox;
                    Console.WriteLine("입력할 텍스트 5개가 생성 되었습니다.");
                    Console.WriteLine("생성 된 텍스트" + StartInBox + " 개 입니다. ");
                    break;
                case 4:
                    Console.WriteLine("입력할 텍스트 4개가 생성 되었습니다.");
                    Console.WriteLine("생성 된 텍스트" + StartInBox + " 개 입니다. ");
                    break;
                case 3:
                    Console.WriteLine("입력할 텍스트 3개가 생성 되었습니다.");
                    Console.WriteLine("생성 된 텍스트" + StartInBox + " 개 입니다. ");
                    break;
                case 2:
                    Console.WriteLine("입력할 텍스트 2개가 생성 되었습니다.");
                    Console.WriteLine("생성 된 텍스트" + StartInBox + " 개 입니다. ");
                    break;
                case 1:
                    Console.WriteLine("2개 이상 선택 해 주세요.");
                    Console.WriteLine("생성 된 텍스트" + StartInBox + " 개 입니다. ");
                    break;
                default: Console.WriteLine("5개 이하로만 선택해 주세요.");
                    return;
            }
            LadderPosition LP = new LadderPosition();
        }
    }
}
