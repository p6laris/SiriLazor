using Microsoft.AspNetCore.Components;

namespace SiriLazor.Component.Models
{
    internal record IOS9WaveOptions : IOptions<IOS9WaveCurveDefintion>
    {
        // The DOM container where the DOM canvas element will be added
        public ElementReference Container { get; set; }

        public string? Style { get; set; }

        // Ratio of the display to use. Calculated by default.
        public double? Ratio { get; set; }
        

        // The speed of the animation.
        public double? Speed { get; set; }

        // The amplitude of the complete wave.
        public double? Amplitude { get; set; }

        // The `canvas` covers the entire width or height of the container.
        public bool? Cover { get; set; }

        // Width of the canvas. Calculated by default.
        public double? Width { get; set; }

        // Height of the canvas. Calculated by default.
        public double? Height { get; set; }

        // Decide whether to start the animation on boot.
        public bool? Autostart { get; set; }

        // Number of steps (in pixels) used when drawn on canvas.
        public double? PixelDepth { get; set; }

        // Lerp speed to interpolate properties.
        public double? LerpSpeed { get; set; }

        public IOS9WaveRanges? iOS9Ranges { get; set; }

        public IEnumerable<IOS9WaveCurveDefintion>? Definitions { get; set; }
        public string? GlobalCompositeOperation { get; set; }
    }
}
