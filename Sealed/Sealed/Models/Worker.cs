using Sealed.Exceptions;

namespace Sealed.Models;
public abstract class Worker
{
    public byte WorkingHours;
    protected Worker(byte wHours)
    {
        if (wHours > 8)
        {
            throw new WorkerOverTimeException("Serefsiz cox isledir");
        }
        WorkingHours = wHours;
    }
    public abstract void Work();
}
