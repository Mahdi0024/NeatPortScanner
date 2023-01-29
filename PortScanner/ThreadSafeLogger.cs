using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PortScannerLib
{
    public class ThreadSafeLogger
    {
        private BlockingCollection<String> SaveQueue;
        private Task LoggerTask;
        public bool IsRunning { get; private set; }

        public ThreadSafeLogger()
        {
            IsRunning = false;
        }

        private void LoggerLoop(String fileName, bool append)
        {
            using (var writer = new StreamWriter(fileName, append, Encoding.Unicode))
            {
                foreach (String value in SaveQueue.GetConsumingEnumerable())
                {
                    writer.Write(value);
                }
                writer.Flush();
            }
        }

        public void WriteLine(String value)
        {
            Write(value + Environment.NewLine);
        }

        public void Write(String value)
        {
            if (!IsRunning)
                throw new Exception("session has not started yet!");
            SaveQueue.Add(value);
        }

        public void StartSession(String fileName, bool append)
        {
            if (!IsRunning)
            {
                SaveQueue = new BlockingCollection<string>();
                LoggerTask = Task.Run(new Action(() => LoggerLoop(fileName, append)));
                IsRunning = true;
            }
        }

        public void StopSession()
        {
            if (IsRunning)
            {
                SaveQueue.CompleteAdding();
                LoggerTask.Wait();
                SaveQueue.Dispose();
                IsRunning = false;
            }
        }
    }
}