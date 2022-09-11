Clear();
Write("Введите Х1: ");
int x1 = int.Parse(ReadLine());
Write("Введите Y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите Z1: ");
int z1 = int.Parse(ReadLine());
Write("Введите Х2: ");
int x2 = int.Parse(ReadLine());
Write("Введите Y2: ");
int y2 = int.Parse(ReadLine());
Write("Введите Z1: ");
int z2 = int.Parse(ReadLine());

double a = Math.Sqrt(Math.Pow(x2 - x1,2)+Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));

WriteLine($"d = {d}");
