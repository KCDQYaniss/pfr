//Type is in global namespace

public class BotGlobalShootData
{
	[Comment("Кулдаун очередного переключения на подствольный гранатомёт. В секундах")]
	public float SWITCH_TO_UNDERBARREL_WEAPON_COOLDOWN; //Field offset: 0x10
	[Comment("Минимальное время в секундах для проверки принудительного переключения на подствол во время боя")]
	public float MIN_TIME_TO_CHECK_FORCE_SWITCH_TO_GRENADE_LAUNCHER; //Field offset: 0x14
	[Comment("Максимальное время в секундах для проверки принудительного переключения на подствол во время боя")]
	public float MAX_TIME_TO_CHECK_FORCE_SWITCH_TO_GRENADE_LAUNCHER; //Field offset: 0x18
	[Comment("Максимальное время в секундах после того как цель вышла из прямой видимости для переключения на подствольный гранатомёт.")]
	public float MAX_TIME_SEEN_TO_SWITCH_TO_GRENADE_LAUNCHER; //Field offset: 0x1C
	[Comment("Максимальное количество попыток выстрелов подряд из подствольного гранатамёта.")]
	public uint MAX_SUCCESS_GRENADE_LAUNCHER_SHOOT_ATTEMPTS; //Field offset: 0x20
	[Comment("0-100. Вероятность очередного выстрела из подствольного гранатамёта. ")]
	public float SHOOT_PROBABILITY_GRENADE_LAUNCHER; //Field offset: 0x24
	[Comment("Коэфициент в формуле расчёта минимальной дистанции ведения огня с подствольного гранатамёта")]
	public float LOW_DIST_K_FOR_GRENADE_LAUNCHER; //Field offset: 0x28
	[Comment("Минимальная дистанция до цели в метрах, для переключения на подствольный гранатомёт")]
	public float DEFAULT_LOW_DIST_TO_USE_GRENADE_LAUNCHER; //Field offset: 0x2C
	[Comment("Порог дистанции до ещё одной цели рядом с текущей")]
	public float DISTANCE_TO_TARGET_NEAR_ENEMY_TRESHOLD; //Field offset: 0x30
	[Comment("Отклонение гистерезиса дистанции до ещё одной цели рядом с текущей")]
	public float DISTANCE_TO_TARGET_NEAR_ENEMY_DEVIATION; //Field offset: 0x34
	[Comment("Время за которое отдача уйдет")]
	public float RECOIL_TIME_NORMALIZE; //Field offset: 0x38
	[Comment("НАсколько высоко подскочит отдача вверх в метрах в зависимостии от расстояния")]
	public float RECOIL_PER_METER; //Field offset: 0x3C
	[Comment("НАсколько высоко подскочит отдача вверх в метрах в зависимостии от расстояния")]
	public float MAX_RECOIL_PER_METER; //Field offset: 0x40
	[Comment("НАсколько высоко подскочит отдача вбок в зависимостии от вертикальной отдачи")]
	public float HORIZONT_RECOIL_COEF; //Field offset: 0x44
	[Comment("Перерыв между выстрелами.")]
	public float WAIT_NEXT_SINGLE_SHOT; //Field offset: 0x48
	[Comment("Перерыв между выстрелами стационарка пулевая.")]
	public float WAIT_NEXT_STATIONARY_BULLET; //Field offset: 0x4C
	[Comment("Перерыв между выстрелами стационарко гранатомет.")]
	public float WAIT_NEXT_STATIONARY_GRENADE; //Field offset: 0x50
	[Comment("Максимальный перерыв между выстремами для снайперов базовый")]
	public float WAIT_NEXT_SINGLE_SHOT_LONG_MAX; //Field offset: 0x54
	[Comment("Минимальный")]
	public float WAIT_NEXT_SINGLE_SHOT_LONG_MIN; //Field offset: 0x58
	[Comment("Перерыв между сериями выстрелов для заражённых")]
	public float NEXT_SINGLE_SHOT_PAUSE; //Field offset: 0x5C
	[Comment("Минимальная длина серии выстрелов для заражённых")]
	public float SINGLE_SHOT_SERIES_TIME_MIN; //Field offset: 0x60
	[Comment("Максимальная длина серии выстрелов для заражённых")]
	public float SINGLE_SHOT_SERIES_TIME_MAX; //Field offset: 0x64
	[Comment("Использовать серии одиночных выстрелов для заражённых")]
	public bool USE_SINGLE_SHOT_SERIES; //Field offset: 0x68
	[Comment("Коэфициент зависимости частоты выстрелов снайперов (каждые Х метров - примерно сек)")]
	public float MARKSMAN_DIST_SEK_COEF; //Field offset: 0x6C
	[Comment("Сколько будет зажат палец курсе при одиночном огне")]
	public float FINGER_HOLD_SINGLE_SHOT; //Field offset: 0x70
	[Comment("Сколько будет зажат палец  курсе при огне стационарке пулемете")]
	public float FINGER_HOLD_STATIONARY_BULLET; //Field offset: 0x74
	[Comment("Сколько будет зажат палец  курсе при огне стационарке гранатомете")]
	public float FINGER_HOLD_STATIONARY_GRENADE; //Field offset: 0x78
	[Comment("Сколько будем зажат палец на курсе при автоматическом огне")]
	public float BASE_AUTOMATIC_TIME; //Field offset: 0x7C
	[Comment("Коэфициент разлета при автоматической стрельбе")]
	public float AUTOMATIC_FIRE_SCATTERING_COEF; //Field offset: 0x80
	[Comment("Шанс переключится в автоматический огонь еа старте игры")]
	public float CHANCE_TO_CHANGE_TO_AUTOMATIC_FIRE_100; //Field offset: 0x84
	[Comment("Минимальная дельта по стрельбе оружия для укрытий")]
	public float FAR_DIST_ENEMY; //Field offset: 0x88
	[Comment("Если выстрелов из укрытия было сделно больше чем Х то возвращается в укрытие")]
	public int SHOOT_FROM_COVER; //Field offset: 0x8C
	[Comment(null)]
	public float FAR_DIST_ENEMY_SQR; //Field offset: 0x90
	[Comment("Коэфициент на каоторы домнажается эффективная дистанция стрельбы что бы получить максимальную дистанцию стельбы.")]
	public float MAX_DIST_COEF; //Field offset: 0x94
	[Comment("типа скорострельность 600 в мин => 10 в сек => 1 в 0.1 сек.")]
	public float RECOIL_DELTA_PRESS; //Field offset: 0x98
	[Comment("Ессли враг дальше чем Х и у бота закончились патроны то он побежит в укрытие и перезарядится там.")]
	public float RUN_DIST_NO_AMMO; //Field offset: 0x9C
	[Comment(null)]
	public float RUN_DIST_NO_AMMO_SQRT; //Field offset: 0xA0
	[Comment("Сколько раз надо несмочь выстрелить что бы не пытаться дальше стрелять, а пойти попрятаться.")]
	public int CAN_SHOOTS_TIME_TO_AMBUSH; //Field offset: 0xA4
	[Comment("Если враг был виден более NOT_TO_SEE_ENEMY_TO_WANT_RELOAD_SEC сек назад и в магазине меньше чем Х патронов то перезарядится")]
	public float NOT_TO_SEE_ENEMY_TO_WANT_RELOAD_PERCENT; //Field offset: 0xA8
	[Comment(null)]
	public float NOT_TO_SEE_ENEMY_TO_WANT_RELOAD_SEC; //Field offset: 0xAC
	[Comment("Если врагов давно небыло и в магазине меньше чем Х процентов патронов то перезарядится")]
	public float RELOAD_PECNET_NO_ENEMY; //Field offset: 0xB0
	[Comment("Шанс поменять оружие если кончились патроны.")]
	public float CHANCE_TO_CHANGE_WEAPON; //Field offset: 0xB4
	[Comment("Шанс поменять оружие если кончились патроны иу врага есть шлем.")]
	public float CHANCE_TO_CHANGE_WEAPON_WITH_HELMET; //Field offset: 0xB8
	[Comment("бот будет менять оружие только если враг дальше чем Х.")]
	public float LOW_DIST_TO_CHANGE_WEAPON; //Field offset: 0xBC
	[Comment("бот будет менять оружие только если враг ближе чем Х.")]
	public float FAR_DIST_TO_CHANGE_WEAPON; //Field offset: 0xC0
	[Comment("Настолько противник будет считаться засапрешеным если его сапрсить пулями")]
	public float SUPPRESS_BY_SHOOT_TIME; //Field offset: 0xC4
	[Comment("Сколько раз надо нажать на спуск что бы противник стал засапрешеным")]
	public int SUPPRESS_TRIGGERS_DOWN; //Field offset: 0xC8
	[Comment("Сколько раз надо нажать на спуск что бы противник стал засапрешеным при условии списка точек")]
	public int SUPPRESS_TRIGGERS_DOWN_AS_LIST; //Field offset: 0xCC
	[Comment(null)]
	public float DIST_TO_CHANGE_TO_MAIN; //Field offset: 0xD0
	[Comment("Дистанция от врага при которой бот покинет АГС_17. ")]
	public float AGS_17_DIST_TO_LEAVE; //Field offset: 0xD4
	[Comment("Дистанция с которой можно бить/начать комбо")]
	public float DIST_TO_HIT_MELEE; //Field offset: 0xD8
	[Comment("Дистанция с которой можно продолжить комбо")]
	public float DIST_TO_HIT_MELEE_CONTINUE_COMBO; //Field offset: 0xDC
	[Comment("Дистанция с которой нужно остановить спринт")]
	public float DIST_TO_STOP_SPRINT_MELEE; //Field offset: 0xE0
	[Comment("Переодичность удара")]
	public float TRY_HIT_PERIOD_MELEE; //Field offset: 0xE4
	[Comment("насколько блокировать стрельбу когда ложишься")]
	public float BLOCK_PERIOD_WHEN_LAY; //Field offset: 0xE8
	[Comment("как часто может менять оружие в руках")]
	public float CHANGE_WEAPON_PERIOD; //Field offset: 0xEC
	[Comment("флаг для комбо атак в OneMeleeAttackNode")]
	public bool USE_MELEE_COMBOS; //Field offset: 0xF0
	[Comment("Время перезарядки мили удара в ноде OneHitNode")]
	public float MELEE_RESET_HIT_TIME; //Field offset: 0xF4
	[Comment("Дистанция, ближе которой бот не пытается подойти в мили ноде")]
	public float MELEE_STOP_MOVE_DISTANCE; //Field offset: 0xF8
	[Comment("100% - оружие ломается как у обычных игроков, 50% - в 2 раза реже, 0 - никогда")]
	public int VALIDATE_MALFUNCTION_CHANCE; //Field offset: 0xFC
	[Comment("шанс чинить оружие сразу в момент поломки, не убегая в укрытие. Если не срабатывает - бот сначала прячется, только потом чинит")]
	public int REPAIR_MALFUNCTION_IMMEDIATE_CHANCE; //Field offset: 0x100
	[Comment("время в секундах между перехода в ноду малфанкшена и осмотром оружия")]
	public float DELAY_BEFORE_EXAMINE_MALFUNCTION; //Field offset: 0x104
	[Comment("время в секундах между осмотром оружия и непосредственно починкой")]
	public float DELAY_BEFORE_FIX_MALFUNCTION; //Field offset: 0x108
	[Comment("Бот попытается сменить оружие вместо перезарядки в бою")]
	public bool TRY_CHANGE_WEAPON_INSTEAD_RELOAD; //Field offset: 0x10C
	[Comment("Милишная атака делает зиг заг")]
	public bool MELEE_ATTACK_ZIG_ZAG; //Field offset: 0x10D
	[Comment("Минимальная дистанция до противника когда бот попытается сменить оружие вместо перезарядки в бою")]
	public float MIN_DIST_TO_ENEMY_TO_CHANGE_WEAPON_INSTEAD_RELOAD; //Field offset: 0x110
	[Comment("Шанс сменить оружие вместо перезарядки в бою")]
	public float CHANCE_TO_CHANGE_WEAPON_INSTEAD_RELOAD; //Field offset: 0x114
	[Comment("Шанс сменить оружие вместо перезарядки в бою когда у противника нет шлема")]
	public float CHANCE_TO_CHANGE_WEAPON_INSTEAD_RELOAD_ENEMY_WITHOUT_HELM; //Field offset: 0x118
	[Comment("дистанция для остановки перед рукопашной атакой (положительная == промежать за спину игрока)")]
	public float MELEE_STOP_DIST; //Field offset: 0x11C
	[Comment("Блокировка стиринга ботгов (создавалась для БТРа)")]
	public bool BLOCK_STEERING; //Field offset: 0x120
	[Comment("Блокировка стиринга ботгов (создавалась для БТРа)")]
	public bool USE_BTR_CANSHOOT; //Field offset: 0x121
	[Comment("Дистанция, на которой используется AssaultEnemyFarLayer для всех пушек")]
	public float FAR_DISTANCE_ALL_WEAPONS; //Field offset: 0x124
	[Comment("Дистанция, на которой используется AssaultEnemyFarLayer для пистолетов")]
	public float FAR_DISTANCE_PISTOLS; //Field offset: 0x128
	[Comment("Дистанция, на которой используется AssaultEnemyFarLayer для дробовиков")]
	public float FAR_DISTANCE_SHOTGUNS; //Field offset: 0x12C
	[Comment("Длительность замечения противника, после которой бот в AssaultEnemyFarLayer будет менять позицию")]
	public float FAR_DIST_EYE_CONTACT_TIME_TO_CHANGE_COVER; //Field offset: 0x130
	[Comment("меняет ли бот оружие на основное во время патруля")]
	public bool CHANGE_TO_MAIN_WEAPON_WHEN_PATROL; //Field offset: 0x134
	[Comment(null)]
	public float SHOOT_IMMEDIATELY_DIST; //Field offset: 0x138
	public bool CAN_STOP_SHOOT_CAUSE_ANIMATOR; //Field offset: 0x13C
	public bool TRY_CHANGE_WEAPON_WHEN_RELOAD; //Field offset: 0x13D
	public bool CHANGE_TO_MAIN_WHEN_SUPPORT_NO_AMMO; //Field offset: 0x13E
	public float LAST_SEEN_TIME_TO_START_SUPPRESS_STATIONARY_AGS; //Field offset: 0x140
	public float STATIONARY_GRENADE_MIN_DIST_TO_TAKE; //Field offset: 0x144
	public double STATIONARY_SIMPLE_MIN_DIST_TO_TAKE; //Field offset: 0x148
	public bool NO_OFFSET_SHOOTING_FROM_PLAYER; //Field offset: 0x150
	public bool ALTERNATIVE_KNIFE_KICK; //Field offset: 0x151
	[Comment("дистанция с которой бот выключает авто огонь")]
	public float DITANCE_TO_OFF_AUTO_FIRE; //Field offset: 0x154
	[Comment("дистанция с которой бот может включать авто огонь")]
	public float DITANCE_TO_ON_AUTO_FIRE; //Field offset: 0x158
	[Comment("дистанция с которой бот не промахиваеться")]
	public float MISS_ON_CRITICAL_DIST; //Field offset: 0x15C
	[Comment("Бот промахиваеться после спринта")]
	public bool MISS_AFTER_SPRINT; //Field offset: 0x160
	[Comment("Бот промахиваеться если роль совпадает с его ролью")]
	public bool MISS_ON_SAME_BOT; //Field offset: 0x161
	[Comment("Бот промахиваеться если цель из его группы")]
	public bool MISS_ON_SAME_GROUP; //Field offset: 0x162
	[Comment("Бот промахиваеться в голову")]
	public bool MISS_TO_HEAD; //Field offset: 0x163
	[Comment("Бот промахиваеться во время движения")]
	public bool MISS_ON_MOVE; //Field offset: 0x164
	[Comment("Бот промахиваеться во время анимаций перехода")]
	public bool MISS_ON_TRANSITION; //Field offset: 0x165
	[Comment("Минимальное время которое бот должен потратить на выход из укрытия")]
	public float MIN_TIME_MOVE_OUT_COVER; //Field offset: 0x168

	public BotGlobalShootData() { }

	public void Update() { }

}

