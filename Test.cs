using System;

public class Test{
    public static void Main(){
        Test test = new Test();
        test.Run();
    }
    public void Run()
    {
        int a = 15;
        int b = 10;
        string f = "abcde";
        var calc = new Calc<int>();
        System.Console.WriteLine(calc.Compare(a,b));
    }
}
public class Calc<T>{
    public T Compare <T>(T a ,T b)
      where T : IComparable{
      return a.CompareTo(b) > 0 ? a : b;
    }
