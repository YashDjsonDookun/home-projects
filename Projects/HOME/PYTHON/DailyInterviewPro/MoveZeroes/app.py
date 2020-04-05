class Solution():
    def moveZeros(self, nums):
        for i in range(len(nums)):
            for j in range(0,(len(nums) - 1)):
                if (nums[j] == 0):
                    nums[j], nums[j+1] = nums[j+1], nums[j]
nums = [0,0,0,2,0,1,3,4,0,0]
Solution().moveZeros(nums)
print(nums)
