//Console.SetCursorPosition(60, 10);
//Console.WriteLine("+");
Console.Clear();
int ax=1, ay=1;
int bx=1, by=10;
int cx=70, cy=10;

Console.SetCursorPosition(ax,ay);
Console.WriteLine("+");

Console.SetCursorPosition(bx,by);
Console.WriteLine("+");

Console.SetCursorPosition(cx,cy);
Console.WriteLine("+");


int x = ax, y = ay;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
if (what==0)
{
    x = (x+ax)/2;
    y = (y+ay)/2;
}
if (what==1)
{
    x= (x+bx)/2;
    y= (y+by)/2;
}
if (what==2)
{
    x=(x+cx)/2;
    y=(y+cy)/2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}