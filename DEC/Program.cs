using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DEC
{
    class Program
    {
        static void Main(string[] args)
        {
            Crypt wd = new Crypt();

            //平文の文字列
            //string enc_str = "30314030303030303030303030303030";
            //暗号化した後の値
            string dec_str = "AD780E95C370A53CC7C0E2D279848A77";
            byte[] decdata = wd.HEX2Bytes(dec_str);

            //鍵
            string key_str = "07010203040506020701020304050602";
            byte[] key = wd.HEX2Bytes(key_str);

            var dest = wd.Decrypt(decdata, key);
            
        }
    }
}
