namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
           string a = string.Join("", str.ToArray());
           return a;
        }
    }
}
