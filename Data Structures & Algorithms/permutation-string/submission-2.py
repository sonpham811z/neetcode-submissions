class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        s1 = "".join(sorted(s1))
        print(len(s2) - len(s1) + 1)
        for i in range(len(s2) - len(s1) + 1):
            tmp = s2[i:i+len(s1)]
            print(tmp)
            if("".join(sorted(tmp)) == s1):
                return True
        
        return False
        
        