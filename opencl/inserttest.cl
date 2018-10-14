//从数组中找出大于min的最小数字
//num初始化为99999999
__kernel void Insert(__global int* numlist,__global int *num ,int minnum,__local int* locallist)
{
    unsigned int id = get_global_id(0); 
    unsigned int lid = get_local_id(0); 
    unsigned int gid = get_group_id(0); 
    unsigned int localsize = get_local_size(0); 
    unsigned int globalsize =get_global_size(0); 

    //locallist[lid] = numlist[id];
    //barrier(CLK_LOCAL_MEM_FENCE);

    for(int i = 0;i<globalsize;i+=localsize)
    {
        if(i+lid < globalsize && numlist[i+lid] > minnum)
        {
            atomic_min(num, numlist[i+lid]);
        }
        barrier(CLK_LOCAL_MEM_FENCE);
    }
}

__kernel void Insert(__global int* numlist,__global int *num ,int minnum)
{
    unsigned int id = get_global_id(0); 
    if(numlist[id] > minnum)
    {
        num[id] = 1;
    }
    else
    {
        num[id] = 0;
    }
}