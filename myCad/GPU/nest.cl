#ifdef FP64

#pragma message("FP64")
#pragma OPENCL EXTENSION cl_khr_fp64 : enable 
typedef double fp_t;
#define EPSILON 0.000001

#elif defined AMDFP64

#pragma message("AMDFP64")
#pragma OPENCL EXTENSION cl_amd_fp64 : enable 
typedef double fp_t;
#define EPSILON 0.000001

#else

typedef float fp_t;
#define EPSILON 0.00001f

#endif

kernel void hello(global write_only fp_t* result,float num)
{
	int i = get_global_id(0);
	result[i]=num*1000;
}