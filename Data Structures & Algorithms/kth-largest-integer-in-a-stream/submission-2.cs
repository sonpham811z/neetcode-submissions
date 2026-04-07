

public class KthLargest {
    private readonly PriorityQueue<int, int> _minHeap;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        this._k = k;
        this._minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums) {
            this.Add(num);
        }
    }

    public int Add(int val) {
        _minHeap.Enqueue(val, val);
        if (_minHeap.Count > _k) {
            _minHeap.Dequeue();
        }

        return _minHeap.Peek();
    }
}