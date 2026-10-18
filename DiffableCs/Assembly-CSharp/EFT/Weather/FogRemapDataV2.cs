namespace EFT.Weather;

[CreateAssetMenu]
public class FogRemapDataV2 : ScriptableObject
{
	[CompilerGenerated]
	private Action OnChange; //Field offset: 0x18
	[SerializeField]
	private FogRemapRecordV2 _record; //Field offset: 0x20

	public event Action OnChange
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public FogRemapRecordV2 Record
	{
		 get { } //Length: 64
		 set { } //Length: 154
	}

	public FogRemapDataV2() { }

	[CompilerGenerated]
	public void add_OnChange(Action value) { }

	public FogRemapRecordV2 get_Record() { }

	public float RemapFogValue(float fog, float hour, out FogRemapRecordV2Result interpolatedParameters) { }

	[CompilerGenerated]
	public void remove_OnChange(Action value) { }

	public void set_Record(FogRemapRecordV2 value) { }

}

