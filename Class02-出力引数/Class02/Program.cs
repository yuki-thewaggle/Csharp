using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02
{
    class VantanStudent
    {
        //フィールド
        public string name;         //名前
        public int age;             //年齢
        public int number;          //出席番号
        public int gamePlayMinutes; //ゲームプレイ時間
        public int studyMinutes;    //勉強時間
        public int freeMinutes;     //可処分時間

        //①出力引数
        public double GameRatio(out double rest)
        {
            double result = (double)gamePlayMinutes / freeMinutes * 100;
            rest = 100 - result;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VantanStudent student1 = new VantanStudent();
            VantanStudent student2 = new VantanStudent();

            student1.name = "田中一郎";
            student1.age = 16;
            student1.number = 21;
            student1.gamePlayMinutes = 2 * 60;      //2時間
            student1.studyMinutes = 4 * 60;         //4時間
            student1.freeMinutes = 12 * 60 + 30;    //12時間30分

            student2.name = "加藤花子";
            student2.age = 15;
            student2.number = 9;
            student2.gamePlayMinutes = 8 * 60 + 30;
            student2.studyMinutes = 2 * 60;
            student2.freeMinutes = 10 * 60;

            //出力引数を呼び出し
            var result1 = student1.GameRatio(out double rest1);
            Console.WriteLine($"{student1.name}さんの可処分時間に対するゲーム割合は{result1.ToString("F1")}%で、ゲーム以外の割合は{rest1.ToString("F1")}%です");
        }
    }
}
