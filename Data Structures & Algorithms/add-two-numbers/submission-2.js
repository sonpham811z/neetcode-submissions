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
     * @param {ListNode} l1
     * @param {ListNode} l2
     * @return {ListNode}
     */
    addTwoNumbers(l1, l2) {
        let res = new ListNode(-1)
        let walk = res
        let carry = 0
        
        while(l1 || l2)
        {
            let val1 = l1 ? l1.val : 0;
            let val2 = l2 ? l2.val : 0;

            let sum = (val1+val2+carry)
            let total = sum%10
            carry = Math.floor(sum/10)
            

            walk.next = new ListNode(total)
            walk = walk.next
            
            if(l1)
                l1 = l1.next
            if (l2) l2 = l2.next;
        }

        if(carry == 0)
            return res.next
        else {
            walk.next = new ListNode(carry)
        }
        return res.next
    }
}
