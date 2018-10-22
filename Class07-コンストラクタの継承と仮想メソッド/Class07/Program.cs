using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human
{
    public string Name { get; set; }         //名前
    public int Age { get; set; }             //年齢

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void IntroduceSelf()
    {
        Console.WriteLine($"私は{Name}です。年齢は{Age.ToString()}です。");
    }

    public virtual void Display()   //仮想メソッド：オーバーライドするのが前提
    {
        Console.WriteLine($"私は、可処分時間のうち全てを読書にあてています");
    }
}

class Student : Human   //Humanクラスを継承
{
    public int Number { get; set; }          //出席番号
    public int StudyMinutes { get; set; }    //勉強時間
    public int FreeMinutes { get; set; }     //可処分時間

    public Student(string name, int age) : base (name, age)
    {
        //Name = name;
        //Age = age;
        StudyMinutes = 2 * 60;
        FreeMinutes = 10 * 60;
    }

    public double StudyRatio()
    {
        double result = (double)StudyMinutes / FreeMinutes * 100;
        return result;
    }

    public override void Display()  //オーバーライド
    {
        Console.WriteLine($"私は、可処分時間のうち{StudyRatio().ToString("F2")}%を勉強にあてています");
    }
}

class VantanStudent : Student
{
    public int GamePlayMinutes { get; set; } //ゲームプレイ時間

    public VantanStudent(string name, int age) : base(name, age)
    {
        //Name = name;
        //Age = age;
        GamePlayMinutes = 3 * 60;
        //FreeMinutes = 10 * 60;

    }
    public double GameRatio()
    {
        double result = (double)GamePlayMinutes / FreeMinutes * 100;
        return result;
    }

    public override void Display()  //オーバーライド
    {
        Console.WriteLine($"私は、可処分時間のうち{GameRatio().ToString("F2")}%をゲームプレイにあてています");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("普通科の山田", 17);
        var vantanStudent = new VantanStudent("バンタンの田中", 16);

        student.IntroduceSelf();
        student.Display();
        Console.WriteLine();
        vantanStudent.IntroduceSelf();
        vantanStudent.Display();
        Console.WriteLine();
        vantanStudent.FreeMinutes += 2 * 60;
        vantanStudent.IntroduceSelf();
        vantanStudent.Display();

    }
}
