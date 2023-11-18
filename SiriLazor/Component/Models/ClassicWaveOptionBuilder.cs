using Microsoft.AspNetCore.Components;
using SiriLazor.Component.Interfaces;

namespace SiriLazor.Component.Models
{
    internal class ClassicWaveOptionBuilder : IWaveOptionBuilder<ClassicWaveCurveDefintion>
    {
        private ElementReference Container;
        private string? Style;
        private string? GlobalCompositeOperation;
        private double? Ratio;
        private double? Speed;
        private double? Amplitude;
        private double? Frequency;
        private string? Color;
        private bool? Cover;
        private double? Width;
        private double? Height;
        private bool? Autostart;
        private double? PixelDepth;
        private double? LerpSpeed;
        private List<ClassicWaveCurveDefintion>? Definitions;

        public ClassicWaveOptionBuilder SetContainer(ElementReference container)
        {
            Container = container;
            return this;
        }

        public ClassicWaveOptionBuilder SetRatio(double? ratio)
        {
            Ratio = ratio;
            return this;
        }

        public ClassicWaveOptionBuilder SetSpeed(double? speed)
        {
            Speed = speed;
            return this;
        }


        public ClassicWaveOptionBuilder SetAmplitude(double? amplitude)
        {
            Amplitude = amplitude;
            return this;
        }
        public ClassicWaveOptionBuilder SetGlobalCompositeOperation(string globalCompositeOperation)
        {
            GlobalCompositeOperation = globalCompositeOperation;
            return this;
        }

        public ClassicWaveOptionBuilder SetFrequency(double? frequency)
        {
            Frequency = frequency;
            return this;
        }

        public ClassicWaveOptionBuilder SetColor(string? color)
        {
            Color = color;
            return this;
        }

        public ClassicWaveOptionBuilder SetCover(bool? cover)
        {
            Cover = cover;
            return this;
        }

        public ClassicWaveOptionBuilder SetWidth(double? width)
        {
            Width = width;
            return this;
        }

        public ClassicWaveOptionBuilder SetHeight(double? height)
        {
            Height = height;
            return this;
        }

        public ClassicWaveOptionBuilder SetAutostart(bool? autostart)
        {
            Autostart = autostart;
            return this;
        }

        public ClassicWaveOptionBuilder SetPixelDepth(double? pixelDepth)
        {
            PixelDepth = pixelDepth;
            return this;
        }

        public ClassicWaveOptionBuilder SetLerpSpeed(double? lerpSpeed)
        {
            LerpSpeed = lerpSpeed;
            return this;
        }

        public ClassicWaveOptionBuilder SetDefinitions(List<ClassicWaveCurveDefintion> definitions)
        {
            Definitions = definitions;
            return this;
        }
        
        public ClassicWaveOptionBuilder GetDefaultOptions(ElementReference Container)
        {

            this.Container = Container;
            Style = "ios";
            Ratio = null;
            Speed = 0.2;
            Amplitude = 1.0;
            Frequency = 6.0;
            Color = "#ffffff";
            Cover = false;
            Width =  640.0;
            Height =  200.0;
            Autostart =  false;
            PixelDepth =  0.02;
            LerpSpeed =  0.01;
            Definitions = null;
            GlobalCompositeOperation = "lighter";

            return this;

        }
        public IOptions<ClassicWaveCurveDefintion> Build()
        {
           

            return new ClassicWaveOptions
            {
                Container = Container,
                Style = "ios",
                Ratio = Ratio,
                Speed = Speed,
                Amplitude = Amplitude,
                Frequency = Frequency,
                Color = Color,
                Cover = Cover,
                Width = Width,
                Height = Height,
                Autostart = Autostart,
                PixelDepth = PixelDepth,
                LerpSpeed = LerpSpeed,
                Definitions = Definitions,
                GlobalCompositeOperation = GlobalCompositeOperation
            };
        }
    }
}
