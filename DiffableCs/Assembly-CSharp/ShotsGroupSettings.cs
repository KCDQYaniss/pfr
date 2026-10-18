//Type is in global namespace

public class ShotsGroupSettings
{
	public int StartShotIndex; //Field offset: 0x10
	public int EndShotIndex; //Field offset: 0x14
	[Tooltip("Разброс силы вращения, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilRotationStrength; //Field offset: 0x18
	[Tooltip("Разброс смещения позиции, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilPositionStrength; //Field offset: 0x20
	[Tooltip("Разброс угла вращения, который добавляется к общим расчетам")]
	public Vector2 ShotRecoilRadianRange; //Field offset: 0x28

	public ShotsGroupSettings() { }

	public bool IsShotIndexInRange(int shotIndex) { }

}

