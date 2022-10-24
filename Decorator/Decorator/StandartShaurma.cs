namespace Decorator
{
    /// <summary>
    /// Шаурма в обычном лаваше.
    /// </summary>
    public class StandartShaurma : Shaurma
    {
        /// <summary>
        /// Создание нового экземпляра шаурмы в обычном лаваше.
        /// </summary>
        /// <param name="name">Имя клиента.</param>
        public StandartShaurma(string name) : base(name + " в обычном лаваше")
        {
        }
    }
}
