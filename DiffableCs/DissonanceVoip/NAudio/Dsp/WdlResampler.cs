namespace NAudio.Dsp;

internal class WdlResampler
{
	private class WDL_Resampler_IIRFilter
	{
		private double m_fpos; //Field offset: 0x10
		private double m_a1; //Field offset: 0x18
		private double m_a2; //Field offset: 0x20
		private double m_b0; //Field offset: 0x28
		private double m_b1; //Field offset: 0x30
		private double m_b2; //Field offset: 0x38
		private double[,] m_hist; //Field offset: 0x40

		public WDL_Resampler_IIRFilter() { }

		public void Apply(float[] inBuffer, int inIndex, float[] outBuffer, int outIndex, int ns, int span, int w) { }

		private double denormal_filter(float x) { }

		private double denormal_filter(double x) { }

		public void Reset() { }

		public void setParms(double fpos, double Q) { }

	}

	private const int WDL_RESAMPLE_MAX_FILTERS = 4; //Field offset: 0x0
	private const int WDL_RESAMPLE_MAX_NCH = 64; //Field offset: 0x0
	private const double PI = 3.141592653589793; //Field offset: 0x0
	private double m_sratein; //Field offset: 0x10
	private double m_srateout; //Field offset: 0x18
	private double m_fracpos; //Field offset: 0x20
	private double m_ratio; //Field offset: 0x28
	private double m_filter_ratio; //Field offset: 0x30
	private float m_filterq; //Field offset: 0x38
	private float m_filterpos; //Field offset: 0x3C
	private float[] m_rsinbuf; //Field offset: 0x40
	private float[] m_filter_coeffs; //Field offset: 0x48
	private WDL_Resampler_IIRFilter m_iirfilter; //Field offset: 0x50
	private int m_filter_coeffs_size; //Field offset: 0x58
	private int m_last_requested; //Field offset: 0x5C
	private int m_filtlatency; //Field offset: 0x60
	private int m_samples_in_rsinbuf; //Field offset: 0x64
	private int m_lp_oversize; //Field offset: 0x68
	private int m_sincsize; //Field offset: 0x6C
	private int m_filtercnt; //Field offset: 0x70
	private int m_sincoversize; //Field offset: 0x74
	private bool m_interp; //Field offset: 0x78
	private bool m_feedmode; //Field offset: 0x79

	public double InputSampleRate
	{
		 get { } //Length: 6
	}

	public double OutputSampleRate
	{
		 get { } //Length: 6
	}

	public WdlResampler() { }

	private void BuildLowPass(double filtpos) { }

	public double get_InputSampleRate() { }

	public double get_OutputSampleRate() { }

	public double GetCurrentLatency() { }

	public int ResampleOut(float[] outBuffer, int outBufferIndex, int nsamples_in, int nsamples_out, int nch) { }

	public int ResamplePrepare(int out_samples, int nch, out float[] inbuffer, out int inbufferOffset) { }

	public void Reset(double fracpos = 0) { }

	public void SetFeedMode(bool wantInputDriven) { }

	public void SetFilterParms(float filterpos = 0.693, float filterq = 0.707) { }

	public void SetMode(bool interp, int filtercnt, bool sinc, int sinc_size = 64, int sinc_interpsize = 32) { }

	public void SetRates(double rate_in, double rate_out) { }

	private void SincSample(float[] outBuffer, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, int nch, float[] filter, int filterIndex, int filtsz) { }

	private void SincSample1(float[] outBuffer, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, float[] filter, int filterIndex, int filtsz) { }

	private void SincSample2(float[] outptr, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, float[] filter, int filterIndex, int filtsz) { }

}

