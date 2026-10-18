namespace EFT.Animations;

public class RotationRecoilProcessBase : RecoilProcessBase
{
	[Tooltip("Максимальный базовый угол разброса вращения оружия от отдачи, применяеться при подсчете базового угла отдачи во время инициализации оружия")]
	public int MaxRecoilRotationAngle; //Field offset: 0x58

	public RotationRecoilProcessBase() { }

}

