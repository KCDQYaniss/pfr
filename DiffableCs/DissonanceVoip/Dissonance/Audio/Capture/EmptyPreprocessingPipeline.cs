namespace Dissonance.Audio.Capture;

internal class EmptyPreprocessingPipeline : BasePreprocessingPipeline
{

	public virtual bool IsOutputMuted
	{
		 set { } //Length: 3
	}

	protected virtual bool VadIsSpeechDetected
	{
		 get { } //Length: 3
	}

	public EmptyPreprocessingPipeline(WaveFormat inputFormat) { }

	protected virtual bool get_VadIsSpeechDetected() { }

	protected virtual void PreprocessAudioFrame(float[] frame) { }

	public virtual void set_IsOutputMuted(bool value) { }

}

