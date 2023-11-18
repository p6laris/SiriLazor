
using Microsoft.JSInterop;
using SiriLazor.Component.Models;


namespace SiriLazor.Component
{

    public partial class SiriLazor : ISiriLazor , IAsyncDisposable
    {
        private readonly IJSRuntime jSRuntime;
        public SiriLazor(IJSRuntime jSRuntime)
        {
            this.jSRuntime = (jSRuntime is not null)
                ? jSRuntime
                : throw new ArgumentNullException(nameof(jSRuntime));

        }

        public async ValueTask<SiriObject> InitSiriLazor(IOptions<ClassicWaveCurveDefintion> options)
        {
            var instance = await jSRuntime.InvokeAsync<int>("siriWave.initIOS", options);
            return new SiriObject(jSRuntime) { Instance = instance };
        }
                

        public async ValueTask<SiriObject> InitSiriLazor(IOptions<IOS9WaveCurveDefintion> options)
        {
            var instance = await jSRuntime.InvokeAsync<int>("siriWave.initIOS9", options);
            return new SiriObject(jSRuntime) { Instance = instance };
        }
            
        public async ValueTask DisposeAsync() =>
            await jSRuntime.InvokeVoidAsync("siriWave.disposeAll");

       
    }
}
