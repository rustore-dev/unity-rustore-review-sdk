### Unity-плагин RuStore для оценок и отзывов

Плагин **RuStoreReviewManager** позволяет пользователю оставить оценку и отзыв о вашем приложении в RuStore, не выходя из приложения.
Поддерживаются версии Unity 6000+.

#### Подключение в проект

**Из сетевого расположения (рекомендуется)**

Пакеты RuStore публикуются в npm-registry и подключаются к проекту через Package Manager без ручного скачивания архивов.

1. Откройте настройки: **Edit → Project Settings → Package Manager**.
2. В разделе **Scoped Registries** нажмите **+** и заполните поля:
   - **Name** — `RuStore Nexus`.
   - **URL** — `https://nexus-external.rustore.ru/repository/npm-unity-rustore-exposed/`.
   - **Scopes** — `ru.rustore`.
3. Откройте **Window → Package Manager** — в списке источников появится реестр **RuStore Nexus**.
4. Выберите **RuStore Nexus** и установите пакет `ru.rustore.review` кнопкой **Install**. Зависимость `ru.rustore.core` установится автоматически.

**Из локального расположения**

**Установка через Package Manager**

1. Для подключения скачайте со страницы <a href="https://gitflic.ru/project/rustore/unity-rustore-review-sdk/release" target="_blank">релизов</a> пакеты:
   - `ru.rustore.core-version.tgz`.
   - `ru.rustore.review-version.tgz`.
2. Импортируйте пакеты в проект через **Package Manager** (Window → Package Manager → + → Add package from tarball…).

**Установка через *.unitypackage**

1. Скачайте файл `RuStoreUnityReviewSDK-version.unitypackage` со страницы <a href="https://gitflic.ru/project/rustore/unity-rustore-review-sdk/release" target="_blank">релизов</a>.
2. Импортируйте его в проект (Assets → Import Package → Custom Package…).

**Клонирование репозитория**

Для установки из исходного кода воспользуйтесь <a href="https://gitflic.ru/project/rustore/unity-rustore-review-sdk/blob/?file=README_CLONE.md" target="_blank">инструкцией по клонированию</a>.

Для каждого артефакта в релизе доступны файлы контрольных сумм (`.sha256`) и цифровой подписи (`.sig`), которые могут использоваться для проверки целостности и подлинности артефакта после скачивания.

> **Подсказка**
>
> Если вы используете операционную систему macOS, измените настройки утилиты архивации. В настройках **Archive Utility** снимите флажок **Keep expanding if possible**. В противном случае архив проекта будет скачан некорректно.

#### Настройка проекта

Для корректной обработки зависимостей SDK выполните следующие настройки.

1. Откройте настройки проекта: Edit → Project Settings → Player → Android Settings.
2. В разделе **Publishing Settings** включите следующие настройки.
   - Custom Main Manifest.
   - Custom Main Gradle Template.
   - Custom Gradle Properties Template.
3. В разделе **Other Settings** настройте:
   - package name.
   - Minimum API Level = 24.
   - Target API Level = 34.

#### Подключение зависимостей

После установки обновите зависимости проекта с помощью **External Dependency Manager** (Assets → External Dependency Manager → Android Resolver → Force Resolve).

Откройте настройки **External Dependency Manager**: Assets → External Dependency Manager → Android Resolver → Settings, включите следующие настройки:
- Use Jetifier.
- Patch mainTemplate.gradle.
- Patch gradleTemplate.properties.

#### Инициализация SDK

Перед вызовом методов библиотеки необходимо инициализировать объект RuStoreReviewManager.

```csharp
RuStoreReviewManager.Instance.Init();
```

Начните изучение документации библиотеки RuStore с методов класса [RuStoreReviewManager](@ref RuStore.Review.RuStoreReviewManager). Или воспользуйтесь <a href="https://www.rustore.ru/help/sdk/reviews-ratings/unity" target="_blank">руководством онлайн</a>.

#### Техническая поддержка

Дополнительная помощь и инструкции доступны в <a href="https://www.rustore.ru/help" target="_blank">документации RuStore</a> и по электронной почте support@rustore.ru.

#### Условия распространения

Данное программное обеспечение, включая исходные коды, бинарные библиотеки и другие файлы, распространяется под лицензией MIT. Информация о лицензировании доступна в документе <a href="https://gitflic.ru/project/rustore/unity-rustore-review-sdk/blob?file=MIT-LICENSE.txt" target="_blank">MIT-LICENSE</a>.
