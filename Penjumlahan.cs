using System;
using System.Collections.Generic;
using System.Text;

namespace modul5_103082400005
{
    internal class Penjumlahan<T>
    {
        public T JumlahTigaAngka(T a, T b, T c)
        {
            dynamic da = a;
            dynamic db = b;
            dynamic dc = c;

            var hasilJumlah = da + db + dc;

            return hasilJumlah;
        }
    }
}
