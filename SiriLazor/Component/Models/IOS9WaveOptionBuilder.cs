using Microsoft.AspNetCore.Components;
using SiriLazor.Component.Interfaces;

namespace SiriLazor.Component.Models
{
    internal class IOS9WaveOptionBuilder : IWaveOptionBuilder<IOS9WaveCurveDefintion>
    {
        private ElementReference Container;
        private string? Style;
        private string? GlobalCompositeOperation;
        private double? Ratio;
        private double? Speed;
        private double? Amplitude;
        private bool? Cover;
        private double? Width;
        private double? Height;
        private bool? Autostart;
        private double? PixelDepth;
        private double? LerpSpeed;
        private IOS9WaveRanges? iOS9Ranges;
        private List<IOS9WaveCurveDefintion>? Definitions;

        public IOS9WaveOptionBuilder SetContainer(ElementReference container)
        {
            Container = container;
            return this;
        }

        public IOS9WaveOptionBuilder SetRatio(double? ratio)
        {
            Ratio = ratio;
            return this;
        }

        public IOS9WaveOptionBuilder SetSpeed(double? speed)
        {
            Speed = speed;
            return this;
        }

        public IOS9WaveOptionBuilder SetAmplitude(double? amplitude)
        {
            Amplitude = amplitude;
            return this;
        }
        public IOS9WaveOptionBuilder SetGlobalCompositeOperation(string globalCompositeOperation)
        {
            GlobalCompositeOperation = globalCompositeOperation;
            return this;
        }
        public IOS9WaveOptionBuilder SetCover(bool? cover)
        {
            Cover = cover;
            return this;
        }

        public IOS9WaveOptionBuilder SetWidth(double? width)
        {
            Width = width;
            return this;
        }

        public IOS9WaveOptionBuilder SetHeight(double? height)
        {
            Height = height;
            return this;
        }

        public IOS9WaveOptionBuilder SetAutostart(bool? autostart)
        {
            Autostart = autostart;
            return this;
        }

        public IOS9WaveOptionBuilder SetPixelDepth(double? pixelDepth)
        {
            PixelDepth = pixelDepth;
            return this;
        }

        public IOS9WaveOptionBuilder SetLerpSpeed(double? lerpSpeed)
        {
            LerpSpeed = lerpSpeed;
            return this;
        }

        public IOS9WaveOptionBuilder SetIOS9Ranges(IOS9WaveRanges ios9Ranges)
        {
            iOS9Ranges = ios9Ranges;
            return this;
        }

        public IOS9WaveOptionBuilder SetDefinitions(List<IOS9WaveCurveDefintion> definitions)
        {
            Definitions = definitions;
            return this;
        }
        public IOS9WaveOptionBuilder GetDefaultOptions(ElementReference Container)
        {
            this.Container = Container;
            Style = "ios";
            Ratio = 1.0;
            Speed = 0.2;
            Amplitude = 1.0;
            Cover = true;
            Width = 640.0;
            Height = 200.0;
            Autostart = true;
            PixelDepth = 0.02;
            LerpSpeed = 0.01;
            Definitions = null;
            GlobalCompositeOperation = "lighter";

            return this;

        }
        public IOptions<IOS9WaveCurveDefintion> Build()
        {
            

            return new IOS9WaveOptions
            {
                Container = Container,
                Style = "ios9",
                Ratio = Ratio,
                Speed = Speed,
                Amplitude = Amplitude,
                Cover = Cover,
                Width = Width,
                Height = Height,
                Autostart = Autostart,
                PixelDepth = PixelDepth,
                LerpSpeed = LerpSpeed,
                iOS9Ranges = iOS9Ranges,
                Definitions = Definitions,
                GlobalCompositeOperation = GlobalCompositeOperation
            };
        }
    }
}
