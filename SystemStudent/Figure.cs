namespace SystemStudent
{
    //Создать абстрактный класс Figure с методами вычисления 
    //площади и периметра, а также методом, выводящим информацию 
    //о фигуре на экран. Создать производные классы: Rectangle 
    //(прямоугольник), Circle (круг), Triangle (треугольник) со 
    //своими методами вычисления площади и периметра.Создать 
    //массив n фигур и вывести полную информацию о фигурах 
    //на экран.

    abstract public class Figure
    {
        abstract public string GetP();
        abstract public string GetS();
        public abstract void GetInfo();
    }
}
