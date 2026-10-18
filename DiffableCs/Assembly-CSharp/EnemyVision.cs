//Type is in global namespace

public class EnemyVision
{
	[CompilerGenerated]
	private bool <Visible>k__BackingField; //Field offset: 0x10
	public bool CanShoot; //Field offset: 0x11
	public float VisibilityLevel; //Field offset: 0x14
	private EEnemyPartVisibleType _visibleType; //Field offset: 0x18

	public private bool Visible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EEnemyPartVisibleType VisibleType
	{
		 get { } //Length: 4
		 set { } //Length: 12
	}

	public EnemyVision(EEnemyPartVisibleType visibleType, bool canShoot, float visibilityLevel) { }

	[CompilerGenerated]
	public bool get_Visible() { }

	public EEnemyPartVisibleType get_VisibleType() { }

	[CompilerGenerated]
	private void set_Visible(bool value) { }

	public void set_VisibleType(EEnemyPartVisibleType value) { }

	public virtual string ToString() { }

}

