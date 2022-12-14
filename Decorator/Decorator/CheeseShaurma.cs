namespace Decorator
{
    /// <summary>
    /// Шаурма в сырном лаваше.
    /// </summary>
    public class CheeseShaurma : Shaurma
    {
        /// <summary>
        /// Создание экземпляра шаурмы в сырном лаваше.
        /// </summary>
        /// <param name="name">Имя клиента.</param>
        public CheeseShaurma(string name) : base(name + " в сырном лаваше")
        {
            Price += 10;
        }
    }
}
