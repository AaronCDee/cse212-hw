using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Dequeues from highest priority to lowest priority
    // Expected Result: item3, item2, item1
    // Defect(s) Found:
    // - Items are not removed during Dequeue()
    // - The loop variables (int index = 1; index < _queue.Count - 1; index++),
    // remove 2 items from the list when trying to find the highest priority
    public void TestPriorityQueue_1()
    {
        var results = new String[3];
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 2);
        priorityQueue.Enqueue("item3", 3);

        results[0] = priorityQueue.Dequeue();
        results[1] = priorityQueue.Dequeue();
        results[2] = priorityQueue.Dequeue();

        Assert.AreEqual(results[0], "item3");
        Assert.AreEqual(results[1], "item2");
        Assert.AreEqual(results[2], "item1");
    }

    [TestMethod]
    // Scenario: When there are multiple items with the same priority, the first one is removed.
    // Expected Result: item2, item3, item1
    // Defect(s) Found:
    // - The index of the highest priority is set when the next item's priority
    // is greater than OR equal to the current highest priority.
    // It should only be set if it's greater than.
    public void TestPriorityQueue_2()
    {
        var results = new String[3];
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("item1", 1);
        priorityQueue.Enqueue("item2", 3);
        priorityQueue.Enqueue("item3", 3);

        results[0] = priorityQueue.Dequeue();
        results[1] = priorityQueue.Dequeue();
        results[2] = priorityQueue.Dequeue();

        Assert.AreEqual(results[0], "item2");
        Assert.AreEqual(results[1], "item3");
        Assert.AreEqual(results[2], "item1");
    }

    [TestMethod]
    // Scenario: When the queue is empty.
    // Expected Result: InvalidOperationException
    // Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}
