using System;

namespace CSharpHomework
{
    public class Problem1
    {
        public static double HesaplaOrtalama(int vize, int final)
        {
            // Vizenin %40'ı, Finalin %60'ı
            return (vize * 0.4) + (final * 0.6);
        }

        public static string BelirleHarfNotu(double ortalama, int final)
        {
            // Önemli Kural: Final 50'den küçükse ortalamaya bakılmaksızın FF döner
            if (final < 50)
            {
                return "FF";
            }

            // Harf Aralıkları
            if (ortalama >= 90) return "AA";
            else if (ortalama >= 85) return "BA";
            else if (ortalama >= 80) return "BB";
            else if (ortalama >= 75) return "CB";
            else if (ortalama >= 70) return "CC";
            else if (ortalama >= 65) return "DC";
            else if (ortalama >= 60) return "DD";
            else if (ortalama >= 50) return "FD";
            else return "FF";
        }

        public static string BelirleGecmeDurumu(string harfNotu)
        {
            // İpuçlarındaki gibi || (veya) operatörü ile kontrol
            if (harfNotu == "AA" || harfNotu == "BA" || harfNotu == "BB" || harfNotu == "CB" || harfNotu == "CC")
            {
                return "Geçti";
            }
            else if (harfNotu == "DC" || harfNotu == "DD")
            {
                return "Şartlı Geçti";
            }
            else
            {
                // FD ve FF durumu
                return "Kaldı";
            }
        }
    }
}
