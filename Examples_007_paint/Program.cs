Console.Clear();
//Console.SetCursorPosition(15,3);
//Console.WriteLine("*");

int xa = 45, ya = 2;
int xb = 2, yb = 30;
int xc = 90, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya;

int count = 0;
while(count < 8000)
{
    int what = new Random().Next (0,3); //  1. 2.
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("*");
    count++;
}

