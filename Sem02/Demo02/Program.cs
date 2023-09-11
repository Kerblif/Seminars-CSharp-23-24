int x, y, z;
x = 1;
y = 2;
z = 3;

int helper1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
Console.WriteLine(helper1);