//Type is in global namespace

public class BotGlobalsCoverSettings
{
	[Comment("min Время после которогобог убежавший в засаду может вернутся в режим атаки")]
	public float RETURN_TO_ATTACK_AFTER_AMBUSH_MIN; //Field offset: 0x10
	[Comment("max")]
	public float RETURN_TO_ATTACK_AFTER_AMBUSH_MAX; //Field offset: 0x14
	[Comment("Дистанция на которой бот пугается выстрела и перестает считать свое укрытие надежным")]
	public float SOUND_TO_GET_SPOTTED; //Field offset: 0x18
	[Comment("Время которое после послейдней перестрелки бот будет сидеть в укрытии (При атакующем состоянии) по любому")]
	public float TIME_TO_MOVE_TO_COVER; //Field offset: 0x1C
	[Comment("Максимальная дистанция при которйо бот считается в укрытии, после перепоиска точки укрытия")]
	public float MAX_DIST_OF_COVER; //Field offset: 0x20
	[Comment("Дельта для перерасчета поиска укрытия во время бега.")]
	public float CHANGE_RUN_TO_COVER_SEC; //Field offset: 0x24
	[Comment("Дельта для перерасчета поиска укрытия во время бега от гранаты.")]
	public float CHANGE_RUN_TO_COVER_SEC_GREANDE; //Field offset: 0x28
	[Comment(null)]
	public float MIN_DIST_TO_ENEMY; //Field offset: 0x2C
	[Comment("Если мы уже приблизились к нашей точке на Х м. То она не может быть сменена")]
	public float DIST_CANT_CHANGE_WAY; //Field offset: 0x30
	[Comment("Если игрок смотрит на меня и ближе чем Х то укрытия считается ненадежным и будет покинуто")]
	public float DIST_CHECK_SFETY; //Field offset: 0x34
	[Comment("Как часто крытие проверяется на сохранность")]
	public float TIME_CHECK_SAFE; //Field offset: 0x38
	[Comment("Время за которое бот выглядывает и прячется за укрытиям")]
	public float HIDE_TO_COVER_TIME; //Field offset: 0x3C
	[Comment(null)]
	public float MAX_DIST_OF_COVER_SQR; //Field offset: 0x40
	[Comment(null)]
	public float DIST_CANT_CHANGE_WAY_SQR; //Field offset: 0x44
	[Comment("Если бот был обнаружет то все точки укрытий в этом радиусе будут помеченны как обнаруженные")]
	public float SPOTTED_COVERS_RADIUS; //Field offset: 0x48
	[Comment("Если последний увиденный враг был меньше стольки секунд назад, то бот не в укрытии позиции будет смотреть на последнюю узвестную точку")]
	public float LOOK_LAST_ENEMY_POS_MOVING; //Field offset: 0x4C
	[Comment("Если последний увиденный враг был меньше стольки секунд назад, и LOOK_LAST_ENEMY_POS_DIST то бот смотр на него ")]
	public float LOOK_LAST_ENEMY_POS_LONG; //Field offset: 0x50
	[Comment("Если последний увиденный враг был меньше стольки секунд назад, то бот не в укрытии позиции будет смотреть на последнюю узвестную точку")]
	public float LOOK_LAST_ENEMY_POS_DIST; //Field offset: 0x54
	[Comment("Если последний увиденный враг был меньше больше X секунд назад, и по боту попали недавно то бот взглянет в сторону урона")]
	public float LOOK_TO_HIT_POINT_IF_LAST_ENEMY; //Field offset: 0x58
	[Comment("Время если последняя увиденная точка была меньше стольки сек. Юот при осмотре места подозрительного места.")]
	public float LOOK_LAST_ENEMY_POS_LOOKAROUND; //Field offset: 0x5C
	[Comment("Максимальный угл отклонения когда бот сидит в укрытии и смотри вдоль стены")]
	public int OFFSET_LOOK_ALONG_WALL_ANG; //Field offset: 0x60
	[Comment("При замечании гранаты все укрытия в этом радиусе будут помеченны как ненадежные.")]
	public float SPOTTED_GRENADE_RADIUS; //Field offset: 0x64
	[Comment("Столько сек укрытия будет оставаться ненадежным.")]
	public float MAX_SPOTTED_TIME_SEC; //Field offset: 0x68
	[Comment("Столько бот сидит в укрытиях передвигаясь перебежками ко врагу который потерялся из виду")]
	public float WAIT_INT_COVER_FINDING_ENEMY; //Field offset: 0x6C
	[Comment(null)]
	public float CLOSE_DIST_POINT_SQRT; //Field offset: 0x70
	[Comment("Через сколько секунд для выглядывания из за угрытия позция точно будет считаться непростреливаемой.")]
	public float DELTA_SEEN_FROM_COVE_LAST_POS; //Field offset: 0x74
	[Comment("При")]
	public bool MOVE_TO_COVER_WHEN_TARGET; //Field offset: 0x78
	[Comment(null)]
	public bool RUN_COVER_IF_CAN_AND_NO_ENEMIES; //Field offset: 0x79
	[Comment("Столько укрытие будет ненадежным после броска гранаты рядом.")]
	public float SPOTTED_GRENADE_TIME; //Field offset: 0x7C
	[Comment("При поске точек на максимальную близость к бот будет учитываться дельта по У")]
	public bool DEPENDS_Y_DIST_TO_BOT; //Field offset: 0x80
	[Comment("Бот будет убегать в укрытие если оно ближе чем Х")]
	public float RUN_IF_FAR; //Field offset: 0x84
	[Comment(null)]
	public float RUN_IF_FAR_SQRT; //Field offset: 0x88
	[Comment("Бот будет идти отстреливаясь в укрытие если оно ближе чем Х но больше чем RUN_IF_FAR")]
	public float STAY_IF_FAR; //Field offset: 0x8C
	[Comment(null)]
	public float STAY_IF_FAR_SQRT; //Field offset: 0x90
	[Comment("проверять безопастность укрытия по тому смотрит ли на него враг.")]
	public bool CHECK_COVER_ENEMY_LOOK; //Field offset: 0x94
	[Comment("Если рядом с ботом который сидит в укрытии сделанно больше чем Х выстрелов то он посчитает это укрытие невалидным")]
	public int SHOOT_NEAR_TO_LEAVE; //Field offset: 0x98
	[Comment("Если рядом с ботом который сидит в укрытии был сделан выстрел то он будет считать не чаще чем раз в Х сек")]
	public float SHOOT_NEAR_SEC_PERIOD; //Field offset: 0x9C
	[Comment("Если вражины в бот попали больше чем Х то он посчитает укрытие невалидным")]
	public int HITS_TO_LEAVE_COVER; //Field offset: 0xA0
	[Comment("Если не вражины в бота попали больше чем Х то он посчитает укрытие невалидным")]
	public int HITS_TO_LEAVE_COVER_UNKNOWN; //Field offset: 0xA4
	[Comment("Столько времени посл того как бота выкинут из укрытия он будет в догфайте")]
	public float DOG_FIGHT_AFTER_LEAVE; //Field offset: 0xA8
	[Comment("Игноировать стены при сидении в укртии при реакции на выстрелы.")]
	public bool NOT_LOOK_AT_WALL_IS_DANGER; //Field offset: 0xAC
	[Comment("Если указано число больше чем 0 то бот будет стараться выбирать укрытия с уровнем защиты более Х")]
	public float MIN_DEFENCE_LEVEL; //Field offset: 0xB0
	[Comment("Если в результате поика в ближайшем радиусе укрытий откуда можно стрелять нет то след итерация будет без обязательной стрельбы")]
	public bool REWORK_NOT_TO_SHOOT; //Field offset: 0xB4
	[Comment("Удалять ли точки ЗА точками угрозы")]
	public bool DELETE_POINTS_BEHIND_ENEMIES; //Field offset: 0xB5
	[Comment("Если блиэе к точке чем GOOD_DIST_TO_POINT*Х - то точка хорошая")]
	public float GOOD_DIST_TO_POINT_COEF; //Field offset: 0xB8
	[Comment("Если враг подошел ближе чем Х и враг был виден то бот покинет укрытие")]
	public float ENEMY_DIST_TO_GO_OUT; //Field offset: 0xBC
	[Comment("Проверка при поиске укрытий на наличие рядом ближайшего друга")]
	public bool CHECK_CLOSEST_FRIEND; //Field offset: 0xC0
	[Comment(null)]
	public float MIN_TO_ENEMY_TO_BE_NOT_SAFE_SQRT; //Field offset: 0xC4
	[Comment("Если враг ближе чем Х к этой точке то бот будет считать что там нельзя спрятаться")]
	public float MIN_TO_ENEMY_TO_BE_NOT_SAFE; //Field offset: 0xC8
	[Comment("Если нельзя выглядывать, то надо ли сидеть")]
	public bool SIT_DOWN_WHEN_HOLDING; //Field offset: 0xCC
	[Comment("Если врага не видно больше чем Х сек , то бот покинет стационарку")]
	public float STATIONARY_WEAPON_NO_ENEMY_GETUP; //Field offset: 0xD0
	[Comment("Если стационарка дальше чем Х то бот точно не будет сипользовать эту стационарку")]
	public float STATIONARY_WEAPON_MAX_DIST_TO_USE; //Field offset: 0xD4
	[Comment("Сколько раз бот должен почуствовать пулю что бы покинуть стационарку")]
	public int STATIONARY_SPOTTED_TIMES_TO_LEAVE; //Field offset: 0xD8
	[Comment("Глобальный переключатель возможности использования стационарки")]
	public bool STATIONARY_CAN_USE; //Field offset: 0xDC
	[Comment("Может ли бот находять в хорошем укрытии решить перейти на стационарку")]
	public bool CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY; //Field offset: 0xDD
	[Comment("Дельта проверки желания пойти к стационарки")]
	public float CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY_DELTA; //Field offset: 0xE0
	[Comment("Радиус проверки желания пойти к стационарки")]
	public float CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY_RADIUS; //Field offset: 0xE4
	[Comment("Если врга виден (не мы подвластен обстрелу) и ближе чем Х метров то кончаем холдить. ")]
	public float END_HOLD_IF_ENEMY_CLOSE_AND_VISIBLE; //Field offset: 0xE8
	[Comment("Если враг дальше чем X то  прекращать поиск укрытий откуда можно стрелять")]
	public float DIST_MAX_REWORK_NOT_TO_SHOOT; //Field offset: 0xEC
	[Comment("Если враг дальше чем X то  прекращать поиск укрытий откуда можно стрелять")]
	public float SDIST_MAX_REWORK_NOT_TO_SHOOT; //Field offset: 0xF0
	[Comment("Использовать опасные зоны и замечать их")]
	public bool USE_DANGER_AREAS; //Field offset: 0xF4
	[Comment(null)]
	public int MAX_ITERATIONS; //Field offset: 0xF8
	[Comment("Через сколько секунд бот покинет укрытия если цель видна а стрелять не может.")]
	public float CHANGE_COVER_IF_CANT_SHOOT_SEC; //Field offset: 0xFC
	[Comment(null)]
	public bool SHALL_CHANGE_COVER_IF_CAN_SHOOT; //Field offset: 0x100
	[Comment("дистанция до ближайшего друга что бы укрытие считалось не оч хорошим.")]
	public float CHECK_CLOSEST_FRIEND_DIST; //Field offset: 0x104
	[Comment("дистанция до врага когда нельзя вертеться если лежишь в холд позишен")]
	public float CAN_LAY_TO_COVER_DIST_LOOK_TO_ENEMY; //Field offset: 0x108
	[Comment("Может ли ложиться в укрытия если оно лежачего типа")]
	public bool CAN_LAY_TO_COVER; //Field offset: 0x10C
	[Comment("Порог времени с того момента как цель была видима последний раз, для оценки продолжать убегать от арты или вести бой")]
	public float MAX_ENEMY_SEEN_TIMEOUT_UNDER_ARTILLERY; //Field offset: 0x110

	public BotGlobalsCoverSettings() { }

	public void Update() { }

}

