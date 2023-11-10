int x = 3, y = 1, z = 2;

int helper1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
int helper3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
int helper2 = (x != helper1 && x != helper3) ? x : ((y != helper1 && y != helper3) ? y : z);
x = helper1;
y = helper2;
z = helper3;

Console.WriteLine($"{x} {y} {z}");