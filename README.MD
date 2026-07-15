# https://stepik.org/lesson/1938788/step/1?unit=1965524
# Marketplace

Online marketplace built with Clean Architecture (.NET 10).

## Architecture

The solution follows Clean Architecture principles with a modular monolith approach, organized by business capabilities:

```
src/
  Services/
    Catalog/          # Product catalog service
      Catalog.Api          - API layer (controllers, middleware)
      Catalog.Application  - Use cases, DTOs, interfaces
      Catalog.Domain       - Entities, value objects, enums
      Catalog.Infrastructure - Data access, external services
```

## Tech Stack

- .NET 10
- Clean Architecture
- CQRS with MediatR
- Entity Framework Core
- PostgreSQL
- FluentValidation

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Docker Desktop (for local PostgreSQL)

## Getting Started

```bash
# Clone the repository
git clone <repo-url>
cd Marketplace

# Restore dependencies
dotnet restore

# Run database migrations (from Catalog.Infrastructure)
dotnet ef database update -s src/Services/Catalog/Catalog.Api

# Run the API
dotnet run --project src/Services/Catalog/Catalog.Api
```

## Project Status

Active development — part of the Clean Architecture course.

## Author

Sergey Zalygin

# после курса
Этап 2. Архитектурные паттерны микросервисов ⭐⭐⭐⭐⭐

Вот это я считаю обязательным.

1. Eventual Consistency

Что изучить:

почему нет общей транзакции
почему данные временно отличаются
когда это нормально

Практика:

✅ специально "сломать" синхронизацию сервисов.

2. Domain Events

Что такое

OrderCreated

PaymentSucceeded

ProductReserved

Когда публиковать события.

Практика:

✅ полностью перейти на события.

3. Transactional Outbox ⭐⭐⭐⭐⭐

Самая важная тема.

Изучить

проблему потери событий
Outbox Table
Publisher
Retry

Практика:

✅ написать собственный Outbox.

4. Idempotency

Что делать если

RabbitMQ прислал событие

2 раза.

Практика:

✅ сделать обработчики идемпотентными.

5. Saga Pattern ⭐⭐⭐⭐⭐

Изучить

Choreography
Orchestration
Compensation

Практика:

✅ написать собственную Saga.

6. API Composition

Когда данные лежат в разных сервисах.

Практика:

✅ собрать ответ сразу из нескольких сервисов.

7. Read Models

Отдельная БД

только для чтения.

Практика:

✅ сделать Read Database.

8. CQRS Advanced

Не просто

Command

Query

А полноценный

Read Model

Write Model

🚀 Этап 3. Надежность Production

Вот здесь начинается настоящий production.

9. Retry Pattern

Например

Polly.

Практика:

Retry
Exponential Backoff
10. Circuit Breaker ⭐⭐⭐⭐⭐

Очень важная тема.

Если сервис умер

не долбить его

1000 раз.

Практика:

Polly Circuit Breaker.

11. Timeout

Что делать

если сервис отвечает

20 секунд.

12. Bulkhead

Ограничение ресурсов.

13. Rate Limiting

Защита API.

14. Health Checks

Liveness

Readiness

15. Graceful Shutdown

Чтобы сервис корректно завершал работу.

🚀 Этап 4. Observability

Очень важный блок.

16. OpenTelemetry ⭐⭐⭐⭐⭐

Самая современная тема.

Практика:

Полностью трассировать запрос

через

5 сервисов.

17. Distributed Tracing

Jaeger

Tempo

Zipkin

18. Correlation ID

RequestId

TraceId

SpanId

19. Structured Logging

JSON логирование.

20. Metrics

Prometheus

Grafana

🚀 Этап 5. Архитектура

Очень любят на Senior.

21. Bounded Context

Как правильно делить сервисы.

22. DDD Strategic Design

Context Map

Shared Kernel

Anti Corruption Layer

23. Aggregates

Почему агрегат нельзя делать огромным.

24. Domain Services
25. Specification Pattern
🚀 Этап 6. Инфраструктура
26. API Gateway ⭐⭐⭐⭐⭐

Например

YARP

Ocelot

27. Service Discovery

Consul

Kubernetes DNS

28. Configuration Management
29. Secrets

Vault

Docker Secrets

30. Kubernetes ⭐⭐⭐⭐⭐

Не становиться DevOps.

А понимать

Deployment

Service

Ingress

ConfigMap

Secret

🚀 Этап 7. Сообщения
31. RabbitMQ Deep Dive

Exchange

Topic

Dead Letter

TTL

Prefetch

Ack

Nack

Poison Queue

32. Kafka

Понять

когда Kafka лучше RabbitMQ.

🚀 Этап 8. Безопасность
33. JWT
34. OAuth2
35. OpenID Connect
36. IdentityServer / Keycloak
🚀 Этап 9. Высокая нагрузка
37. Cache Aside
38. Write Through
39. Sharding
40. Horizontal Scaling
41. Sticky Sessions
42. CDN
🚀 Этап 10. Уровень архитектора ⭐⭐⭐⭐⭐

Самое интересное.

43. Монолит vs Микросервисы

Когда НЕ нужны микросервисы.

44. Модульный монолит

Очень популярная тема.

45. CAP Theorem
46. PACELC
47. Event Sourcing
48. Hexagonal Architecture
49. Vertical Slice Architecture
50. Trade-offs

Самое важное.

Не существует

идеальной архитектуры.

Есть

компромиссы.

📚 Книги

После курса

1️⃣ Microservices Patterns — Крис Ричардсон ⭐⭐⭐⭐⭐

2️⃣ Building Microservices — Сэм Ньюман ⭐⭐⭐⭐⭐

3️⃣ Learning Domain-Driven Design — Влад Хонатюк ⭐⭐⭐⭐☆

4️⃣ Микрослужбы .NET. Архитектура контейнерных приложений .NET (Microsoft) ⭐⭐⭐⭐☆
