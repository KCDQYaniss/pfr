namespace MultiFlare;

public class FlareSettings
{
	[HideInInspectorButNotInDebug]
	[SerializeField]
	private ProFlareAtlas _atlas; //Field offset: 0x10
	[SerializeField]
	private BatchSettings _normalBatch; //Field offset: 0x18
	[SerializeField]
	private BatchSettings _shitBatch; //Field offset: 0x20
	[SerializeField]
	private FlareOverlapSettings _flareOverlapSettings; //Field offset: 0x28

	public ProFlareAtlas Atlas
	{
		 get { } //Length: 5
	}

	public FlareOverlapSettings FlareOverlapSettings
	{
		 get { } //Length: 5
	}

	public bool IsNvEnabled
	{
		 set { } //Length: 50
	}

	public bool IsPopulated
	{
		 get { } //Length: 481
	}

	public BatchSettings NormalBatch
	{
		 get { } //Length: 5
	}

	public BatchSettings ShitBatch
	{
		 get { } //Length: 5
	}

	public FlareSettings() { }

	public ProFlareAtlas get_Atlas() { }

	public FlareOverlapSettings get_FlareOverlapSettings() { }

	public bool get_IsPopulated() { }

	public BatchSettings get_NormalBatch() { }

	public BatchSettings get_ShitBatch() { }

	public void set_IsNvEnabled(bool value) { }

	public void SetBlindnessProtectionFactor(float value) { }

}

