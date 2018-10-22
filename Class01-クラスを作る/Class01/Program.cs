using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01
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

        //②メソッドの定義
        public void IntroduceSelf()
        {
            Console.WriteLine($"私の名前は{name}です。年齢は{age.ToString()}です。");
        }

        //③メソッド呼び出し（★）
        public double GameRatio()
        {
            double result = (double)gamePlayMinutes / freeMinutes * 100;
            return result;
        }

        //③メソッド呼び出し（●）
        public void DisplayGameRatio()
        {
            Console.WriteLine($"{name}は、可処分時間のうち{GameRatio().ToString("F2")}%をゲームプレイにあてています");
        }

        //④メソッドのオーバーロード
        public void IntroduceSelf(string name)
        {
            Console.Write($"こんにちは、{name}さん。");
            Console.WriteLine($"私の名前は{this.name}です。年齢は{age.ToString()}です。");
        }

        //⑤オプション引数
        public void IntroduceSelf(string name, string greeting, string callSelf = "私", string suffix = "。")
        {
            Console.WriteLine($"{greeting}、{name}さん。{callSelf}の名前は{this.name}です。年齢は{age.ToString()}です{suffix}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //インスタンス化
            VantanStudent student1 = new VantanStudent();
            VantanStudent student2 = new VantanStudent();

            //フィールド設定
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

            //①コンソールに自己紹介を表示する
            Console.WriteLine("私の名前は{0}です。年齢は{1}です。", student1.name, student1.age.ToString());
            Console.WriteLine("私の名前は{0}です。年齢は{1}です。", student2.name, student2.age.ToString());

            //②自己紹介をVantanStudentのメソッドにして、メソッドを呼び出すことで自己紹介を表示する
            Console.WriteLine("\nIntroduceSelf呼び出し");
            student1.IntroduceSelf();
            student2.IntroduceSelf();

            //③可処分時間のうちゲームにあてる割合を計算するメソッド（★）を作り、
            //そのメソッドを表示するメソッド（●）を呼び出すことでゲーム割合を表示する
            Console.WriteLine("\nDisplayGameRatio呼び出し");
            student1.DisplayGameRatio();
            student2.DisplayGameRatio();

            //④自己紹介を表示するメソッドに相手の名前を加えたオーバーロードを呼び出す
            Console.WriteLine("\nIntroduceSelfオーバーロード");
            student1.IntroduceSelf(student2.name);

            //⑤オプション引数のメソッドを呼び出す
            Console.WriteLine("\nIntroduceSelfオプション引数（デフォルト）");
            student1.IntroduceSelf(student2.name, "おはようございます");
            Console.WriteLine("\nIntroduceSelfオプション引数（名前付き引数）");
            student1.IntroduceSelf(student2.name, "おはようございます", suffix:"！");
        }
    }
}
