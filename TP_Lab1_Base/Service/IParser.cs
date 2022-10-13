namespace TP_Lab1_Base.Service
{
    internal interface IParser<T>
    {
        public T TryParse(string data);
        public T? Parse(string data);
    }
}
