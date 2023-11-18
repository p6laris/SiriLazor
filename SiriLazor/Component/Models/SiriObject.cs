using Microsoft.JSInterop;

namespace SiriLazor;

public class SiriObject : IAsyncDisposable
{
    private readonly IJSRuntime jSRuntime;
    public int Instance { get; set; }

    public SiriObject(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task StartAnimation() =>
        await jSRuntime.InvokeVoidAsync("siriWave.start", Instance);

    public async Task StopAnimation() =>
        await jSRuntime.InvokeVoidAsync("siriWave.stop", Instance);

    public async Task SetSpeed(double newValue) =>
        await jSRuntime.InvokeVoidAsync("siriWave.setSpeed", newValue, Instance);

    public async Task SetAmplitude(double value) =>
        await jSRuntime.InvokeVoidAsync("siriWave.setAmplitude", value, Instance);

    public async ValueTask DisposeAsync() =>
        await jSRuntime.InvokeVoidAsync("siriWave.dispose", Instance);


}
