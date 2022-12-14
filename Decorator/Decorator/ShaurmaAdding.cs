namespace Decorator
{
    /// <summary>
    /// Базовый класс добавки к шаурме.
    /// </summary>
    public abstract class ShaurmaAdding : Shaurma
    {
        /// <summary>
        /// Шаурма в которую добавляются добавки.
        /// </summary>
        protected Shaurma Shaurma { get; set; }

        /// <summary>
        /// Создание нового экземпляра шаурмы с добавкой.
        /// </summary>
        /// <param name="shaurma">Шаурма, в которую добавляется добавка.</param>
        public ShaurmaAdding(Shaurma shaurma) : base(shaurma.Name)
        {
            Shaurma = shaurma;
            Price = shaurma.Price;
        }
    }
}
