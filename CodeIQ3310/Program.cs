using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeIQ3310
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();

            // 入力データをリストに取得
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                input.Add(line);
            }

            // 文字列の最大長を取得
            int maxLength = input.Max((str) => str.Length);

            // パディングした文字列を新しいリストに作成
            var resultList = new List<string>();
            input.ForEach((str) =>
            {
                int paddingSize = maxLength - str.Length;
                resultList.Add(new string('_', paddingSize) + str);
            });
            
            // 標準出力に出力
            string result = String.Join("\n", resultList);
            Console.WriteLine(result);
        }
    }
}
