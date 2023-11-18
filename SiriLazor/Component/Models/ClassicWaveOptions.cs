using Microsoft.AspNetCore.Components;

namespace SiriLazor.Component.Models
{
    internal record ClassicWaveOptions : IOptions<ClassicWaveCurveDefintion>
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

        // The frequency for the complete wave (how many waves). - Not available in iOS9 Style
        public double? Frequency { get; set; }

        // The color of the wave, in hexadecimal form (`#336699`, `#FF0`). - Not available in iOS9 Style
        public string? Color { get; set; }

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
        public IEnumerable<ClassicWaveCurveDefintion>? Definitions { get; set; }

        public string? GlobalCompositeOperation { get; set; }
    }

}
