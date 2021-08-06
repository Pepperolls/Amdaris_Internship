using System;

namespace QueueImplementation
{
    public class Queue<T>
    {
        private readonly int maxSize;
        private int first;
        private int last;
        public T[] items;

        public Queue(int maxSize = 10)
        {
            this.maxSize = maxSize;
            this.items = new T[maxSize+1];
            this.first = maxSize + 1;
            this.last = maxSize;
        }

        public void AddToQueue(T item)
        {
            if (last < 1)
            {
                throw new InvalidOperationException("Queue is full");
            }

            items[last--] = item;
        }

        public T RemoveFromQueue()
        {
            first--;
            if (first > last)
            {
                return items[first];
            }

            throw new InvalidOperationException("Queue is empty");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.AddToQueue(10);
            queue.AddToQueue(11);
            queue.AddToQueue(12);
            queue.AddToQueue(13);
            queue.AddToQueue(14);

            Console.WriteLine(queue.RemoveFromQueue());
            Console.WriteLine(queue.RemoveFromQueue());
            Console.WriteLine(queue.RemoveFromQueue());
            Console.WriteLine(queue.RemoveFromQueue());
            queue.AddToQueue(15);
            Console.WriteLine(queue.RemoveFromQueue());
            Console.WriteLine(queue.RemoveFromQueue());
        }
    }
}
