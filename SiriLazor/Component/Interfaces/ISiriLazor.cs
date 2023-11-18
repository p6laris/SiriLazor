using SiriLazor.Component.Models;

namespace SiriLazor
{
    public interface ISiriLazor
    {
        ValueTask<SiriObject> InitSiriLazor(IOptions<ClassicWaveCurveDefintion> options);
        ValueTask<SiriObject> InitSiriLazor(IOptions<IOS9WaveCurveDefintion> options);
    }
}
