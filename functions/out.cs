public static int Div(int x, int y, out int remainder)
{
    remainder = x % y;
    return x / y;
}

int q = Divide(10, 3, out int r);

int value = int.TryParse(text, out int x) ? x : 0;
