using SiriLazor.Component.Interfaces;


namespace SiriLazor.Component.Models
{
    /// <summary>
    /// Represents the definition of a classic wave curve for graphics rendering.
    /// </summary>
    public class ClassicWaveCurveDefintion : ICurveDefintion
    {
        public string Color { get; set; }

        public int Attenuation { get; set; }
        public int LineWidth { get; set; }
        public int Opacity { get; set; }
    }
}
