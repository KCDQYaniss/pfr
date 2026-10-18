//Type is in global namespace

[DefaultMember("Item")]
public sealed class BallisticPreset
{
	public string Name; //Field offset: 0x10
	public MaterialType MaterialType; //Field offset: 0x18
	public float[] values; //Field offset: 0x20
	[Tooltip("PenetrationLevel зависит от скейла")]
	public bool DependOnScale; //Field offset: 0x28
	[Tooltip("График множителя PenetrationLevel(value) от скейла(time)")]
	public AnimationCurve ScaleToPenetrationCurve; //Field offset: 0x30

	public float Item
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public BallisticPreset() { }

	public void ApplyPresetValues(BallisticCollider bCollider) { }

	public void ApplyScaleMult(BallisticCollider ballisticCollider, in Vector3 scale) { }

	public float get_Item(int i) { }

	public bool IsValid(BallisticCollider bCollider) { }

	public void set_Item(int i, float value) { }

}

