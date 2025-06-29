namespace Engine.Domain.Entity
{
    public interface IHandler
    {
        void Handle(IEvent tEvent);
    }
}