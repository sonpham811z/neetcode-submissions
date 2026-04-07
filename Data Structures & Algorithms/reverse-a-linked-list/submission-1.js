class Solution {
    /**
     * @param {ListNode} head
     * @return {ListNode}
     */
    reverseList(head) {
        // Base case: if list is empty or has only one node
        if (head === null || head.next === null) {
            return head;
        }

        // Recursive step: reverse the rest of the list
        const newHead = this.reverseList(head.next);

        // Adjust the pointers for the current node
        // head.next is the next node; we set its .next back to head
        head.next.next = head;
        
        // Break the original link to avoid cycles
        head.next = null;

        return newHead;
    }
}