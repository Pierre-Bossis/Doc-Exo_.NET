string MESSAGE = "%";
string result = string.Empty;
string resultConverted = string.Empty;

//on converti l'entrée en binaire
foreach (char ch in MESSAGE)
{
    result += Convert.ToString((int)ch, 2);
}

//on parcours le binaire pour décoder le message et le concatener
int j = 0;
int count = 1;
for (int i = 0; i < result.Length;)
{
    if(result.Length > 1)
    {
    while (result[j] == result[j + 1])
    {
        count++;
        j++;
        if (count >= result.Length)
            break;
    }
    }
    if (result[i] == '0')
    {
        resultConverted += "00 " + new string('0', count);
        resultConverted += " ";
    }
    else
    {
        resultConverted += "0 " + new string('0', count);
        resultConverted += " ";
    }
    //cut ce qu'on a deja examiné de la chaine
    if (result.Length > 0)
    {
        result =  result.Substring(count);
        j = 0;
        count = 1;
    }
}
resultConverted = resultConverted.Remove(resultConverted.Length -1);
Console.WriteLine(resultConverted);