int[] vector = new int[18];
int[] vectorBingo = new int[15];
Random azar = new Random();

Console.Write("Vector[18]: ");
for (int i = 1 ; i <= vector.Length; i++)
{   //Llenamos el vector de nros random del 0 al 89
    if (i < 10)
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
        vector[i - 1] = vector[i - 1] - 10;
        while (vector[i - 1] < 1)
        {   //Aquí elimino la posibilidad del valor '0' (cero)
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
            vector[i - 1] = vector[i - 1] - 10;
        }
        Console.Write(vector[i - 1] + " ");

    }
    else
    {
        vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
        vector[i - 1] = vector[i - 1] - 100;
        while (vector[i - 1] < 1)
        {   //Aquí elimino la posibilidad del valor '0' (cero)
            vector[i - 1] = (azar.Next((i * 10), ((i * 10) + 9)));
            vector[i - 1] = vector[i - 1] - 10;
        }
        Console.Write(vector[i - 1] + " ");
    }
}
Console.WriteLine("\n");


//vector[0] = (columnA.Next(1, 9));
//vector[1] = (columnB.Next(10, 19));
//vector[2] = (columnC.Next(20, 29));
//vector[3] = (columnD.Next(30, 39));
//vector[4] = (columnE.Next(40, 49));
//vector[5] = (columnF.Next(50, 59));
//vector[6] = (columnG.Next(60, 69));
//vector[7] = (columnH.Next(70, 79));
//vector[8] = (columnI.Next(80, 89));
//vector[9] = (columnA.Next(1, 9));
//vector[10] = (columnB.Next(10, 19));
//vector[11] = (columnC.Next(20, 29));
//vector[12] = (columnD.Next(30, 39));
//vector[13] = (columnE.Next(40, 49));
//vector[14] = (columnF.Next(50, 59));
//vector[15] = (columnG.Next(60, 69));
//vector[16] = (columnH.Next(70, 79));
//vector[17] = (columnI.Next(80, 89));

Console.Write("Selecciono 3 posiciones al azar: ");
int[] aux = new int[3]; //Seleccionamos 3 posiciones al azar  SIN REPETIR para eliminar del vector
Random itemToRemove = new Random();
for (int i = 0; i < aux.Length; i++)
{
    if (i == 0)
    {
        aux[i] = itemToRemove.Next(0, 17);
    } else
    {
        if (i == 2)
        {
            aux[i] = itemToRemove.Next(0, 17);
            while ((aux[i] == aux[i - 1]) || (aux[i] == aux[i - 2]))
            {
                aux[i] = itemToRemove.Next(0, 17);
            }
        }
        else
        {
            aux[i] = itemToRemove.Next(0, 17);
            while (aux[i] == aux[i - 1])
            {
                aux[i] = itemToRemove.Next(0, 17);
            }
        }

    }
    Console.Write(aux[i] + "° | ");
}
Console.WriteLine("\n");