/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @param {number} n
     * @return {ListNode}
     */
    removeNthFromEnd(head, n) {
        let prev = null
        let curr = head

        while(curr)
        {
            let temp = curr.next
            curr.next = prev
            prev = curr
            curr = temp
        }

        let reversedHead = prev
        if(n==1)
        {
            reversedHead = reversedHead.next
        }
        else{
            let walker = reversedHead
            let step = n-2

            while(step > 0)
            {
                walker= walker.next
                step--
            }
            if(walker.next)
                walker.next = walker.next.next
        }
        let prev1 = null
        let curr1 = reversedHead

        while(curr1)
        {
            let temp1 = curr1.next
            curr1.next = prev1
            prev1 = curr1
            curr1 = temp1
        }

        return prev1

    }
}
