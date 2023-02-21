
ArrayList List = new ArrayList();
List.Add(0);
List.Add(1);
List.Add(2);
List.Add(3);
List.Add(4);
List.Add(5);
List.Add(6);
List.Add(7);
List.Add(8);
List.Add(9);
List.Add(10);
List.Insert(0, 14);
List.Delete(7);
List.Print();
List.Length();
List.Clear();
List.Add(0);
List.Print();
List.Get(0);
List.Length();


internal class ArrayList
{
    public int count = 0;
    int[] array = null;

    public void Expand()
    {
        if (array == null)
        {
            array = new int[1];
            return;
        }
        if (count < array.Length)
            return;
        int[] buf = new int[array.Length * 2];
        Array.Copy(array, 0, buf, 0, count);
        array = buf;
    }
    public void Print()
    {
        if (array == null)
            return;
        Console.WriteLine("Список:");
        for (int i = 0; i < count; i++)
            Console.Write(array[i] + " ");
        Console.Write("\n");
    }
    public void Add(int a)
    {
        Expand();
        array[count] = a;
        count++;
    }
    public void Insert(int pos, int a) 
    {
        if((array == null & pos == 0)|pos == count+1)// Если массив пустой или позиция на следущей от последней ячейки, то Add()
        {
            Add(a);
            return;
        }
        if(pos > count | pos < 0| (array == null & pos != 0))//проверка
            return;

        //Все остальные случаи
        Expand();
        for(int i = count; i >= pos; i--)
            if (i != 0)
                array[i] = array[i - 1];
        array[pos] = a;
        count++;
    }

    public void Delete(int pos)
    {
        if(array==null|pos+1 > count|pos < 0)
            return;

        for (int i = pos; i < count; i++)
            if (count != 1)
                array[i] = array[i + 1];
        count--;
    }
    public void Length()
    {
        Console.WriteLine("Length of list: " + count);
    }
    public void Clear()
    {
        count = 0;
    }
    public void Get(int pos)
    {
        Console.WriteLine("A [ " + pos +" ] = " + array[pos]);
    }
}