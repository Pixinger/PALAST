using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PALAST
{
    public static class FileTools
    {
        public static void CopyDirectoryRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyDirectoryRecursively(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        }
    }
}
