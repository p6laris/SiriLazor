using SiriLazor.Component.Interfaces;


namespace SiriLazor.Component.Models
{
    public class ClassicWaveCurveDefintion : ICurveDefintion
    {
        public string Color { get; set; }

        public int Attenuation { get; set; }
        public int LineWidth { get; set; }
        public int Opacity { get; set; }
    }
}
