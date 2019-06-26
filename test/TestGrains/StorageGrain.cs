using System.Threading.Tasks;
using Orleans;
using Orleans.Providers;

[StorageProvider(ProviderName = "Storage")]
public class StorageGrain : Grain<SimpleState>, IStorageGrain<SimpleState>
{
    public Task<SimpleState> GetState() => Task.FromResult(State);

    public Task SetState(SimpleState state)
    {
        State = state;
        return Task.CompletedTask;
    }

    public Task SaveAsync() => WriteStateAsync();
}