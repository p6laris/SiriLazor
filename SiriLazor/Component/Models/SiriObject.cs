using Microsoft.JSInterop;

namespace SiriLazor
{
    /// <summary>
    /// Represents an object for controlling SiriWave animation through JavaScript Interop.
    /// </summary>
    public class SiriObject : IAsyncDisposable
    {
        private readonly IJSRuntime jSRuntime;

        /// <summary>
        /// Gets the instance identifier for the SiriObject.
        /// </summary>
        public int Instance { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiriObject"/> class.
        /// </summary>
        /// <param name="jSRuntime">The JavaScript Runtime instance.</param>
        public SiriObject(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        /// <summary>
        /// Starts the SiriWave animation.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task StartAnimation() =>
            await jSRuntime.InvokeVoidAsync("siriWave.start", Instance);

        /// <summary>
        /// Stops the SiriWave animation.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task StopAnimation() =>
            await jSRuntime.InvokeVoidAsync("siriWave.stop", Instance);

        /// <summary>
        /// Sets the speed of the SiriWave animation.
        /// </summary>
        /// <param name="newValue">The new speed value.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SetSpeed(double newValue) =>
            await jSRuntime.InvokeVoidAsync("siriWave.setSpeed", newValue, Instance);

        /// <summary>
        /// Sets the amplitude of the SiriWave animation.
        /// </summary>
        /// <param name="value">The new amplitude value.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SetAmplitude(double value) =>
            await jSRuntime.InvokeVoidAsync("siriWave.setAmplitude", value, Instance);

        /// <summary>
        /// Disposes the SiriObject and cleans up associated resources.
        /// </summary>
        /// <returns>A ValueTask representing the asynchronous operation.</returns>
        public async ValueTask DisposeAsync() =>
            await jSRuntime.InvokeVoidAsync("siriWave.dispose", Instance);
    }
}
