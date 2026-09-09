<!-- ── Language switch (RU active) ──────────────────────────────────── -->
<div align="left" style="margin:0 0 14px 0;">

  <span style="display:inline-block;
               padding:.28rem .6rem;
               border:1px solid rgba(0,0,0,.18);
               border-radius:10px 0 0 10px;
               font-weight:400;
               font-size:12px;
               letter-spacing:.06em;
               color:#111827;
               background:linear-gradient(180deg,#e9edf2,#ffffff);
               box-shadow:inset 0 2px 6px rgba(0,0,0,.10);">
    RU
  </span><span style="display:inline-block;
               margin-left:-1px;
               padding:.28rem .6rem;
               border:1px solid rgba(0,0,0,.14);
               border-radius:0 10px 10px 0;
               font-weight:400;
               font-size:12px;
               letter-spacing:.06em;
               background:linear-gradient(180deg,#ffffff,#f3f4f6);
               box-shadow:0 1px 0 rgba(0,0,0,.06);">
    [EN][en]
  </span>

</div>
<!-- ────────────────────────────────────────────────────────────────── -->

## История изменений

### Master branch
- Обновлён Maven-репозиторий: https://nexus-external.rustore.ru/repository/maven-rustore-exposed.
- Обновлён npm-реестр: https://nexus-external.rustore.ru/repository/npm-unity-rustore-exposed.

### Release 10.5.1
- Версия SDK Review 10.5.1.
- Добавлен `link.xml` с `preserve="all"` для защиты от Managed Code Stripping.
- Добавлены ProGuard/R8 правила в `consumer-rules.pro` для защиты JNI-моста от минификации.
- Пакеты RuStore теперь доступны через npm-реестр.
- Обновлён Maven-репозиторий на `https://nexus-external.vkteam.ru/repository/maven-rustore-exposed`.

### Release 10.5.0
- Версия SDK Review 10.5.0.
- Исправлена ошибка, при которой LaunchReviewFlow без предварительного RequestReviewFlow не возвращал колбеков.

### Release 10.3.1
- Версия SDK Review 10.3.1.

### Release 10.3.0
- Версия SDK Review 10.3.0.

### Release 10.2.0
- Версия SDK Review 10.2.0.
- Пакет протестирован и поддерживается на Unity 6000+.

### Release 10.1.0
- Версия SDK Review 10.1.0.

### Release 10.0.0
- Версия SDK Review 10.0.0.

### Release 9.1.0
- Версия SDK Review 9.1.0.
- Исправлено объявление пространства имён в Android-манифесте RuStoreSDKSettings.androidlib.

### Release 9.0.2
- Версия SDK Review 9.0.2.

### Release 9.0.1
- Версия SDK Review 9.0.1.

### Release 8.0.0
- Версия SDK Review 8.0.0.

### Release 7.0.0
- Версия SDK Review 7.0.0.

### Release 6.1.0
- Версия SDK Review 6.1.0.
- RuStoreSDK помещена в отдельную assembly.

### Release 6.0.0
- Версия SDK Review 6.+.
- Изменена структура репозитория.
- Добавлен проект с исходным кодом пакетов `.aar`.

### Release 2.0.0
- Версия SDK Review 2.+.

### Release 0.1.7
- Исправлены зависимости SDK.

### Release 0.1.6
- Версия SDK Review 0.1.6.

[en]: CHANGELOG.en.md
