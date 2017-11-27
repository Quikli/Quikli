namespace Domain
{
    public interface IStateContainer<TState>
    {
        TState GetCurrentState();
    }
}