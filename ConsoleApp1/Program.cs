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
            Console.WriteLine("입력 받은 Start Box 의 개수는 \n" + StartB + " 개 입니다.");

            LadderPosition LP = new LadderPosition();
        }
    }
}
