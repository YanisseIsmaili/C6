namespace CSharpDiscovery.Quest01
{
    public class DoubleArrayForEvenInteger_Exercice
    {

    static int[] DoubleArrayForEvenInteger(int[] inputTab)
    {
        int[] result = new int[inputTab.Length];

        for (int i = 0; i < inputTab.Length; i++)
        {
            if (inputTab[i] % 2 != 0) 
            {
                result[i] = inputTab[i] * 2; 
            }
            else
            {
                result[i] = inputTab[i]; 
            }
        }

        return result;
        }
    }
}
