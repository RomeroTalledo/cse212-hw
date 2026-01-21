/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _queue.Add(person);
        // Initially, _queue.Insert(0, person) was used, which added elements to the front of the list, breaking the FIFO order.
        // It was corrected to _queue.Add(person) so that elements are added to the end, maintaining the correct queue order.
    }

    public Person Dequeue()
    {
        var person = _queue[0];
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}