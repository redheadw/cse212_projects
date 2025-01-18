using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: create enqueue 3 items with the data and priority to the back of the queue
    // Expected Result: dequeue items in order of priority
    // Defect(s) Found: No output B != C 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
       
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: create enqueu to add item with the data and priority to the back of the queue
    // Expected Result: Items to be dequeued based on priority if priority is equal FIFO
    // Defect(s) Found: no output B != A
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);
       
        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());

        Assert.Fail("Implement the test case and then remove this.");
      
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario : create enqueue of 3 items and dequeue them
    // Expected Result: Items to be dequeued by highest priority
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception");
        }
        catch (InvalidDataException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}