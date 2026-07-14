# Catalog Project Rules

## Course Context
- Прохожу курс **"C#: Создаём API для маркетплейса на микросервисах"** (автор шаблона Capi — Sergey Zalygin)
- Полная программа курса в `AGENTS.md`
- Текущий модуль: **3. Создание и настройка микросервиса каталога** (урок ~3.9 — интеграция Marten с PostgreSQL)

## Role & Teaching Style
- Я **новичок** в .NET микросервисах — контролируй меня строго
- **Не давай** мне изучать устаревшие/legacy практики — только современные тренды 2026 года
- Если я предлагаю или делаю что-то неоптимально — **останови и объясни** почему так плохо и как лучше
- Если в курсе показывают подход, который в 2026 уже устарел — **предупреди** и предложи современную альтернативу
- Объясняй понятно, без излишнего сленга, но и не примитивно
- **Проверяй понимание**: когда я задаю вопрос и ты объясняешь — задай 1-2 коротких вопроса чтобы убедиться что я усвоил. Если я отвечаю правильно — едем дальше. Если нет — мягко поправь и объясни как на самом деле. Не забрасывай десятком вопросов, только по делу.

## Program
1. Старт ✅
2. Создание и публикация шаблона микросервиса ✅
3. Создание и настройка микросервиса каталога ← **текущий**
4. CQRS и MediatR в каталоге
5. Расширение и Production-ready
6. Микросервис корзины: CQRS, кэширование и продакшн-подготовка
7. Микросервис промоакций на gRPC: CQRS, Dapper, MySQL
8. Интеграция промосервиса и корзины
9. Микросервис заказов
10. Событийная интеграция с RabbitMQ: MassTransit
11. Инфраструктура (логирование, мониторинг, метрики)

## Author
- Автор проекта: **Sergey Zalygin**.
- Если в файлах встречаются другие имена автора — предложи заменить на Sergey Zalygin.
- Если нужно где-то указать автора — ставь Sergey Zalygin без лишних вопросов.

## Scope of work
- Выполняй только то, что явно попросили.
- Если задача выходит за рамки запроса — сначала спроси у меня, нужно ли это делать.

## NuGet packages
- Не устанавливай пакеты без моего явного согласия.
- Если для реализации функционала нужны дополнительные библиотеки — просто сообщи мне об этом.
- Если я отвечу "да, ставь" — устанавливай.

## Decomposition
- Если задача крупная или средняя — предложи сначала декомпозировать её на маленькие логически связанные подзадачи.
- Решай их последовательно, в логически правильном порядке.
- Главное — не плодить много кода за один раз, а делать качественно, компонентно.

## Reporting
- После выполнения любой операции кратко напиши, что было сделано (тезисно, по пунктам).

## Chain of actions
- Если после выполненного действия логически вытекает другое необходимое действие — предложи его сразу, не жди отдельной просьбы.

## Code review & typos
- Когда я прошу сделать ревью, или ты читаешь код и видишь опечатку / неправильное написание английского слова — просто укажи на это.
- При ревью кода参照 `CODE_REVIEW.md` — там описаны naming conventions, code style и common mistakes.
- При работе с CQRS参照 `CQRS_RULES.md` — там описаны naming conventions для Query/Command/Handler.

## Branch naming
- Ветки создавай по схеме: `<type>/TASK-<number>_<english-title>`
- `<type>`: `feature` — новая фича, `bug` — исправление бага, `refactor` — рефакторинг, `chore` — обслуживание
- `<english-title>` — краткое описание на английском, слова через дефис
- Пример: `feature/TASK-1_create-entities-baseentity-brand-category-catalogitem`

## Branch workflow
- При создании новой ветки от `master` **всегда** сначала делай `git checkout master; git pull`, чтобы актуализировать master, и только потом создавай ветку
- Формат: `git checkout master; git pull; git checkout -b <branch-name>`

---

<!-- COMPACT START: 2026-06-28 17:41 -->
# Session Compact (2026-06-28)

## Goal
Develop a full Clean Architecture course project — an online marketplace (Marketplace) with PostgreSQL, using the `Capi` dotnet template.

## Constraints & Preferences
- Work in `C:\Users\cplus\Desktop\Csharp\projects\Marketplace`
- Catalog microservice generated from `dotnet new Capi -n Catalog`
- Author: **Sergey Zalygin**
- AGENTS.md rules: scope, NuGet packages on confirmation, decomposition, reporting, chain of actions, author identity, branch naming, code review & typos
- PostgreSQL connection: `Host=localhost;Port=7101;Database=catalog-db;User Id=postgres;Password=postgres`

## Progress
### Done
- Created and pushed initial commit to `https://github.com/Azirit/markeplace.git` (master)
- Created `README.MD` at Marketplace root
- Created `AGENTS.md` in `src/Services/Catalog/` with branch naming convention (feature/bug/refactor/chore + `TASK-N_english-title`) and code review typos rule
- Created `Catalog.Domain/Entities/` with stub classes: `BaseEntity`, `Brand`, `Category`, `CatalogItem`
- Added `Id` property to `BaseEntity`, `Title` to `Brand`/`Category`, full properties + navigation to `CatalogItem`
- Created `Catalog.Domain/Repositories/`: `IBrandRepository`, `ICategoryRepository`, `ICatalogItemRepository` (each with `Task<IEnumerable<T>> GetAllAsync()`)
- Added `global using Catalog.Domain.Repositories;` in `GlobalUsings.cs`
- Added `PostgreSQL` connection string to `appsettings.json` and `appsettings.Development.json`
- Created `docker-compose-dev.yaml` with PostgreSQL 18 and updated volume mount path
- Branches created and pushed:
  - `feature/TASK-1_create-entities-baseentity-brand-category-catalogitem`
  - `feature/TASK-2_add-ibrandrepository-repository`
  - `feature/TASK-3_setup-docker-compose-for-db-and-dbeaver` (current)

### In Progress
- (none)

### Blocked
- (none)

## Key Decisions
- Repository interfaces kept minimal (`GetAllAsync` only) — user preference
- PostgreSQL connection string format from course: `Host=localhost;Port=7101;Database=catalog-db;User Id=postgres;Password=postgres;Include Error Detail=true` (dev only)
- AGENTS.md stores both project rules and branch naming conventions — single source of truth for opencode

## Next Steps
- (user decides when resuming)

## Critical Context
- No gh CLI installed; remote repo manually created and linked via `git remote add origin`
- Global usings in `Catalog.Domain` are only visible within Domain project — Application/Infrastructure need their own if consuming Domain types
- Session memory is not persisted across restarts — `AGENTS.md` and git history serve as the persistent context
- The Capi template (package `zalsergey.cleanarchitecture.template`) is installed and functional

## Relevant Files
- `Marketplace/README.MD`: project overview
- `Marketplace/docker-compose-dev.yaml`: Docker Compose for local PostgreSQL 18
- `Marketplace/src/Services/Catalog/AGENTS.md`: all project rules and conventions
- `Marketplace/src/Services/Catalog/Catalog.Domain/Entities/`: `BaseEntity.cs`, `Brand.cs`, `Category.cs`, `CatalogItem.cs`
- `Marketplace/src/Services/Catalog/Catalog.Domain/Repositories/`: `IBrandRepository.cs`, `ICategoryRepository.cs`, `ICatalogItemRepository.cs`
- `Marketplace/src/Services/Catalog/Catalog.Api/appsettings.json` / `appsettings.Development.json`: PostgreSQL connection strings
- `Marketplace/Marketplace.slnx`: solution file with Catalog service projects
<!-- COMPACT END: 2026-06-28 17:41 -->
