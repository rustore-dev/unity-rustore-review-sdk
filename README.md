## RuStore Unity плагин для оценок и отзывов

### [🔗 Документация разработчика](https://www.rustore.ru/help/sdk/reviews-ratings/unity/)

Плагин “RuStoreReviewManager” позволяет пользователю оставить оценку и отзыв о вашем приложении в RuStore, не выходя из приложения. 

Репозиторий содержит плагины “RuStoreReviewManager” и “RuStoreCommon”, а также демонстрационное приложение с примерами использования и настроек. Поддерживаются версии Unity 2022+.


### Сборка примера приложения

Вы можете ознакомиться с демонстрационным приложением содержащим представление работы всех методов sdk:
- [README](review_example/README.md)
- [review_example](https://gitflic.ru/project/rustore/unity-rustore-review-sdk/file?file=review_example)


### Установка плагина в свой проект

1. Импортируйте пакет Example/RuStoreReviewSDKExample.unitypackage в проект Unity.

2. Откройте настройки проекта: Edit → Project Settings → Player → Android Settings.

3. В pазделе Publishing Settings: включите настройки Custom Main Manifest, Custom Main Gradle Template, Custom Gradle Properties Template. 

4. В разделе Other Settings: настройте package name, Minimum API Level = 24, Target API Level = 34.

5. Откройте настройки External Dependency Manager: Assets → External Dependency Manager → Android Resolver → Settings. Включите настройки Use Jetifier, Patch mainTemplate.gradle, Patch gradleTemplate.properties.

6. Обновите зависимости проекта: Assets → External Dependency Manager → Android Resolver → Force Resolve.


### Пересборка плагина

Если вам необходимо изменить код библиотек плагинов, вы можете внести изменения и пересобрать подключаемые .aar файлы.

1. Откройте в вашей IDE проект Android из папки _“android_libraries”_.

2. Выполните сборку проекта командой gradle assemble.

При успешном выполнении сборки в папках _“review_example / Assets / RuStoreSDK / Review / Android”_ и _“review_example / Assets / RuStoreSDK / Common / Android”_ будут обновлены файлы:
- RuStoreUnityReview.aar
- RuStoreUnityCore.aar


### История изменений

[CHANGELOG](CHANGELOG.md)


### Условия распространения

Данное программное обеспечение, включая исходные коды, бинарные библиотеки и другие файлы распространяется под лицензией MIT. Информация о лицензировании доступна в документе [MIT-LICENSE](MIT-LICENSE.txt).


### Техническая поддержка

Дополнительная помощь и инструкции доступны на странице [rustore.ru/help/](https://www.rustore.ru/help/) и по электронной почте [support@rustore.ru](mailto:support@rustore.ru).
