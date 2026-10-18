//Type is in global namespace

public class BotGlobasHearingSettings
{
	[Comment("Если вытрелить рядом с ботом когда он ничем не обеспокоен с дистанции меньше Х то он начнет паниковать")]
	public float BOT_CLOSE_PANIC_DIST; //Field offset: 0x10
	[Comment("Шанс услышать простой звук")]
	public float CHANCE_TO_HEAR_SIMPLE_SOUND_0_1; //Field offset: 0x14
	[Comment("Коэфицент точности восприятия звука от не опасных звуков - больше - точнее")]
	public float DISPERSION_COEF; //Field offset: 0x18
	[Comment("Коэфицент точности восприятия звука от опасных звуков - больше - точнее")]
	public float DISPERSION_COEF_GUN; //Field offset: 0x1C
	[Comment("Множитель дистанции, на которой слышен выстрел. 1 — без изменений. На шаги не влияет.")]
	public float GUNSHOT_HEARING_COEF; //Field offset: 0x20
	[Comment("Ближе этой дистанции простой звук слышен всегда")]
	public float CLOSE_DIST; //Field offset: 0x24
	[Comment("Дальше эой дистанции простой звук не слышен всегда")]
	public float FAR_DIST; //Field offset: 0x28
	[Comment("Угл При котором выстрел считается произведенным в бота")]
	public float SOUND_DIR_DEEFREE; //Field offset: 0x2C
	[Comment(null)]
	public float DIST_PLACE_TO_FIND_POINT; //Field offset: 0x30
	[Comment(null)]
	public float DEAD_BODY_SOUND_RAD; //Field offset: 0x34
	[Comment("Когда юот смотрит на слух. Он убдет оборачиватся только на \"опасные\" точки.")]
	public bool LOOK_ONLY_DANGER; //Field offset: 0x38
	[Comment(null)]
	public float RESET_TIMER_DIST; //Field offset: 0x3C
	[Comment("Задержка для слуха когда бот в мирном режиме.")]
	public float HEAR_DELAY_WHEN_PEACE; //Field offset: 0x40
	[Comment("Задержка для слуха когда бот в режиме подозрения.")]
	public float HEAR_DELAY_WHEN_HAVE_SMT; //Field offset: 0x44
	[Comment("Через сколько секунд после пропадния врага из вида бот входит в режим карауливания")]
	public float LOOK_ONLY_DANGER_DELTA; //Field offset: 0x48
	[Comment("Если бот почуствовал выстрел с дистанции боле Х то бот скажет \"снайпер\"")]
	public float ENEMY_SNIPER_SHOOT_DIST; //Field offset: 0x4C

	public BotGlobasHearingSettings() { }

	public void Update() { }

}

