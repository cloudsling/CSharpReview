using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpReview.ThreadTest
{
    class ParallelDemo
    {
        public void ParallelInvoke()
        {
            Parallel.Invoke(
                () => DoSomething(0),
                () => DoSomething(0),
                () => DoSomething(0));
        }

        public void DoWithParallel()
        {
            Parallel.For(0, 1000, DoSomething);
        }

        public void DoWithFor()
        {
            for (int i = 0; i < 1000; i++)
            {
                DoSomething(i);
            }
        }

        public void DoSomething(int index)
        {
            // Do something
        }

        public static Int64 DirectoryBytes(String path, String searchPattern, SearchOption option)
        {
            var files = Directory.EnumerateFiles(path, searchPattern, option);
            Int64 masterTotal = 0;

            ParallelLoopResult result = Parallel.ForEach<String, Int64>(
                    files,
                    () => 0,
                    (file, loopState, index, taskLocalTotal) =>
                    {
                        Int64 fileLength = 0;
                        FileStream fs = null;
                        try
                        {
                            fs = File.OpenRead(file);
                            fileLength = fs.Length;
                        }
                        catch (IOException) { }
                        finally
                        {
                            fs?.Dispose();
                        }
                        return taskLocalTotal + fileLength;
                    },
                    taskLocalTotal => Interlocked.Add(ref masterTotal, taskLocalTotal)
                );

            return masterTotal;
        }
    }
}
