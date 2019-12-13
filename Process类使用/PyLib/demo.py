# -*- coding: utf-8 -*-


import numpy as np
import sys
import time

def call(num):    
   return (np.random.randn(num));
  
call(sys.argv[1])


#结束进程的执行
time.sleep(2)   #休眠5s
sys.exit()      #结束进程

#def Function（a,b）
#	result=np.sqrt(int(a)*int(b))
#	#return result
#	print result

#if __name__=='__main__':
#	pow(func(sys.argv[1],sys.argv[2]))