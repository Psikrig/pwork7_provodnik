using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pwork_7__provodnik
{
    internal class Visual
    {

        public static void Drivem()
        {
            Console.Clear();
            DriveInfo[] drive = DriveInfo.GetDrives();
            int z = -1;
            foreach (DriveInfo d in drive)
            {
                Console.WriteLine(" " + d + "\t " + d.TotalFreeSpace / 1073741824 + " Gb из " + d.TotalSize / 1073741824 + " Gb");
                z++;
            }
            int pos = str.strel(z);
            string h = "l";
            if (pos == 0)
            {
                h = "C:\\";
            }
            if (pos == 1)
            {
                h = "D:\\";
            }
            int j = -1;
            string[] pap = Directory.GetDirectories(h);
            string[] faf = Directory.GetFiles(h);
            foreach (var d in pap)
            {
                var c = Directory.GetCreationTime(d);
                Console.WriteLine(" " + d + "\t дата создания: " + c);
                z++;
                j++;
            }
            foreach (var d in faf)
            {
                Console.WriteLine(" " + d);
                z++;
            }
            dir(pap, faf, pos, z, j);
        }
        private static void dir(string[] pap, string[] faf, int pos, int z, int j)
        {
            while (true)
            {
                string[] gag = pap.Concat(faf).ToArray();
                Console.Clear();
                    z = -1;
                j = -1;
                    foreach (var d in pap)
                    {
                        var c = Directory.GetCreationTime(d);
                        Console.WriteLine(" " + d + "\t дата создания: " + c);
                        z++;
                    j++;
                    }
                    foreach (var d in faf)
                    {
                        Console.WriteLine(" " + d);
                        z++;
                    }
                    pos = str.strel(z);
                if (pos > j)
                {
                    Process.Start(new ProcessStartInfo { FileName = gag[pos], UseShellExecute = true });
                }
                else
                {
                    faf = Directory.GetFiles(pap[pos]);
                    pap = Directory.GetDirectories(pap[pos]);
                    gag = pap.Concat(faf).ToArray();
                }
            }
        }
    }
}