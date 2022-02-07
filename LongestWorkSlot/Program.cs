using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Açıklama
        //
        //Main içerisinde örnek bir liste oluşturup findLongestSingleSlot fonksiyonuna gönderiyoruz.
        //leaveTimes listesinde 2'li elemanlardan ilki Çalışan ID'sini, 2. si ise işi bıraktığı zamanı temsil ediyor.
        //
        //Aşağıdaki örneğe bakacak olursak;
        //26 çalışanın olduğu bir yerde aynı anda sadece bir kişi çalışıyor. Bir işçi bıraktığında diğeri başlıyor aralık vermeden devam ediliyor.
        //0 Id numaralı işçinin 0 da işe başladığı kabul ediliyor ve 3'te işi bırakıyor.
        //Daha sonra 2 Id numaralı işçi 3'te başlayıp 5'te işini bitiriyor.
        //
        #endregion

        List<List<int>> leaveTimes = new List<List<int>>();
        leaveTimes.Add(new List<int> { 0, 3 });
        leaveTimes.Add(new List<int> { 2, 5 });
        leaveTimes.Add(new List<int> { 0, 9 });
        leaveTimes.Add(new List<int> { 1, 15 });

        char empoyeeName = findLongestSingleSlot(leaveTimes);
        Console.WriteLine("Empoyee name is : *{0}*", empoyeeName);
        Console.ReadLine();

    }

    private static char findLongestSingleSlot(List<List<int>> leaveTimes)
    {
        #region Tanımlamalar
        /*
         * startingTime => Çalışanın işe başlangıç zamanı
         * endingTime => Çalışanın iş bitiş zamanı
         * maxTime => Tek seferde çalışılan en uzun süre
         * maxEmployee => Tek seferde en uzun süre çalışan işçi Id'si
         * convertList => İşçi Id'lerinin harf karşılıklarının ASCII koduyla depolandığı liste
        */
        #endregion 

        int startingTime = 0;
        int endingTime = 0;
        int maxTime = 0;
        int maxEmployee = 0;

        for (int i = 0; i < leaveTimes.Count; i++)
        {
            endingTime = leaveTimes[i][1];
            int duration = endingTime - startingTime;
            if (duration > maxTime)
            {
                maxTime = duration;
                maxEmployee = leaveTimes[i][0];
            }
            startingTime = leaveTimes[i][1];
        }

        List<int> convertList = new List<int>();


        for (int i = 97; i < 123; i++)
        {
            convertList.Add(i);
        }

        return (char)convertList[maxEmployee];

    }
}