//Žemėlapyje atvaizduojami žemė ir vanduo (žemė - 1, vanduo - 0).
//Surasti žemėlapyje esančias salas

//Žemėlapis (Šiame varijante turi būti 3 salos)
int[,] zemelapis = new int[,]{
  {1, 0, 0, 0, 0},
  {0, 0, 0, 1, 1},
  {0, 1, 0, 1, 1},
  {1, 1, 1, 0, 1}
};

Console.WriteLine("Salų skaičius: {0}", Salos(zemelapis));

void DFS(int[,] zemelapis, int i, int j, int eil, int stulp)
{
    if (i < 0 || j < 0 || i >= eil || j >= stulp || zemelapis[i, j] != 1)
    {
        return;
    }
    zemelapis[i, j] = -1;

    DFS(zemelapis, i + 1, j, eil, stulp);
    DFS(zemelapis, i - 1, j, eil, stulp);
    DFS(zemelapis, i, j + 1, eil, stulp);
    DFS(zemelapis, i, j - 1, eil, stulp);
}

int Salos(int[,] zemelapis)
{
    if (zemelapis == null || zemelapis.GetLength(0) == 0)
    {
        return 0;
    }

    int saluSkaic = 0;
    int eil = zemelapis.GetLength(0);
    int stulp = zemelapis.GetLength(1);
    for (int i = 0; i < eil; i++)
    {

        for (int j = 0; j < stulp; j++)
        {

            if (zemelapis[i, j] == 1)
            {
                saluSkaic++;
                DFS(zemelapis, i, j, eil, stulp);
            }
        }
    }
    return saluSkaic;
}
