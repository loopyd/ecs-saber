// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
//
// Code modified to work independently of repository by Robert Smith <nightwintertooth@gmail.com>
// ----------------------------------------------------------------------------

using System;
using System.Threading;

namespace Saber7ooth.LeoEcsSaber.Extensions.Threading
{
    static class ThreadService
    {
        static readonly ThreadDesc[] _descs;
        static ThreadWorkerHandler _task;
        static readonly int DescsCount;

        static ThreadService()
        {
            DescsCount = Environment.ProcessorCount;
            _descs = new ThreadDesc[DescsCount];
            for (var i = 0; i < _descs.Length; i++)
            {
                ref var desc = ref _descs[i];
                desc.Thread = new Thread(ThreadProc) { IsBackground = true };
                desc.HasWork = new ManualResetEvent(false);
                desc.WorkDone = new ManualResetEvent(true);
                desc.Thread.Start(i);
            }
        }

        public static void Run(ThreadWorkerHandler worker, int count, int chunkSize)
        {
#if DEBUG
            if (_task != null) { throw new Exception("Calls from multiple threads not supported."); }
#endif
            if (count <= 0 || chunkSize <= 0)
            {
                return;
            }
            _task = worker;
            // _task = task.Execute;
            var processed = 0;
            var jobSize = count / DescsCount;
            int workersCount;
            if (jobSize >= chunkSize)
            {
                workersCount = DescsCount;
            }
            else
            {
                workersCount = count / chunkSize;
                jobSize = chunkSize;
            }
            if (workersCount <= 0)
            {
                workersCount = 1;
            }
            for (int i = 0, iMax = workersCount - 1; i < iMax; i++)
            {
                ref var desc = ref _descs[i];
                desc.FromIndex = processed;
                processed += jobSize;
                desc.BeforeIndex = processed;
                desc.WorkDone.Reset();
                desc.HasWork.Set();
            }
            ref var lastDesc = ref _descs[workersCount - 1];
            lastDesc.FromIndex = processed;
            lastDesc.BeforeIndex = count;
            lastDesc.WorkDone.Reset();
            lastDesc.HasWork.Set();

            for (int i = 0, iMax = workersCount; i < iMax; i++)
            {
                _descs[i].WorkDone.WaitOne();
            }
            _task = null;
        }

        static void ThreadProc(object raw)
        {
            ref var desc = ref _descs[(int)raw];
            try
            {
                while (Thread.CurrentThread.IsAlive)
                {
                    desc.HasWork.WaitOne();
                    desc.HasWork.Reset();
                    _task.Invoke(desc.FromIndex, desc.BeforeIndex);
                    desc.WorkDone.Set();
                }
            }
            catch
            {
                // ignored
            }
        }

        struct ThreadDesc
        {
            public Thread Thread;
            public ManualResetEvent HasWork;
            public ManualResetEvent WorkDone;
            public int FromIndex;
            public int BeforeIndex;
        }
    }

    delegate void ThreadWorkerHandler(int fromIndex, int beforeIndex);
}