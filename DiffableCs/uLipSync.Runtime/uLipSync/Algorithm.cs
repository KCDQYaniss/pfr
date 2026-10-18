namespace uLipSync;

[BurstCompile]
public static class Algorithm
{
	public static class _FFT_0000001E$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static _FFT_0000001E$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* spectrumRe, float* spectrumIm, int N) { }

	}

	internal sealed class _FFT_0000001E$PostfixBurstDelegate : MulticastDelegate
	{

		public _FFT_0000001E$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* spectrumRe, float* spectrumIm, int N, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* spectrumRe, float* spectrumIm, int N) { }

	}

	public static class CopyRingBuffer_0000000F$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static CopyRingBuffer_0000000F$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* input, float* output, int len, int startSrcIndex) { }

	}

	internal sealed class CopyRingBuffer_0000000F$PostfixBurstDelegate : MulticastDelegate
	{

		public CopyRingBuffer_0000000F$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* input, float* output, int len, int startSrcIndex, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* input, float* output, int len, int startSrcIndex) { }

	}

	public static class DCT_00000026$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static DCT_00000026$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* spectrum, float* cepstrum, int len) { }

	}

	internal sealed class DCT_00000026$PostfixBurstDelegate : MulticastDelegate
	{

		public DCT_00000026$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* spectrum, float* cepstrum, int len, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* spectrum, float* cepstrum, int len) { }

	}

	public static class DownSample1_00000015$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static DownSample1_00000015$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* input, float* output, int outputLen, int skip) { }

	}

	internal sealed class DownSample1_00000015$PostfixBurstDelegate : MulticastDelegate
	{

		public DownSample1_00000015$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* input, float* output, int outputLen, int skip, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* input, float* output, int outputLen, int skip) { }

	}

	public static class DownSample2_00000016$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static DownSample2_00000016$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* input, int inputLen, float* output, int outputLen, float df) { }

	}

	internal sealed class DownSample2_00000016$PostfixBurstDelegate : MulticastDelegate
	{

		public DownSample2_00000016$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* input, int inputLen, float* output, int outputLen, float df, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* input, int inputLen, float* output, int outputLen, float df) { }

	}

	public static class FFT_0000001D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static FFT_0000001D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* data, float* spectrum, int N) { }

	}

	internal sealed class FFT_0000001D$PostfixBurstDelegate : MulticastDelegate
	{

		public FFT_0000001D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* data, float* spectrum, int N, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* data, float* spectrum, int N) { }

	}

	public static class GetMaxValue_0000000B$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetMaxValue_0000000B$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float* array, int len) { }

	}

	internal sealed class GetMaxValue_0000000B$PostfixBurstDelegate : MulticastDelegate
	{

		public GetMaxValue_0000000B$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float* array, int len) { }

	}

	public static class GetRMSVolume_0000000D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static GetRMSVolume_0000000D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float* array, int len) { }

	}

	internal sealed class GetRMSVolume_0000000D$PostfixBurstDelegate : MulticastDelegate
	{

		public GetRMSVolume_0000000D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float* array, int len) { }

	}

	public static class HammingWindow_0000001A$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static HammingWindow_0000001A$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* array, int len) { }

	}

	internal sealed class HammingWindow_0000001A$PostfixBurstDelegate : MulticastDelegate
	{

		public HammingWindow_0000001A$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* array, int len) { }

	}

	public static class LowPassFilter_00000013$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static LowPassFilter_00000013$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* data, int len, float cutoff, float* tmp, float* b, int bLen) { }

	}

	internal sealed class LowPassFilter_00000013$PostfixBurstDelegate : MulticastDelegate
	{

		public LowPassFilter_00000013$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* data, int len, float cutoff, float* tmp, float* b, int bLen, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* data, int len, float cutoff, float* tmp, float* b, int bLen) { }

	}

	public static class MelFilterBank_00000020$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static MelFilterBank_00000020$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* spectrum, float* melSpectrum, int len, float sampleRate, int melDiv) { }

	}

	internal sealed class MelFilterBank_00000020$PostfixBurstDelegate : MulticastDelegate
	{

		public MelFilterBank_00000020$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* spectrum, float* melSpectrum, int len, float sampleRate, int melDiv, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* spectrum, float* melSpectrum, int len, float sampleRate, int melDiv) { }

	}

	public static class Norm_00000029$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Norm_00000029$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float* array, int len) { }

	}

	internal sealed class Norm_00000029$PostfixBurstDelegate : MulticastDelegate
	{

		public Norm_00000029$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float* array, int len) { }

	}

	public static class Normalize_00000011$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Normalize_00000011$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* array, int len, float value = 1) { }

	}

	internal sealed class Normalize_00000011$PostfixBurstDelegate : MulticastDelegate
	{

		public Normalize_00000011$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, float value = 1, AsyncCallback unnamed_param_3, object unnamed_param_4) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* array, int len, float value = 1) { }

	}

	public static class PowerToDb_00000022$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static PowerToDb_00000022$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* array, int len) { }

	}

	internal sealed class PowerToDb_00000022$PostfixBurstDelegate : MulticastDelegate
	{

		public PowerToDb_00000022$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* array, int len, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* array, int len) { }

	}

	public static class PreEmphasis_00000018$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static PreEmphasis_00000018$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(float* data, float* tmp, int len, float p) { }

	}

	internal sealed class PreEmphasis_00000018$PostfixBurstDelegate : MulticastDelegate
	{

		public PreEmphasis_00000018$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float* data, float* tmp, int len, float p, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		public override void Invoke(float* data, float* tmp, int len, float p) { }

	}

	public static class ToHz_00000024$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ToHz_00000024$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float mel, bool slaney = false) { }

	}

	internal sealed class ToHz_00000024$PostfixBurstDelegate : MulticastDelegate
	{

		public ToHz_00000024$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float mel, bool slaney = false, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float mel, bool slaney = false) { }

	}

	public static class ToMel_00000023$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static ToMel_00000023$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static float Invoke(float hz, bool slaney = false) { }

	}

	internal sealed class ToMel_00000023$PostfixBurstDelegate : MulticastDelegate
	{

		public ToMel_00000023$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float hz, bool slaney = false, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		public override float EndInvoke(IAsyncResult unnamed_param_0) { }

		public override float Invoke(float hz, bool slaney = false) { }

	}


	[BurstCompile]
	private static void _FFT(float* spectrumRe, float* spectrumIm, int N) { }

	[BurstCompile]
	public static void _FFT$BurstManaged(float* spectrumRe, float* spectrumIm, int N) { }

	public static void CopyRingBuffer(in NativeArray input, out NativeArray output, int startSrcIndex) { }

	[BurstCompile]
	private static void CopyRingBuffer(float* input, float* output, int len, int startSrcIndex) { }

	[BurstCompile]
	public static void CopyRingBuffer$BurstManaged(float* input, float* output, int len, int startSrcIndex) { }

	public static void DCT(in NativeArray spectrum, out NativeArray cepstrum) { }

	[BurstCompile]
	private static void DCT(float* spectrum, float* cepstrum, int len) { }

	[BurstCompile]
	public static void DCT$BurstManaged(float* spectrum, float* cepstrum, int len) { }

	public static void DownSample(in NativeArray input, out NativeArray output, int sampleRate, int targetSampleRate) { }

	[BurstCompile]
	private static void DownSample1(float* input, float* output, int outputLen, int skip) { }

	[BurstCompile]
	public static void DownSample1$BurstManaged(float* input, float* output, int outputLen, int skip) { }

	[BurstCompile]
	private static void DownSample2(float* input, int inputLen, float* output, int outputLen, float df) { }

	[BurstCompile]
	public static void DownSample2$BurstManaged(float* input, int inputLen, float* output, int outputLen, float df) { }

	[BurstCompile]
	private static void FFT(float* data, float* spectrum, int N) { }

	public static void FFT(in NativeArray data, out NativeArray spectrum) { }

	[BurstCompile]
	public static void FFT$BurstManaged(float* data, float* spectrum, int N) { }

	[BurstCompile]
	private static float GetMaxValue(float* array, int len) { }

	public static float GetMaxValue(in NativeArray array) { }

	[BurstCompile]
	public static float GetMaxValue$BurstManaged(float* array, int len) { }

	public static float GetRMSVolume(in NativeArray array) { }

	[BurstCompile]
	private static float GetRMSVolume(float* array, int len) { }

	[BurstCompile]
	public static float GetRMSVolume$BurstManaged(float* array, int len) { }

	public static void HammingWindow(ref NativeArray array) { }

	[BurstCompile]
	private static void HammingWindow(float* array, int len) { }

	[BurstCompile]
	public static void HammingWindow$BurstManaged(float* array, int len) { }

	[BurstCompile]
	private static void LowPassFilter(float* data, int len, float cutoff, float* tmp, float* b, int bLen) { }

	public static void LowPassFilter(ref NativeArray data, float sampleRate, float cutoff, float range) { }

	[BurstCompile]
	public static void LowPassFilter$BurstManaged(float* data, int len, float cutoff, float* tmp, float* b, int bLen) { }

	[BurstCompile]
	private static void MelFilterBank(float* spectrum, float* melSpectrum, int len, float sampleRate, int melDiv) { }

	public static void MelFilterBank(in NativeArray spectrum, out NativeArray melSpectrum, float sampleRate, int melDiv) { }

	[BurstCompile]
	public static void MelFilterBank$BurstManaged(float* spectrum, float* melSpectrum, int len, float sampleRate, int melDiv) { }

	public static float Norm(in NativeArray array) { }

	public static float Norm(in NativeSlice slice) { }

	[BurstCompile]
	private static float Norm(float* array, int len) { }

	[BurstCompile]
	public static float Norm$BurstManaged(float* array, int len) { }

	[BurstCompile]
	private static void Normalize(float* array, int len, float value = 1) { }

	public static void Normalize(ref NativeArray array, float value = 1) { }

	[BurstCompile]
	public static void Normalize$BurstManaged(float* array, int len, float value = 1) { }

	public static void PowerToDb(ref NativeArray array) { }

	[BurstCompile]
	private static void PowerToDb(float* array, int len) { }

	[BurstCompile]
	public static void PowerToDb$BurstManaged(float* array, int len) { }

	[BurstCompile]
	private static void PreEmphasis(float* data, float* tmp, int len, float p) { }

	public static void PreEmphasis(ref NativeArray data, float p) { }

	[BurstCompile]
	public static void PreEmphasis$BurstManaged(float* data, float* tmp, int len, float p) { }

	[BurstCompile]
	private static float ToHz(float mel, bool slaney = false) { }

	[BurstCompile]
	public static float ToHz$BurstManaged(float mel, bool slaney = false) { }

	[BurstCompile]
	private static float ToMel(float hz, bool slaney = false) { }

	[BurstCompile]
	public static float ToMel$BurstManaged(float hz, bool slaney = false) { }

	public static void ZeroPadding(ref NativeArray data, out NativeArray dataWithPadding) { }

}

