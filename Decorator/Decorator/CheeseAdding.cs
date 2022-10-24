namespace Decorator
{
    /// <summary>
    /// Сырная добавка к шаурме.
    /// </summary>
    public class CheeseAdding : ShaurmaAdding
    {
        /// <summary>
        /// Создание экземпляра шаурмы с сырной добавкой.
        /// </summary>
        /// <param name="shaurma">Шаурма, в которую будет добавлен сыр.</param>
        public CheeseAdding(Shaurma shaurma) : base(shaurma)
        {
            Price += 10;
            Name += " с сыром";
        }
    }
}
