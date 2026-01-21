 public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }
    // MI DOCUMENTACION
    // Para recordar mejor un stack recuerda como la computadora escribe un texto
    // 1234 no es 4321
    public static float Run(string text) {
        // Creacion del stack
        var stack = new Stack<float>();
        // Iteracion de cada elemento 
        foreach (var item in text.Split(' ')) {
            // Si es un operador se aplica las siguientes operaciones para poder 
            // agregar nuevos elementos
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    // Esta condicion finaliza el programa si es que en la division
                    // uno de los elementos es igual a cero
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            // Si no es un operador se agrega el numero de forma normal
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            // Esta condicion evita el uso de espacios
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }
        // El programa debe terminar con un solo elemento asi que no importa cuantos numeros haya
        // o es un caso invalido o es un numero en particular.
        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}