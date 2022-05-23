/*
Methods with out parameters are largely used in C# to return multiple values.


From C#7 you can also use the out keyword to implicitly declare a local variable,


Interestingly, the new variable is immediately available in the rest of an expression.
*/

public static int Div(int x, int y, out int remainder)
{
    remainder = x % y;
    return x / y;
}

int q = Divide(10, 3, out int r);

int value = int.TryParse(text, out int x) ? x : 0;
