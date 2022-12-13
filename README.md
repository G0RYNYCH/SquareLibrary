# SquareLibrary
C# library can calculate the area of a circle by radius and a triangle by three sides.
* Unit tests are written (XUnit usage).
* To add figures you need to add a new figure class and inherit from the base abstract class FigureBase.
* The figure area is calculated without knowing the type of the figure at compile-time.
* Heron's formula, which was used to calculate the area of a triangle, is universal. And the project does not contain a right triangle check.


C# библиотека, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
* Библиотека покрыта юнит-тестами (использовал XUnit).
* Для добавления фигур неабходимо добавить класс новой фигуры и пронаследоваться от базового абстрактного класса FigureBase.
* Вычисление площади фигуры происходит без знания типа фигуры в compile-time.
* Проект не содержит проверку на то, является ли треугольник прямоугольным, поскольку формула Герона, которая использовалась для рассчета площади треугольника, является универсальной.
