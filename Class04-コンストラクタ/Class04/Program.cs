using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04
{
    class Game
    {
        public string Name { get; set; }    //ゲームの名前
        public string Genre { get; set; }   //ジャンル
        public int Times { get; set; }      //プレイした回数

        public Game()   //コンストラクタ
        {
            Genre = "Action";   //ジャンルの初期値
            Times = 5;          //プレイ回数の初期値
        }
        public Game(string name)   //コンストラクタのオーバーロード
        {
            this.Name = name;   //引数をゲームの名前に設定する
            Genre = "Action";   //ジャンルの初期値
            Times = 5;          //プレイ回数の初期値
        }

        public void Display()
        {
            Console.WriteLine($"{Name},\t{Genre},\t{Times.ToString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var game1 = new Game();    //コンストラクタ呼び出し
            game1.Display();

            var game2 = new Game("GAME2");    //引数つきコンストラクタ呼び出し
            game2.Display();

            //プロパティを書き換える
            game2.Genre = "RPG";
            game2.Display();
        }
    }
}
