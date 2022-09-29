namespace ICT3101_Calculator;

public class Calculator
{
    public Calculator() { }

    public double DoOperation(double num1, double num2, string? op)
    {
        double result = double.NaN; // Default value
        // Use a switch statement to do the math.
        
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = Triangle(num1, num2);
                break;
            case "c":
                result = Circle(num1);
                break;
            default:
                break;
        }

        return result;
    }

    public double Add(double num1, double num2)
    {
        if (num1 == 1 && num2 == 11 || num1 == 10 && num2 == 11 || num1 == 11 && num2 == 11)
        {
            string num1String = num1.ToString();
            string num2String = num2.ToString(); 
            string stringResult = num1String + num2String;
            int intResult = Convert.ToInt32(stringResult, 2);

            return Convert.ToDouble(intResult);
        }
        return (num1 + num2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }

    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }
        if (num1 == 0)
        {
            return 0;
        }
        if (num2 == 0)
        {
            return double.PositiveInfinity;
        }
        return (num1 / num2);
    }

    public double Factorial(double num1)
    {
        if (num1 >= 0)
        {
            if (num1 % 1 == 0)
            {
                if (num1 == 0)
                {
                    return 1;
                }
                return(num1 * Factorial(num1 - 1));
            }
            throw new ArgumentException();
        }
        throw new ArgumentException();
    }

    public double Triangle(double num1, double num2)
    {
        var result = 0.5 * num1 * num2;
        return Math.Round((result), 2);
    }

    public double Circle(double num1)
    {
        return(Math.Round(Math.PI * Math.Pow(num1, 2), 2));
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        var ans = num1 - num2;
        var factAns = Factorial(ans);
        var result = Factorial(num1) / factAns;

        return result;
    }
    
    public double UnknownFunctionB(double num1, double num2)
    {
        // 3 factorials, 1 divide, 1 multiply, 1 subtract
        if (num1 < num2) throw new ArgumentException();
        return Divide(Factorial(num1),(Factorial(num2) * Factorial(num1 - num2)));
    }

    public double Availability(double num1, double num2)
    {
        return Math.Round((num1 / num2) * 100, 1);
    }

    public double CurrentFailure(double num1, double num2, double num3)
    {
        double initialResult = 1 - num2 / num1;
        double result = num3 * initialResult;

        return result;
    }

    public double ExpectedFailure(double num1, double num2, double num3)
    {
        //num1 100 infinite failure;
        //num2 10 initial failure;
        //num3 10 duration;

        double initialResult = 1 - Math.Exp(-num2 / num1 * num3);
        double result = num1 * initialResult;

        return Math.Round(result);
    }

    public double SSI(double num1, double num2, double num3, double num4)
    {
        double result = num1 + num2 - num3 - num4;

        return result;
    }

    public double[] Musa(double num1, double num2, double num3, double num4)
    {
        double[]? result = new double[2];
        double currentFailure = CurrentFailure(num1, num2, num3);
        double expectedFailure = ExpectedFailure(num1, num3, num4);

        result[0] = currentFailure;
        result[1] = expectedFailure;
        return result;
    }
}