using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add multiple people with different priorities and remove them in order of priority.
    // Expected Result: Elements are dequeued in descending priority order: Dallin -> Dieter -> Alanis.
    // Defect(s) Found: 
    // 1. The loop in Dequeue() does not check the last element (for loop ends early).
    // 2. If multiple elements have the same priority, the last one is removed instead of the first (FIFO is not respected).
    // 3. _queue.RemoveAt(highPriorityIndex) may be missing in the current implementation.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        var dallin = new Person("Dallin",5);
        var alanis = new Person("Alanis",2);
        var dieter = new Person("Dieter",3);

        priorityQueue.Enqueue(dallin.Name, dallin.Turns);
        priorityQueue.Enqueue(alanis.Name, alanis.Turns);
        priorityQueue.Enqueue(dieter.Name, dieter.Turns);


        Assert.AreEqual("Dallin",priorityQueue.Dequeue());
        Assert.AreEqual("Dieter",priorityQueue.Dequeue());
        Assert.AreEqual("Alanis",priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: Throws an InvalidOperationException indicating the queue is empty.
    // Defect(s) Found: The exception message in the code ("The queue is empty.") does not match the assignment documentation ("The queuuue is empty").
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Implement the test case and then remove this.");
        }
        catch(InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.",ex.Message);
        }
        
    }

    // Add more test cases as needed below.
}