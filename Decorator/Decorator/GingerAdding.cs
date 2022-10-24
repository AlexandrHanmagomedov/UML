namespace Decorator
{
    /// <summary>
    /// Добавка имбиря в шаурму.
    /// </summary>
    public class GingerAdding : ShaurmaAdding
    {
        /// <summary>
        /// Создать экземпляр шаурмы с добавкой имбиря.
        /// </summary>
        /// <param name="shaurma">Шаурма, в которую будет добавлен имбирь.</param>
        public GingerAdding(Shaurma shaurma) : base(shaurma)
        {
            Price += 15;
            Name += " с имбирем";
        }
    }
}
