namespace Partea_practica
{
    interface IStack<T>
    {
        void Push(int T);
        void Pop();
        T Peek();
        T Capacity { get; set; }
        T Count { get; set; }
    }
}
