
using System.Collections;
using System.Collections.Generic;
ChainList.Methods ChainList = new ChainList.Methods();
ArrayList ArrayList = new ArrayList();
Random random = new Random();
int count = 0;
for (int i = 0; i < 10000; i++)
{
    int method = random.Next(0, 4);
    int pos = random.Next(0, 10001);
    int data = random.Next(0, 100);
    
    switch (method)
    {
        case 0:
            ChainList.Add(data);
            ArrayList.Add(data);
            break;

        case 1:
                ChainList.Insert(pos, data);
                ArrayList.Insert(pos, data);
            break;

        case 2:
            ChainList.Clear();
            ArrayList.Clear();
            break;

        case 3:
            ChainList.Delete(pos);
            ArrayList.Delete(pos);
            break;

        case 4:
            ChainList[pos] = data;
            ArrayList[pos] = data;
            break;
    }
    if (ArrayList.Lenght() != ChainList.Lenght())
    {
        Console.WriteLine(i + " Count слетел!");
    }
}
for (int i = 0; i < ChainList.Lenght(); i++)
{
    if (ArrayList[i] != ChainList[i])
    {
        Console.WriteLine(i + " Элементы не ровны!");
    }
}

ChainList.Print();
ArrayList.Print();

