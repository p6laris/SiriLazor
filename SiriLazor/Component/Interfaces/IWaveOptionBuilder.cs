
namespace SiriLazor.Component.Interfaces
{
    public interface IWaveOptionBuilder<TCurve> where TCurve : ICurveDefintion
    {
        IOptions<TCurve> Build();
    }
}
