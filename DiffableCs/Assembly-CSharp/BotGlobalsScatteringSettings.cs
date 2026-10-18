//Type is in global namespace

public class BotGlobalsScatteringSettings
{
	[Comment(" [метры на расстояние]\tМинимальный угол разброса")]
	public float MinScatter; //Field offset: 0x10
	[Comment(" [метры на расстояние]\tРабочий угол разброса")]
	public float WorkingScatter; //Field offset: 0x14
	[Comment("[метры на расстояние]\tМаксимальный угол разброса")]
	public float MaxScatter; //Field offset: 0x18
	[Comment(" [метры на расстояние]/сек\tСкорость схождения угла разброса")]
	public float SpeedUp; //Field offset: 0x1C
	[Comment("  Float\tКоэффициент на который умножается скорость схождения угла разброса при прицеливании. Больше лучше")]
	public float SpeedUpAim; //Field offset: 0x20
	[Comment("   Попугаи/сек\tСкорость расхождения угла разброса. Больше лучше")]
	public float SpeedDown; //Field offset: 0x24
	[Comment("   Попугаи/сек\tСкорость бота после которой начинается замедление схождения угла разброса")]
	public float ToSlowBotSpeed; //Field offset: 0x28
	[Comment("   Попугаи/сек\tСкорость бота после которой начинается останавливается схождение угла разброса")]
	public float ToLowBotSpeed; //Field offset: 0x2C
	[Comment(" Попугаи/сек Скорость бота после которой начинается расхождение угла разброса")]
	public float ToUpBotSpeed; //Field offset: 0x30
	[Comment("Коэфициент. Больше хуже. Насколько изменится скорсоть сведения если удельная скорость (ToSlowBotSpeed,ToLowBotSpeed) в этом промежутке")]
	public float MovingSlowCoef; //Field offset: 0x34
	[Comment("  Градусы/сек\tСкорость поворота бота после которой начинается расхождение угла разброса")]
	public float ToLowBotAngularSpeed; //Field offset: 0x38
	[Comment(null)]
	public float ToStopBotAngularSpeed; //Field offset: 0x3C
	[Comment("   Градусы\tНа сколько расходится угол разброса бота при попадании по нему умноженное на урон.")]
	public float FromShot; //Field offset: 0x40
	[Comment(" Float\tМножитель на сколько быстрей будет сходиться значение ScatterSpeed при использовании трассирующих пуль")]
	public float TracerCoef; //Field offset: 0x44
	[Comment(" Float\tКоэффициент изменения минимального круга точности  при выбитой руке")]
	public float HandDamageScatteringMinMax; //Field offset: 0x48
	[Comment(" Float kоэффициент скорости схождения угла прицеливания при выбитой руке")]
	public float HandDamageAccuracySpeed; //Field offset: 0x4C
	[Comment("   Float\tКоэффициент изменения рабочего круга точности при кровотечении")]
	public float BloodFall; //Field offset: 0x50
	[Comment(" В процентах\tКоличество оставшихся патронов для перехода в состояние экономии патронов 0_1")]
	public float Caution; //Field offset: 0x54
	[Comment("  Float\tКоэффициент изменения предпочтительного круга точности в режиме экономии патронов")]
	public float ToCaution; //Field offset: 0x58
	[Comment("  Float\tКоэффициент контроля отдачи зависящий от отдачи оружия. Увеличивает текущий круг при вылете пули из ствола. Для одиночных выстрелов.")]
	public float RecoilControlCoefShootDone; //Field offset: 0x5C
	[Comment("  Float\tКоэффициент контроля отдачи зависящий от отдачи оружия. Увеличивает текущий круг при вылете пули из ствола. для автоматического огня")]
	public float RecoilControlCoefShootDoneAuto; //Field offset: 0x60
	[Comment("Попугаи. Как высоко подскакивает при амплитуде прицел")]
	public float AMPLITUDE_FACTOR; //Field offset: 0x64
	[Comment("Попугаи. Скорость амплитуды прицеливания")]
	public float AMPLITUDE_SPEED; //Field offset: 0x68
	[Comment("Метры. Дистанция от новой точки прицеливая до старой, если больше чем Х то бот автоматически считает что он неприцелился независимо не от чего остального.")]
	public float DIST_FROM_OLD_POINT_TO_NOT_AIM; //Field offset: 0x6C
	[Comment(null)]
	public float DIST_FROM_OLD_POINT_TO_NOT_AIM_SQRT; //Field offset: 0x70
	[Comment("Метры. Если точка прицеливания ближе чем Х то бот не будет стрелять")]
	public float DIST_NOT_TO_SHOOT; //Field offset: 0x74
	[Comment("В момент смены положения текущий круг сведения увеличится на Х*степень смены положения")]
	public float PoseChnageCoef; //Field offset: 0x78
	[Comment(" В момент смены положения на лежа/нележа текущий круг сведения увеличится на Х")]
	public float LayFactor; //Field offset: 0x7C
	[Comment("насколько вверх подбрасывает ствол. Коэфициент от отдачи оружия.")]
	public float RecoilYCoef; //Field offset: 0x80
	[Comment("Скорость снижения отдачи вверх")]
	public float RecoilYCoefSppedDown; //Field offset: 0x84
	[Comment("насколько максимально может подняться отдача.")]
	public float RecoilYMax; //Field offset: 0x88

	public BotGlobalsScatteringSettings() { }

	public void Update() { }

}

