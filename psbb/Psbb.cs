using System;

class Program
{
    public static int MinimumBus(int n,string[]familyMember){
        int[] familySizes = new int[n];
        for (int i = 0; i < n; i++)
        {
            familySizes[i] = int.Parse(familyMember[i]); //rubah ke int
        }

    

        int familiesWithMoreThanFour = 0;
        foreach (int size in familySizes)
        {
            if (size > 4)
            {
                familiesWithMoreThanFour++; //mencari keluarga yang beranggota lebih dari 4
            }
        }

        int totalFamilies = n + familiesWithMoreThanFour; //menganggap ada keluarga baru

        int minBusesRequired = totalFamilies / 2;
        if (totalFamilies % 2 != 0) //jika menghasilkan ganjil maka terdapat lebih dari keluarga berbeda
        {
            minBusesRequired++; // tambah bus nya
        }
        minBusesRequired++;

        return minBusesRequired;
    }
    static void Main(string[] args)
    {
        Console.Write("Input the number of families: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Input the number of members in the family (separated by space): ");
        string[] familySizesInput = Console.ReadLine().Split(' ');

        if (n != familySizesInput.Length)
        {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }else{
            Console.WriteLine($"Minimum Bus Required is : {MinimumBus(n,familySizesInput)}");
        }

    
    }
}
