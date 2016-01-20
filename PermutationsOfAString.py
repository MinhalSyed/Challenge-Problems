import time;
'''
Given a sequence of characters, this program prints out all the permutations of it.

Eg) 'abc' => ['abc', 'acb', 'bac', 'bca', 'cab', 'cba']

'''

#This is an inefficient recursive algorithm. It performs multiple 
#computations again and again.
#It can solve a sequence of max length of 10 before running out of memory.
#e.g 'abcdefghij'
 
def permutations(str):
	if len(str) < 1:
		return [""];
	elif len(str) == 1:
		return [str];
	else:
		L = []
		for i in range (0, len(str)):
			for perm in permutations(str[0:i] + str[i+1:len(str)]):
				L.append( str[i] + perm );
		return L;


#This is a memoized version of the recursive algorithm.
#It stores previous computations and uses it when it can.
#It can solve a sequence of max length of 10 before running out of memory.
#e.g 'abcdefghij'		

#GLOBAL
dictionary = dict(); #Used for memoization

def memoized_permuations(str):
	if len(str) < 1:
		return [""];
	elif len(str) == 1:
		return [str];
	elif computedAlready(str):
		return memoizedAnswer(str);
	else:
		L = []
		for i in range (0, len(str)):
			for perm in memoized_permuations(str[0:i] + str[i+1:len(str)]):
				L.append( str[i] + perm );
		memoize(str, L)
		return L;

def memoize(key, value):
	dictionary[key] = value;

def computedAlready(key):
	return key in dictionary;
	
def memoizedAnswer(key):
	return dictionary[key];

def time_functions():
	input_string = "abcdefghij"
	start = time.clock() 
	memoized_permuations(input_string)
	elapsed = time.clock()
	elapsed = elapsed - start
	print ("Time spent in (Memoized Function) is: " + str(elapsed))

	start = time.clock() 
	permutations(input_string)
	elapsed = time.clock()
	elapsed = elapsed - start
	print ("Time spent in (non- Memoized Function) is: " + str(elapsed))
	
print("This program will print all the permutations of a string.")
input_string = input("Type a sequence of characters:\n");
print (memoized_permuations(input_string));


