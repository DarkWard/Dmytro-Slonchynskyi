public interface IRefList
{
    int Count { get; }
    object this[int index] { get; set; }
    void Add(object value);
    void AddToEnd(object value);
    void DeleteByValue(object value); // Удаляет все вхождения
    void DeleteByIndex(int index);
    int IndexOf(object value);
    object[] ToArray();
}