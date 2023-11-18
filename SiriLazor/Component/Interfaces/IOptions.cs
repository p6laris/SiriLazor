using Microsoft.AspNetCore.Components;
using SiriLazor.Component.Interfaces;

namespace SiriLazor;
public interface IOptions<out TCurve> where TCurve : ICurveDefintion
{
    ElementReference Container { get; set; }

    string? Style { get; set; }
    double? Ratio { get; set; }
    double? Speed { get; set; }
    double? Amplitude { get; set; }
    bool? Cover { get; set; }
    double? Width { get; set; }
    double? Height { get; set; }
    bool? Autostart { get; set; }
    double? PixelDepth { get; set; }
    double? LerpSpeed { get; set; }
    IEnumerable<TCurve>? Definitions { get;}
    string? GlobalCompositeOperation { get; set; }

}