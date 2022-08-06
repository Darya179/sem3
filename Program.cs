Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int Res(int nLoc)
{

    return nLoc*nLoc*nLoc;

}

for (int i = 1; i <= n; i++)
{

    Console.WriteLine(Res(i));
}
