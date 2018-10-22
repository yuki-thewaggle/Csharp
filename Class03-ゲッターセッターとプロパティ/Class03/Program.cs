using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class View
{
    private int times;  //getterとsetterを定義する
    public string Text { get; set; }    //プロパティを定義する
    //参考：
    //private string text;

    public int GetTimes()   //timesのgetter
    {
        return this.times;
    }
    public void SetTimes(int times)   //timesのsetter
    {
        this.times = times;
    }

    //参考：
    //public string GetText()
    //{
    //    return text;
    //}
    //public void SetText(string text)
    //{
    //    this.text = text;
    //}

    public void Display()
    {
        for (var i = 0; i < this.times; i++)
        {
            Console.WriteLine(this.Text);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var view = new View();

        view.SetTimes(3);

        view.Text = "hello!";
        //参考：
        //view.SetText("hello!");

        view.Display();

        Console.WriteLine($"回数：{view.GetTimes()} , 文字列：{view.Text}");
    }
}

