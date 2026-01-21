public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}

// La primera es palindroma
// Las segunda palabras tambien es palindroma
// La tercera es igual a la 2 pero la 3 no tiene sentido