# Patterns

## В данном репозитории реализованы примеры реализации паттернов проектирования:

1) Стратегия
   ---
   Пример паттерна взят из книги "Head first. Паттерны проектирования" Э. Фримен (примеры на языке Java). Структура паттерна представлена на изображении:![стратегия](https://github.com/EngineersDream1/Patterns/assets/132830089/71d00b7a-094a-4b88-8011-a707897668b7)
Базовым классом является абстрактный класс Duck, который реализуют дочерние классы MallardDuck, RedheadDuck, RubberDuck и др. Изменяемые параметры базового класса были инкапсулированные по средством интерфейсов FlyBehavior и QackBehavior, которые в свою очередь включены в базовый класс по средством композиции для возможности динамического изменения поведения. Конкретная реализация поведения осуществляется с помощью классов реализующих интерфейсы FlyBehavior и QackBehavior. Механизм динамического изменения поведения осуществляется методами SetFlyBehavior и SetQuackBehavior.
---
Основные принципы проектирования паттерна:
1) Выделите аспекты приложения, которые 
могут изменяться, и отделите их от тех, 
которые всегда остаются постоянными.
2) Программируйте на уровне интерфейса, а не на уровне реализации.
3) Отдавайте предпочтение композиции перед наследованием.
   
---
2) Наблюдатель
   ---
   Пример паттерна взят с сайта https://metanit.com/sharp/patterns/3.2.php. Структура паттерна представлена на изображении: ![ClassDiagram](https://github.com/EngineersDream1/Patterns/assets/132830089/a21a910a-3bcc-4c1c-84ff-c241a1005da3)
