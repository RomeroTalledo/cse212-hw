public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new List<int> { 1, 2, 3, 4, 5 };
        var l2 = new List<int> { 2, 4, 6, 8, 10 };
        var select = new List<int> { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}");
        // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(List<int> list1, List<int> list2, List<int> select)
    {
        List<int> newlist = new();
        foreach (int i in select)
        {
            if (i == 1 && list1.Count > 0)
            {
                int valor = list1[0];
                list1.RemoveAt(0);
                newlist.Add(valor);
            }
            else if (i == 2 && list2.Count > 0)
            {
                int valor = list2[0];
                list2.RemoveAt(0);
                newlist.Add(valor);
            }
        }
        return newlist.ToArray();
    }

}

// foreach (int i in select)
// {
//     if (i == 1) MoveFirst(list1, newlist);
//     else if (i == 2) MoveFirst(list2, newlist);
// }

// // Método auxiliar
// void MoveFirst(List<int> source, List<int> target)
// {
//     if (source.Count > 0)
//     {
//         target.Add(source[0]);
//         source.RemoveAt(0);
//     }
// }
