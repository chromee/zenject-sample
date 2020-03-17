using System.IO;
using UnityEngine;

namespace Zenject
{
    public class PerformanceUtil
    {
        private static readonly string Path = $"{Application.dataPath}/../output.log";

        public static void WriteFile(string msg)
        {
            using (var file = new StreamWriter(Path, true))
            {
                file.WriteLine(msg);
            }
        }
    }
}