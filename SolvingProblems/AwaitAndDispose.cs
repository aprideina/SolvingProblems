using System;
using System.Threading;
using System.Threading.Tasks;

namespace SolvingProblems
{
    public class AwaitAndDispose
    {
        private DisposableResource _disposableResource;

        public AwaitAndDispose(DisposableResource disposableResource)
        {
            _disposableResource = disposableResource;
        }

        public Task GetLongingRunningTask()
        {
            return Task.Factory.StartNew(async () =>
            {
                await LongRunningOperationCallAsync();
            }, TaskCreationOptions.LongRunning);
        }

        public async Task LongRunningOperationCallAsync()
        {
            using var ds = new DisposableResource();
            await LongRunningOperation();
            await LongRunningOperation();
        }

        public Task LongRunningOperation()
        {
            Thread.Sleep(10000);

            return Task.CompletedTask;
        }
    }

    public class DisposableResource : IDisposable
    {
        public bool Disposed { get; set; }

        public DisposableResource()
        {
            Disposed = false;
        }

        public void Dispose()
        {
            Disposed = true;
        }
    }
}
