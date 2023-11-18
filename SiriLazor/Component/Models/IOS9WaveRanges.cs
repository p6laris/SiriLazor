namespace SiriLazor.Component.Models
{
    public record IOS9WaveRanges
    {
        public double[] NoOfCurves { get; set; } = new double[2];
        public double[] Amplitude { get; set; } = new double[2];
        public double[] Offset { get; set; } = new double[2];
        public double[] Width { get; set; } = new double[2];
        public double[] Speed { get; set; } = new double[2];
        public double[] DespawnTimeout { get; set; } = new double[2];
    }


}
