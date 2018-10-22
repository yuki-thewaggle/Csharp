using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human
{
    public string Name { get; set; }         //名前
    public int Age { get; set; }             //年齢

    public void IntroduceSelf()
    {
        Console.WriteLine($"私は{Name}です。年齢は{Age.ToString()}です。");
    }

}

class Student : Human   //Humanクラスを継承
{
    //public string Name { get; set; }         //名前
    //public int Age { get; set; }             //年齢
    public int Number { get; set; }          //出席番号
    public int StudyMinutes { get; set; }    //勉強時間
    public int FreeMinutes { get; set; }     //可処分時間

    //public void IntroduceSelf()
    //{
    //    Console.WriteLine($"私は{Name}です。年齢は{Age.ToString()}です。");
    //}

    public double StudyRatio()
    {
        double result = (double)StudyMinutes / FreeMinutes * 100;
        return result;
    }

    public void Display()
    {
        Console.WriteLine($"私は、可処分時間のうち{StudyRatio().ToString("F2")}%を勉強にあてています");
    }
}

class VantanStudent : Student
{
    //フィールド
    //public string Name { get; set; }         //名前
    //public int Age { get; set; }             //年齢
    //public int Number { get; set; }          //出席番号
    public int GamePlayMinutes { get; set; } //ゲームプレイ時間
    //public int StudyMinutes { get; set; }    //勉強時間
    //public int FreeMinutes { get; set; }     //可処分時間

    //public void IntroduceSelf()
    //{
    //    Console.WriteLine($"私は{Name}です。年齢は{Age.ToString()}です。");
    //}

    public double GameRatio()
    {
        double result = (double)GamePlayMinutes / FreeMinutes * 100;
        return result;
    }

    public new void Display()   //newをつけてStudentのDisplayと別のものであることを伝える
    {
        Console.WriteLine($"私は、可処分時間のうち{GameRatio().ToString("F2")}%をゲームプレイにあてています");
    }
}



class Program
{
    static void Main(string[] args)
    {
        var student = new Student();
        var vantanStudent = new VantanStudent();

        student.Name = "普通科の山田";
        student.Age = 17;
        student.StudyMinutes = 2 * 60;
        student.FreeMinutes = 10 * 60;

        vantanStudent.Name = "バンタンの田中";
        vantanStudent.Age = 16;
        vantanStudent.GamePlayMinutes = 3 * 60;
        vantanStudent.FreeMinutes = 10 * 60;

        student.IntroduceSelf();
        student.Display();
        Console.WriteLine();
        vantanStudent.IntroduceSelf();
        vantanStudent.Display();
    }
}
