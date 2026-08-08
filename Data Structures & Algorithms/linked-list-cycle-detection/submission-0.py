# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        first_point = head;
        second_point = head;
        while(second_point!= None and second_point.next != None):
            first_point = first_point.next
            second_point = second_point.next.next
         
            if(first_point == second_point):
                return True

        return False