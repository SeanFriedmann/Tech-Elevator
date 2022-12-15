can type in here

int method, no params, return sum of all odd itns between 1 and 100
public int MethodName ()
{
    
    for (int i = 1, i < 100, i+=2)
    {
        int sum += i;
    }
    return sum;
}

create method, retunrs bool, called Has23, takes in int[] Nums, return true if array contains a 2 or 3

public bool Has23(int[] nums)
{
    for (int i = 0, i < nums.Length, i++)
    {
        if (nums[i] == 2 || nums[i] == 3)
        {
            return true;
        }
        
    }
    return false; always test examples
}

method, returns int[], MakeEnds, int[] nums as param, nums will alwasy be length  or more, return new array of length 2 that contains first and last elements from nums

public int[] MakeEnds(int[] nums)
int[] makeEnds = new int[2] {nums[0], nums[length -1]};
return makeEnds;
