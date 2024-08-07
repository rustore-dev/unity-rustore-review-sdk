## RuStore Unity плагин для оценок и отзывов

### [🔗 Документация разработчика](https://www.rustore.ru/help/sdk/reviews-ratings/unity/)

- [Условия работы SDK](#Условия-работы-SDK)
- [Подготовка требуемых параметров](#Подготовка-требуемых-параметров)
- [Настройка примера приложения](#Настройка-примера-приложения)
- [Сценарий использования](#Сценарий-использования)
- [Условия распространения](#Условия-распространения)
- [Техническая поддержка](#Техническая-поддержка)


### Условия работы SDK

Для работы SDK оценок и отзывов необходимо соблюдение следующих условий:

1. ОС Android версии 7.0 или выше.

2. На устройстве пользователя установлено приложение RuStore.

3. Версия RuStore на устройстве пользователя актуальная.

4. Пользователь авторизован в RuStore.

5. Приложение должно быть опубликовано в RuStore.


### Подготовка требуемых параметров

1. `applicationId` - уникальный идентификатор приложения в системе Android в формате обратного доменного имени (пример: ru.rustore.sdk.example).

2. `*.keystore` - файл ключа, который используется для [подписи и аутентификации Android приложения](https://www.rustore.ru/help/developers/publishing-and-verifying-apps/app-publication/apk-signature/).


### Настройка примера приложения

1. Откройте проект Unity из папки _“review_example”_.

2. В разделе Publishing Settings: Edit → Project Settings → Player → Android Settings выберите вариант _“Custom Keystore”_ и задайте параметры “Path / Password”, “Alias / Password” подготовленного файла `*.keystore`.

3. В разделе Other Settings: Edit → Project Settings → Player → Android Settings настройте раздел “Identification”, отметив опцию “Override Default Package Name” и указав `applicationId` в поле “Package Name”.

4. Выполните сборку проекта командой Build: File → Build Settings и проверьте работу приложения.


### Сценарий использования

#### Подготовка к запуску оценки приложения

Тап по кнопке `RequestReviewFlow` выполняет процедуру [подготовки к запуску оценки приложения](https://www.rustore.ru/help/sdk/reviews-ratings/unity/6-0-0#%D0%BF%D0%BE%D0%B4%D0%B3%D0%BE%D1%82%D0%BE%D0%B2%D0%BA%D0%B0-%D0%BA-%D0%B7%D0%B0%D0%BF%D1%83%D1%81%D0%BA%D1%83-%D0%BE%D1%86%D0%B5%D0%BD%D0%BA%D0%B8-%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F).

![Подготовка к запуску оценки приложения](images/01_request_review_flow.png)


#### Запуск оценки приложения

Тап по кнопке `LaunchReviewFlow` выполняет процедуру [запуска оценки приложения](https://www.rustore.ru/help/sdk/reviews-ratings/unity/6-0-0#%D0%B7%D0%B0%D0%BF%D1%83%D1%81%D0%BA-%D0%BE%D1%86%D0%B5%D0%BD%D0%BA%D0%B8-%D0%BF%D1%80%D0%B8%D0%BB%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F).

![Запуск оценки приложения](images/02_launch_review_flow.png)


### Условия распространения

Данное программное обеспечение, включая исходные коды, бинарные библиотеки и другие файлы распространяется под лицензией MIT. Информация о лицензировании доступна в документе [MIT-LICENSE](../MIT-LICENSE.txt).


### Техническая поддержка

Дополнительная помощь и инструкции доступны на странице [rustore.ru/help/](https://www.rustore.ru/help/) и по электронной почте [support@rustore.ru](mailto:support@rustore.ru).
