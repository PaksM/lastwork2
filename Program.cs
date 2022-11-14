Console.Clear();

string[] MyArray = {"Яр", "Сом", "Москва", "Уфа", "Оренбург"};
 
var result = new string[MyArray.Length];
var realSize = 0;
foreach (var value in MyArray)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));