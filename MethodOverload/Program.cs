//Add Method (2 integer parameters)
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public static int Add(int num1, int num2);
{
    return num1 + num2;
}

//Overload Add Method (2 decimal parameters)
public static decimal Add(decimal num1, decimal num2);
{ 
    var sum = num1 + num2

    if (isCheck == true && sum > 1)
    {
        return $"{sum} dollars";


    else if (isCheck == true && sum == 1)
        {
            return $"{sum} dollar";
        }
        else if (isCheck == true && sum < 1)
        {
            return $"{sum} dollars";
        }
        else
        {
            return sum.ToString();
    }

}

//Overload of Add Method/string & 3 params..)

static void Main(string[] args)
{
        var x = 29;
        var y = 55;
            
            var answer = Add (x,y);
}           var a = 32.0m;
            var b = 45.0m;
    var decimalAnswer = Add(a, b);
    var thirdAnswer = Add(0, 0, true);
    Console.WriteLine($"int add: {answer} decimal add): {decimalAnswer}");
    Console.WriteLine(thirdAnswer);